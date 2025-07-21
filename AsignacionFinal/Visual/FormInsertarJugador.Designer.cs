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
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 293);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(570, 43);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Equipo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(111, 43);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 2;
            label3.Text = "Ciudad de Nacimiento :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(453, 333);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Número : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 333);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Nacim :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(455, 293);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 5;
            label6.Text = "Id :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 291);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 6;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(440, 83);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.Size = new Size(325, 188);
            dgvEquipos.TabIndex = 7;
            dgvEquipos.CellContentClick += dgvEquipos_CellContentClick;
            // 
            // dgvCiudades
            // 
            dgvCiudades.AllowUserToAddRows = false;
            dgvCiudades.AllowUserToDeleteRows = false;
            dgvCiudades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCiudades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudades.Location = new Point(47, 83);
            dgvCiudades.MultiSelect = false;
            dgvCiudades.Name = "dgvCiudades";
            dgvCiudades.ReadOnly = true;
            dgvCiudades.RowHeadersWidth = 51;
            dgvCiudades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudades.Size = new Size(325, 188);
            dgvCiudades.TabIndex = 8;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(527, 333);
            txtNumero.MaxLength = 4;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 9;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(64, 64, 64);
            btnInsertar.Enabled = false;
            btnInsertar.FlatAppearance.BorderSize = 0;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(406, 405);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(179, 40);
            btnInsertar.TabIndex = 10;
            btnInsertar.Text = "Aceptar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(617, 405);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(179, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpFechaNacim
            // 
            dtpFechaNacim.Location = new Point(173, 331);
            dtpFechaNacim.Name = "dtpFechaNacim";
            dtpFechaNacim.Size = new Size(113, 27);
            dtpFechaNacim.TabIndex = 12;
            // 
            // txtId
            // 
            txtId.Location = new Point(527, 291);
            txtId.MaxLength = 5;
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 13;
            // 
            // FormInsertarJugador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(824, 477);
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
            Name = "FormInsertarJugador";
            StartPosition = FormStartPosition.CenterScreen;
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