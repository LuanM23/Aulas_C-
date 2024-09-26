namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            string valor2 = textBox2.Text;

            bool soma = checkBox1.Checked;
            bool sub = checkBox2.Checked;
            bool mult = checkBox3.Checked;
            bool div = checkBox4.Checked;

            if (soma)
            {
                double resultado = Convert.ToDouble(valor1) + Convert.ToDouble(valor2);
                label3.Text = resultado.ToString();
            }

            else if (sub)
            {
                double resultado = Convert.ToDouble(valor1) - Convert.ToDouble(valor2);
                label3.Text = resultado.ToString();
            }

            else if (mult)
            {
                double resultado = Convert.ToDouble(valor1) * Convert.ToDouble(valor2);
                label3.Text = resultado.ToString();
            }

            else if (div)
            {
                double resultado = Convert.ToDouble(valor1) / Convert.ToDouble(valor2);
                label3.Text = resultado.ToString();
            }


        }

        private void Soma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
