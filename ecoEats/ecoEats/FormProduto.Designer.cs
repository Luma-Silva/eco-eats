namespace ecoEats
{
    partial class FormProduto
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
            this.picProd = new System.Windows.Forms.PictureBox();
            this.picImpacto = new System.Windows.Forms.PictureBox();
            this.picNutricional = new System.Windows.Forms.PictureBox();
            this.picSelo = new System.Windows.Forms.PictureBox();
            this.picScore = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImpacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNutricional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).BeginInit();
            this.SuspendLayout();
            // 
            // picProd
            // 
            this.picProd.BackgroundImage = global::ecoEats.Properties.Resources.card3;
            this.picProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProd.Location = new System.Drawing.Point(880, 383);
            this.picProd.Name = "picProd";
            this.picProd.Size = new System.Drawing.Size(331, 339);
            this.picProd.TabIndex = 7;
            this.picProd.TabStop = false;
            // 
            // picImpacto
            // 
            this.picImpacto.BackgroundImage = global::ecoEats.Properties.Resources.card21;
            this.picImpacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImpacto.Location = new System.Drawing.Point(471, 383);
            this.picImpacto.Name = "picImpacto";
            this.picImpacto.Size = new System.Drawing.Size(331, 339);
            this.picImpacto.TabIndex = 6;
            this.picImpacto.TabStop = false;
            // 
            // picNutricional
            // 
            this.picNutricional.BackgroundImage = global::ecoEats.Properties.Resources.card1;
            this.picNutricional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNutricional.Location = new System.Drawing.Point(45, 383);
            this.picNutricional.Name = "picNutricional";
            this.picNutricional.Size = new System.Drawing.Size(331, 339);
            this.picNutricional.TabIndex = 5;
            this.picNutricional.TabStop = false;
            // 
            // picSelo
            // 
            this.picSelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSelo.BackgroundImage = global::ecoEats.Properties.Resources.selos__1___2_;
            this.picSelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSelo.Location = new System.Drawing.Point(828, 12);
            this.picSelo.Name = "picSelo";
            this.picSelo.Size = new System.Drawing.Size(419, 353);
            this.picSelo.TabIndex = 4;
            this.picSelo.TabStop = false;
            // 
            // picScore
            // 
            this.picScore.BackgroundImage = global::ecoEats.Properties.Resources.score__1_;
            this.picScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picScore.Location = new System.Drawing.Point(61, 48);
            this.picScore.Name = "picScore";
            this.picScore.Size = new System.Drawing.Size(268, 244);
            this.picScore.TabIndex = 3;
            this.picScore.TabStop = false;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1275, 734);
            this.Controls.Add(this.picProd);
            this.Controls.Add(this.picImpacto);
            this.Controls.Add(this.picNutricional);
            this.Controls.Add(this.picSelo);
            this.Controls.Add(this.picScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImpacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNutricional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picScore;
        private System.Windows.Forms.PictureBox picSelo;
        private System.Windows.Forms.PictureBox picNutricional;
        private System.Windows.Forms.PictureBox picImpacto;
        private System.Windows.Forms.PictureBox picProd;
    }
}