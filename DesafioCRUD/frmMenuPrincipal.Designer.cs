namespace DesafioCRUD
{
    partial class frmMenuPrincipal
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
            panelMenu = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnAdicionar = new Button();
            panel1 = new Panel();
            pnCadastro = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            panelMenu.SuspendLayout();
            pnCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnAdicionar);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 542);
            panelMenu.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gainsboro;
            button2.Image = Properties.Resources.user_plus__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 200);
            button2.Name = "button2";
            button2.Size = new Size(218, 60);
            button2.TabIndex = 3;
            button2.Text = "     Remover Clientes";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Image = Properties.Resources.user_plus__1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 140);
            button1.Name = "button1";
            button1.Size = new Size(218, 60);
            button1.TabIndex = 2;
            button1.Text = "     Listar Clientes";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Dock = DockStyle.Top;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.ForeColor = Color.GhostWhite;
            btnAdicionar.Image = Properties.Resources.user_plus__1_;
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(0, 80);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(218, 60);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "   ADICIONAR";
            btnAdicionar.TextAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 80);
            panel1.TabIndex = 1;
            // 
            // pnCadastro
            // 
            pnCadastro.Controls.Add(button3);
            pnCadastro.Controls.Add(label1);
            pnCadastro.Controls.Add(textBox1);
            pnCadastro.Location = new Point(226, 12);
            pnCadastro.Name = "pnCadastro";
            pnCadastro.Size = new Size(562, 518);
            pnCadastro.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "NOME COMPLETO:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(15, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(510, 16);
            textBox1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(211, 208);
            button3.Name = "button3";
            button3.Size = new Size(106, 41);
            button3.TabIndex = 3;
            button3.Text = "Teste";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(pnCadastro);
            Controls.Add(panelMenu);
            Name = "frmMenuPrincipal";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            pnCadastro.ResumeLayout(false);
            pnCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Button btnAdicionar;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel pnCadastro;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
    }
}