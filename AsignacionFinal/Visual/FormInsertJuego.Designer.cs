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
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(106, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Juego";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(64, 48);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Id :";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 73);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(75, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción :";
            // 
            // lblEqA
            // 
            lblEqA.AutoSize = true;
            lblEqA.Location = new Point(26, 98);
            lblEqA.Name = "lblEqA";
            lblEqA.Size = new Size(61, 15);
            lblEqA.TabIndex = 3;
            lblEqA.Text = "Equipo A :";
            // 
            // lblEqB
            // 
            lblEqB.AutoSize = true;
            lblEqB.Location = new Point(425, 98);
            lblEqB.Name = "lblEqB";
            lblEqB.Size = new Size(60, 15);
            lblEqB.TabIndex = 4;
            lblEqB.Text = "Equipo B :";
            // 
            // dgvEqA
            // 
            dgvEqA.AllowUserToAddRows = false;
            dgvEqA.AllowUserToDeleteRows = false;
            dgvEqA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEqA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEqA.Location = new Point(93, 98);
            dgvEqA.MultiSelect = false;
            dgvEqA.Name = "dgvEqA";
            dgvEqA.ReadOnly = true;
            dgvEqA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEqA.Size = new Size(298, 150);
            dgvEqA.TabIndex = 5;
            dgvEqA.SelectionChanged += dgvEqA_SelectionChanged;
            // 
            // dgvEqB
            // 
            dgvEqB.AllowUserToAddRows = false;
            dgvEqB.AllowUserToDeleteRows = false;
            dgvEqB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEqB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEqB.Location = new Point(490, 98);
            dgvEqB.MultiSelect = false;
            dgvEqB.Name = "dgvEqB";
            dgvEqB.ReadOnly = true;
            dgvEqB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEqB.Size = new Size(298, 150);
            dgvEqB.TabIndex = 6;
            dgvEqB.SelectionChanged += dgvEqB_SelectionChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(93, 45);
            txtId.MaxLength = 6;
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 7;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(93, 70);
            txtDescripcion.MaxLength = 25;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(234, 23);
            txtDescripcion.TabIndex = 8;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // lblFechaYHora
            // 
            lblFechaYHora.AutoSize = true;
            lblFechaYHora.Location = new Point(12, 268);
            lblFechaYHora.Name = "lblFechaYHora";
            lblFechaYHora.Size = new Size(82, 15);
            lblFechaYHora.TabIndex = 9;
            lblFechaYHora.Text = "Fecha y Hora :";
            lblFechaYHora.Click += lblFecha_Click;
            // 
            // pickFechaYHora
            // 
            pickFechaYHora.Format = DateTimePickerFormat.Custom;
            pickFechaYHora.Location = new Point(93, 262);
            pickFechaYHora.Name = "pickFechaYHora";
            pickFechaYHora.Size = new Size(256, 23);
            pickFechaYHora.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(93, 331);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormInsertJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 381);
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
            Name = "FormInsertJuego";
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