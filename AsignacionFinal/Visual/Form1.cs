using AsignacionFinal.BDD;
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
        }

        private void loadDataCiudad()
        {
            dgvCiudades.DataSource = CiudadRepository.GetAll();
        }
        private void loadDataEquipo()
        {
            dgvEquipos.DataSource = EquipoRepository.GetAll();
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
            using var frm = new FormInsertEquipo("Editar Equipo",id,nombre,idCiudad);

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

    }
}
