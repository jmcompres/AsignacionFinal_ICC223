namespace AsignacionFinal.Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola desde Windows Forms!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Probando");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
