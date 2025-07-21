using AsignacionFinal.BDD;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AsignacionFinal.Visual
{
    public partial class Form1 : Form
    {
        private int prevValCantEstad;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeAllData();

            foreach (var btn in new[] {
                btnMenuPrincipal, btnCiudades, btnJugadores, btnEquipos, btnJuegos, btnEstadisticas,
                btnInsertarEquipo, btnEliminarEquipo, btnActualizarListEquipos,
                btnInsertarJugador, btnEliminarJugador, btnActualizarListaJugadores,
                btnInsertarJuego, btnEliminarJuego,
                btnActualizarTabla, btnEliminar, btnEditar,btnInsertar,btnEditarJugador,btnEditarEquipo, btnEditarJuego,
                btnActualizarListadoJuegos, btnConsultarResumen, btnActualizarEstadJuego, btnMenuPrincipal
            })
            {
                if (btn is System.Windows.Forms.Button b)
                {
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                }
            }
            initResumen();
            initCmbTipoEstad();
        }

        private void InitializeAllData()
        {
            loadDataCiudad();
            loadDataEquipo();
            loadDataJugador();
            loadDataJuego();

        }

        private void loadDataCiudad()
        {
            dgvCiudades.DataSource = CiudadRepository.GetAll();
        }
        private void loadDataEquipo()
        {
            dgvEquipos.DataSource = EquipoRepository.GetAll();
        }
        private void loadDataJuego()
        {
            dgvJuegos.DataSource = JuegoRepository.GetAll();
            dgvJuegoPEstad.DataSource = JuegoRepository.GetAll();
            updateCmbResumen();
        }

        private void loadDataJugador()
        {
            var dt = JugadorRepository.GetAll();

            dgvJugadores.DataSource = null;
            dgvJugadores.Columns.Clear();

            dgvJugadores.AutoGenerateColumns = false;
            dgvJugadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJugadores.MultiSelect = false;

            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdJugador",
                HeaderText = "ID",
                Name = "IdJugador",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreJugador",
                HeaderText = "Nombre",
                Name = "NombreJugador",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvJugadores.DataSource = dt;

            // Selecciona la primera fila (ambas columnas quedarán resaltadas si hay datos)
            if (dgvJugadores.Rows.Count > 0)
            {
                dgvJugadores.ClearSelection();
                dgvJugadores.Rows[0].Selected = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Esto es para instertar una nueva ciudad
        private void button1_Click_1(object sender, EventArgs e)
        {
            while (true)
            {
                using var frm = new FormInsertCiudad();
                var result = frm.ShowDialog();

                if (result != DialogResult.OK || frm.ciudad == null)
                    break; // El usuario canceló o cerró la ventana

                bool exito = CiudadRepository.Insert(frm.ciudad);
                loadDataCiudad();
                if (exito)
                {
                    MessageBox.Show("Ciudad insertada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo insertar la ciudad. Verifique los datos.");
                }

            }
        }
        private void btnInsertarEquipo_Click(object sender, EventArgs e)
        {
            while (true)
            {
                using var frm = new FormInsertEquipo();
                var result = frm.ShowDialog();

                if (result != DialogResult.OK || frm.equipo == null)
                    break; // El usuario canceló o cerró la ventana

                bool exito = EquipoRepository.Insert(frm.equipo);
                loadDataEquipo();
                if (exito)
                {
                    MessageBox.Show("Equipo insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el equipo. Verifique los datos.");
                }

            }
        }
        private void btnInsertarJuego_Click(object sender, EventArgs e)
        {
            while (true)
            {
                using var frm = new FormInsertJuego(DateTime.Now);
                var result = frm.ShowDialog();

                if (result != DialogResult.OK || frm.juego == null)
                    break; // El usuario canceló o cerró la ventana

                bool exito = JuegoRepository.Insert(frm.juego);
                loadDataJuego();
                if (exito)
                {
                    MessageBox.Show("Juego insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el juego. Verifique los datos.");
                }

            }
        }


        //Esto es para editar una ciudad
        private void button1_Click_2(object sender, EventArgs e)
        {
            var row = dgvCiudades.CurrentRow;
            string id = Convert.ToString(row.Cells["ID"].Value).Trim();
            string nombre = row.Cells["Nombre"].Value.ToString().Trim();

            // Abrir el formulario de edición y pre‑llenar
            using var frm = new FormInsertCiudad("Editar Ciudad", id, nombre);

            if (frm.ShowDialog() == DialogResult.OK && frm.ciudad != null)
            {
                // Asignar Id y llamar al repositorio
                var actualizado = frm.ciudad;

                bool exito = CiudadRepository.Update(actualizado, id);
                if (exito)
                {
                    loadDataCiudad();
                    MessageBox.Show("Ciudad actualizada correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la ciudad.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            var row = dgvEquipos.CurrentRow;
            string id = Convert.ToString(row.Cells["ID"].Value).Trim();
            string nombre = row.Cells["Nombre"].Value.ToString().Trim();
            string idCiudad = EquipoRepository.GetIdCiudad(id);

            // Abrir el formulario de edición y pre‑llenar
            using var frm = new FormInsertEquipo("Editar Equipo", id, nombre, idCiudad);

            if (frm.ShowDialog() == DialogResult.OK && frm.equipo != null)
            {
                // Asignar Id y llamar al repositorio
                var actualizado = frm.equipo;

                bool exito = EquipoRepository.Update(actualizado, id);
                if (exito)
                {
                    loadDataEquipo();
                    MessageBox.Show("Equipo actualizado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el equipo.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEditarJuego_Click(object sender, EventArgs e)
        {
            var row = dgvJuegos.CurrentRow;
            string id = Convert.ToString(row.Cells["ID"].Value).Trim();
            string descripcion = row.Cells["Descripcion"].Value.ToString().Trim();
            string idEqA = JuegoRepository.GetIdEqA(id);
            string idEqB = JuegoRepository.GetIdEqB(id);
            DateTime fechaYHora = DateTime.ParseExact(
                transformarHora(Convert.ToString(row.Cells["Fecha_Y_Hora"].Value).Trim()),
                "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture
            );

            // Abrir el formulario de edición y pre‑llenar
            using var frm = new FormInsertJuego(fechaYHora, "Editar Juego", id, descripcion, idEqA, idEqB);

            if (frm.ShowDialog() == DialogResult.OK && frm.juego != null)
            {
                // Asignar Id y llamar al repositorio
                var actualizado = frm.juego;

                bool exito = JuegoRepository.Update(actualizado, id);
                if (exito)
                {
                    loadDataJuego();
                    MessageBox.Show("Juego actualizado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el juego.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Eventos de selección de filas (actualizar el enable de botones para borrar y editar)
        private void dgvCiudades_SelectionChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = dgvCiudades.SelectedRows.Count == 1;
            btnEliminar.Enabled = dgvCiudades.SelectedRows.Count == 1;
        }
        private void dgvEquipos_SelectionChanged(object sender, EventArgs e)
        {
            btnEditarEquipo.Enabled = dgvEquipos.SelectedRows.Count == 1;
            btnEliminarEquipo.Enabled = dgvEquipos.SelectedRows.Count == 1;
        }
        private void dgvJuegos_SelectionChanged(object sender, EventArgs e)
        {
            btnEditarJuego.Enabled = dgvJuegos.SelectedRows.Count == 1;
            btnEliminarJuego.Enabled = dgvJuegos.SelectedRows.Count == 1;
        }

        // Agrega este método para manejar la selección de filas y activar los botones
        private void dgvJugadores_SelectionChanged(object sender, EventArgs e)
        {
            btnEditarJugador.Enabled = dgvJugadores.SelectedRows.Count == 1;
            btnEliminarJugador.Enabled = dgvJugadores.SelectedRows.Count == 1;
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            loadDataCiudad();
        }
        private void btnActualizarListEquipos_Click(object sender, EventArgs e)
        {
            loadDataEquipo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvCiudades.CurrentRow;
            string id = Convert.ToString(row.Cells["ID"].Value).Trim();

            var confirm = MessageBox.Show(
                "¿Seguro que deseas eliminar a la ciudad seleccionada?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                bool exito = CiudadRepository.Delete(id);
                if (exito)
                {
                    loadDataCiudad();
                    MessageBox.Show("Ciudad eliminada correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar a la ciudad. Revise sus relaciones.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un jugador para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = Convert.ToString(dgvJugadores.CurrentRow.Cells["IdJugador"].Value)?.Trim() ?? "";

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("No se pudo obtener el ID del jugador seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                "¿Seguro que deseas eliminar al jugador seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                bool exito = JugadorRepository.Delete(id);
                if (exito)
                {
                    loadDataJugador();
                    MessageBox.Show("Jugador eliminado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar al jugador. Revise sus relaciones.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInsertarJugador_Click(object sender, EventArgs e)
        {
            while (true)
            {
                using var frm = new FormInsertarJugador();
                var result = frm.ShowDialog();
                if (result != DialogResult.OK || frm.jugador == null)
                    break; // El usuario canceló o cerró la ventana
                bool exito = JugadorRepository.Insert(frm.jugador);
                btnActualizarListaJugadores.PerformClick();
                if (exito)
                {
                    MessageBox.Show("Jugador insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el jugador. Verifique los datos.");
                }
            }
        }

        private void btnEditarJugador_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un jugador para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtén los datos del jugador seleccionado
            string id = dgvJugadores.CurrentRow.Cells["IdJugador"].Value?.ToString() ?? "";
            // Si necesitas más datos, obténlos de la base de datos o DataTable
            var dt = JugadorRepository.GetAll();
            var row = dt.Rows.Cast<DataRow>().FirstOrDefault(r => r["IdJugador"].ToString() == id);
            if (row == null)
            {
                MessageBox.Show("No se pudo encontrar el jugador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var jugadorEditar = new Jugador
            {
                IdJugador = row["IdJugador"].ToString(),
                IdEquipo = row["IdEquipo"].ToString(),
                IdCiudadNacimiento = row["IdCiudadNacimiento"].ToString(),
                FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"]),
                NumeroJugador = row["NumeroJugador"].ToString(),
                NombreJugador = row["NombreJugador"].ToString()
            };

            using var frm = new FormInsertarJugador(jugadorEditar);
            if (frm.ShowDialog() == DialogResult.OK && frm.jugador != null)
            {
                bool exito = JugadorRepository.Update(frm.jugador, id);
                if (exito)
                {
                    loadDataJugador();
                    MessageBox.Show("Jugador actualizado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el jugador.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizarListaJugadores_Click(object sender, EventArgs e)
        {
            dgvJugadores.DataSource = JugadorRepository.GetAll();
        }
        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            var row = dgvEquipos.CurrentRow;
            string id = Convert.ToString(row.Cells["ID"].Value).Trim();

            var confirm = MessageBox.Show(
                "¿Seguro que deseas eliminar al equipo seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                bool exito = EquipoRepository.Delete(id);
                if (exito)
                {
                    loadDataEquipo();
                    MessageBox.Show("Equipo eliminado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar al equipo. Revise sus relaciones.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarJuego_Click(object sender, EventArgs e)
        {
            var row = dgvJuegos.CurrentRow;
            string id = Convert.ToString(row.Cells["ID"].Value).Trim();

            var confirm = MessageBox.Show(
                "¿Seguro que deseas eliminar al juego seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                bool exito = JuegoRepository.Delete(id);
                if (exito)
                {
                    loadDataJuego();
                    MessageBox.Show("Juego eliminado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar al juego. Revise sus relaciones.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        //Funciones de utilidades varias
        public static string transformarHora(string input)
        {
            string[] formatosEntrada = {
                "d/M/yyyy h:mm:ss tt",
                "dd/MM/yyyy h:mm:ss tt",
            };

            var culturaEs = CultureInfo.GetCultureInfo("es-ES");

            DateTime dt = DateTime.ParseExact(
                input.Trim(),
                formatosEntrada,
                culturaEs,
                DateTimeStyles.None
            );

            return dt.ToString("dd/MM/yyyy HH:mm");
        }


        private void tabMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnCiudades_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btnJuegos_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void btnConsultarResumen_Click(object sender, EventArgs e)
        {
            dgvResumen.DataSource = JuegoRepository.GetResumenJuego(cmbIdJuegoResumen.SelectedValue.ToString().Trim());
            if (dgvResumen.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados para el ID de juego proporcionado.", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvResumen.Visible = false;
            }
            else
            {
                dgvResumen.ClearSelection();
                dgvResumen.Visible = true;
            }
        }

        private void initResumen()
        {
            dgvResumen.ReadOnly = true; // Evita edición
            dgvResumen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResumen.ClearSelection();
            dgvResumen.CurrentCell = null;
            dgvResumen.MultiSelect = false;

            dgvResumen.DataSource = AsignacionFinal.BDD.JuegoRepository.GetResumenJuego("");

            // Evita selección al hacer clic o usar teclas
            dgvResumen.SelectionChanged += (s, e) => dgvResumen.ClearSelection();
            dgvResumen.KeyDown += (s, e) => e.Handled = true;

            var colFija = dgvResumen.Columns[" "]; //" " es el nombre de la primera columna
            colFija.Width = 300;
            colFija.Resizable = DataGridViewTriState.False;
            colFija.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Las demás se ajustan
            foreach (DataGridViewColumn col in dgvResumen.Columns)
            {
                if (col.Name != "ID")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            updateCmbResumen();
        }

        private void cmbIdJuegoResumen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdJuegoResumen.SelectedIndex < 0) btnConsultarResumen.Enabled = false;
            else btnConsultarResumen.Enabled = true;
        }

        private void updateCmbResumen()
        {
            cmbIdJuegoResumen.DataSource = JuegoRepository.GetAll();
            cmbIdJuegoResumen.DisplayMember = "ID";     // Lo que se ve en la lista
            cmbIdJuegoResumen.ValueMember = "ID";
            cmbIdJuegoResumen.SelectedIndex = -1;
            dgvResumen.Visible = false;
        }

        private void initCmbTipoEstad()
        {
            cmbTipoEstad.DataSource = EstadsRepository.GetAll();
            cmbTipoEstad.DisplayMember = "Descripcion";     // Lo que se ve en la lista
            cmbTipoEstad.ValueMember = "IdEstadistica";
            cmbIdJuegoResumen.SelectedIndex = -1;
        }

        private void dgvJuegoPEstad_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJuegoPEstad.SelectedRows.Count <= 0)
            {
                dgvJugadorPEstad.DataSource = null;
                dgvJugadorPEstad.Enabled = false;
                dgvJugadorPEstad.ClearSelection();
            }
            else
            {
                dgvJugadorPEstad.Enabled = true;
                dgvJugadorPEstad.DataSource = JuegoRepository.GetJugadoresJuego(
                    dgvJuegoPEstad.SelectedRows[0].Cells["ID"].Value.ToString().Trim()
                );
            }
        }

        private void dgvJugadorPEstad_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJugadorPEstad.SelectedRows.Count == 0)
            {
                cmbTipoEstad.SelectedIndex = -1;
                cmbTipoEstad.Enabled = false;
            }
            else cmbTipoEstad.Enabled = true;
        }

        private void cmbTipoEstad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoEstad.SelectedIndex >= 0 && dgvJuegoPEstad.Rows.Count > 0 && dgvJugadorPEstad.Rows.Count > 0)
            {
                prevValCantEstad = EstadsRepository.getCantEstadJuego(
                    dgvJuegoPEstad.SelectedRows[0].Cells["ID"].Value.ToString().Trim(),
                    cmbTipoEstad.SelectedValue.ToString().Trim(),
                    dgvJugadorPEstad.SelectedRows[0].Cells["IdJugador"].Value.ToString().Trim()
                );
                spnCantEstad.Value = prevValCantEstad;
                spnCantEstad.Enabled = true;
            }
            else spnCantEstad.Enabled = false;
        }

        private void spnCantEstad_ValueChanged(object sender, EventArgs e)
        {
            if (spnCantEstad.Enabled == true && spnCantEstad.Value != prevValCantEstad)
                btnActualizarEstadJuego.Enabled = true;
            else btnActualizarEstadJuego.Enabled = false;
        }

        private void btnActualizarEstadJuego_Click(object sender, EventArgs e)
        {
            bool exito = true;

            if (prevValCantEstad == 0)
            {
                exito = EstadsRepository.Insert(
                        dgvJuegoPEstad.SelectedRows[0].Cells["ID"].Value.ToString().Trim(),
                        cmbTipoEstad.SelectedValue.ToString().Trim(),
                        dgvJugadorPEstad.SelectedRows[0].Cells["IdJugador"].Value.ToString().Trim(),
                        Convert.ToInt32(spnCantEstad.Value)
                     );

            }
            else if (Convert.ToInt32(spnCantEstad.Value) == 0)
            {
                exito = EstadsRepository.Delete(
                        dgvJuegoPEstad.SelectedRows[0].Cells["ID"].Value.ToString().Trim(),
                        cmbTipoEstad.SelectedValue.ToString().Trim(),
                        dgvJugadorPEstad.SelectedRows[0].Cells["IdJugador"].Value.ToString().Trim()
                     );
            }
            else
            {
                exito = EstadsRepository.Update(
                        dgvJuegoPEstad.SelectedRows[0].Cells["ID"].Value.ToString().Trim(),
                        cmbTipoEstad.SelectedValue.ToString().Trim(),
                        dgvJugadorPEstad.SelectedRows[0].Cells["IdJugador"].Value.ToString().Trim(),
                        Convert.ToInt32(spnCantEstad.Value)
                     );
            }


            if (exito)
            {
                updateCmbResumen();
                MessageBox.Show("Estadística de juego actualizada correctamente", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                prevValCantEstad = Convert.ToInt32(spnCantEstad.Value);
                btnActualizarEstadJuego.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la estadística de juego.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
