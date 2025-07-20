
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
            label1.Location = new Point(47, 293);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(570, 42);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Equipo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 42);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 2;
            label3.Text = "Ciudad de Nacimiento :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 333);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Numero: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 333);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Nacim :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 293);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 5;
            label6.Text = "Id :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 290);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 6;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(451, 83);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.Size = new Size(300, 188);
            dgvEquipos.TabIndex = 7;
            dgvEquipos.CellContentClick += dgvEquipos_CellContentClick;
            // 
            // dgvCiudades
            // 
            dgvCiudades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudades.Location = new Point(47, 83);
            dgvCiudades.Name = "dgvCiudades";
            dgvCiudades.RowHeadersWidth = 51;
            dgvCiudades.Size = new Size(300, 188);
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
            btnInsertar.Location = new Point(570, 406);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 29);
            btnInsertar.TabIndex = 10;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(694, 406);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpFechaNacim
            // 
            dtpFechaNacim.Location = new Point(173, 330);
            dtpFechaNacim.Name = "dtpFechaNacim";
            dtpFechaNacim.Size = new Size(250, 27);
            dtpFechaNacim.TabIndex = 12;
            // 
            // txtId
            // 
            txtId.Location = new Point(527, 290);
            txtId.MaxLength = 5;
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 13;
            // 
            // FormInsertarJugador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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