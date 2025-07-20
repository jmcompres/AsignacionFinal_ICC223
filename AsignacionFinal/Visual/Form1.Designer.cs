using AsignacionFinal.BDD;
using System.Windows.Forms;

namespace AsignacionFinal.Visual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabMenuPrincipal = new TabPage();
            tabCiudades = new TabPage();
            btnActualizarTabla = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            lblCiudades = new Label();
            dgvCiudades = new DataGridView();
            tabJugadores = new TabPage();
            dgvJugadores = new DataGridView();
            btnActualizarListaJugadores = new Button();
            btnEliminarJugador = new Button();
            btnEditarJugador = new Button();
            btnInsertarJugador = new Button();
            tabEquipos = new TabPage();
            tabJuegos = new TabPage();
            tabEstads = new TabPage();
            ciudadBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabCiudades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).BeginInit();
            tabJugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ciudadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMenuPrincipal);
            tabControl1.Controls.Add(tabCiudades);
            tabControl1.Controls.Add(tabJugadores);
            tabControl1.Controls.Add(tabEquipos);
            tabControl1.Controls.Add(tabJuegos);
            tabControl1.Controls.Add(tabEstads);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 600);
            tabControl1.TabIndex = 0;
            // 
            // tabMenuPrincipal
            // 
            tabMenuPrincipal.Location = new Point(4, 29);
            tabMenuPrincipal.Margin = new Padding(3, 4, 3, 4);
            tabMenuPrincipal.Name = "tabMenuPrincipal";
            tabMenuPrincipal.Padding = new Padding(3, 4, 3, 4);
            tabMenuPrincipal.Size = new Size(906, 567);
            tabMenuPrincipal.TabIndex = 0;
            tabMenuPrincipal.Text = "Menú Principal";
            tabMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // tabCiudades
            // 
            tabCiudades.Controls.Add(btnActualizarTabla);
            tabCiudades.Controls.Add(btnEditar);
            tabCiudades.Controls.Add(btnEliminar);
            tabCiudades.Controls.Add(btnInsertar);
            tabCiudades.Controls.Add(lblCiudades);
            tabCiudades.Controls.Add(dgvCiudades);
            tabCiudades.Location = new Point(4, 29);
            tabCiudades.Margin = new Padding(3, 4, 3, 4);
            tabCiudades.Name = "tabCiudades";
            tabCiudades.Padding = new Padding(3, 4, 3, 4);
            tabCiudades.Size = new Size(906, 567);
            tabCiudades.TabIndex = 1;
            tabCiudades.Text = "Ciudades";
            tabCiudades.UseVisualStyleBackColor = true;
            // 
            // btnActualizarTabla
            // 
            btnActualizarTabla.Location = new Point(387, 405);
            btnActualizarTabla.Margin = new Padding(3, 4, 3, 4);
            btnActualizarTabla.Name = "btnActualizarTabla";
            btnActualizarTabla.Size = new Size(130, 31);
            btnActualizarTabla.TabIndex = 5;
            btnActualizarTabla.Text = "Actualizar Listado";
            btnActualizarTabla.UseVisualStyleBackColor = true;
            btnActualizarTabla.Click += btnActualizarTabla_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(194, 405);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button1_Click_2;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(102, 405);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(9, 405);
            btnInsertar.Margin = new Padding(3, 4, 3, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(86, 31);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += button1_Click_1;
            // 
            // lblCiudades
            // 
            lblCiudades.AutoSize = true;
            lblCiudades.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCiudades.Location = new Point(9, 27);
            lblCiudades.Name = "lblCiudades";
            lblCiudades.Size = new Size(192, 28);
            lblCiudades.TabIndex = 1;
            lblCiudades.Text = "Listado de ciudades";
            // 
            // dgvCiudades
            // 
            dgvCiudades.AllowUserToAddRows = false;
            dgvCiudades.AllowUserToDeleteRows = false;
            dgvCiudades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCiudades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudades.Location = new Point(9, 59);
            dgvCiudades.Margin = new Padding(3, 4, 3, 4);
            dgvCiudades.MultiSelect = false;
            dgvCiudades.Name = "dgvCiudades";
            dgvCiudades.ReadOnly = true;
            dgvCiudades.RowHeadersWidth = 51;
            dgvCiudades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudades.Size = new Size(509, 339);
            dgvCiudades.TabIndex = 0;
            dgvCiudades.CellContentClick += dataGridView1_CellContentClick;
            dgvCiudades.SelectionChanged += dgvCiudades_SelectionChanged;
            // 
            // tabJugadores
            // 
            tabJugadores.Controls.Add(dgvJugadores);
            tabJugadores.Controls.Add(btnActualizarListaJugadores);
            tabJugadores.Controls.Add(btnEliminarJugador);
            tabJugadores.Controls.Add(btnEditarJugador);
            tabJugadores.Controls.Add(btnInsertarJugador);
            tabJugadores.Location = new Point(4, 29);
            tabJugadores.Margin = new Padding(3, 4, 3, 4);
            tabJugadores.Name = "tabJugadores";
            tabJugadores.Padding = new Padding(3, 4, 3, 4);
            tabJugadores.Size = new Size(906, 567);
            tabJugadores.TabIndex = 2;
            tabJugadores.Text = "Jugadores";
            tabJugadores.UseVisualStyleBackColor = true;
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(21, 25);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.RowHeadersWidth = 51;
            dgvJugadores.Size = new Size(462, 282);
            dgvJugadores.TabIndex = 4;
            // 
            // btnActualizarListaJugadores
            // 
            btnActualizarListaJugadores.Enabled = false;
            btnActualizarListaJugadores.Location = new Point(396, 324);
            btnActualizarListaJugadores.Name = "btnActualizarListaJugadores";
            btnActualizarListaJugadores.Size = new Size(94, 29);
            btnActualizarListaJugadores.TabIndex = 3;
            btnActualizarListaJugadores.Text = "Actualizar";
            btnActualizarListaJugadores.UseVisualStyleBackColor = true;
            btnActualizarListaJugadores.Click += btnActualizarListaJugadores_Click;
            // 
            // btnEliminarJugador
            // 
            btnEliminarJugador.Enabled = false;
            btnEliminarJugador.Location = new Point(121, 324);
            btnEliminarJugador.Name = "btnEliminarJugador";
            btnEliminarJugador.Size = new Size(94, 29);
            btnEliminarJugador.TabIndex = 2;
            btnEliminarJugador.Text = "Eliminar";
            btnEliminarJugador.UseVisualStyleBackColor = true;
            btnEliminarJugador.Click += btnEliminarJugador_Click;
            // 
            // btnEditarJugador
            // 
            btnEditarJugador.Enabled = false;
            btnEditarJugador.Location = new Point(221, 324);
            btnEditarJugador.Name = "btnEditarJugador";
            btnEditarJugador.Size = new Size(94, 29);
            btnEditarJugador.TabIndex = 1;
            btnEditarJugador.Text = "Editar";
            btnEditarJugador.UseVisualStyleBackColor = true;
            btnEditarJugador.Click += btnEditarJugador_Click;
            // 
            // btnInsertarJugador
            // 
            btnInsertarJugador.Location = new Point(21, 324);
            btnInsertarJugador.Name = "btnInsertarJugador";
            btnInsertarJugador.Size = new Size(94, 29);
            btnInsertarJugador.TabIndex = 0;
            btnInsertarJugador.Text = "Insertar";
            btnInsertarJugador.UseVisualStyleBackColor = true;
            btnInsertarJugador.Click += btnInsertarJugador_Click;
            // 
            // tabEquipos
            // 
            tabEquipos.Location = new Point(4, 29);
            tabEquipos.Margin = new Padding(3, 4, 3, 4);
            tabEquipos.Name = "tabEquipos";
            tabEquipos.Padding = new Padding(3, 4, 3, 4);
            tabEquipos.Size = new Size(906, 567);
            tabEquipos.TabIndex = 3;
            tabEquipos.Text = "Equipos";
            tabEquipos.UseVisualStyleBackColor = true;
            // 
            // tabJuegos
            // 
            tabJuegos.Location = new Point(4, 29);
            tabJuegos.Margin = new Padding(3, 4, 3, 4);
            tabJuegos.Name = "tabJuegos";
            tabJuegos.Padding = new Padding(3, 4, 3, 4);
            tabJuegos.Size = new Size(906, 567);
            tabJuegos.TabIndex = 4;
            tabJuegos.Text = "Juegos";
            tabJuegos.UseVisualStyleBackColor = true;
            // 
            // tabEstads
            // 
            tabEstads.Location = new Point(4, 29);
            tabEstads.Margin = new Padding(3, 4, 3, 4);
            tabEstads.Name = "tabEstads";
            tabEstads.Padding = new Padding(3, 4, 3, 4);
            tabEstads.Size = new Size(906, 567);
            tabEstads.TabIndex = 5;
            tabEstads.Text = "Estadísticas";
            tabEstads.UseVisualStyleBackColor = true;
            // 
            // ciudadBindingSource
            // 
            ciudadBindingSource.DataSource = typeof(Modelos.Ciudad);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Gestor de torneo";
            tabControl1.ResumeLayout(false);
            tabCiudades.ResumeLayout(false);
            tabCiudades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).EndInit();
            tabJugadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)ciudadBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabMenuPrincipal;
        private TabPage tabCiudades;
        private TabPage tabJugadores;
        private TabPage tabEquipos;
        private TabPage tabJuegos;
        private TabPage tabEstads;
        private DataGridView dgvCiudades;
        private BindingSource ciudadBindingSource;
        private Label lblCiudades;
        private Button btnInsertar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnActualizarTabla;
        private Button btnEliminarJugador;
        private Button btnEditarJugador;
        private Button btnInsertarJugador;
        private Button btnActualizarListaJugadores;
        private DataGridView dgvJugadores;
    }
}
