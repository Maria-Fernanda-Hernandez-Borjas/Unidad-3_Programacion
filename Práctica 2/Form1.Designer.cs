﻿namespace Práctica_2
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
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(269, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(269, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(269, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 15);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 4;
            label1.Text = "Escribe un número";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 73);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 5;
            label2.Text = "Escribe un número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 128);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 6;
            label3.Text = "Escribe un número";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 188);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 7;
            label4.Text = "Escribe un número";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 283);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 8;
            label5.Text = "N1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 283);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 9;
            label6.Text = "N2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 283);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 10;
            label7.Text = "N3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(402, 283);
            label8.Name = "label8";
            label8.Size = new Size(28, 20);
            label8.TabIndex = 11;
            label8.Text = "N4";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Location = new Point(541, 188);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Location = new Point(541, 241);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(727, 437);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Invierte números";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
    }
}
