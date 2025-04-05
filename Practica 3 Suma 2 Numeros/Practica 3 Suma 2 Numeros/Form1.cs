namespace Practica_3_Suma_2_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            int sum = num1 + num2;
            label3.Text = "Sum = " + sum;
        }
    }
}
