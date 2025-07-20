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
        }

        private void loadDataCiudad()
        {
            dgvCiudades.DataSource = CiudadRepository.GetAll();
            dgvCiudades.Columns["idCiudad"].HeaderText = "ID";
            dgvCiudades.Columns["nombre"].HeaderText = "Nombre";
            dgvCiudades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        //Esto es para editar una ciudad
        private void button1_Click_2(object sender, EventArgs e)
        {
            var row = dgvCiudades.CurrentRow;
            string id = Convert.ToString(row.Cells["IdCiudad"].Value).Trim();
            string nombre = row.Cells["Nombre"].Value.ToString().Trim();

            // Abrir el formulario de edición y pre‑llenar
            using var frm = new FormInsertCiudad("Editar Ciudad",id,nombre);

            if (frm.ShowDialog() == DialogResult.OK && frm.ciudad != null)
            {
                // Asignar Id y llamar al repositorio
                var actualizado = frm.ciudad;

                bool exito = CiudadRepository.Update(actualizado,id);
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

        private void dgvCiudades_SelectionChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = dgvCiudades.SelectedRows.Count == 1;
            btnEliminar.Enabled = dgvCiudades.SelectedRows.Count == 1;
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            loadDataCiudad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvCiudades.CurrentRow;
            string id = Convert.ToString(row.Cells["IdCiudad"].Value).Trim();

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
    }
}
