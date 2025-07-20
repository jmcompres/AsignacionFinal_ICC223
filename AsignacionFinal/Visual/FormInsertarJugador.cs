using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionFinal.Visual
{
    public partial class FormInsertarJugador : Form
    {
        public FormInsertarJugador()
        {
            InitializeComponent();
        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public Jugador jugador { get; private set; }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Validación básica de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtIdJugador.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroJugador.Text) ||
                string.IsNullOrWhiteSpace(txtNombreJugador.Text))
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

            // Obtener los valores seleccionados del DataGridView
            string idEquipo = dgvEquipos.CurrentRow.Cells["IdEquipo"].Value?.ToString();
            string idCiudad = dgvCiudades.CurrentRow.Cells["IdCiudadDeNacimiento"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(idEquipo) || string.IsNullOrWhiteSpace(idCiudad))
            {
                MessageBox.Show("No se pudo obtener el Id del equipo o de la ciudad seleccionada.");
                return;
            }

            jugador = new Jugador
            {
                IdJugador = txtIdJugador.Text.Trim(),
                IdEquipo = idEquipo.Trim(),
                IdCiudadDeNacimiento = idCiudad.Trim(),
                FechaNacimiento = dtpFechaNacimiento.Value,
                NumeroJugador = txtNumeroJugador.Text.Trim(),
                NombreJugador = txtNombreJugador.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
