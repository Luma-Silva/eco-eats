namespace ecoEats
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarSelo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroNome = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroCodigo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(123)))));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.Sair});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(10, 8, 0, 8);
            this.menuStrip2.Size = new System.Drawing.Size(617, 44);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtos,
            this.comprarSelo});
            this.toolStripMenuItem3.Image = global::ecoEats.Properties.Resources.CapiIcon;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(106, 28);
            this.toolStripMenuItem3.Text = "Olá, [nome]";
            // 
            // produtos
            // 
            this.produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(209)))), ((int)(((byte)(154)))));
            this.produtos.Image = global::ecoEats.Properties.Resources.new_features;
            this.produtos.Name = "produtos";
            this.produtos.Size = new System.Drawing.Size(188, 30);
            this.produtos.Text = "Seus Produtos";
            this.produtos.Click += new System.EventHandler(this.produtos_Click);
            // 
            // comprarSelo
            // 
            this.comprarSelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(209)))), ((int)(((byte)(154)))));
            this.comprarSelo.Image = global::ecoEats.Properties.Resources.cart;
            this.comprarSelo.Name = "comprarSelo";
            this.comprarSelo.Size = new System.Drawing.Size(188, 30);
            this.comprarSelo.Text = "Comprar Selos";
            this.comprarSelo.Click += new System.EventHandler(this.comprarSelo_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastroNome,
            this.CadastroCodigo});
            this.toolStripMenuItem4.Image = global::ecoEats.Properties.Resources.grocery_bag;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(139, 28);
            this.toolStripMenuItem4.Text = "Cadastrar Produto";
            // 
            // CadastroNome
            // 
            this.CadastroNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(209)))), ((int)(((byte)(154)))));
            this.CadastroNome.Image = global::ecoEats.Properties.Resources.signature;
            this.CadastroNome.Name = "CadastroNome";
            this.CadastroNome.Size = new System.Drawing.Size(183, 22);
            this.CadastroNome.Text = "Por nome";
            this.CadastroNome.Click += new System.EventHandler(this.CadastroNome_Click);
            // 
            // CadastroCodigo
            // 
            this.CadastroCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(209)))), ((int)(((byte)(154)))));
            this.CadastroCodigo.Image = global::ecoEats.Properties.Resources.barcode;
            this.CadastroCodigo.Name = "CadastroCodigo";
            this.CadastroCodigo.Size = new System.Drawing.Size(183, 22);
            this.CadastroCodigo.Text = "Por código de barras";
            this.CadastroCodigo.Click += new System.EventHandler(this.CadastroCodigo_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenha});
            this.toolStripMenuItem5.Image = global::ecoEats.Properties.Resources.gear;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(120, 28);
            this.toolStripMenuItem5.Text = "Configurações";
            // 
            // alterarSenha
            // 
            this.alterarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(209)))), ((int)(((byte)(154)))));
            this.alterarSenha.Image = global::ecoEats.Properties.Resources.change_management;
            this.alterarSenha.Name = "alterarSenha";
            this.alterarSenha.Size = new System.Drawing.Size(144, 22);
            this.alterarSenha.Text = "Alterar Senha";
            this.alterarSenha.Click += new System.EventHandler(this.alterarSenha_Click);
            // 
            // Sair
            // 
            this.Sair.Image = global::ecoEats.Properties.Resources.power_on;
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(62, 28);
            this.Sair.Text = "Sair";
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.AutoSize = true;
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(236)))));
            this.panelPrincipal.Location = new System.Drawing.Point(0, 36);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(617, 328);
            this.panelPrincipal.TabIndex = 2;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(617, 365);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem produtos;
        private System.Windows.Forms.ToolStripMenuItem comprarSelo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem CadastroNome;
        private System.Windows.Forms.ToolStripMenuItem CadastroCodigo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem Sair;
        private System.Windows.Forms.ToolStripMenuItem alterarSenha;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}