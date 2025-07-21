namespace AsignacionFinal.Visual
{
    partial class FormInsertJuego
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
            lblTitulo = new Label();
            lblId = new Label();
            lblDescripcion = new Label();
            lblEqA = new Label();
            lblEqB = new Label();
            dgvEqA = new DataGridView();
            dgvEqB = new DataGridView();
            txtId = new TextBox();
            txtDescripcion = new TextBox();
            lblFechaYHora = new Label();
            pickFechaYHora = new DateTimePicker();
            btnCancelar = new Button();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEqA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEqB).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(14, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Juego";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(189, 299);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 20);
            lblId.TabIndex = 1;
            lblId.Text = "Id :";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(302, 375);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(98, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción :";
            // 
            // lblEqA
            // 
            lblEqA.AutoSize = true;
            lblEqA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEqA.ForeColor = Color.White;
            lblEqA.Location = new Point(25, 71);
            lblEqA.Name = "lblEqA";
            lblEqA.Size = new Size(80, 20);
            lblEqA.TabIndex = 3;
            lblEqA.Text = "Equipo A :";
            // 
            // lblEqB
            // 
            lblEqB.AutoSize = true;
            lblEqB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEqB.ForeColor = Color.White;
            lblEqB.Location = new Point(478, 71);
            lblEqB.Name = "lblEqB";
            lblEqB.Size = new Size(79, 20);
            lblEqB.TabIndex = 4;
            lblEqB.Text = "Equipo B :";
            // 
            // dgvEqA
            // 
            dgvEqA.AllowUserToAddRows = false;
            dgvEqA.AllowUserToDeleteRows = false;
            dgvEqA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEqA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEqA.Location = new Point(106, 71);
            dgvEqA.Margin = new Padding(3, 4, 3, 4);
            dgvEqA.MultiSelect = false;
            dgvEqA.Name = "dgvEqA";
            dgvEqA.ReadOnly = true;
            dgvEqA.RowHeadersWidth = 51;
            dgvEqA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEqA.Size = new Size(341, 200);
            dgvEqA.TabIndex = 5;
            dgvEqA.SelectionChanged += dgvEqA_SelectionChanged;
            // 
            // dgvEqB
            // 
            dgvEqB.AllowUserToAddRows = false;
            dgvEqB.AllowUserToDeleteRows = false;
            dgvEqB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEqB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEqB.Location = new Point(560, 71);
            dgvEqB.Margin = new Padding(3, 4, 3, 4);
            dgvEqB.MultiSelect = false;
            dgvEqB.Name = "dgvEqB";
            dgvEqB.ReadOnly = true;
            dgvEqB.RowHeadersWidth = 51;
            dgvEqB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEqB.Size = new Size(341, 200);
            dgvEqB.TabIndex = 6;
            dgvEqB.SelectionChanged += dgvEqB_SelectionChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(219, 296);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 6;
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 7;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(400, 371);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.MaxLength = 25;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(267, 27);
            txtDescripcion.TabIndex = 8;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // lblFechaYHora
            // 
            lblFechaYHora.AutoSize = true;
            lblFechaYHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaYHora.ForeColor = Color.White;
            lblFechaYHora.Location = new Point(527, 299);
            lblFechaYHora.Name = "lblFechaYHora";
            lblFechaYHora.Size = new Size(107, 20);
            lblFechaYHora.TabIndex = 9;
            lblFechaYHora.Text = "Fecha y Hora :";
            lblFechaYHora.Click += lblFecha_Click;
            // 
            // pickFechaYHora
            // 
            pickFechaYHora.Format = DateTimePickerFormat.Custom;
            pickFechaYHora.Location = new Point(633, 296);
            pickFechaYHora.Margin = new Padding(3, 4, 3, 4);
            pickFechaYHora.Name = "pickFechaYHora";
            pickFechaYHora.Size = new Size(195, 27);
            pickFechaYHora.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(150, 441);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(64, 64, 64);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(46, 441);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormInsertJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(929, 508);
            ControlBox = false;
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(pickFechaYHora);
            Controls.Add(lblFechaYHora);
            Controls.Add(txtDescripcion);
            Controls.Add(txtId);
            Controls.Add(dgvEqB);
            Controls.Add(dgvEqA);
            Controls.Add(lblEqB);
            Controls.Add(lblEqA);
            Controls.Add(lblDescripcion);
            Controls.Add(lblId);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInsertJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInsertJuego";
            ((System.ComponentModel.ISupportInitialize)dgvEqA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEqB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblId;
        private Label lblDescripcion;
        private Label lblEqA;
        private Label lblEqB;
        private DataGridView dgvEqA;
        private DataGridView dgvEqB;
        private TextBox txtId;
        private TextBox txtDescripcion;
        private Label lblFechaYHora;
        private DateTimePicker pickFechaYHora;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}