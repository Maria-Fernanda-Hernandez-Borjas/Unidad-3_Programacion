namespace Práctica_2._7
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SolidWorks GDT", 9F);
            label1.Location = new Point(213, 8);
            label1.Name = "label1";
            label1.Size = new Size(199, 18);
            label1.TabIndex = 0;
            label1.Text = "Identificador de triángulos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SolidWorks GDT", 9F);
            label2.Location = new Point(30, 148);
            label2.Name = "label2";
            label2.Size = new Size(57, 18);
            label2.TabIndex = 1;
            label2.Text = "Lado A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SolidWorks GDT", 9F);
            label3.Location = new Point(32, 189);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 2;
            label3.Text = "Lado B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SolidWorks GDT", 9F);
            label4.Location = new Point(30, 229);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 3;
            label4.Text = "Lado C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SolidWorks GDT", 9F);
            label5.Location = new Point(66, 309);
            label5.Name = "label5";
            label5.Size = new Size(132, 18);
            label5.TabIndex = 4;
            label5.Text = "Tipo de triángulo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 25);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 25);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 25);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(213, 306);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 25);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(121, 267);
            button1.Name = "button1";
            button1.Size = new Size(106, 26);
            button1.TabIndex = 9;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(265, 267);
            button2.Name = "button2";
            button2.Size = new Size(106, 26);
            button2.TabIndex = 10;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.Location = new Point(414, 267);
            button3.Name = "button3";
            button3.Size = new Size(106, 26);
            button3.TabIndex = 11;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(265, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 150);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(640, 405);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("SolidWorks GDT", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tipos de triángulo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}
