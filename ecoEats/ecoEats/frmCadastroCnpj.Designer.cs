namespace ecoEats
{
    partial class frmCadastroCnpj
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



        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCnpj));
            this.lblDados = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblRazao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lbLTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCSenha = new System.Windows.Forms.TextBox();
            this.mkdTCnpj = new System.Windows.Forms.MaskedTextBox();
            this.mkdTTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCSenha = new System.Windows.Forms.Label();
            this.mdkTCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.rdbConfirmar = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pbCSenha2 = new System.Windows.Forms.PictureBox();
            this.pbCSenha = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gBPrincipal = new System.Windows.Forms.GroupBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCSenha2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCSenha)).BeginInit();
            this.gBPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDados
            // 
            this.lblDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDados.AutoEllipsis = true;
            this.lblDados.AutoSize = true;
            this.lblDados.BackColor = System.Drawing.Color.DarkOrange;
            this.lblDados.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDados.Location = new System.Drawing.Point(277, 168);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(261, 34);
            this.lblDados.TabIndex = 0;
            this.lblDados.Text = "Cadastro de cliente CNPJ";
            this.lblDados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDados.UseCompatibleTextRendering = true;
            // 
            // lblCnpj
            // 
            this.lblCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(346, 227);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(43, 17);
            this.lblCnpj.TabIndex = 1;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblRazao
            // 
            this.lblRazao.AllowDrop = true;
            this.lblRazao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRazao.AutoSize = true;
            this.lblRazao.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazao.Location = new System.Drawing.Point(308, 262);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(88, 17);
            this.lblRazao.TabIndex = 0;
            this.lblRazao.Text = "Razão Social:";
            this.lblRazao.Click += new System.EventHandler(this.lblRazao_Click);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(300, 297);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(104, 17);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome Fantasia:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lbLTelefone
            // 
            this.lbLTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLTelefone.AutoSize = true;
            this.lbLTelefone.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLTelefone.Location = new System.Drawing.Point(692, 435);
            this.lbLTelefone.Name = "lbLTelefone";
            this.lbLTelefone.Size = new System.Drawing.Size(65, 17);
            this.lbLTelefone.TabIndex = 4;
            this.lbLTelefone.Text = "Telefone:";
            this.lbLTelefone.Click += new System.EventHandler(this.lbLTelefone_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(353, 332);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(35, 17);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Rua:";
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(758, 332);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(23, 17);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "N°";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(338, 367);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(49, 17);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(338, 437);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "e-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(338, 469);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 17);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha:";
            // 
            // lblCep
            // 
            this.lblCep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(728, 367);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(35, 17);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
            // 
            // txtRazao
            // 
            this.txtRazao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazao.Location = new System.Drawing.Point(382, 259);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(453, 20);
            this.txtRazao.TabIndex = 2;
            this.txtRazao.TextChanged += new System.EventHandler(this.txtRazao_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(382, 294);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(453, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.Location = new System.Drawing.Point(382, 329);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(358, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Location = new System.Drawing.Point(777, 329);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(58, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.Location = new System.Drawing.Point(382, 364);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(327, 20);
            this.txtBairro.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(382, 434);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(382, 469);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(169, 20);
            this.txtSenha.TabIndex = 11;
            // 
            // txtCSenha
            // 
            this.txtCSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCSenha.Location = new System.Drawing.Point(382, 501);
            this.txtCSenha.Name = "txtCSenha";
            this.txtCSenha.PasswordChar = '*';
            this.txtCSenha.Size = new System.Drawing.Size(169, 20);
            this.txtCSenha.TabIndex = 12;
            // 
            // mkdTCnpj
            // 
            this.mkdTCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mkdTCnpj.Location = new System.Drawing.Point(382, 224);
            this.mkdTCnpj.Mask = "00.000.000/0000-00";
            this.mkdTCnpj.Name = "mkdTCnpj";
            this.mkdTCnpj.Size = new System.Drawing.Size(113, 20);
            this.mkdTCnpj.TabIndex = 1;
            this.mkdTCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mkdTTelefone
            // 
            this.mkdTTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mkdTTelefone.Location = new System.Drawing.Point(746, 434);
            this.mkdTTelefone.Mask = "(00)00000-0000";
            this.mkdTTelefone.Name = "mkdTTelefone";
            this.mkdTTelefone.Size = new System.Drawing.Size(90, 20);
            this.mkdTTelefone.TabIndex = 9;
            this.mkdTTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCSenha
            // 
            this.lblCSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCSenha.AutoSize = true;
            this.lblCSenha.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSenha.Location = new System.Drawing.Point(288, 504);
            this.lblCSenha.Name = "lblCSenha";
            this.lblCSenha.Size = new System.Drawing.Size(114, 17);
            this.lblCSenha.TabIndex = 22;
            this.lblCSenha.Text = "Confirmar senha:";
            // 
            // mdkTCep
            // 
            this.mdkTCep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdkTCep.Location = new System.Drawing.Point(757, 364);
            this.mdkTCep.Mask = "00.000-000";
            this.mdkTCep.Name = "mdkTCep";
            this.mdkTCep.Size = new System.Drawing.Size(80, 20);
            this.mdkTCep.TabIndex = 7;
            this.mdkTCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.Location = new System.Drawing.Point(773, 399);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(63, 20);
            this.txtEstado.TabIndex = 8;
            // 
            // lblUf
            // 
            this.lblUf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(751, 400);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(28, 17);
            this.lblUf.TabIndex = 25;
            this.lblUf.Text = "UF:";
            // 
            // rdbConfirmar
            // 
            this.rdbConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbConfirmar.AutoSize = true;
            this.rdbConfirmar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConfirmar.Location = new System.Drawing.Point(382, 548);
            this.rdbConfirmar.Name = "rdbConfirmar";
            this.rdbConfirmar.Size = new System.Drawing.Size(421, 21);
            this.rdbConfirmar.TabIndex = 26;
            this.rdbConfirmar.TabStop = true;
            this.rdbConfirmar.Text = "Confirmo que as informações declaradas acima são verdadeiras.";
            this.rdbConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.AutoSize = true;
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(209)))), ((int)(((byte)(137)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Location = new System.Drawing.Point(713, 593);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 29);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pbCSenha2
            // 
            this.pbCSenha2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCSenha2.Image = global::ecoEats.Properties.Resources.hide;
            this.pbCSenha2.InitialImage = null;
            this.pbCSenha2.Location = new System.Drawing.Point(557, 469);
            this.pbCSenha2.Name = "pbCSenha2";
            this.pbCSenha2.Size = new System.Drawing.Size(29, 20);
            this.pbCSenha2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCSenha2.TabIndex = 28;
            this.pbCSenha2.TabStop = false;
            this.pbCSenha2.Click += new System.EventHandler(this.pbCSenha2_Click);
            // 
            // pbCSenha
            // 
            this.pbCSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCSenha.Image = global::ecoEats.Properties.Resources.hide;
            this.pbCSenha.InitialImage = global::ecoEats.Properties.Resources.hide;
            this.pbCSenha.Location = new System.Drawing.Point(557, 501);
            this.pbCSenha.Name = "pbCSenha";
            this.pbCSenha.Size = new System.Drawing.Size(29, 20);
            this.pbCSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCSenha.TabIndex = 29;
            this.pbCSenha.TabStop = false;
            this.pbCSenha.UseWaitCursor = true;
            this.pbCSenha.Click += new System.EventHandler(this.pbCSenha_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(209)))), ((int)(((byte)(137)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(384, 593);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(124, 29);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gBPrincipal
            // 
            this.gBPrincipal.Controls.Add(this.txtCidade);
            this.gBPrincipal.Controls.Add(this.lblCidade);
            this.gBPrincipal.Controls.Add(this.txtName);
            this.gBPrincipal.Controls.Add(this.btnVoltar);
            this.gBPrincipal.Controls.Add(this.lblDados);
            this.gBPrincipal.Controls.Add(this.pbCSenha);
            this.gBPrincipal.Controls.Add(this.lblCnpj);
            this.gBPrincipal.Controls.Add(this.pbCSenha2);
            this.gBPrincipal.Controls.Add(this.lblRazao);
            this.gBPrincipal.Controls.Add(this.btnCadastrar);
            this.gBPrincipal.Controls.Add(this.lblNome);
            this.gBPrincipal.Controls.Add(this.rdbConfirmar);
            this.gBPrincipal.Controls.Add(this.lbLTelefone);
            this.gBPrincipal.Controls.Add(this.lblUf);
            this.gBPrincipal.Controls.Add(this.lblEndereco);
            this.gBPrincipal.Controls.Add(this.txtEstado);
            this.gBPrincipal.Controls.Add(this.lblNumero);
            this.gBPrincipal.Controls.Add(this.mdkTCep);
            this.gBPrincipal.Controls.Add(this.lblBairro);
            this.gBPrincipal.Controls.Add(this.lblCSenha);
            this.gBPrincipal.Controls.Add(this.lblEmail);
            this.gBPrincipal.Controls.Add(this.mkdTTelefone);
            this.gBPrincipal.Controls.Add(this.lblSenha);
            this.gBPrincipal.Controls.Add(this.mkdTCnpj);
            this.gBPrincipal.Controls.Add(this.lblCep);
            this.gBPrincipal.Controls.Add(this.txtCSenha);
            this.gBPrincipal.Controls.Add(this.txtRazao);
            this.gBPrincipal.Controls.Add(this.txtSenha);
            this.gBPrincipal.Controls.Add(this.txtEndereco);
            this.gBPrincipal.Controls.Add(this.txtEmail);
            this.gBPrincipal.Controls.Add(this.txtNumero);
            this.gBPrincipal.Controls.Add(this.txtBairro);
            this.gBPrincipal.Location = new System.Drawing.Point(3, 1);
            this.gBPrincipal.Name = "gBPrincipal";
            this.gBPrincipal.Size = new System.Drawing.Size(1115, 790);
            this.gBPrincipal.TabIndex = 31;
            this.gBPrincipal.TabStop = false;
            this.gBPrincipal.Enter += new System.EventHandler(this.gBPrincipal_Enter);
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.Location = new System.Drawing.Point(382, 399);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(348, 20);
            this.txtCidade.TabIndex = 32;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(334, 399);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 17);
            this.lblCidade.TabIndex = 31;
            this.lblCidade.Text = "Cidade:";
            // 
            // frmCadastroCnpj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1120, 749);
            this.Controls.Add(this.gBPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroCnpj";
            this.Text = "Cadastro CNPJ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadastroCnpj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCSenha2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCSenha)).EndInit();
            this.gBPrincipal.ResumeLayout(false);
            this.gBPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lbLTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtCSenha;
        private System.Windows.Forms.MaskedTextBox mkdTCnpj;
        private System.Windows.Forms.MaskedTextBox mkdTTelefone;
        private System.Windows.Forms.Label lblCSenha;
        private System.Windows.Forms.MaskedTextBox mdkTCep;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.RadioButton rdbConfirmar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pbCSenha2;
        private System.Windows.Forms.PictureBox pbCSenha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gBPrincipal;
        public System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
    }
}