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
            SuspendLayout();
            // 
            // registro_butt
            // 
            registro_butt.Location = new Point(21, 221);
            registro_butt.Name = "registro_butt";
            registro_butt.Size = new Size(119, 34);
            registro_butt.TabIndex = 0;
            registro_butt.Text = "registro";
            registro_butt.UseVisualStyleBackColor = true;
            registro_butt.Click += button1_Click;
            // 
            // ini_sesion_butt
            // 
            ini_sesion_butt.Location = new Point(168, 226);
            ini_sesion_butt.Name = "ini_sesion_butt";
            ini_sesion_butt.Size = new Size(124, 29);
            ini_sesion_butt.TabIndex = 1;
            ini_sesion_butt.Text = "iniciar sesion";
            ini_sesion_butt.UseVisualStyleBackColor = true;
            ini_sesion_butt.Click += button2_Click;
            // 
            // correo_textbox
            // 
            correo_textbox.Location = new Point(167, 58);
            correo_textbox.Name = "correo_textbox";
            correo_textbox.Size = new Size(125, 27);
            correo_textbox.TabIndex = 2;
            // 
            // contra_textbox
            // 
            contra_textbox.Location = new Point(168, 107);
            contra_textbox.Name = "contra_textbox";
            contra_textbox.Size = new Size(125, 27);
            contra_textbox.TabIndex = 3;
            contra_textbox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 110);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 5;
            label2.Text = "contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(314, 312);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contra_textbox);
            Controls.Add(correo_textbox);
            Controls.Add(ini_sesion_butt);
            Controls.Add(registro_butt);
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
    }
}