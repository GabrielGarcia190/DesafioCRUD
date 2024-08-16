namespace DesafioCRUD.Controles
{
    partial class ucListaClientes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRemover = new Button();
            btnAtualizar = new MaterialSkin.Controls.MaterialButton();
            gvClientes = new DataGridView();
            NomeCliente = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            Idade = new DataGridViewTextBoxColumn();
            UF = new DataGridViewTextBoxColumn();
            CodigoCliente = new DataGridViewTextBoxColumn();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnRemover);
            panel1.Controls.Add(btnAtualizar);
            panel1.Controls.Add(gvClientes);
            panel1.Controls.Add(materialButton1);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(2139, 1328);
            panel1.TabIndex = 0;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Red;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatStyle = FlatStyle.Popup;
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemover.ForeColor = SystemColors.Control;
            btnRemover.Location = new Point(3, 467);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(99, 36);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "REMOVER";
            btnRemover.UseMnemonic = false;
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAtualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAtualizar.Depth = 0;
            btnAtualizar.HighEmphasis = true;
            btnAtualizar.Icon = null;
            btnAtualizar.Location = new Point(457, 467);
            btnAtualizar.Margin = new Padding(4, 6, 4, 6);
            btnAtualizar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.NoAccentTextColor = Color.Empty;
            btnAtualizar.Size = new Size(99, 36);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "atualizar";
            btnAtualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAtualizar.UseAccentColor = false;
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // gvClientes
            // 
            gvClientes.BackgroundColor = SystemColors.Control;
            gvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvClientes.Columns.AddRange(new DataGridViewColumn[] { NomeCliente, DataNascimento, Cidade, Idade, UF, CodigoCliente });
            gvClientes.Location = new Point(3, 0);
            gvClientes.MultiSelect = false;
            gvClientes.Name = "gvClientes";
            gvClientes.ReadOnly = true;
            gvClientes.RowTemplate.Height = 25;
            gvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvClientes.Size = new Size(553, 458);
            gvClientes.TabIndex = 1;
            // 
            // NomeCliente
            // 
            NomeCliente.DataPropertyName = "NomeCliente";
            NomeCliente.Frozen = true;
            NomeCliente.HeaderText = "Nome do Cliente";
            NomeCliente.Name = "NomeCliente";
            NomeCliente.ReadOnly = true;
            NomeCliente.Width = 270;
            // 
            // DataNascimento
            // 
            DataNascimento.DataPropertyName = "DataNascimento";
            DataNascimento.HeaderText = "DataNascimento";
            DataNascimento.Name = "DataNascimento";
            DataNascimento.ReadOnly = true;
            DataNascimento.Visible = false;
            // 
            // Cidade
            // 
            Cidade.DataPropertyName = "Cidade";
            Cidade.HeaderText = "Cidade";
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            Cidade.Width = 110;
            // 
            // Idade
            // 
            Idade.DataPropertyName = "Idade";
            Idade.HeaderText = "Idade";
            Idade.Name = "Idade";
            Idade.ReadOnly = true;
            // 
            // UF
            // 
            UF.DataPropertyName = "UF";
            UF.HeaderText = "UF";
            UF.Name = "UF";
            UF.ReadOnly = true;
            UF.Width = 30;
            // 
            // CodigoCliente
            // 
            CodigoCliente.DataPropertyName = "CodigoCliente";
            CodigoCliente.HeaderText = "CodigoCliente";
            CodigoCliente.Name = "CodigoCliente";
            CodigoCliente.ReadOnly = true;
            CodigoCliente.Visible = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(1663, 863);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Red;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // ucListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel1);
            Name = "ucListaClientes";
            Size = new Size(1470, 672);
            Load += ucListaClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private DataGridView gvClientes;
        private MaterialSkin.Controls.MaterialButton btnAtualizar;
        private Button btnRemover;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn UF;
        private DataGridViewTextBoxColumn CodigoCliente;
    }
}
