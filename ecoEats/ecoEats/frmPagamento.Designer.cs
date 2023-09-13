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
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNomeNoCartao = new System.Windows.Forms.TextBox();
            this.txtNumeroDoCartao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtpDataDeValidade = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblpag = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormadepagamento
            // 
            this.lblFormadepagamento.AutoSize = true;
            this.lblFormadepagamento.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormadepagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblFormadepagamento.Location = new System.Drawing.Point(242, 153);
            this.lblFormadepagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormadepagamento.Name = "lblFormadepagamento";
            this.lblFormadepagamento.Size = new System.Drawing.Size(205, 28);
            this.lblFormadepagamento.TabIndex = 0;
            this.lblFormadepagamento.Text = "Forma de Pagamento:";
            // 
            // ckbCredito
            // 
            this.ckbCredito.AutoSize = true;
            this.ckbCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.ckbCredito.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCredito.Location = new System.Drawing.Point(494, 153);
            this.ckbCredito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbCredito.Name = "ckbCredito";
            this.ckbCredito.Size = new System.Drawing.Size(81, 27);
            this.ckbCredito.TabIndex = 2;
            this.ckbCredito.Text = "Crédito";
            this.ckbCredito.UseVisualStyleBackColor = false;
            // 
            // ckbDebito
            // 
            this.ckbDebito.AutoSize = true;
            this.ckbDebito.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDebito.Location = new System.Drawing.Point(615, 153);
            this.ckbDebito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbDebito.Name = "ckbDebito";
            this.ckbDebito.Size = new System.Drawing.Size(76, 27);
            this.ckbDebito.TabIndex = 3;
            this.ckbDebito.Text = "Débito";
            this.ckbDebito.UseVisualStyleBackColor = true;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblCpf.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblCpf.Location = new System.Drawing.Point(302, 200);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(145, 28);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF do titular :";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblCodigo.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblCodigo.Location = new System.Drawing.Point(363, 394);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(84, 28);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código :";
            // 
            // lblDataDeValidade
            // 
            this.lblDataDeValidade.AutoSize = true;
            this.lblDataDeValidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblDataDeValidade.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeValidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblDataDeValidade.Location = new System.Drawing.Point(284, 344);
            this.lblDataDeValidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDeValidade.Name = "lblDataDeValidade";
            this.lblDataDeValidade.Size = new System.Drawing.Size(169, 28);
            this.lblDataDeValidade.TabIndex = 7;
            this.lblDataDeValidade.Text = "Data de validade :";
            // 
            // lblNumeroDoCartao
            // 
            this.lblNumeroDoCartao.AutoSize = true;
            this.lblNumeroDoCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblNumeroDoCartao.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDoCartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblNumeroDoCartao.Location = new System.Drawing.Point(263, 300);
            this.lblNumeroDoCartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDoCartao.Name = "lblNumeroDoCartao";
            this.lblNumeroDoCartao.Size = new System.Drawing.Size(184, 28);
            this.lblNumeroDoCartao.TabIndex = 8;
            this.lblNumeroDoCartao.Text = "Número do cartão :";
            // 
            // lblNomeNoCartao
            // 
            this.lblNomeNoCartao.AutoSize = true;
            this.lblNomeNoCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblNomeNoCartao.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeNoCartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblNomeNoCartao.Location = new System.Drawing.Point(288, 250);
            this.lblNomeNoCartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeNoCartao.Name = "lblNomeNoCartao";
            this.lblNomeNoCartao.Size = new System.Drawing.Size(165, 28);
            this.lblNomeNoCartao.TabIndex = 9;
            this.lblNomeNoCartao.Text = "Nome no cartão :";
            // 
            // btnConfirmarPagamento
            // 
            this.btnConfirmarPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.btnConfirmarPagamento.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPagamento.Location = new System.Drawing.Point(635, 454);
            this.btnConfirmarPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfirmarPagamento.Name = "btnConfirmarPagamento";
            this.btnConfirmarPagamento.Size = new System.Drawing.Size(178, 67);
            this.btnConfirmarPagamento.TabIndex = 10;
            this.btnConfirmarPagamento.Text = "Confirmar pagamento";
            this.btnConfirmarPagamento.UseVisualStyleBackColor = false;
            this.btnConfirmarPagamento.Click += new System.EventHandler(this.btnConfirmarPagamento_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(492, 200);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(158, 22);
            this.txtCpf.TabIndex = 11;
            // 
            // txtNomeNoCartao
            // 
            this.txtNomeNoCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNoCartao.Location = new System.Drawing.Point(492, 251);
            this.txtNomeNoCartao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomeNoCartao.Name = "txtNomeNoCartao";
            this.txtNomeNoCartao.Size = new System.Drawing.Size(233, 22);
            this.txtNomeNoCartao.TabIndex = 12;
            // 
            // txtNumeroDoCartao
            // 
            this.txtNumeroDoCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDoCartao.Location = new System.Drawing.Point(492, 300);
            this.txtNumeroDoCartao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeroDoCartao.Name = "txtNumeroDoCartao";
            this.txtNumeroDoCartao.Size = new System.Drawing.Size(200, 22);
            this.txtNumeroDoCartao.TabIndex = 13;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(494, 400);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 22);
            this.txtCodigo.TabIndex = 14;
            // 
            // dtpDataDeValidade
            // 
            this.dtpDataDeValidade.CustomFormat = "MM/yy";
            this.dtpDataDeValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataDeValidade.Location = new System.Drawing.Point(494, 348);
            this.dtpDataDeValidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDataDeValidade.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpDataDeValidade.Name = "dtpDataDeValidade";
            this.dtpDataDeValidade.Size = new System.Drawing.Size(233, 22);
            this.dtpDataDeValidade.TabIndex = 15;
            this.dtpDataDeValidade.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblpag);
            this.groupBox1.Controls.Add(this.dtpDataDeValidade);
            this.groupBox1.Controls.Add(this.txtNomeNoCartao);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblFormadepagamento);
            this.groupBox1.Controls.Add(this.txtNumeroDoCartao);
            this.groupBox1.Controls.Add(this.ckbCredito);
            this.groupBox1.Controls.Add(this.ckbDebito);
            this.groupBox1.Controls.Add(this.txtCpf);
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblpag
            // 
            this.lblpag.AutoSize = true;
            this.lblpag.Font = new System.Drawing.Font("Sitka Heading", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblpag.Location = new System.Drawing.Point(476, 89);
            this.lblpag.Name = "lblpag";
            this.lblpag.Size = new System.Drawing.Size(216, 35);
            this.lblpag.TabIndex = 16;
            this.lblpag.Text = "Pagamento de Selo";
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
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
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNomeNoCartao;
        private System.Windows.Forms.TextBox txtNumeroDoCartao;
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
    }
}