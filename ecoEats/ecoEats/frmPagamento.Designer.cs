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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormadepagamento
            // 
            this.lblFormadepagamento.AutoSize = true;
            this.lblFormadepagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblFormadepagamento.Location = new System.Drawing.Point(316, 25);
            this.lblFormadepagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormadepagamento.Name = "lblFormadepagamento";
            this.lblFormadepagamento.Size = new System.Drawing.Size(130, 13);
            this.lblFormadepagamento.TabIndex = 0;
            this.lblFormadepagamento.Text = "Forma de Pagamento:";
            // 
            // ckbCredito
            // 
            this.ckbCredito.AutoSize = true;
            this.ckbCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.ckbCredito.Location = new System.Drawing.Point(466, 25);
            this.ckbCredito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbCredito.Name = "ckbCredito";
            this.ckbCredito.Size = new System.Drawing.Size(66, 17);
            this.ckbCredito.TabIndex = 2;
            this.ckbCredito.Text = "Crédito";
            this.ckbCredito.UseVisualStyleBackColor = false;
            // 
            // ckbDebito
            // 
            this.ckbDebito.AutoSize = true;
            this.ckbDebito.Location = new System.Drawing.Point(466, 59);
            this.ckbDebito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbDebito.Name = "ckbDebito";
            this.ckbDebito.Size = new System.Drawing.Size(63, 17);
            this.ckbDebito.TabIndex = 3;
            this.ckbDebito.Text = "Débito";
            this.ckbDebito.UseVisualStyleBackColor = true;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblCpf.Location = new System.Drawing.Point(319, 131);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(92, 13);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF do titular :";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblCodigo.Location = new System.Drawing.Point(316, 321);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código :";
            // 
            // lblDataDeValidade
            // 
            this.lblDataDeValidade.AutoSize = true;
            this.lblDataDeValidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblDataDeValidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblDataDeValidade.Location = new System.Drawing.Point(316, 276);
            this.lblDataDeValidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDeValidade.Name = "lblDataDeValidade";
            this.lblDataDeValidade.Size = new System.Drawing.Size(112, 13);
            this.lblDataDeValidade.TabIndex = 7;
            this.lblDataDeValidade.Text = "Data de validade :";
            // 
            // lblNumeroDoCartao
            // 
            this.lblNumeroDoCartao.AutoSize = true;
            this.lblNumeroDoCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblNumeroDoCartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblNumeroDoCartao.Location = new System.Drawing.Point(316, 225);
            this.lblNumeroDoCartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDoCartao.Name = "lblNumeroDoCartao";
            this.lblNumeroDoCartao.Size = new System.Drawing.Size(116, 13);
            this.lblNumeroDoCartao.TabIndex = 8;
            this.lblNumeroDoCartao.Text = "Número do cartão :";
            // 
            // lblNomeNoCartao
            // 
            this.lblNomeNoCartao.AutoSize = true;
            this.lblNomeNoCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblNomeNoCartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.lblNomeNoCartao.Location = new System.Drawing.Point(316, 173);
            this.lblNomeNoCartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeNoCartao.Name = "lblNomeNoCartao";
            this.lblNomeNoCartao.Size = new System.Drawing.Size(105, 13);
            this.lblNomeNoCartao.TabIndex = 9;
            this.lblNomeNoCartao.Text = "Nome no cartão :";
            // 
            // btnConfirmarPagamento
            // 
            this.btnConfirmarPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(63)))));
            this.btnConfirmarPagamento.Location = new System.Drawing.Point(593, 370);
            this.btnConfirmarPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfirmarPagamento.Name = "btnConfirmarPagamento";
            this.btnConfirmarPagamento.Size = new System.Drawing.Size(145, 51);
            this.btnConfirmarPagamento.TabIndex = 10;
            this.btnConfirmarPagamento.Text = "Confirmar pagamento";
            this.btnConfirmarPagamento.UseVisualStyleBackColor = false;
            this.btnConfirmarPagamento.Click += new System.EventHandler(this.btnConfirmarPagamento_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(436, 128);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(158, 20);
            this.txtCpf.TabIndex = 11;
            // 
            // txtNomeNoCartao
            // 
            this.txtNomeNoCartao.Location = new System.Drawing.Point(436, 170);
            this.txtNomeNoCartao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomeNoCartao.Name = "txtNomeNoCartao";
            this.txtNomeNoCartao.Size = new System.Drawing.Size(233, 20);
            this.txtNomeNoCartao.TabIndex = 12;
            // 
            // txtNumeroDoCartao
            // 
            this.txtNumeroDoCartao.Location = new System.Drawing.Point(436, 222);
            this.txtNumeroDoCartao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeroDoCartao.Name = "txtNumeroDoCartao";
            this.txtNumeroDoCartao.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroDoCartao.TabIndex = 13;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(372, 318);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 14;
            // 
            // dtpDataDeValidade
            // 
            this.dtpDataDeValidade.CustomFormat = "MM/yy";
            this.dtpDataDeValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataDeValidade.Location = new System.Drawing.Point(436, 276);
            this.dtpDataDeValidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDataDeValidade.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpDataDeValidade.Name = "dtpDataDeValidade";
            this.dtpDataDeValidade.Size = new System.Drawing.Size(233, 20);
            this.dtpDataDeValidade.TabIndex = 15;
            this.dtpDataDeValidade.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1230, 611);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
    }
}