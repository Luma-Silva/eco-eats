namespace ecoEats
{
    partial class frmPagamento
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
            this.lblFormadepagamento = new System.Windows.Forms.Label();
            this.ckbCredito = new System.Windows.Forms.CheckBox();
            this.ckbDebito = new System.Windows.Forms.CheckBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDataDeValidade = new System.Windows.Forms.Label();
            this.lblNumeroDoCartao = new System.Windows.Forms.Label();
            this.lblNomeNoCartao = new System.Windows.Forms.Label();
            this.btnConfirmarPagamento = new System.Windows.Forms.Button();
            this.txtNomeNoCartao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtpDataDeValidade = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblpag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbCartao = new System.Windows.Forms.MaskedTextBox();
            this.lblValorSelo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormadepagamento
            // 
            this.lblFormadepagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormadepagamento.AutoSize = true;
            this.lblFormadepagamento.BackColor = System.Drawing.Color.Transparent;
            this.lblFormadepagamento.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormadepagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.lblFormadepagamento.Location = new System.Drawing.Point(312, 105);
            this.lblFormadepagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormadepagamento.Name = "lblFormadepagamento";
            this.lblFormadepagamento.Size = new System.Drawing.Size(205, 28);
            this.lblFormadepagamento.TabIndex = 0;
            this.lblFormadepagamento.Text = "Forma de Pagamento:";
            // 
            // ckbCredito
            // 
            this.ckbCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbCredito.AutoSize = true;
            this.ckbCredito.BackColor = System.Drawing.Color.Transparent;
            this.ckbCredito.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCredito.Location = new System.Drawing.Point(562, 105);
            this.ckbCredito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbCredito.Name = "ckbCredito";
            this.ckbCredito.Size = new System.Drawing.Size(81, 27);
            this.ckbCredito.TabIndex = 2;
            this.ckbCredito.Text = "Crédito";
            this.ckbCredito.UseVisualStyleBackColor = false;
            // 
            // ckbDebito
            // 
            this.ckbDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbDebito.AutoSize = true;
            this.ckbDebito.BackColor = System.Drawing.Color.Transparent;
            this.ckbDebito.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDebito.Location = new System.Drawing.Point(670, 106);
            this.ckbDebito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbDebito.Name = "ckbDebito";
            this.ckbDebito.Size = new System.Drawing.Size(76, 27);
            this.ckbDebito.TabIndex = 3;
            this.ckbDebito.Text = "Débito";
            this.ckbDebito.UseVisualStyleBackColor = false;
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.lblCpf.Location = new System.Drawing.Point(372, 150);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(145, 28);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF do titular :";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.lblCodigo.Location = new System.Drawing.Point(393, 361);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(124, 28);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código CVV :";
            // 
            // lblDataDeValidade
            // 
            this.lblDataDeValidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataDeValidade.AutoSize = true;
            this.lblDataDeValidade.BackColor = System.Drawing.Color.Transparent;
            this.lblDataDeValidade.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeValidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.lblDataDeValidade.Location = new System.Drawing.Point(348, 306);
            this.lblDataDeValidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDeValidade.Name = "lblDataDeValidade";
            this.lblDataDeValidade.Size = new System.Drawing.Size(169, 28);
            this.lblDataDeValidade.TabIndex = 7;
            this.lblDataDeValidade.Text = "Data de validade :";
            // 
            // lblNumeroDoCartao
            // 
            this.lblNumeroDoCartao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDoCartao.AutoSize = true;
            this.lblNumeroDoCartao.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroDoCartao.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDoCartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.lblNumeroDoCartao.Location = new System.Drawing.Point(333, 253);
            this.lblNumeroDoCartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDoCartao.Name = "lblNumeroDoCartao";
            this.lblNumeroDoCartao.Size = new System.Drawing.Size(184, 28);
            this.lblNumeroDoCartao.TabIndex = 8;
            this.lblNumeroDoCartao.Text = "Número do cartão :";
            // 
            // lblNomeNoCartao
            // 
            this.lblNomeNoCartao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeNoCartao.AutoSize = true;
            this.lblNomeNoCartao.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeNoCartao.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeNoCartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.lblNomeNoCartao.Location = new System.Drawing.Point(352, 200);
            this.lblNomeNoCartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeNoCartao.Name = "lblNomeNoCartao";
            this.lblNomeNoCartao.Size = new System.Drawing.Size(165, 28);
            this.lblNomeNoCartao.TabIndex = 9;
            this.lblNomeNoCartao.Text = "Nome no cartão :";
            // 
            // btnConfirmarPagamento
            // 
            this.btnConfirmarPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.btnConfirmarPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfirmarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPagamento.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPagamento.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirmarPagamento.Location = new System.Drawing.Point(879, 448);
            this.btnConfirmarPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfirmarPagamento.Name = "btnConfirmarPagamento";
            this.btnConfirmarPagamento.Size = new System.Drawing.Size(178, 67);
            this.btnConfirmarPagamento.TabIndex = 10;
            this.btnConfirmarPagamento.Text = "Efetuar pagamento";
            this.btnConfirmarPagamento.UseVisualStyleBackColor = false;
            this.btnConfirmarPagamento.Click += new System.EventHandler(this.btnConfirmarPagamento_Click);
            // 
            // txtNomeNoCartao
            // 
            this.txtNomeNoCartao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeNoCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNoCartao.Location = new System.Drawing.Point(562, 206);
            this.txtNomeNoCartao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomeNoCartao.Name = "txtNomeNoCartao";
            this.txtNomeNoCartao.Size = new System.Drawing.Size(321, 22);
            this.txtNomeNoCartao.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(562, 367);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(47, 22);
            this.txtCodigo.TabIndex = 14;
            // 
            // dtpDataDeValidade
            // 
            this.dtpDataDeValidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataDeValidade.CustomFormat = "MM/yy";
            this.dtpDataDeValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataDeValidade.Location = new System.Drawing.Point(562, 312);
            this.dtpDataDeValidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDataDeValidade.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpDataDeValidade.Name = "dtpDataDeValidade";
            this.dtpDataDeValidade.Size = new System.Drawing.Size(233, 22);
            this.dtpDataDeValidade.TabIndex = 15;
            this.dtpDataDeValidade.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(216)))), ((int)(((byte)(158)))));
            this.groupBox1.Controls.Add(this.lblValorSelo);
            this.groupBox1.Controls.Add(this.mtbCartao);
            this.groupBox1.Controls.Add(this.mtbCpf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblpag);
            this.groupBox1.Controls.Add(this.dtpDataDeValidade);
            this.groupBox1.Controls.Add(this.txtNomeNoCartao);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblFormadepagamento);
            this.groupBox1.Controls.Add(this.ckbCredito);
            this.groupBox1.Controls.Add(this.ckbDebito);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.btnConfirmarPagamento);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblNomeNoCartao);
            this.groupBox1.Controls.Add(this.lblDataDeValidade);
            this.groupBox1.Controls.Add(this.lblNumeroDoCartao);
            this.groupBox1.Location = new System.Drawing.Point(35, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1194, 575);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lblpag
            // 
            this.lblpag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpag.AutoSize = true;
            this.lblpag.BackColor = System.Drawing.Color.Transparent;
            this.lblpag.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.lblpag.Location = new System.Drawing.Point(556, 44);
            this.lblpag.Name = "lblpag";
            this.lblpag.Size = new System.Drawing.Size(216, 35);
            this.lblpag.TabIndex = 16;
            this.lblpag.Text = "Pagamento de Selo";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(383, 415);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valor do selo:";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbCpf.Location = new System.Drawing.Point(562, 158);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(97, 20);
            this.mtbCpf.TabIndex = 18;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbCartao
            // 
            this.mtbCartao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbCartao.Location = new System.Drawing.Point(562, 261);
            this.mtbCartao.Mask = "0000 0000 0000 0000";
            this.mtbCartao.Name = "mtbCartao";
            this.mtbCartao.Size = new System.Drawing.Size(131, 20);
            this.mtbCartao.TabIndex = 19;
            this.mtbCartao.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblValorSelo
            // 
            this.lblValorSelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorSelo.AutoSize = true;
            this.lblValorSelo.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorSelo.Location = new System.Drawing.Point(558, 419);
            this.lblValorSelo.Name = "lblValorSelo";
            this.lblValorSelo.Size = new System.Drawing.Size(0, 23);
            this.lblValorSelo.TabIndex = 20;
            this.lblValorSelo.Click += new System.EventHandler(this.lblValorSelo_Click);
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(216)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1274, 651);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPagamento";
            this.Text = "Compra de selo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormadepagamento;
        private System.Windows.Forms.CheckBox ckbCredito;
        private System.Windows.Forms.CheckBox ckbDebito;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDataDeValidade;
        private System.Windows.Forms.Label lblNumeroDoCartao;
        private System.Windows.Forms.Label lblNomeNoCartao;
        private System.Windows.Forms.Button btnConfirmarPagamento;
        private System.Windows.Forms.TextBox txtNomeNoCartao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dtpDataDeValidade;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblpag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCartao;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lblValorSelo;
    }
}