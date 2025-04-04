namespace Práctica_5
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(234, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SolidWorks GDT", 9F);
            label1.Location = new Point(234, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 18);
            label1.TabIndex = 3;
            label1.Text = "Área triángulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SolidWorks GDT", 9F);
            label2.Location = new Point(123, 57);
            label2.Name = "label2";
            label2.Size = new Size(44, 18);
            label2.TabIndex = 4;
            label2.Text = "Base";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SolidWorks GDT", 9F);
            label3.Location = new Point(123, 108);
            label3.Name = "label3";
            label3.Size = new Size(51, 18);
            label3.TabIndex = 5;
            label3.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SolidWorks GDT", 9F);
            label4.Location = new Point(123, 235);
            label4.Name = "label4";
            label4.Size = new Size(41, 18);
            label4.TabIndex = 6;
            label4.Text = "Área";
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("SolidWorks GDT", 9F);
            button1.Location = new Point(103, 304);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("SolidWorks GDT", 9F);
            button2.Location = new Point(249, 304);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.Font = new Font("SolidWorks GDT", 9F);
            button3.Location = new Point(391, 304);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(562, 413);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Área triángulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
