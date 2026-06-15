namespace Prueba2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cuando se unde el botón de crear cuenta
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Falta información para crear la cuenta");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                MessageBox.Show("Cuenta creada");
            }
        }
    }
}
