namespace AsignacionFinal.Visual
{
    partial class FormInsertEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsertEquipo));
            lblTitulo = new Label();
            lblId = new Label();
            lblNombre = new Label();
            lblCiudad = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            dgvCiudades = new DataGridView();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(14, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(145, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Equipo";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(53, 64);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 20);
            lblId.TabIndex = 1;
            lblId.Text = "Id :";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(10, 97);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre :";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCiudad.ForeColor = Color.White;
            lblCiudad.Location = new Point(21, 131);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(65, 20);
            lblCiudad.TabIndex = 3;
            lblCiudad.Text = "Ciudad :";
            // 
            // txtId
            // 
            txtId.Location = new Point(86, 60);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 3;
            txtId.Name = "txtId";
            txtId.Size = new Size(69, 27);
            txtId.TabIndex = 4;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 93);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(346, 27);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // dgvCiudades
            // 
            dgvCiudades.AllowUserToAddRows = false;
            dgvCiudades.AllowUserToDeleteRows = false;
            dgvCiudades.AllowUserToResizeRows = false;
            dgvCiudades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCiudades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudades.Location = new Point(86, 132);
            dgvCiudades.Margin = new Padding(3, 4, 3, 4);
            dgvCiudades.MultiSelect = false;
            dgvCiudades.Name = "dgvCiudades";
            dgvCiudades.ReadOnly = true;
            dgvCiudades.RowHeadersWidth = 51;
            dgvCiudades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudades.Size = new Size(509, 339);
            dgvCiudades.TabIndex = 6;
            dgvCiudades.SelectionChanged += dgvCiudades_SelectionChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(64, 64, 64);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(24, 503);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(126, 503);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormInsertEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(637, 549);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dgvCiudades);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lblCiudad);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInsertEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Equipo";
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblId;
        private Label lblNombre;
        private Label lblCiudad;
        private TextBox txtId;
        private TextBox txtNombre;
        private DataGridView dgvCiudades;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}