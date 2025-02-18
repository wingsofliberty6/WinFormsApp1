namespace WinFormsApp1
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
            registro_butt = new Button();
            ini_sesion_butt = new Button();
            correo_textbox = new TextBox();
            contra_textbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // registro_butt
            // 
            registro_butt.Font = new Font("Open Sans Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            registro_butt.ForeColor = SystemColors.GrayText;
            registro_butt.Location = new Point(37, 337);
            registro_butt.Margin = new Padding(4, 2, 4, 2);
            registro_butt.Name = "registro_butt";
            registro_butt.Size = new Size(115, 30);
            registro_butt.TabIndex = 0;
            registro_butt.Text = "Registro";
            registro_butt.UseVisualStyleBackColor = true;
            registro_butt.Click += button1_Click;
            // 
            // ini_sesion_butt
            // 
            ini_sesion_butt.Font = new Font("Open Sans Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ini_sesion_butt.ForeColor = SystemColors.GrayText;
            ini_sesion_butt.Location = new Point(205, 339);
            ini_sesion_butt.Margin = new Padding(4, 2, 4, 2);
            ini_sesion_butt.Name = "ini_sesion_butt";
            ini_sesion_butt.Size = new Size(115, 30);
            ini_sesion_butt.TabIndex = 1;
            ini_sesion_butt.Text = "Iniciar sesion";
            ini_sesion_butt.UseVisualStyleBackColor = true;
            ini_sesion_butt.Click += button2_Click;
            // 
            // correo_textbox
            // 
            correo_textbox.Location = new Point(96, 160);
            correo_textbox.Margin = new Padding(4, 2, 4, 2);
            correo_textbox.Name = "correo_textbox";
            correo_textbox.Size = new Size(176, 23);
            correo_textbox.TabIndex = 2;
            // 
            // contra_textbox
            // 
            contra_textbox.Location = new Point(96, 260);
            contra_textbox.Margin = new Padding(4, 2, 4, 2);
            contra_textbox.Name = "contra_textbox";
            contra_textbox.Size = new Size(176, 23);
            contra_textbox.TabIndex = 3;
            contra_textbox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(154, 121);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(141, 217);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(114, 36);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 33);
            label3.TabIndex = 6;
            label3.Text = "Bienvenido";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(114, 410);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 7;
            label4.Text = "@ Registrado como PIA";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(366, 458);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contra_textbox);
            Controls.Add(correo_textbox);
            Controls.Add(ini_sesion_butt);
            Controls.Add(registro_butt);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registro_butt;
        private Button ini_sesion_butt;
        private TextBox correo_textbox;
        private TextBox contra_textbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}