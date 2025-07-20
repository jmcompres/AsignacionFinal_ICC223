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
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(113, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Equipo";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(46, 48);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Id :";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre :";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(18, 98);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(51, 15);
            lblCiudad.TabIndex = 3;
            lblCiudad.Text = "Ciudad :";
            // 
            // txtId
            // 
            txtId.Location = new Point(75, 45);
            txtId.MaxLength = 3;
            txtId.Name = "txtId";
            txtId.Size = new Size(61, 23);
            txtId.TabIndex = 4;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(75, 70);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(303, 23);
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
            dgvCiudades.Location = new Point(75, 99);
            dgvCiudades.MultiSelect = false;
            dgvCiudades.Name = "dgvCiudades";
            dgvCiudades.ReadOnly = true;
            dgvCiudades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudades.Size = new Size(445, 254);
            dgvCiudades.TabIndex = 6;
            dgvCiudades.SelectionChanged += dgvCiudades_SelectionChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(100, 377);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(18, 377);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormInsertEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 412);
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
            Name = "FormInsertEquipo";
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