namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            textBox11 = new TextBox();
            label12 = new Label();
            textBox12 = new TextBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(124, 18);
            label1.TabIndex = 0;
            label1.Text = "Numero empleado";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(28, 97);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(28, 154);
            label3.Name = "label3";
            label3.Size = new Size(120, 18);
            label3.TabIndex = 2;
            label3.Text = "Nombre completo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(401, 220);
            label4.Name = "label4";
            label4.Size = new Size(135, 18);
            label4.TabIndex = 3;
            label4.Text = "Fecha de nacimiento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 67);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 122);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 176);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 23);
            textBox3.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(444, 251);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            monthCalendar1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(653, 512);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(115, 30);
            button1.TabIndex = 11;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(516, 512);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(115, 30);
            button2.TabIndex = 12;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            //button2.Click += this.button2_Click; error revisar
            // 
            // textBox4
            // 
            textBox4.Location = new Point(87, 231);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(253, 23);
            textBox4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(28, 209);
            label5.Name = "label5";
            label5.Size = new Size(100, 18);
            label5.TabIndex = 13;
            label5.Text = "Departamento";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(87, 286);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(253, 23);
            textBox5.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(28, 263);
            label6.Name = "label6";
            label6.Size = new Size(42, 18);
            label6.TabIndex = 15;
            label6.Text = "CURP";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(28, 319);
            label7.Name = "label7";
            label7.Size = new Size(32, 18);
            label7.TabIndex = 17;
            label7.Text = "NSS";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(87, 342);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(253, 23);
            textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(87, 401);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(253, 23);
            textBox7.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HighlightText;
            label8.Location = new Point(28, 377);
            label8.Name = "label8";
            label8.Size = new Size(109, 18);
            label8.TabIndex = 19;
            label8.Text = "Registro Federal";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(87, 457);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(253, 23);
            textBox8.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HighlightText;
            label9.Location = new Point(28, 435);
            label9.Name = "label9";
            label9.Size = new Size(68, 18);
            label9.TabIndex = 21;
            label9.Text = "Domicilio";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(87, 512);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(253, 23);
            textBox9.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.HighlightText;
            label10.Location = new Point(28, 491);
            label10.Name = "label10";
            label10.Size = new Size(47, 18);
            label10.TabIndex = 23;
            label10.Text = "Banco";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(444, 67);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(253, 23);
            textBox10.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(399, 41);
            label11.Name = "label11";
            label11.Size = new Size(122, 18);
            label11.TabIndex = 25;
            label11.Text = "Numero de cuenta";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(444, 121);
            textBox11.Margin = new Padding(3, 2, 3, 2);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(253, 23);
            textBox11.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.HighlightText;
            label12.Location = new Point(401, 99);
            label12.Name = "label12";
            label12.Size = new Size(43, 18);
            label12.TabIndex = 27;
            label12.Text = "Email";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(444, 176);
            textBox12.Margin = new Padding(3, 2, 3, 2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(253, 23);
            textBox12.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.HighlightText;
            label13.Location = new Point(401, 153);
            label13.Name = "label13";
            label13.Size = new Size(62, 18);
            label13.TabIndex = 29;
            label13.Text = "Telefono";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(784, 560);
            Controls.Add(textBox12);
            Controls.Add(label13);
            Controls.Add(textBox11);
            Controls.Add(label12);
            Controls.Add(textBox10);
            Controls.Add(label11);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Registro";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private MonthCalendar monthCalendar1;
        private Button button1;
        private Button button2;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox10;
        private Label label11;
        private TextBox textBox11;
        private Label label12;
        private TextBox textBox12;
        private Label label13;
    }
}