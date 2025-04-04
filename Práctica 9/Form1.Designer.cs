namespace Práctica_2._3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SolidWorks GDT", 12F);
            label1.Location = new Point(111, 9);
            label1.Name = "label1";
            label1.Size = new Size(474, 24);
            label1.TabIndex = 0;
            label1.Text = "Este programa suma los números capturados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SolidWorks GDT", 12F);
            label2.Location = new Point(28, 107);
            label2.Name = "label2";
            label2.Size = new Size(222, 24);
            label2.TabIndex = 1;
            label2.Text = "Introduce un número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SolidWorks GDT", 12F);
            label3.Location = new Point(64, 286);
            label3.Name = "label3";
            label3.Size = new Size(186, 24);
            label3.TabIndex = 2;
            label3.Text = "La suma total es:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(287, 283);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("SolidWorks GDT", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(530, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 244);
            listBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("SolidWorks GDT", 9F);
            button1.Location = new Point(287, 203);
            button1.Name = "button1";
            button1.Size = new Size(125, 39);
            button1.TabIndex = 6;
            button1.Text = "Sumar todos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Font = new Font("SolidWorks GDT", 9F);
            button2.Location = new Point(303, 137);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Añadir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("SolidWorks GDT", 9F);
            button3.Location = new Point(156, 373);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 8;
            button3.Text = "Borrar todo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.Font = new Font("SolidWorks GDT", 9F);
            button4.Location = new Point(420, 373);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Suma de números";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
