namespace Practica_2_Invierte_Datos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            Invertir = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 83);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 0;
            label1.Text = "Escribe un número";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 142);
            label2.Name = "label2";
            label2.Size = new Size(202, 25);
            label2.TabIndex = 2;
            label2.Text = "Escribe un número";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(282, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 27);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 263);
            label3.Name = "label3";
            label3.Size = new Size(202, 25);
            label3.TabIndex = 6;
            label3.Text = "Escribe un número";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(282, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 27);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 204);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 4;
            label4.Text = "Escribe un número";
            // 
            // Invertir
            // 
            Invertir.BackColor = Color.DarkGray;
            Invertir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Invertir.Location = new Point(597, 122);
            Invertir.Name = "Invertir";
            Invertir.Size = new Size(119, 45);
            Invertir.TabIndex = 8;
            Invertir.Text = "Invertir";
            Invertir.UseVisualStyleBackColor = false;
            Invertir.Click += Invertir_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(597, 200);
            button2.Name = "button2";
            button2.Size = new Size(119, 50);
            button2.TabIndex = 9;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F);
            label5.Location = new Point(77, 332);
            label5.Name = "label5";
            label5.Size = new Size(48, 38);
            label5.TabIndex = 10;
            label5.Text = "n1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F);
            label6.Location = new Point(177, 332);
            label6.Name = "label6";
            label6.Size = new Size(48, 38);
            label6.TabIndex = 11;
            label6.Text = "n2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F);
            label7.Location = new Point(282, 332);
            label7.Name = "label7";
            label7.Size = new Size(48, 38);
            label7.TabIndex = 13;
            label7.Text = "n3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F);
            label8.Location = new Point(369, 332);
            label8.Name = "label8";
            label8.Size = new Size(48, 38);
            label8.TabIndex = 12;
            label8.Text = "n4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(Invertir);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Invierte Números";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button Invertir;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
