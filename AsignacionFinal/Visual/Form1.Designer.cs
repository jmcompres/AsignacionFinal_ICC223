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
            label1 = new Label();
            dgvJugadores = new DataGridView();
            btnActualizarListaJugadores = new Button();
            btnEliminarJugador = new Button();
            btnEditarJugador = new Button();
            btnInsertarJugador = new Button();
            tabEquipos = new TabPage();
            btnActualizarListEquipos = new Button();
            btnEditarEquipo = new Button();
            btnEliminarEquipo = new Button();
            btnInsertarEquipo = new Button();
            dgvEquipos = new DataGridView();
            lblTituloEquipos = new Label();
            tabJuegos = new TabPage();
            btnActualizarListadoJuegos = new Button();
            btnEditarJuego = new Button();
            btnEliminarJuego = new Button();
            btnInsertarJuego = new Button();
            dgvJuegos = new DataGridView();
            lblTituloJuegos = new Label();
            tabEstads = new TabPage();
            ciudadBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabCiudades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).BeginInit();
            tabJugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            tabEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            tabJuegos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).BeginInit();
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
            tabJugadores.Controls.Add(label1);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 5;
            label1.Text = "Listado de Jugadores";
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(21, 59);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.RowHeadersWidth = 51;
            dgvJugadores.Size = new Size(462, 282);
            dgvJugadores.TabIndex = 4;
            // 
            // btnActualizarListaJugadores
            // 
            btnActualizarListaJugadores.Location = new Point(391, 358);
            btnActualizarListaJugadores.Name = "btnActualizarListaJugadores";
            btnActualizarListaJugadores.Size = new Size(94, 29);
            btnActualizarListaJugadores.TabIndex = 3;
            btnActualizarListaJugadores.Text = "Actualizar";
            btnActualizarListaJugadores.UseVisualStyleBackColor = true;
            btnActualizarListaJugadores.Click += btnActualizarListaJugadores_Click;
            // 
            // btnEliminarJugador
            // 
            btnEliminarJugador.Location = new Point(121, 358);
            btnEliminarJugador.Name = "btnEliminarJugador";
            btnEliminarJugador.Size = new Size(94, 29);
            btnEliminarJugador.TabIndex = 2;
            btnEliminarJugador.Text = "Eliminar";
            btnEliminarJugador.UseVisualStyleBackColor = true;
            btnEliminarJugador.Click += btnEliminarJugador_Click;
            // 
            // btnEditarJugador
            // 
            btnEditarJugador.Location = new Point(221, 358);
            btnEditarJugador.Name = "btnEditarJugador";
            btnEditarJugador.Size = new Size(94, 29);
            btnEditarJugador.TabIndex = 1;
            btnEditarJugador.Text = "Editar";
            btnEditarJugador.UseVisualStyleBackColor = true;
            btnEditarJugador.Click += btnEditarJugador_Click;
            // 
            // btnInsertarJugador
            // 
            btnInsertarJugador.Location = new Point(21, 358);
            btnInsertarJugador.Name = "btnInsertarJugador";
            btnInsertarJugador.Size = new Size(94, 29);
            btnInsertarJugador.TabIndex = 0;
            btnInsertarJugador.Text = "Insertar";
            btnInsertarJugador.UseVisualStyleBackColor = true;
            btnInsertarJugador.Click += btnInsertarJugador_Click;
            // 
            // tabEquipos
            // 
            tabEquipos.Controls.Add(btnActualizarListEquipos);
            tabEquipos.Controls.Add(btnEditarEquipo);
            tabEquipos.Controls.Add(btnEliminarEquipo);
            tabEquipos.Controls.Add(btnInsertarEquipo);
            tabEquipos.Controls.Add(dgvEquipos);
            tabEquipos.Controls.Add(lblTituloEquipos);
            tabEquipos.Location = new Point(4, 29);
            tabEquipos.Margin = new Padding(3, 4, 3, 4);
            tabEquipos.Name = "tabEquipos";
            tabEquipos.Padding = new Padding(3, 4, 3, 4);
            tabEquipos.Size = new Size(906, 567);
            tabEquipos.TabIndex = 3;
            tabEquipos.Text = "Equipos";
            tabEquipos.UseVisualStyleBackColor = true;
            // 
            // btnActualizarListEquipos
            // 
            btnActualizarListEquipos.Location = new Point(418, 304);
            btnActualizarListEquipos.Name = "btnActualizarListEquipos";
            btnActualizarListEquipos.Size = new Size(109, 23);
            btnActualizarListEquipos.TabIndex = 7;
            btnActualizarListEquipos.Text = "Actualizar Listado";
            btnActualizarListEquipos.UseVisualStyleBackColor = true;
            btnActualizarListEquipos.Click += btnActualizarListEquipos_Click;
            // 
            // btnEditarEquipo
            // 
            btnEditarEquipo.Enabled = false;
            btnEditarEquipo.Location = new Point(170, 304);
            btnEditarEquipo.Name = "btnEditarEquipo";
            btnEditarEquipo.Size = new Size(75, 23);
            btnEditarEquipo.TabIndex = 6;
            btnEditarEquipo.Text = "Editar";
            btnEditarEquipo.UseVisualStyleBackColor = true;
            btnEditarEquipo.Click += btnEditarEquipo_Click;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Enabled = false;
            btnEliminarEquipo.Location = new Point(89, 304);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(75, 23);
            btnEliminarEquipo.TabIndex = 5;
            btnEliminarEquipo.Text = "Eliminar";
            btnEliminarEquipo.UseVisualStyleBackColor = true;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // btnInsertarEquipo
            // 
            btnInsertarEquipo.Location = new Point(8, 304);
            btnInsertarEquipo.Name = "btnInsertarEquipo";
            btnInsertarEquipo.Size = new Size(75, 23);
            btnInsertarEquipo.TabIndex = 4;
            btnInsertarEquipo.Text = "Insertar";
            btnInsertarEquipo.UseVisualStyleBackColor = true;
            btnInsertarEquipo.Click += btnInsertarEquipo_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(8, 44);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.Size = new Size(519, 254);
            dgvEquipos.TabIndex = 3;
            dgvEquipos.SelectionChanged += dgvEquipos_SelectionChanged;
            // 
            // lblTituloEquipos
            // 
            lblTituloEquipos.AutoSize = true;
            lblTituloEquipos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloEquipos.Location = new Point(8, 20);
            lblTituloEquipos.Name = "lblTituloEquipos";
            lblTituloEquipos.Size = new Size(185, 28);
            lblTituloEquipos.TabIndex = 2;
            lblTituloEquipos.Text = "Listado de equipos";
            // 
            // tabJuegos
            // 

            tabJuegos.Location = new Point(4, 29);
            tabJuegos.Margin = new Padding(3, 4, 3, 4);

            tabJuegos.Controls.Add(btnActualizarListadoJuegos);
            tabJuegos.Controls.Add(btnEditarJuego);
            tabJuegos.Controls.Add(btnEliminarJuego);
            tabJuegos.Controls.Add(btnInsertarJuego);
            tabJuegos.Controls.Add(dgvJuegos);
            tabJuegos.Controls.Add(lblTituloJuegos);
            tabJuegos.Location = new Point(4, 24);

            tabJuegos.Name = "tabJuegos";
            tabJuegos.Padding = new Padding(3, 4, 3, 4);
            tabJuegos.Size = new Size(906, 567);
            tabJuegos.TabIndex = 4;
            tabJuegos.Text = "Juegos";
            tabJuegos.UseVisualStyleBackColor = true;
            // 
            // btnActualizarListadoJuegos
            // 
            btnActualizarListadoJuegos.Location = new Point(672, 304);
            btnActualizarListadoJuegos.Name = "btnActualizarListadoJuegos";
            btnActualizarListadoJuegos.Size = new Size(112, 23);
            btnActualizarListadoJuegos.TabIndex = 5;
            btnActualizarListadoJuegos.Text = "Actualizar Listado";
            btnActualizarListadoJuegos.UseVisualStyleBackColor = true;
            // 
            // btnEditarJuego
            // 
            btnEditarJuego.Location = new Point(170, 304);
            btnEditarJuego.Name = "btnEditarJuego";
            btnEditarJuego.Size = new Size(75, 23);
            btnEditarJuego.TabIndex = 4;
            btnEditarJuego.Text = "Editar";
            btnEditarJuego.UseVisualStyleBackColor = true;
            btnEditarJuego.Click += btnEditarJuego_Click;
            // 
            // btnEliminarJuego
            // 
            btnEliminarJuego.Location = new Point(89, 304);
            btnEliminarJuego.Name = "btnEliminarJuego";
            btnEliminarJuego.Size = new Size(75, 23);
            btnEliminarJuego.TabIndex = 3;
            btnEliminarJuego.Text = "Eliminar";
            btnEliminarJuego.UseVisualStyleBackColor = true;
            btnEliminarJuego.Click += btnEliminarJuego_Click;
            // 
            // btnInsertarJuego
            // 
            btnInsertarJuego.Location = new Point(8, 304);
            btnInsertarJuego.Name = "btnInsertarJuego";
            btnInsertarJuego.Size = new Size(75, 23);
            btnInsertarJuego.TabIndex = 2;
            btnInsertarJuego.Text = "Insertar";
            btnInsertarJuego.UseVisualStyleBackColor = true;
            btnInsertarJuego.Click += btnInsertarJuego_Click;
            // 
            // dgvJuegos
            // 
            dgvJuegos.AllowUserToAddRows = false;
            dgvJuegos.AllowUserToDeleteRows = false;
            dgvJuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJuegos.Location = new Point(8, 44);
            dgvJuegos.MultiSelect = false;
            dgvJuegos.Name = "dgvJuegos";
            dgvJuegos.ReadOnly = true;
            dgvJuegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJuegos.Size = new Size(776, 254);
            dgvJuegos.TabIndex = 1;
            dgvJuegos.SelectionChanged += dgvJuegos_SelectionChanged;
            // 
            // lblTituloJuegos
            // 
            lblTituloJuegos.AutoSize = true;
            lblTituloJuegos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloJuegos.Location = new Point(8, 20);
            lblTituloJuegos.Name = "lblTituloJuegos";
            lblTituloJuegos.Size = new Size(139, 21);
            lblTituloJuegos.TabIndex = 0;
            lblTituloJuegos.Text = "Listado de juegos";
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
            tabJugadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            tabEquipos.ResumeLayout(false);
            tabEquipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            tabJuegos.ResumeLayout(false);
            tabJuegos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).EndInit();
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
        private DataGridView dgvEquipos;
        private Label lblTituloEquipos;
        private Button btnInsertarEquipo;
        private Button btnActualizarListEquipos;
        private Button btnEditarEquipo;
        private Button btnEliminarEquipo;

        private Button btnEliminarJugador;
        private Button btnEditarJugador;
        private Button btnInsertarJugador;
        private Button btnActualizarListaJugadores;
        private DataGridView dgvJugadores;
        private Label label1;

        private Label lblTituloJuegos;
        private Button btnActualizarListadoJuegos;
        private Button btnEditarJuego;
        private Button btnEliminarJuego;
        private Button btnInsertarJuego;
        private DataGridView dgvJuegos;
    }
}
