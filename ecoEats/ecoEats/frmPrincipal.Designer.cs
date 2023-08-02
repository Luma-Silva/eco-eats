namespace ecoEats
{
    partial class frmPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cnpj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cpf = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.Panel();
            this.imgScore = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem-vinda(o) ao Eco Eats!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "O único lugar onde você pode medir o quão sustentável é o seu produto\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comece sua jornada:";
            // 
            // btn_cnpj
            // 
            this.btn_cnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(168)))));
            this.btn_cnpj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(168)))));
            this.btn_cnpj.FlatAppearance.BorderSize = 0;
            this.btn_cnpj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cnpj.Location = new System.Drawing.Point(28, 202);
            this.btn_cnpj.Name = "btn_cnpj";
            this.btn_cnpj.Size = new System.Drawing.Size(189, 49);
            this.btn_cnpj.TabIndex = 6;
            this.btn_cnpj.Text = "Cadastre-se CNPJ";
            this.btn_cnpj.UseVisualStyleBackColor = false;
            this.btn_cnpj.Click += new System.EventHandler(this.btn_cnpj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Já é cadastrado?";
            // 
            // btn_cpf
            // 
            this.btn_cpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(168)))));
            this.btn_cpf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(168)))));
            this.btn_cpf.FlatAppearance.BorderSize = 0;
            this.btn_cpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cpf.Location = new System.Drawing.Point(248, 202);
            this.btn_cpf.Name = "btn_cpf";
            this.btn_cpf.Size = new System.Drawing.Size(173, 49);
            this.btn_cpf.TabIndex = 9;
            this.btn_cpf.Text = "Cadastre-se CPF";
            this.btn_cpf.UseVisualStyleBackColor = false;
            this.btn_cpf.Click += new System.EventHandler(this.btn_cpf_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(168)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(168)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(93, 345);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(189, 49);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLogo.BackgroundImage = global::ecoEats.Properties.Resources.Design_sem_nome;
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Location = new System.Drawing.Point(652, -75);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(631, 758);
            this.imgLogo.TabIndex = 11;
            // 
            // imgScore
            // 
            this.imgScore.AutoSize = true;
            this.imgScore.BackgroundImage = global::ecoEats.Properties.Resources.imagemScore;
            this.imgScore.Location = new System.Drawing.Point(74, 420);
            this.imgScore.Name = "imgScore";
            this.imgScore.Size = new System.Drawing.Size(484, 467);
            this.imgScore.TabIndex = 12;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1283, 682);
            this.Controls.Add(this.imgScore);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btn_cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cnpj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmPrincipal";
            this.Text = "Bem-Vinda(o)!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cpf;
        private System.Windows.Forms.Button btnLogin;

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel imgLogo;
        private System.Windows.Forms.Panel imgScore;
    }
}

