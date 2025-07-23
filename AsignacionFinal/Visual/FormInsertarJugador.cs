using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsignacionFinal.BDD; 

namespace AsignacionFinal.Visual
{
    public partial class FormInsertarJugador : Form
    {
        private bool esEdicion = false;
        private string? idOriginal = null;

        public FormInsertarJugador()
        {
            InitializeComponent();
            dtpFechaNacim.Value = DateTime.Today.AddYears(-18);
            dtpFechaNacim.Format = DateTimePickerFormat.Custom;
            dtpFechaNacim.CustomFormat = "MM/dd/yyyy";
            CargarDatosTablas();
            // Suscribir eventos para validar campos
            txtId.TextChanged += ValidarCampos;
            txtNumero.TextChanged += ValidarCampos;
            txtNombre.TextChanged += ValidarCampos;
            dgvEquipos.SelectionChanged += ValidarCampos;
            dgvCiudades.SelectionChanged += ValidarCampos;
            txtNumero.KeyPress += TxtSoloNumeros_KeyPress;
            txtNombre.KeyPress += TxtSoloLetras_KeyPress;
            ValidarCampos(null, null);
        }

        private void TxtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y teclas de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public FormInsertarJugador(Jugador jugadorEditar)
            : this()
        {
            esEdicion = true;
            idOriginal = jugadorEditar.IdJugador;
            // Rellena los campos con los datos del jugador a editar
            txtId.Text = jugadorEditar.IdJugador;
            txtNumero.Text = jugadorEditar.NumeroJugador;
            txtNombre.Text = jugadorEditar.NombreJugador;
            dtpFechaNacim.Value = jugadorEditar.FechaNacimiento;

            // Deshabilita el campo ID en modo edición
            txtId.Enabled = false;

            // Cambia el texto del botón a "Editar"
            btnInsertar.Text = "Editar";

            // Selecciona el equipo correspondiente
            foreach (DataGridViewRow row in dgvEquipos.Rows)
            {
                if (row.Cells["ID"].Value?.ToString() == jugadorEditar.IdEquipo)
                {
                    row.Selected = true;
                    dgvEquipos.CurrentCell = row.Cells[0];
                    break;
                }
            }
            // Selecciona la ciudad correspondiente
            foreach (DataGridViewRow row in dgvCiudades.Rows)
            {
                if (row.Cells["ID"].Value?.ToString() == jugadorEditar.IdCiudadNacimiento)
                {
                    row.Selected = true;
                    dgvCiudades.CurrentCell = row.Cells[0];
                    break;
                }
            }

            if (JugadorRepository.existEstadParaJugador(txtId.Text)) deshabilitarDGV(dgvEquipos);
        }

        private void CargarDatosTablas()
        {
            // Obtener los datos originales
            var equipos = EquipoRepository.GetAll();
            var ciudades = CiudadRepository.GetAll();

            // Crear una tabla solo con las columnas ID y Nombre para equipos
            var equiposSoloDos = new DataTable();
            equiposSoloDos.Columns.Add("ID", typeof(string));
            equiposSoloDos.Columns.Add("Nombre", typeof(string));
            foreach (DataRow row in equipos.Rows)
            {
                equiposSoloDos.Rows.Add(row["ID"], row["Nombre"]);
            }

            dgvEquipos.DataSource = equiposSoloDos;
            dgvCiudades.DataSource = ciudades;

            // Ajusta el formato de las columnas para mejor visualización
            if (dgvEquipos.Columns.Contains("ID"))
                dgvEquipos.Columns["ID"].HeaderText = "ID Equipo";
            if (dgvEquipos.Columns.Contains("Nombre"))
                dgvEquipos.Columns["Nombre"].HeaderText = "Nombre Equipo";

			if (dgvCiudades.Columns.Contains("IdCiudad"))
				dgvCiudades.Columns["IdCiudad"].HeaderText = "ID Ciudad";
			if (dgvCiudades.Columns.Contains("NombreCiudad"))
				dgvCiudades.Columns["NombreCiudad"].HeaderText = "Nombre Ciudad";

            // Selecciona la fila completa (ambas columnas) en ambos DataGridView
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.MultiSelect = false;
            if (dgvEquipos.Rows.Count > 0)
            {
                dgvEquipos.ClearSelection();
                dgvEquipos.Rows[0].Selected = true;
            }

            dgvCiudades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudades.MultiSelect = false;
            if (dgvCiudades.Rows.Count > 0)
            {
                dgvCiudades.ClearSelection();
                dgvCiudades.Rows[0].Selected = true;
            }
        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public Jugador? jugador { get; private set; }

        private void ResetearFormulario()
        {
            txtId.Clear();
            txtNumero.Clear();
            txtNombre.Clear();
            dtpFechaNacim.Value = DateTime.Today.AddYears(-18);
            if (dgvEquipos.Rows.Count > 0)
            {
                dgvEquipos.ClearSelection();
                dgvEquipos.Rows[0].Selected = true;
            }
            if (dgvCiudades.Rows.Count > 0)
            {
                dgvCiudades.ClearSelection();
                dgvCiudades.Rows[0].Selected = true;
            }
            txtId.Focus();
        }

        private void ValidarCampos(object? sender, EventArgs? e)
        {
            bool camposLlenos =
                !string.IsNullOrWhiteSpace(txtId.Text) &&
                !string.IsNullOrWhiteSpace(txtNumero.Text) &&
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                dgvEquipos.CurrentRow != null &&
                dgvCiudades.CurrentRow != null &&
                !EquipoRepository.existNumEnEquipo(dgvEquipos.CurrentRow.Cells["ID"].Value?.ToString(), txtNumero.Text);

            btnInsertar.Enabled = camposLlenos;
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            // Validación básica de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNumero.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            // Validar selección en los DataGridView
            if (dgvEquipos.CurrentRow == null || dgvCiudades.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un equipo y una ciudad de nacimiento.");
                return;
            }

            string idEquipo = dgvEquipos.CurrentRow.Cells["ID"].Value?.ToString();
            string idCiudad = dgvCiudades.CurrentRow.Cells["ID"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(idEquipo) || string.IsNullOrWhiteSpace(idCiudad))
            {
                MessageBox.Show("No se pudo obtener el Id del equipo o de la ciudad seleccionada.");
                return;
            }

            jugador = new Jugador
            {
                IdJugador = txtId.Text.Trim(),
                IdEquipo = idEquipo.Trim(),
                IdCiudadNacimiento = idCiudad.Trim(),
                FechaNacimiento = dtpFechaNacim.Value,
                NumeroJugador = txtNumero.Text.Trim(),
                NombreJugador = txtNombre.Text.Trim()
            };

            bool exito;
            if (esEdicion && idOriginal != null)
            {
                exito = AsignacionFinal.BDD.JugadorRepository.Update(jugador, idOriginal);
                if (exito)
                {
                    // El mensaje de éxito se muestra en el formulario principal
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo editar el jugador. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                exito = AsignacionFinal.BDD.JugadorRepository.Insert(jugador);
                if (exito)
                {
                    MessageBox.Show("Jugador insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetearFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el jugador. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Dibuja un borde negro de 2px alrededor del formulario
            using (var pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    1, 1,
                    this.ClientSize.Width - 2,
                    this.ClientSize.Height - 2
                );
            }
        }

        private void deshabilitarDGV(DataGridView dgv)
        {
            dgv.Enabled = false;
            dgv.DefaultCellStyle.BackColor = SystemColors.Control; // gris claro típico
            dgv.DefaultCellStyle.ForeColor = SystemColors.GrayText;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dgv.BackgroundColor = SystemColors.Control;
        }
    }
}
