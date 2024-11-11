namespace WinFormsApp1
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            butt_buscar = new Button();
            button1 = new Button();
            comboBox4 = new ComboBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            cambiarDeSesionToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            Busquedas = new ToolStripMenuItem();
            recientesToolStripMenuItem = new ToolStripMenuItem();
            favoritosToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox2 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Génesis", "Éxodo", "Levítico", "Números", "Deuteronomio", "Josué", "Jueces", "Rut", "Samuel", "Reyes", "Crónicas", "Esdras", "Nehemías", "Ester", "Macabeos", "Job", "Salmos", "Proverbios", "Eclesiastés", "Cantares", "Isaías", "Jeremías", "Lamentacias", "Baruc", "Ezequiel", "Daniel", "Oseas", "Joel", "Amós", "Abdías", "Jonás", "Miqueas", "Nahum", "Habacuc", "Sofonías", "Ageo", "Zacarías", "Malaquías", "Evangelio de Mateo", "Evangelio de Marcos", "Evangelio de Lucas", "Evangelio de Juan", "Hechos", "Romanos", "Corintios", "Gálatas", "Efesios", "Filipenses", "Colosenses", "Tesalonicenses", "Timoteo", "Tito", "Filemon", "Hebreos", "Santiago", "Pedro", "Juan", "Judas", "Apocalipsis" });
            comboBox1.Location = new Point(178, 55);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(178, 91);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(219, 23);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(178, 128);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(219, 23);
            comboBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(22, 57);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 4;
            label1.Text = "Numero empleado";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(105, 94);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 5;
            label2.Text = "Puesto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(39, 128);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 6;
            label3.Text = "Fechas recientes";
            label3.Click += label3_Click;
            // 
            // butt_buscar
            // 
            butt_buscar.BackColor = SystemColors.ButtonHighlight;
            butt_buscar.Font = new Font("Open Sans Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            butt_buscar.ForeColor = SystemColors.GrayText;
            butt_buscar.Location = new Point(347, 170);
            butt_buscar.Margin = new Padding(3, 2, 3, 2);
            butt_buscar.Name = "butt_buscar";
            butt_buscar.Size = new Size(115, 30);
            butt_buscar.TabIndex = 8;
            butt_buscar.Text = "Buscar";
            butt_buscar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Open Sans Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.GrayText;
            button1.Location = new Point(667, 170);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(115, 30);
            button1.TabIndex = 9;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(497, 95);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(219, 23);
            comboBox4.TabIndex = 11;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Honeydew;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, Busquedas });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(816, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { modificarToolStripMenuItem, usuarioToolStripMenuItem, cambiarDeSesionToolStripMenuItem, cerrarSesionToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(59, 20);
            toolStripMenuItem1.Text = "Usuario";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(171, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // cambiarDeSesionToolStripMenuItem
            // 
            cambiarDeSesionToolStripMenuItem.Name = "cambiarDeSesionToolStripMenuItem";
            cambiarDeSesionToolStripMenuItem.Size = new Size(171, 22);
            cambiarDeSesionToolStripMenuItem.Text = "Cambiar de sesion";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(171, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(171, 22);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // Busquedas
            // 
            Busquedas.DropDownItems.AddRange(new ToolStripItem[] { recientesToolStripMenuItem, favoritosToolStripMenuItem });
            Busquedas.Name = "Busquedas";
            Busquedas.Size = new Size(76, 20);
            Busquedas.Text = "Busquedas";
            Busquedas.Click += toolStripMenuItem2_Click;
            // 
            // recientesToolStripMenuItem
            // 
            recientesToolStripMenuItem.Name = "recientesToolStripMenuItem";
            recientesToolStripMenuItem.Size = new Size(180, 22);
            recientesToolStripMenuItem.Text = "Recientes";
            // 
            // favoritosToolStripMenuItem
            // 
            favoritosToolStripMenuItem.Name = "favoritosToolStripMenuItem";
            favoritosToolStripMenuItem.Size = new Size(180, 22);
            favoritosToolStripMenuItem.Text = "Busqueda avanzada";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Open Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(497, 55);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 28);
            textBox1.TabIndex = 13;
            textBox1.Text = "Departamento";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 28);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 231);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(794, 151);
            textBox2.TabIndex = 16;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(816, 393);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(comboBox4);
            Controls.Add(button1);
            Controls.Add(butt_buscar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip1);
            Cursor = Cursors.Hand;
            ForeColor = Color.DodgerBlue;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Menu principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button butt_buscar;
        private Button button1;
        private ComboBox comboBox4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem Busquedas;
        private ToolStripMenuItem recientesToolStripMenuItem;
        private ToolStripMenuItem favoritosToolStripMenuItem;
        private TextBox textBox1;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox2;
        private ToolStripMenuItem cambiarDeSesionToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
    }
}