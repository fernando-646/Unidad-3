namespace Practica_2__F__W__D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            this.textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 22);
            label2.Name = "label2";
            label2.Size = new Size(265, 38);
            label2.TabIndex = 0;
            label2.Text = "Tabla de multiplicar ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(217, 56);
            label3.TabIndex = 1;
            label3.Text = "Introduce el valor de la \r\ntabla de multiplicar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(199, 155);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 184);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 78);
            label1.Name = "label1";
            label1.Size = new Size(211, 56);
            label1.TabIndex = 4;
            label1.Text = "Limite maximo para la \r\ntabla de multiplicacion";
            // 
            // button1
            // 
            button1.Location = new Point(463, 298);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            this.textBox2.Location = new Point(450, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(125, 27);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            ClientSize = new Size(625, 392);
            Controls.Add(this.textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, count = 0, limite;
            n = int.Parse(textBox1.Text);
            limite = int.Parse(textBox2.Text);
            do
            {
                listBox1.Items.Add(n + " * " + count + "=" + n * count);
                    count++;

            }
            while (count <= limite);
        }
    }
}
