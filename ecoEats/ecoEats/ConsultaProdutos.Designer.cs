namespace ecoEats
{
    partial class ConsultaProdutos
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Location = new System.Drawing.Point(220, 54);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(200, 100);
            this.gb.TabIndex = 2;
            this.gb.TabStop = false;
            this.gb.Text = "groupBox1";
            // 
            // ConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(238)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1510, 920);
            this.Controls.Add(this.gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaProdutos";
            this.Text = "Consulta Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultaProdutos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb;
    }
}