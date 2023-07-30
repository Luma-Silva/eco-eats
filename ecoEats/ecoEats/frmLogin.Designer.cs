namespace ecoEats
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF_CNPJ = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnRedefinirSenha = new System.Windows.Forms.Button();
            this.picMostrarEsconder = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarEsconder)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro Black", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(179)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(455, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log-in";
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(193)))), ((int)(((byte)(95)))));
            this.btnLogar.FlatAppearance.BorderSize = 0;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Source Code Pro Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Location = new System.Drawing.Point(454, 344);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(167, 53);
            this.btnLogar.TabIndex = 1;
            this.btnLogar.Text = "Fazer Login";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Code Pro Semibold", 14.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF/CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Code Pro Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "SENHA:";
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.BackColor = System.Drawing.Color.White;
            this.txtCPF_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF_CNPJ.Location = new System.Drawing.Point(432, 233);
            this.txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            this.txtCPF_CNPJ.Size = new System.Drawing.Size(210, 26);
            this.txtCPF_CNPJ.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(432, 275);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(210, 26);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnRedefinirSenha
            // 
            this.btnRedefinirSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnRedefinirSenha.FlatAppearance.BorderSize = 0;
            this.btnRedefinirSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedefinirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedefinirSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRedefinirSenha.Location = new System.Drawing.Point(432, 307);
            this.btnRedefinirSenha.Name = "btnRedefinirSenha";
            this.btnRedefinirSenha.Size = new System.Drawing.Size(194, 21);
            this.btnRedefinirSenha.TabIndex = 7;
            this.btnRedefinirSenha.Text = "Esqueceu a senha? Redefinir senha";
            this.btnRedefinirSenha.UseVisualStyleBackColor = false;
            this.btnRedefinirSenha.Click += new System.EventHandler(this.btnRedefinirSenha_Click);
            // 
            // picMostrarEsconder
            // 
            this.picMostrarEsconder.BackColor = System.Drawing.Color.Transparent;
            this.picMostrarEsconder.BackgroundImage = global::ecoEats.Properties.Resources.view;
            this.picMostrarEsconder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMostrarEsconder.Location = new System.Drawing.Point(648, 275);
            this.picMostrarEsconder.Name = "picMostrarEsconder";
            this.picMostrarEsconder.Size = new System.Drawing.Size(36, 24);
            this.picMostrarEsconder.TabIndex = 8;
            this.picMostrarEsconder.TabStop = false;
            this.picMostrarEsconder.Click += new System.EventHandler(this.picMostrarEsconder_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picMostrarEsconder);
            this.panel1.Controls.Add(this.btnLogar);
            this.panel1.Controls.Add(this.btnRedefinirSenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCPF_CNPJ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 583);
            this.panel1.TabIndex = 9;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1054, 583);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarEsconder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPF_CNPJ;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnRedefinirSenha;
        private System.Windows.Forms.PictureBox picMostrarEsconder;
        private System.Windows.Forms.Panel panel1;


    }
}
