namespace ecoEats
{
    partial class frmCodigoBarras
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
            this.lblCódBarras = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.textBoxDigCod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCódBarras
            // 
            this.lblCódBarras.AutoSize = true;
            this.lblCódBarras.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódBarras.Location = new System.Drawing.Point(24, 75);
            this.lblCódBarras.Name = "lblCódBarras";
            this.lblCódBarras.Size = new System.Drawing.Size(139, 21);
            this.lblCódBarras.TabIndex = 2;
            this.lblCódBarras.Text = "Código de barras";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(203, 147);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(110, 37);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // textBoxDigCod
            // 
            this.textBoxDigCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDigCod.Location = new System.Drawing.Point(28, 99);
            this.textBoxDigCod.Name = "textBoxDigCod";
            this.textBoxDigCod.Size = new System.Drawing.Size(447, 38);
            this.textBoxDigCod.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDigCod);
            this.groupBox1.Controls.Add(this.lblCódBarras);
            this.groupBox1.Controls.Add(this.btnContinuar);
            this.groupBox1.Location = new System.Drawing.Point(105, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 316);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
///            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmCodigoBarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCodigoBarras";
            this.Text = "FrmCódigodeBarras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCodigoBarras_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCódBarras;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox textBoxDigCod;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}