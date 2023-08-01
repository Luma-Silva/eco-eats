namespace ecoEats
{
    partial class frmAlterarSenha
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNSenha = new System.Windows.Forms.Label();
            this.lblRsenha = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnEmail = new System.Windows.Forms.RadioButton();
            this.rbtnCelular = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRsenha = new System.Windows.Forms.TextBox();
            this.txtNsenha = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblEmail.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.lblEmail.Location = new System.Drawing.Point(50, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(151, 21);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail ou CPF :";
            // 
            // lblNSenha
            // 
            this.lblNSenha.AutoSize = true;
            this.lblNSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblNSenha.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.lblNSenha.Location = new System.Drawing.Point(78, 173);
            this.lblNSenha.Name = "lblNSenha";
            this.lblNSenha.Size = new System.Drawing.Size(123, 21);
            this.lblNSenha.TabIndex = 1;
            this.lblNSenha.Text = "Nova Senha :";
            // 
            // lblRsenha
            // 
            this.lblRsenha.AutoSize = true;
            this.lblRsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblRsenha.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.lblRsenha.Location = new System.Drawing.Point(57, 228);
            this.lblRsenha.Name = "lblRsenha";
            this.lblRsenha.Size = new System.Drawing.Size(153, 21);
            this.lblRsenha.TabIndex = 2;
            this.lblRsenha.Text = "Repita a Senha :";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.lblConfirm.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.lblConfirm.Location = new System.Drawing.Point(50, 279);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(164, 21);
            this.lblConfirm.TabIndex = 3;
            this.lblConfirm.Text = "Confirmação por :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.label5.Location = new System.Drawing.Point(248, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Recuperar Senha:";
            // 
            // rbtnEmail
            // 
            this.rbtnEmail.AutoSize = true;
            this.rbtnEmail.Checked = true;
            this.rbtnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.rbtnEmail.Location = new System.Drawing.Point(231, 284);
            this.rbtnEmail.Name = "rbtnEmail";
            this.rbtnEmail.Size = new System.Drawing.Size(52, 17);
            this.rbtnEmail.TabIndex = 5;
            this.rbtnEmail.TabStop = true;
            this.rbtnEmail.Text = "e-mail";
            this.rbtnEmail.UseVisualStyleBackColor = true;
            // 
            // rbtnCelular
            // 
            this.rbtnCelular.AutoSize = true;
            this.rbtnCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.rbtnCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.rbtnCelular.Location = new System.Drawing.Point(349, 284);
            this.rbtnCelular.Name = "rbtnCelular";
            this.rbtnCelular.Size = new System.Drawing.Size(56, 17);
            this.rbtnCelular.TabIndex = 6;
            this.rbtnCelular.Text = "celular";
            this.rbtnCelular.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(210, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 24);
            this.txtEmail.TabIndex = 7;
            // 
            // txtRsenha
            // 
            this.txtRsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.txtRsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRsenha.Location = new System.Drawing.Point(210, 227);
            this.txtRsenha.Name = "txtRsenha";
            this.txtRsenha.Size = new System.Drawing.Size(293, 24);
            this.txtRsenha.TabIndex = 8;
            this.txtRsenha.UseSystemPasswordChar = true;
            // 
            // txtNsenha
            // 
            this.txtNsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.txtNsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNsenha.Location = new System.Drawing.Point(209, 173);
            this.txtNsenha.Name = "txtNsenha";
            this.txtNsenha.Size = new System.Drawing.Size(293, 24);
            this.txtNsenha.TabIndex = 9;
            this.txtNsenha.UseSystemPasswordChar = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(272, 336);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(133, 47);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.btnMostrar.Location = new System.Drawing.Point(509, 198);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 29);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "mostrar senha";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtNsenha);
            this.Controls.Add(this.txtRsenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.rbtnCelular);
            this.Controls.Add(this.rbtnEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblRsenha);
            this.Controls.Add(this.lblNSenha);
            this.Controls.Add(this.lblEmail);
            this.Name = "frmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.frmAlterarInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNSenha;
        private System.Windows.Forms.Label lblRsenha;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnEmail;
        private System.Windows.Forms.RadioButton rbtnCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRsenha;
        private System.Windows.Forms.TextBox txtNsenha;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnMostrar;
    }
}