﻿using AsignacionFinal.Modelos;
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
    public partial class FormInsertEquipo : Form
    {
        public Equipo equipo { get; private set; }

        public FormInsertEquipo(string titulo = "Nuevo Equipo", string id = "", string nombre = "", string idCiudad = "")
        {
            InitializeComponent();
            dgvCiudades.DataSource = AsignacionFinal.BDD.CiudadRepository.GetAll();

            this.AcceptButton = btnAceptar;
            this.CancelButton = btnCancelar;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Text = titulo;
            if (titulo != "Nuevo Equipo")
                lblTitulo.Text = "Editar Equipo " + nombre + " (" + id + ")";

            dgvCiudades.DataBindingComplete += (s, e) =>
            {
                if (titulo != "Nuevo Equipo")
                {
                    foreach (DataGridViewRow row in dgvCiudades.Rows)
                    {
                        var cellVal = row.Cells["ID"].Value?.ToString().Trim();
                        if (cellVal == idCiudad)
                        {
                            dgvCiudades.ClearSelection();
                            row.Selected = true;
                            dgvCiudades.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
            };

            txtId.Text = id;
            txtNombre.Text = nombre;

            txtId.KeyPress += TxtSoloLetrasYNumeros_KeyPress;
        }

        private void verify()
        {
            btnAceptar.Enabled = txtId.Text.Trim() != "" && txtNombre.Text.Trim() != "" && dgvCiudades.SelectedRows.Count > 0;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            verify();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            verify();
        }

        private void dgvCiudades_SelectionChanged(object sender, EventArgs e)
        {
            verify();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvCiudades.SelectedRows[0];
            string idCiudad = selectedRow.Cells["ID"].Value.ToString().Trim();
            equipo = new Equipo
            {
                idEquipo = txtId.Text.Trim(),
                nombre = txtNombre.Text.Trim(),
                idCiudad = idCiudad
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TxtSoloLetrasYNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
