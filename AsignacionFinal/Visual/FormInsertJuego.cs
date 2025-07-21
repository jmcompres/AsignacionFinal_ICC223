using AsignacionFinal.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AsignacionFinal.Visual
{
    public partial class FormInsertJuego : Form
    {
        public Juego juego { get; private set; }

        public FormInsertJuego(DateTime fechaYHora, string titulo = "Nuevo Juego", string id = "", string descripcion = "", string idEqA = "", string idEqB = "")
        {
            InitializeComponent();
            dgvEqA.DataSource = AsignacionFinal.BDD.EquipoRepository.GetAll();
            dgvEqB.DataSource = AsignacionFinal.BDD.EquipoRepository.GetAll();
            // Hacer que no se puedan cambiar los equipos si ya hay estadísticas registradas para ese equipo en el juego
            if (AsignacionFinal.BDD.JuegoRepository.existEquipoEstad(id,idEqA)) deshabilitarDGV(dgvEqA);
            if (AsignacionFinal.BDD.JuegoRepository.existEquipoEstad(id,idEqB)) deshabilitarDGV(dgvEqB);

            pickFechaYHora.Format = DateTimePickerFormat.Custom;
            pickFechaYHora.CustomFormat = "dd/MM/yyyy HH:mm";
            pickFechaYHora.ShowUpDown = true;

            this.AcceptButton = btnAceptar;
            this.CancelButton = btnCancelar;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Text = titulo;
            if (titulo != "Nuevo Juego")
                lblTitulo.Text = "Editar Juego " + id;

            dgvEqA.DataBindingComplete += (s, e) =>
            {
                if (titulo != "Nuevo Juego")
                {
                    foreach (DataGridViewRow row in dgvEqA.Rows)
                    {
                        var cellVal = row.Cells["ID"].Value?.ToString().Trim();
                        if (cellVal == idEqA)
                        {
                            dgvEqA.ClearSelection();
                            row.Selected = true;
                            dgvEqA.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
            };

            dgvEqB.DataBindingComplete += (s, e) =>
            {
                if (titulo != "Nuevo Juego")
                {
                    foreach (DataGridViewRow row in dgvEqB.Rows)
                    {
                        var cellVal = row.Cells["ID"].Value?.ToString().Trim();
                        if (cellVal == idEqB)
                        {
                            dgvEqB.ClearSelection();
                            row.Selected = true;
                            dgvEqB.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
            };

            txtId.Text = id;
            txtDescripcion.Text = descripcion;
            pickFechaYHora.Value = fechaYHora;
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void verify()
        {
            btnAceptar.Enabled = txtId.Text.Trim() != "" && txtDescripcion.Text.Trim() != "" && dgvEqA.SelectedRows.Count > 0 && dgvEqB.SelectedRows.Count > 0
                                 && Convert.ToString(dgvEqA.SelectedRows[0].Cells["ID"].Value).Trim() != Convert.ToString(dgvEqB.SelectedRows[0].Cells["ID"].Value).Trim();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            verify();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            verify();
        }

        private void dgvEqA_SelectionChanged(object sender, EventArgs e)
        {
            verify();
        }

        private void dgvEqB_SelectionChanged(object sender, EventArgs e)
        {
            verify();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var selectedRowA = dgvEqA.SelectedRows[0];
            var selectedRowB = dgvEqB.SelectedRows[0];
            string idEqA = selectedRowA.Cells["ID"].Value.ToString().Trim();
            string idEqB = selectedRowB.Cells["ID"].Value.ToString().Trim();
            juego = new Juego
            {
                idJuego = txtId.Text.Trim(),
                descripcion = txtDescripcion.Text.Trim(),
                idEquipoA = idEqA,
                idEquipoB = idEqB,
                fechaYHora = pickFechaYHora.Value
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void deshabilitarDGV(DataGridView dgv)
        {
            dgv.Enabled = false;
            dgv.DefaultCellStyle.BackColor = SystemColors.Control; // gris claro típico
            dgv.DefaultCellStyle.ForeColor = SystemColors.GrayText;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dgv.BackgroundColor = SystemColors.Control;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
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
    }
}
