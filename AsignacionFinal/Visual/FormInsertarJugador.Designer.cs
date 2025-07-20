
namespace AsignacionFinal.Visual
{
    partial class FormInsertarJugador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            dgvEquipos = new DataGridView();
            dgvCiudades = new DataGridView();
            txtNumero = new TextBox();
            btnInsertar = new Button();
            btnCancelar = new Button();
            dtpFechaNacim = new DateTimePicker();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 220);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(499, 32);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Equipo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 32);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 2;
            label3.Text = "Ciudad de Nacimiento :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 250);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Numero: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 250);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Nacim :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 220);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 5;
            label6.Text = "Id :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 218);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(219, 23);
            txtNombre.TabIndex = 6;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(385, 62);
            dgvEquipos.Margin = new Padding(3, 2, 3, 2);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.Size = new Size(284, 141);
            dgvEquipos.TabIndex = 7;
            dgvEquipos.CellContentClick += dgvEquipos_CellContentClick;
            // 
            // dgvCiudades
            // 
            dgvCiudades.AllowUserToAddRows = false;
            dgvCiudades.AllowUserToDeleteRows = false;
            dgvCiudades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCiudades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudades.Location = new Point(41, 62);
            dgvCiudades.Margin = new Padding(3, 2, 3, 2);
            dgvCiudades.MultiSelect = false;
            dgvCiudades.Name = "dgvCiudades";
            dgvCiudades.ReadOnly = true;
            dgvCiudades.RowHeadersWidth = 51;
            dgvCiudades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudades.Size = new Size(284, 141);
            dgvCiudades.TabIndex = 8;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(461, 250);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.MaxLength = 4;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(110, 23);
            txtNumero.TabIndex = 9;
            // 
            // btnInsertar
            // 
            btnInsertar.Enabled = false;
            btnInsertar.Location = new Point(499, 304);
            btnInsertar.Margin = new Padding(3, 2, 3, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(82, 22);
            btnInsertar.TabIndex = 10;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(607, 304);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpFechaNacim
            // 
            dtpFechaNacim.Location = new Point(151, 248);
            dtpFechaNacim.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNacim.Name = "dtpFechaNacim";
            dtpFechaNacim.Size = new Size(99, 23);
            dtpFechaNacim.TabIndex = 12;
            // 
            // txtId
            // 
            txtId.Location = new Point(461, 218);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.MaxLength = 5;
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 13;
            // 
            // FormInsertarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 358);
            ControlBox = false;
            Controls.Add(txtId);
            Controls.Add(dtpFechaNacim);
            Controls.Add(btnCancelar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNumero);
            Controls.Add(dgvCiudades);
            Controls.Add(dgvEquipos);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormInsertarJugador";
            Text = "Insertar Jugador";
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private DataGridView dgvEquipos;
        private DataGridView dgvCiudades;
        private TextBox txtNumero;
        private Button btnInsertar;
        private Button btnCancelar;
        private DateTimePicker dtpFechaNacim;
        private TextBox txtId;
    }
}