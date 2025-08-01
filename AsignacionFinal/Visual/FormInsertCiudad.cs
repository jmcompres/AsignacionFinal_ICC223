﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsignacionFinal.BDD;

using AsignacionFinal.Modelos;

namespace AsignacionFinal.Visual
{
    public partial class FormInsertCiudad : Form
    {

        public Ciudad ciudad { get; private set; }

        public FormInsertCiudad(string titulo = "Nueva Ciudad", string id = "", string nombre = "")
        {
            InitializeComponent();
            this.AcceptButton = btnAceptar;
            this.CancelButton = btnCancelar;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Text = titulo;
            if (titulo != "Nueva Ciudad") lblTitulo.Text = "Editar Ciudad "+ nombre + " ("+id+")";
            else lblTitulo.Text = "Nueva Ciudad";
            txtId.Text = id;
            txtNombre.Text = nombre;
            txtId.KeyPress += TxtSoloLetrasYNumeros_KeyPress;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = txtId.Text.Trim() != "" && txtNombre.Text.Trim() != "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ciudad = new Ciudad
            {
                idCiudad = txtId.Text.Trim(),
                nombre = txtNombre.Text.Trim()
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = txtId.Text.Trim() != "" && txtNombre.Text.Trim() != "";
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
