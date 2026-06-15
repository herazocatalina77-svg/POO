namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Método para cargar el form
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Cuando se unde el botón de crear cuenta
            if (label2.Text == "" || label3.Text == "" || label4.Text == "")
            {
                MessageBox.Show("Falta información para crear la cuenta");
            }
            else if (label4.Text != label3.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                MessageBox.Show("Cuenta creada");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Label que confirma la contraseña
        }
        private void label3_Click(object sender, EventArgs e)
        {
            //Label que crea la contraseña
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
