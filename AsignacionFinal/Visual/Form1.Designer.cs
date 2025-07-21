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
            dgvResumen = new DataGridView();
            cmbIdJuegoResumen = new ComboBox();
            btnConsultarResumen = new Button();
            lblIdResumen = new Label();
            lblTituloResumenJuego = new Label();
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
            label4 = new Label();
            btnActualizarEstadJuego = new Button();
            spnCantEstad = new NumericUpDown();
            cmbTipoEstad = new ComboBox();
            lblCantidad = new Label();
            lblTipoEstad = new Label();
            dgvJugadorPEstad = new DataGridView();
            label3 = new Label();
            dgvJuegoPEstad = new DataGridView();
            lblTituloEstads = new Label();
            label2 = new Label();
            btnEstadisticas = new Button();
            btnJuegos = new Button();
            btnEquipos = new Button();
            btnJugadores = new Button();
            MenuLateral = new Panel();
            btnMenuPrincipal = new Button();
            btnCiudades = new Button();
            ciudadBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            tabCiudades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).BeginInit();
            tabJugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            tabEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            tabJuegos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).BeginInit();
            tabEstads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spnCantEstad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJugadorPEstad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJuegoPEstad).BeginInit();
            MenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ciudadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabMenuPrincipal);
            tabControl1.Controls.Add(tabCiudades);
            tabControl1.Controls.Add(tabJugadores);
            tabControl1.Controls.Add(tabEquipos);
            tabControl1.Controls.Add(tabJuegos);
            tabControl1.Controls.Add(tabEstads);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(60, 1);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1924, 975);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // tabMenuPrincipal
            // 
            tabMenuPrincipal.BackColor = Color.Gray;
            tabMenuPrincipal.Controls.Add(dgvResumen);
            tabMenuPrincipal.Controls.Add(cmbIdJuegoResumen);
            tabMenuPrincipal.Controls.Add(btnConsultarResumen);
            tabMenuPrincipal.Controls.Add(lblIdResumen);
            tabMenuPrincipal.Controls.Add(lblTituloResumenJuego);
            tabMenuPrincipal.Location = new Point(304, 4);
            tabMenuPrincipal.Name = "tabMenuPrincipal";
            tabMenuPrincipal.Padding = new Padding(3);
            tabMenuPrincipal.Size = new Size(1616, 967);
            tabMenuPrincipal.TabIndex = 0;
            tabMenuPrincipal.Text = "Resúmenes de juegos";
            // 
            // dgvResumen
            // 
            dgvResumen.AllowUserToAddRows = false;
            dgvResumen.AllowUserToDeleteRows = false;
            dgvResumen.AllowUserToResizeColumns = false;
            dgvResumen.AllowUserToResizeRows = false;
            dgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(700, 202);
            dgvResumen.MultiSelect = false;
            dgvResumen.Name = "dgvResumen";
            dgvResumen.ReadOnly = true;
            dgvResumen.RowHeadersWidth = 51;
            dgvResumen.Size = new Size(800, 668);
            dgvResumen.TabIndex = 4;
            dgvResumen.Visible = false;
            // 
            // cmbIdJuegoResumen
            // 
            cmbIdJuegoResumen.BackColor = Color.FromArgb(64, 64, 64);
            cmbIdJuegoResumen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdJuegoResumen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbIdJuegoResumen.ForeColor = Color.White;
            cmbIdJuegoResumen.FormattingEnabled = true;
            cmbIdJuegoResumen.Location = new Point(847, 152);
            cmbIdJuegoResumen.Name = "cmbIdJuegoResumen";
            cmbIdJuegoResumen.Size = new Size(137, 28);
            cmbIdJuegoResumen.TabIndex = 5;
            cmbIdJuegoResumen.SelectedIndexChanged += cmbIdJuegoResumen_SelectedIndexChanged;
            // 
            // btnConsultarResumen
            // 
            btnConsultarResumen.BackColor = Color.FromArgb(64, 64, 64);
            btnConsultarResumen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConsultarResumen.ForeColor = Color.White;
            btnConsultarResumen.Location = new Point(1004, 146);
            btnConsultarResumen.Name = "btnConsultarResumen";
            btnConsultarResumen.Size = new Size(179, 40);
            btnConsultarResumen.TabIndex = 3;
            btnConsultarResumen.Text = "Consultar";
            btnConsultarResumen.UseVisualStyleBackColor = false;
            btnConsultarResumen.Click += btnConsultarResumen_Click;
            // 
            // lblIdResumen
            // 
            lblIdResumen.AutoSize = true;
            lblIdResumen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblIdResumen.ForeColor = Color.White;
            lblIdResumen.Location = new Point(700, 152);
            lblIdResumen.Name = "lblIdResumen";
            lblIdResumen.Size = new Size(129, 28);
            lblIdResumen.TabIndex = 1;
            lblIdResumen.Text = "Id de juego :";
            // 
            // lblTituloResumenJuego
            // 
            lblTituloResumenJuego.AutoSize = true;
            lblTituloResumenJuego.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloResumenJuego.ForeColor = Color.White;
            lblTituloResumenJuego.Location = new Point(700, 92);
            lblTituloResumenJuego.Name = "lblTituloResumenJuego";
            lblTituloResumenJuego.Size = new Size(412, 41);
            lblTituloResumenJuego.TabIndex = 0;
            lblTituloResumenJuego.Text = "Consultar resumen de juego";
            // 
            // tabCiudades
            // 
            tabCiudades.BackColor = Color.Gray;
            tabCiudades.Controls.Add(btnActualizarTabla);
            tabCiudades.Controls.Add(btnEditar);
            tabCiudades.Controls.Add(btnEliminar);
            tabCiudades.Controls.Add(btnInsertar);
            tabCiudades.Controls.Add(lblCiudades);
            tabCiudades.Controls.Add(dgvCiudades);
            tabCiudades.Location = new Point(304, 4);
            tabCiudades.Margin = new Padding(3, 4, 3, 4);
            tabCiudades.Name = "tabCiudades";
            tabCiudades.Padding = new Padding(3, 4, 3, 4);
            tabCiudades.Size = new Size(1616, 967);
            tabCiudades.TabIndex = 1;
            tabCiudades.Text = "Ciudades";
            // 
            // btnActualizarTabla
            // 
            btnActualizarTabla.BackColor = Color.FromArgb(64, 64, 64);
            btnActualizarTabla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActualizarTabla.ForeColor = Color.White;
            btnActualizarTabla.Location = new Point(1321, 684);
            btnActualizarTabla.Margin = new Padding(3, 4, 3, 4);
            btnActualizarTabla.Name = "btnActualizarTabla";
            btnActualizarTabla.Size = new Size(179, 40);
            btnActualizarTabla.TabIndex = 5;
            btnActualizarTabla.Text = "Actualizar Listado";
            btnActualizarTabla.UseVisualStyleBackColor = false;
            btnActualizarTabla.Click += btnActualizarTabla_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(64, 64, 64);
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(1114, 684);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(179, 40);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += button1_Click_2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(907, 684);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(179, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(64, 64, 64);
            btnInsertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(700, 684);
            btnInsertar.Margin = new Padding(3, 4, 3, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(179, 40);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += button1_Click_1;
            // 
            // lblCiudades
            // 
            lblCiudades.AutoSize = true;
            lblCiudades.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCiudades.ForeColor = Color.White;
            lblCiudades.Location = new Point(700, 141);
            lblCiudades.Name = "lblCiudades";
            lblCiudades.Size = new Size(295, 41);
            lblCiudades.TabIndex = 1;
            lblCiudades.Text = "Listado de ciudades";
            // 
            // dgvCiudades
            // 
            dgvCiudades.AllowUserToAddRows = false;
            dgvCiudades.AllowUserToDeleteRows = false;
            dgvCiudades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCiudades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudades.Location = new Point(700, 202);
            dgvCiudades.Margin = new Padding(3, 4, 3, 4);
            dgvCiudades.MultiSelect = false;
            dgvCiudades.Name = "dgvCiudades";
            dgvCiudades.ReadOnly = true;
            dgvCiudades.RowHeadersWidth = 51;
            dgvCiudades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudades.Size = new Size(800, 450);
            dgvCiudades.TabIndex = 0;
            dgvCiudades.CellContentClick += dataGridView1_CellContentClick;
            dgvCiudades.SelectionChanged += dgvCiudades_SelectionChanged;
            // 
            // tabJugadores
            // 
            tabJugadores.BackColor = Color.Gray;
            tabJugadores.Controls.Add(label1);
            tabJugadores.Controls.Add(dgvJugadores);
            tabJugadores.Controls.Add(btnActualizarListaJugadores);
            tabJugadores.Controls.Add(btnEliminarJugador);
            tabJugadores.Controls.Add(btnEditarJugador);
            tabJugadores.Controls.Add(btnInsertarJugador);
            tabJugadores.Location = new Point(304, 4);
            tabJugadores.Margin = new Padding(3, 4, 3, 4);
            tabJugadores.Name = "tabJugadores";
            tabJugadores.Padding = new Padding(3, 4, 3, 4);
            tabJugadores.Size = new Size(1616, 967);
            tabJugadores.TabIndex = 2;
            tabJugadores.Text = "Jugadores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(700, 141);
            label1.Name = "label1";
            label1.Size = new Size(311, 41);
            label1.TabIndex = 5;
            label1.Text = "Listado de jugadores";
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(700, 202);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.RowHeadersWidth = 51;
            dgvJugadores.Size = new Size(800, 450);
            dgvJugadores.TabIndex = 4;
            // 
            // btnActualizarListaJugadores
            // 
            btnActualizarListaJugadores.BackColor = Color.FromArgb(64, 64, 64);
            btnActualizarListaJugadores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActualizarListaJugadores.ForeColor = Color.White;
            btnActualizarListaJugadores.Location = new Point(1318, 684);
            btnActualizarListaJugadores.Name = "btnActualizarListaJugadores";
            btnActualizarListaJugadores.Size = new Size(179, 40);
            btnActualizarListaJugadores.TabIndex = 3;
            btnActualizarListaJugadores.Text = "Actualizar Listado";
            btnActualizarListaJugadores.UseVisualStyleBackColor = false;
            btnActualizarListaJugadores.Click += btnActualizarListaJugadores_Click;
            // 
            // btnEliminarJugador
            // 
            btnEliminarJugador.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminarJugador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarJugador.ForeColor = Color.White;
            btnEliminarJugador.Location = new Point(906, 684);
            btnEliminarJugador.Name = "btnEliminarJugador";
            btnEliminarJugador.Size = new Size(179, 40);
            btnEliminarJugador.TabIndex = 2;
            btnEliminarJugador.Text = "Eliminar";
            btnEliminarJugador.UseVisualStyleBackColor = false;
            btnEliminarJugador.Click += btnEliminarJugador_Click;
            // 
            // btnEditarJugador
            // 
            btnEditarJugador.BackColor = Color.FromArgb(64, 64, 64);
            btnEditarJugador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarJugador.ForeColor = Color.White;
            btnEditarJugador.Location = new Point(1112, 684);
            btnEditarJugador.Name = "btnEditarJugador";
            btnEditarJugador.Size = new Size(179, 40);
            btnEditarJugador.TabIndex = 1;
            btnEditarJugador.Text = "Editar";
            btnEditarJugador.UseVisualStyleBackColor = false;
            btnEditarJugador.Click += btnEditarJugador_Click;
            // 
            // btnInsertarJugador
            // 
            btnInsertarJugador.BackColor = Color.FromArgb(64, 64, 64);
            btnInsertarJugador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInsertarJugador.ForeColor = Color.White;
            btnInsertarJugador.Location = new Point(700, 684);
            btnInsertarJugador.Name = "btnInsertarJugador";
            btnInsertarJugador.Size = new Size(179, 40);
            btnInsertarJugador.TabIndex = 0;
            btnInsertarJugador.Text = "Insertar";
            btnInsertarJugador.UseVisualStyleBackColor = false;
            btnInsertarJugador.Click += btnInsertarJugador_Click;
            // 
            // tabEquipos
            // 
            tabEquipos.BackColor = Color.Gray;
            tabEquipos.Controls.Add(btnActualizarListEquipos);
            tabEquipos.Controls.Add(btnEditarEquipo);
            tabEquipos.Controls.Add(btnEliminarEquipo);
            tabEquipos.Controls.Add(btnInsertarEquipo);
            tabEquipos.Controls.Add(dgvEquipos);
            tabEquipos.Controls.Add(lblTituloEquipos);
            tabEquipos.Location = new Point(304, 4);
            tabEquipos.Margin = new Padding(3, 4, 3, 4);
            tabEquipos.Name = "tabEquipos";
            tabEquipos.Padding = new Padding(3, 4, 3, 4);
            tabEquipos.Size = new Size(1616, 967);
            tabEquipos.TabIndex = 3;
            tabEquipos.Text = "Equipos";
            // 
            // btnActualizarListEquipos
            // 
            btnActualizarListEquipos.BackColor = Color.FromArgb(64, 64, 64);
            btnActualizarListEquipos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActualizarListEquipos.ForeColor = Color.White;
            btnActualizarListEquipos.Location = new Point(1321, 684);
            btnActualizarListEquipos.Name = "btnActualizarListEquipos";
            btnActualizarListEquipos.Size = new Size(179, 40);
            btnActualizarListEquipos.TabIndex = 7;
            btnActualizarListEquipos.Text = "Actualizar Listado";
            btnActualizarListEquipos.UseVisualStyleBackColor = false;
            btnActualizarListEquipos.Click += btnActualizarListEquipos_Click;
            // 
            // btnEditarEquipo
            // 
            btnEditarEquipo.BackColor = Color.FromArgb(64, 64, 64);
            btnEditarEquipo.Enabled = false;
            btnEditarEquipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarEquipo.ForeColor = Color.White;
            btnEditarEquipo.Location = new Point(1114, 684);
            btnEditarEquipo.Name = "btnEditarEquipo";
            btnEditarEquipo.Size = new Size(179, 40);
            btnEditarEquipo.TabIndex = 6;
            btnEditarEquipo.Text = "Editar";
            btnEditarEquipo.UseVisualStyleBackColor = false;
            btnEditarEquipo.Click += btnEditarEquipo_Click;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminarEquipo.Enabled = false;
            btnEliminarEquipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarEquipo.ForeColor = Color.White;
            btnEliminarEquipo.Location = new Point(907, 684);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(179, 40);
            btnEliminarEquipo.TabIndex = 5;
            btnEliminarEquipo.Text = "Eliminar";
            btnEliminarEquipo.UseVisualStyleBackColor = false;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // btnInsertarEquipo
            // 
            btnInsertarEquipo.BackColor = Color.FromArgb(64, 64, 64);
            btnInsertarEquipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInsertarEquipo.ForeColor = Color.White;
            btnInsertarEquipo.Location = new Point(700, 684);
            btnInsertarEquipo.Name = "btnInsertarEquipo";
            btnInsertarEquipo.Size = new Size(179, 40);
            btnInsertarEquipo.TabIndex = 4;
            btnInsertarEquipo.Text = "Insertar";
            btnInsertarEquipo.UseVisualStyleBackColor = false;
            btnInsertarEquipo.Click += btnInsertarEquipo_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(700, 202);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.Size = new Size(800, 450);
            dgvEquipos.TabIndex = 3;
            dgvEquipos.SelectionChanged += dgvEquipos_SelectionChanged;
            // 
            // lblTituloEquipos
            // 
            lblTituloEquipos.AutoSize = true;
            lblTituloEquipos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloEquipos.ForeColor = Color.White;
            lblTituloEquipos.Location = new Point(700, 141);
            lblTituloEquipos.Name = "lblTituloEquipos";
            lblTituloEquipos.Size = new Size(283, 41);
            lblTituloEquipos.TabIndex = 2;
            lblTituloEquipos.Text = "Listado de equipos";
            // 
            // tabJuegos
            // 
            tabJuegos.BackColor = Color.Gray;
            tabJuegos.Controls.Add(btnActualizarListadoJuegos);
            tabJuegos.Controls.Add(btnEditarJuego);
            tabJuegos.Controls.Add(btnEliminarJuego);
            tabJuegos.Controls.Add(btnInsertarJuego);
            tabJuegos.Controls.Add(dgvJuegos);
            tabJuegos.Controls.Add(lblTituloJuegos);
            tabJuegos.Location = new Point(304, 4);
            tabJuegos.Margin = new Padding(3, 4, 3, 4);
            tabJuegos.Name = "tabJuegos";
            tabJuegos.Padding = new Padding(3, 4, 3, 4);
            tabJuegos.Size = new Size(1616, 967);
            tabJuegos.TabIndex = 4;
            tabJuegos.Text = "Juegos";
            // 
            // btnActualizarListadoJuegos
            // 
            btnActualizarListadoJuegos.BackColor = Color.FromArgb(64, 64, 64);
            btnActualizarListadoJuegos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActualizarListadoJuegos.ForeColor = Color.White;
            btnActualizarListadoJuegos.Location = new Point(1297, 684);
            btnActualizarListadoJuegos.Name = "btnActualizarListadoJuegos";
            btnActualizarListadoJuegos.Size = new Size(179, 40);
            btnActualizarListadoJuegos.TabIndex = 5;
            btnActualizarListadoJuegos.Text = "Actualizar Listado";
            btnActualizarListadoJuegos.UseVisualStyleBackColor = false;
            // 
            // btnEditarJuego
            // 
            btnEditarJuego.BackColor = Color.FromArgb(64, 64, 64);
            btnEditarJuego.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarJuego.ForeColor = Color.White;
            btnEditarJuego.Location = new Point(1098, 684);
            btnEditarJuego.Name = "btnEditarJuego";
            btnEditarJuego.Size = new Size(179, 40);
            btnEditarJuego.TabIndex = 4;
            btnEditarJuego.Text = "Editar";
            btnEditarJuego.UseVisualStyleBackColor = false;
            btnEditarJuego.Click += btnEditarJuego_Click;
            // 
            // btnEliminarJuego
            // 
            btnEliminarJuego.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminarJuego.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarJuego.ForeColor = Color.White;
            btnEliminarJuego.Location = new Point(899, 684);
            btnEliminarJuego.Name = "btnEliminarJuego";
            btnEliminarJuego.Size = new Size(179, 40);
            btnEliminarJuego.TabIndex = 3;
            btnEliminarJuego.Text = "Eliminar";
            btnEliminarJuego.UseVisualStyleBackColor = false;
            btnEliminarJuego.Click += btnEliminarJuego_Click;
            // 
            // btnInsertarJuego
            // 
            btnInsertarJuego.BackColor = Color.FromArgb(64, 64, 64);
            btnInsertarJuego.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInsertarJuego.ForeColor = Color.White;
            btnInsertarJuego.Location = new Point(700, 684);
            btnInsertarJuego.Name = "btnInsertarJuego";
            btnInsertarJuego.Size = new Size(179, 40);
            btnInsertarJuego.TabIndex = 2;
            btnInsertarJuego.Text = "Insertar";
            btnInsertarJuego.UseVisualStyleBackColor = false;
            btnInsertarJuego.Click += btnInsertarJuego_Click;
            // 
            // dgvJuegos
            // 
            dgvJuegos.AllowUserToAddRows = false;
            dgvJuegos.AllowUserToDeleteRows = false;
            dgvJuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJuegos.Location = new Point(700, 202);
            dgvJuegos.MultiSelect = false;
            dgvJuegos.Name = "dgvJuegos";
            dgvJuegos.ReadOnly = true;
            dgvJuegos.RowHeadersWidth = 51;
            dgvJuegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJuegos.Size = new Size(776, 450);
            dgvJuegos.TabIndex = 1;
            dgvJuegos.SelectionChanged += dgvJuegos_SelectionChanged;
            // 
            // lblTituloJuegos
            // 
            lblTituloJuegos.AutoSize = true;
            lblTituloJuegos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloJuegos.ForeColor = Color.White;
            lblTituloJuegos.Location = new Point(700, 141);
            lblTituloJuegos.Name = "lblTituloJuegos";
            lblTituloJuegos.Size = new Size(264, 41);
            lblTituloJuegos.TabIndex = 0;
            lblTituloJuegos.Text = "Listado de juegos";
            // 
            // tabEstads
            // 
            tabEstads.BackColor = Color.Gray;
            tabEstads.Controls.Add(label4);
            tabEstads.Controls.Add(btnActualizarEstadJuego);
            tabEstads.Controls.Add(spnCantEstad);
            tabEstads.Controls.Add(cmbTipoEstad);
            tabEstads.Controls.Add(lblCantidad);
            tabEstads.Controls.Add(lblTipoEstad);
            tabEstads.Controls.Add(dgvJugadorPEstad);
            tabEstads.Controls.Add(label3);
            tabEstads.Controls.Add(dgvJuegoPEstad);
            tabEstads.Controls.Add(lblTituloEstads);
            tabEstads.Location = new Point(5, 4);
            tabEstads.Name = "tabEstads";
            tabEstads.Padding = new Padding(3);
            tabEstads.Size = new Size(1915, 967);
            tabEstads.TabIndex = 5;
            tabEstads.Text = "Estadísticas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(591, 202);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 10;
            label4.Text = "Juego :";
            // 
            // btnActualizarEstadJuego
            // 
            btnActualizarEstadJuego.BackColor = Color.FromArgb(64, 64, 64);
            btnActualizarEstadJuego.Enabled = false;
            btnActualizarEstadJuego.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActualizarEstadJuego.ForeColor = Color.White;
            btnActualizarEstadJuego.Location = new Point(950, 770);
            btnActualizarEstadJuego.Name = "btnActualizarEstadJuego";
            btnActualizarEstadJuego.Size = new Size(179, 40);
            btnActualizarEstadJuego.TabIndex = 9;
            btnActualizarEstadJuego.Text = "Actualizar";
            btnActualizarEstadJuego.UseVisualStyleBackColor = false;
            btnActualizarEstadJuego.Click += btnActualizarEstadJuego_Click;
            // 
            // spnCantEstad
            // 
            spnCantEstad.BackColor = Color.FromArgb(64, 64, 64);
            spnCantEstad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            spnCantEstad.ForeColor = Color.White;
            spnCantEstad.Location = new Point(1229, 674);
            spnCantEstad.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            spnCantEstad.Name = "spnCantEstad";
            spnCantEstad.Size = new Size(144, 27);
            spnCantEstad.TabIndex = 8;
            spnCantEstad.ValueChanged += spnCantEstad_ValueChanged;
            // 
            // cmbTipoEstad
            // 
            cmbTipoEstad.BackColor = Color.FromArgb(64, 64, 64);
            cmbTipoEstad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEstad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbTipoEstad.ForeColor = Color.White;
            cmbTipoEstad.FormattingEnabled = true;
            cmbTipoEstad.Location = new Point(904, 673);
            cmbTipoEstad.Name = "cmbTipoEstad";
            cmbTipoEstad.Size = new Size(144, 28);
            cmbTipoEstad.TabIndex = 7;
            cmbTipoEstad.SelectedIndexChanged += cmbTipoEstad_SelectedIndexChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(1110, 673);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(107, 28);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad :";
            // 
            // lblTipoEstad
            // 
            lblTipoEstad.AutoSize = true;
            lblTipoEstad.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTipoEstad.ForeColor = Color.White;
            lblTipoEstad.Location = new Point(703, 673);
            lblTipoEstad.Name = "lblTipoEstad";
            lblTipoEstad.Size = new Size(201, 28);
            lblTipoEstad.TabIndex = 5;
            lblTipoEstad.Text = "Tipo de estadística :";
            // 
            // dgvJugadorPEstad
            // 
            dgvJugadorPEstad.AllowUserToAddRows = false;
            dgvJugadorPEstad.AllowUserToDeleteRows = false;
            dgvJugadorPEstad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJugadorPEstad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadorPEstad.Location = new Point(700, 458);
            dgvJugadorPEstad.MultiSelect = false;
            dgvJugadorPEstad.Name = "dgvJugadorPEstad";
            dgvJugadorPEstad.ReadOnly = true;
            dgvJugadorPEstad.RowHeadersWidth = 51;
            dgvJugadorPEstad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJugadorPEstad.Size = new Size(679, 194);
            dgvJugadorPEstad.TabIndex = 4;
            dgvJugadorPEstad.SelectionChanged += dgvJugadorPEstad_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(571, 458);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 3;
            label3.Text = "Jugador :";
            // 
            // dgvJuegoPEstad
            // 
            dgvJuegoPEstad.AllowUserToAddRows = false;
            dgvJuegoPEstad.AllowUserToDeleteRows = false;
            dgvJuegoPEstad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJuegoPEstad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJuegoPEstad.Location = new Point(700, 202);
            dgvJuegoPEstad.MultiSelect = false;
            dgvJuegoPEstad.Name = "dgvJuegoPEstad";
            dgvJuegoPEstad.ReadOnly = true;
            dgvJuegoPEstad.RowHeadersWidth = 51;
            dgvJuegoPEstad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJuegoPEstad.Size = new Size(679, 194);
            dgvJuegoPEstad.TabIndex = 2;
            dgvJuegoPEstad.SelectionChanged += dgvJuegoPEstad_SelectionChanged;
            // 
            // lblTituloEstads
            // 
            lblTituloEstads.AutoSize = true;
            lblTituloEstads.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloEstads.ForeColor = Color.White;
            lblTituloEstads.Location = new Point(700, 141);
            lblTituloEstads.Name = "lblTituloEstads";
            lblTituloEstads.Size = new Size(454, 41);
            lblTituloEstads.TabIndex = 0;
            lblTituloEstads.Text = "Gestionar estadísticas de juego";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 50);
            label2.Name = "label2";
            label2.Size = new Size(166, 82);
            label2.TabIndex = 1;
            label2.Text = "Gestor\r\n de Torneo";
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.BackColor = Color.FromArgb(64, 64, 64);
            btnEstadisticas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstadisticas.ForeColor = Color.White;
            btnEstadisticas.Location = new Point(0, 541);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(260, 70);
            btnEstadisticas.TabIndex = 4;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.UseVisualStyleBackColor = false;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // btnJuegos
            // 
            btnJuegos.BackColor = Color.FromArgb(64, 64, 64);
            btnJuegos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJuegos.ForeColor = Color.White;
            btnJuegos.Location = new Point(0, 471);
            btnJuegos.Name = "btnJuegos";
            btnJuegos.Size = new Size(260, 70);
            btnJuegos.TabIndex = 3;
            btnJuegos.Text = "Juegos";
            btnJuegos.UseVisualStyleBackColor = false;
            btnJuegos.Click += btnJuegos_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.BackColor = Color.FromArgb(64, 64, 64);
            btnEquipos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquipos.ForeColor = Color.White;
            btnEquipos.Location = new Point(0, 401);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(260, 70);
            btnEquipos.TabIndex = 2;
            btnEquipos.Text = "Equipos";
            btnEquipos.UseVisualStyleBackColor = false;
            btnEquipos.Click += btnEquipos_Click;
            // 
            // btnJugadores
            // 
            btnJugadores.BackColor = Color.FromArgb(64, 64, 64);
            btnJugadores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJugadores.ForeColor = Color.White;
            btnJugadores.Location = new Point(0, 331);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(260, 70);
            btnJugadores.TabIndex = 1;
            btnJugadores.Text = "Jugadores";
            btnJugadores.UseVisualStyleBackColor = false;
            btnJugadores.Click += btnJugadores_Click;
            // 
            // MenuLateral
            // 
            MenuLateral.BackColor = Color.FromArgb(64, 64, 64);
            MenuLateral.Controls.Add(label2);
            MenuLateral.Controls.Add(btnEstadisticas);
            MenuLateral.Controls.Add(btnMenuPrincipal);
            MenuLateral.Controls.Add(btnJuegos);
            MenuLateral.Controls.Add(btnEquipos);
            MenuLateral.Controls.Add(btnCiudades);
            MenuLateral.Controls.Add(btnJugadores);
            MenuLateral.Dock = DockStyle.Left;
            MenuLateral.Location = new Point(0, 0);
            MenuLateral.Name = "MenuLateral";
            MenuLateral.Size = new Size(260, 975);
            MenuLateral.TabIndex = 0;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.BackColor = Color.FromArgb(64, 64, 64);
            btnMenuPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuPrincipal.ForeColor = Color.White;
            btnMenuPrincipal.Location = new Point(0, 191);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(260, 70);
            btnMenuPrincipal.TabIndex = 0;
            btnMenuPrincipal.Text = "Menu Principal";
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // btnCiudades
            // 
            btnCiudades.BackColor = Color.FromArgb(64, 64, 64);
            btnCiudades.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCiudades.ForeColor = Color.White;
            btnCiudades.Location = new Point(0, 261);
            btnCiudades.Name = "btnCiudades";
            btnCiudades.Size = new Size(260, 70);
            btnCiudades.TabIndex = 0;
            btnCiudades.Text = "Ciudades";
            btnCiudades.UseVisualStyleBackColor = false;
            btnCiudades.Click += btnCiudades_Click;
            // 
            // ciudadBindingSource
            // 
            ciudadBindingSource.DataSource = typeof(Modelos.Ciudad);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 975);
            Controls.Add(MenuLateral);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Gestor de torneo";
            tabControl1.ResumeLayout(false);
            tabMenuPrincipal.ResumeLayout(false);
            tabMenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
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
            tabEstads.ResumeLayout(false);
            tabEstads.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spnCantEstad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvJugadorPEstad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvJuegoPEstad).EndInit();
            MenuLateral.ResumeLayout(false);
            MenuLateral.PerformLayout();
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
      
        private Panel MenuLateral;
        private Button btnEstadisticas;
        private Button btnJuegos;
        private Button btnEquipos;
        private Button btnJugadores;
        private Button btnMenuPrincipal;
        private Button btnCiudades;
        private Label label2;

        private DataGridView dgvResumen;
        private Button btnConsultarResumen;
        private Label lblIdResumen;
        private Label lblTituloResumenJuego;
        private ComboBox cmbIdJuegoResumen;
        private Label lblTituloEstads;
        private Label label3;
        private DataGridView dgvJuegoPEstad;
        private DataGridView dgvJugadorPEstad;
        private ComboBox cmbTipoEstad;
        private Label lblCantidad;
        private Label lblTipoEstad;
        private NumericUpDown spnCantEstad;
        private Button btnActualizarEstadJuego;
        private Label label4;
    }
}
