namespace Práctica_6
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("SolidWorks GDT", 9F);
            groupBox1.Location = new Point(41, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SolidWorks GDT", 9F);
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(102, 18);
            label1.TabIndex = 4;
            label1.Text = "Ingresa Valor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 25);
            textBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Font = new Font("SolidWorks GDT", 9F);
            groupBox2.Location = new Point(41, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 122);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opciones de conversión";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("SolidWorks GDT", 9F);
            button1.Location = new Point(23, 37);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Fahrenheit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Font = new Font("SolidWorks GDT", 9F);
            button2.Location = new Point(154, 37);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 6;
            button2.Text = "Centígrados";
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("SolidWorks GDT", 9F);
            button3.Location = new Point(93, 72);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Font = new Font("SolidWorks GDT", 9F);
            groupBox3.Location = new Point(41, 284);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(273, 101);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultado";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SolidWorks GDT", 9F);
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 5;
            label2.Text = "Resultado";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 25);
            textBox2.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.Font = new Font("SolidWorks GDT", 9F);
            button4.Location = new Point(134, 406);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Cerrar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(372, 456);
            Controls.Add(button4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Conversiones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private TextBox textBox2;
        private Button button4;
    }
}
