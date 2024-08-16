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
            btnListar = new Button();
            btnAdicionar = new Button();
            panel1 = new Panel();
            pnMenu = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            panelMenu.SuspendLayout();
            pnMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(btnListar);
            panelMenu.Controls.Add(btnAdicionar);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 542);
            panelMenu.TabIndex = 0;
            // 
            // btnListar
            // 
            btnListar.Dock = DockStyle.Top;
            btnListar.FlatAppearance.BorderSize = 0;
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListar.ForeColor = Color.GhostWhite;
            btnListar.Image = Properties.Resources.list;
            btnListar.ImageAlign = ContentAlignment.MiddleLeft;
            btnListar.Location = new Point(0, 140);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(218, 60);
            btnListar.TabIndex = 2;
            btnListar.Text = "     LISTAR";
            btnListar.TextAlign = ContentAlignment.MiddleLeft;
            btnListar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Dock = DockStyle.Top;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.ForeColor = Color.GhostWhite;
            btnAdicionar.Image = Properties.Resources.pencil;
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(0, 80);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(218, 60);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "   ADICIONAR";
            btnAdicionar.TextAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
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
            // pnMenu
            // 
            pnMenu.AutoSize = true;
            pnMenu.Controls.Add(materialLabel1);
            pnMenu.Location = new Point(226, 12);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(562, 518);
            pnMenu.TabIndex = 1;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(147, 240);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(252, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Selcione uma das opções na lateral";
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(pnMenu);
            Controls.Add(panelMenu);
            Name = "frmMenuPrincipal";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            pnMenu.ResumeLayout(false);
            pnMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Button btnAdicionar;
        private Button btnListar;
        private Panel panel2;
        private Panel pnMenu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}