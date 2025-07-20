using AsignacionFinal.BDD;
using System.Globalization;
using System.Windows.Forms;

namespace AsignacionFinal.Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeAllData();
        }

        private void InitializeAllData()
        {
            loadDataCiudad();
            loadDataEquipo();
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
            using var frm = new FormInsertJuego(fechaYHora,"Editar Juego", id, descripcion, idEqA,idEqB);

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

    }
}
