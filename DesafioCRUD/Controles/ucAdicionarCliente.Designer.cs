namespace DesafioCRUD.Controles
{
    partial class ucAdicionarCliente
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
            btnSalvar = new MaterialSkin.Controls.MaterialButton();
            btnLimparCampos = new Button();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            txtUf = new TextBox();
            txtCidade = new TextBox();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            txtCEP = new TextBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            txtNumero = new TextBox();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            txtBairro = new TextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            txtNomeRua = new TextBox();
            cbEstadoCivil = new ComboBox();
            cbGenero = new ComboBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            txtTelefone = new TextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            dtpDataNascimento = new DateTimePicker();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtNome = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnLimparCampos);
            panel1.Controls.Add(materialLabel12);
            panel1.Controls.Add(materialLabel11);
            panel1.Controls.Add(txtUf);
            panel1.Controls.Add(txtCidade);
            panel1.Controls.Add(materialLabel10);
            panel1.Controls.Add(txtCEP);
            panel1.Controls.Add(materialLabel9);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(materialLabel8);
            panel1.Controls.Add(txtBairro);
            panel1.Controls.Add(materialLabel7);
            panel1.Controls.Add(txtNomeRua);
            panel1.Controls.Add(cbEstadoCivil);
            panel1.Controls.Add(cbGenero);
            panel1.Controls.Add(materialLabel6);
            panel1.Controls.Add(materialLabel5);
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(materialLabel4);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(dtpDataNascimento);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(14, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(5738, 1978);
            panel1.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.Location = new Point(455, 455);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 24;
            btnSalvar.Text = "SALVAR";
            btnSalvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.BackColor = Color.Red;
            btnLimparCampos.FlatAppearance.BorderSize = 0;
            btnLimparCampos.FlatStyle = FlatStyle.Popup;
            btnLimparCampos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimparCampos.ForeColor = SystemColors.Control;
            btnLimparCampos.Location = new Point(21, 455);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(121, 36);
            btnLimparCampos.TabIndex = 4;
            btnLimparCampos.Text = "LIMPAR CAMPOS";
            btnLimparCampos.UseMnemonic = false;
            btnLimparCampos.UseVisualStyleBackColor = false;
            btnLimparCampos.Click += btnRemover_Click;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel12.Location = new Point(490, 329);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(22, 17);
            materialLabel12.TabIndex = 23;
            materialLabel12.Text = "UF:";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel11.Location = new Point(292, 329);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(46, 17);
            materialLabel11.TabIndex = 22;
            materialLabel11.Text = "Cidade";
            // 
            // txtUf
            // 
            txtUf.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUf.Location = new Point(490, 349);
            txtUf.MaxLength = 2;
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(41, 23);
            txtUf.TabIndex = 21;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(292, 349);
            txtCidade.MaxLength = 30;
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(166, 23);
            txtCidade.TabIndex = 20;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel10.Location = new Point(137, 329);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(31, 17);
            materialLabel10.TabIndex = 19;
            materialLabel10.Text = "CEP:";
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCEP.Location = new Point(137, 349);
            txtCEP.MaxLength = 9;
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(120, 23);
            txtCEP.TabIndex = 18;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel9.Location = new Point(21, 329);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(56, 17);
            materialLabel9.TabIndex = 17;
            materialLabel9.Text = "Numero:";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(21, 349);
            txtNumero.MaxLength = 8;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(86, 23);
            txtNumero.TabIndex = 16;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel8.Location = new Point(365, 266);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(44, 17);
            materialLabel8.TabIndex = 15;
            materialLabel8.Text = "Bairro:";
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(365, 286);
            txtBairro.MaxLength = 30;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(166, 23);
            txtBairro.TabIndex = 14;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel7.Location = new Point(21, 266);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(86, 17);
            materialLabel7.TabIndex = 13;
            materialLabel7.Text = "Nome da Rua";
            // 
            // txtNomeRua
            // 
            txtNomeRua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeRua.Location = new Point(21, 286);
            txtNomeRua.MaxLength = 30;
            txtNomeRua.Name = "txtNomeRua";
            txtNomeRua.Size = new Size(321, 23);
            txtNomeRua.TabIndex = 12;
            // 
            // cbEstadoCivil
            // 
            cbEstadoCivil.FormattingEnabled = true;
            cbEstadoCivil.Location = new Point(177, 110);
            cbEstadoCivil.Name = "cbEstadoCivil";
            cbEstadoCivil.Size = new Size(165, 23);
            cbEstadoCivil.TabIndex = 11;
            cbEstadoCivil.Text = "Selecione";
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(21, 110);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(121, 23);
            cbGenero.TabIndex = 10;
            cbGenero.Text = "Selecione";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel6.Location = new Point(177, 90);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(80, 17);
            materialLabel6.TabIndex = 9;
            materialLabel6.Text = "Estado Civil:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel5.Location = new Point(365, 90);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(59, 17);
            materialLabel5.TabIndex = 8;
            materialLabel5.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(365, 110);
            txtTelefone.MaxLength = 10;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(166, 23);
            txtTelefone.TabIndex = 7;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel4.Location = new Point(21, 91);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(52, 17);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "Gênero:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel3.Location = new Point(107, 216);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(317, 17);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "------------------------- Endereço -------------------------";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.CustomFormat = "dd/MM/yyyy";
            dtpDataNascimento.Location = new Point(365, 39);
            dtpDataNascimento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(166, 23);
            dtpDataNascimento.TabIndex = 4;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel2.Location = new Point(365, 14);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(134, 17);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Data de Nascimento:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel1.Location = new Point(21, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(111, 17);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Nome do Cliente:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(21, 39);
            txtNome.MaxLength = 35;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(321, 23);
            txtNome.TabIndex = 2;
            // 
            // ucAdicionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            Controls.Add(panel1);
            Name = "ucAdicionarCliente";
            Size = new Size(562, 518);
            Load += ucAdicionarCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private TextBox txtNome;
        private DateTimePicker dtpDataNascimento;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private TextBox txtBairro;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private TextBox txtNomeRua;
        private ComboBox cbEstadoCivil;
        private ComboBox cbGenero;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private TextBox txtTelefone;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private TextBox txtNumero;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private TextBox txtUf;
        private TextBox txtCidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private TextBox txtCEP;
        private MaterialSkin.Controls.MaterialButton btnSalvar;
        private Button btnLimparCampos;
    }
}
