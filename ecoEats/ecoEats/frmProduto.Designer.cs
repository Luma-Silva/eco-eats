﻿namespace ecoEats
{
    partial class frmProduto
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
/*
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "frmProduto";
        }

        #endregion*/

        #region Windows Form Designer generated code



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nome_produto = new System.Windows.Forms.Label();
            this.lInterpretacao = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.btnComprarSelo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lFab = new System.Windows.Forms.Label();
            this.lValidade = new System.Windows.Forms.Label();
            this.lPreco = new System.Windows.Forms.Label();
            this.lDescricao = new System.Windows.Forms.Label();
            this.lLote = new System.Windows.Forms.Label();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lCod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lCarbo = new System.Windows.Forms.Label();
            this.lProt = new System.Windows.Forms.Label();
            this.lAcucar = new System.Windows.Forms.Label();
            this.lGordura = new System.Windows.Forms.Label();
            this.lEnergetico = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lAgua = new System.Windows.Forms.Label();
            this.lImpacto = new System.Windows.Forms.Label();
            this.lPerdas = new System.Windows.Forms.Label();
            this.lEmbalagem = new System.Windows.Forms.Label();
            this.lCultivo = new System.Windows.Forms.Label();
            this.lCarbono = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picSelo = new System.Windows.Forms.PictureBox();
            this.picScore = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).BeginInit();
            this.SuspendLayout();
            // 
            // nome_produto
            // 
            this.nome_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nome_produto.AutoSize = true;
            this.nome_produto.Font = new System.Drawing.Font("Source Code Pro", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_produto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(179)))), ((int)(((byte)(89)))));
            this.nome_produto.Location = new System.Drawing.Point(809, 138);
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.Size = new System.Drawing.Size(300, 80);
            this.nome_produto.TabIndex = 16;
            this.nome_produto.Text = "Produto";
            this.nome_produto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lInterpretacao
            // 
            this.lInterpretacao.AutoSize = true;
            this.lInterpretacao.Font = new System.Drawing.Font("Source Code Pro Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInterpretacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lInterpretacao.Location = new System.Drawing.Point(39, 337);
            this.lInterpretacao.Name = "lInterpretacao";
            this.lInterpretacao.Size = new System.Drawing.Size(87, 23);
            this.lInterpretacao.TabIndex = 17;
            this.lInterpretacao.Text = "Produto";
            this.lInterpretacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lScore
            // 
            this.lScore.BackColor = System.Drawing.Color.Transparent;
            this.lScore.Font = new System.Drawing.Font("Source Code Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.ForeColor = System.Drawing.Color.Black;
            this.lScore.Location = new System.Drawing.Point(115, 138);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(114, 36);
            this.lScore.TabIndex = 18;
            this.lScore.Text = "80.67";
            this.lScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnComprarSelo
            // 
            this.btnComprarSelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComprarSelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(94)))));
            this.btnComprarSelo.FlatAppearance.BorderSize = 0;
            this.btnComprarSelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprarSelo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarSelo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComprarSelo.Image = global::ecoEats.Properties.Resources.bolsa_de_compras;
            this.btnComprarSelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprarSelo.Location = new System.Drawing.Point(1569, 300);
            this.btnComprarSelo.Name = "btnComprarSelo";
            this.btnComprarSelo.Size = new System.Drawing.Size(139, 42);
            this.btnComprarSelo.TabIndex = 20;
            this.btnComprarSelo.Text = "Comprar Selo";
            this.btnComprarSelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprarSelo.UseVisualStyleBackColor = false;
            this.btnComprarSelo.Click += new System.EventHandler(this.btnComprarSelo_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ecoEats.Properties.Resources.cardNovo3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.lFab);
            this.panel2.Controls.Add(this.lValidade);
            this.panel2.Controls.Add(this.lPreco);
            this.panel2.Controls.Add(this.lDescricao);
            this.panel2.Controls.Add(this.lLote);
            this.panel2.Controls.Add(this.lCategoria);
            this.panel2.Controls.Add(this.lCod);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.aa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1163, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 486);
            this.panel2.TabIndex = 15;
            // 
            // lFab
            // 
            this.lFab.AutoSize = true;
            this.lFab.BackColor = System.Drawing.Color.Transparent;
            this.lFab.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lFab.Location = new System.Drawing.Point(165, 109);
            this.lFab.Name = "lFab";
            this.lFab.Size = new System.Drawing.Size(0, 19);
            this.lFab.TabIndex = 22;
            // 
            // lValidade
            // 
            this.lValidade.AutoSize = true;
            this.lValidade.BackColor = System.Drawing.Color.Transparent;
            this.lValidade.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lValidade.Location = new System.Drawing.Point(145, 149);
            this.lValidade.Name = "lValidade";
            this.lValidade.Size = new System.Drawing.Size(0, 19);
            this.lValidade.TabIndex = 21;
            // 
            // lPreco
            // 
            this.lPreco.AutoSize = true;
            this.lPreco.BackColor = System.Drawing.Color.Transparent;
            this.lPreco.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lPreco.Location = new System.Drawing.Point(117, 185);
            this.lPreco.Name = "lPreco";
            this.lPreco.Size = new System.Drawing.Size(0, 19);
            this.lPreco.TabIndex = 20;
            // 
            // lDescricao
            // 
            this.lDescricao.AutoSize = true;
            this.lDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lDescricao.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lDescricao.Location = new System.Drawing.Point(161, 220);
            this.lDescricao.Name = "lDescricao";
            this.lDescricao.Size = new System.Drawing.Size(0, 19);
            this.lDescricao.TabIndex = 19;
            // 
            // lLote
            // 
            this.lLote.AutoSize = true;
            this.lLote.BackColor = System.Drawing.Color.Transparent;
            this.lLote.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lLote.Location = new System.Drawing.Point(117, 258);
            this.lLote.Name = "lLote";
            this.lLote.Size = new System.Drawing.Size(0, 19);
            this.lLote.TabIndex = 18;
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lCategoria.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lCategoria.Location = new System.Drawing.Point(161, 298);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(0, 19);
            this.lCategoria.TabIndex = 17;
            // 
            // lCod
            // 
            this.lCod.AutoSize = true;
            this.lCod.BackColor = System.Drawing.Color.Transparent;
            this.lCod.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lCod.Location = new System.Drawing.Point(136, 76);
            this.lCod.Name = "lCod";
            this.lCod.Size = new System.Drawing.Size(0, 19);
            this.lCod.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(58, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Descrição:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(58, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lote:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(58, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(58, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(58, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Validade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(58, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fabricação:";
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.BackColor = System.Drawing.Color.Transparent;
            this.aa.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.aa.Location = new System.Drawing.Point(59, 75);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(72, 19);
            this.aa.TabIndex = 9;
            this.aa.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(58, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Informações Adicionais";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ecoEats.Properties.Resources.cardNovo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.lCarbo);
            this.panel3.Controls.Add(this.lProt);
            this.panel3.Controls.Add(this.lAcucar);
            this.panel3.Controls.Add(this.lGordura);
            this.panel3.Controls.Add(this.lEnergetico);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 486);
            this.panel3.TabIndex = 15;
            // 
            // lCarbo
            // 
            this.lCarbo.AutoSize = true;
            this.lCarbo.BackColor = System.Drawing.Color.Transparent;
            this.lCarbo.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lCarbo.Location = new System.Drawing.Point(191, 256);
            this.lCarbo.Name = "lCarbo";
            this.lCarbo.Size = new System.Drawing.Size(0, 19);
            this.lCarbo.TabIndex = 40;
            // 
            // lProt
            // 
            this.lProt.AutoSize = true;
            this.lProt.BackColor = System.Drawing.Color.Transparent;
            this.lProt.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lProt.Location = new System.Drawing.Point(164, 217);
            this.lProt.Name = "lProt";
            this.lProt.Size = new System.Drawing.Size(0, 19);
            this.lProt.TabIndex = 39;
            // 
            // lAcucar
            // 
            this.lAcucar.AutoSize = true;
            this.lAcucar.BackColor = System.Drawing.Color.Transparent;
            this.lAcucar.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lAcucar.Location = new System.Drawing.Point(155, 168);
            this.lAcucar.Name = "lAcucar";
            this.lAcucar.Size = new System.Drawing.Size(0, 19);
            this.lAcucar.TabIndex = 38;
            // 
            // lGordura
            // 
            this.lGordura.AutoSize = true;
            this.lGordura.BackColor = System.Drawing.Color.Transparent;
            this.lGordura.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lGordura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lGordura.Location = new System.Drawing.Point(218, 118);
            this.lGordura.Name = "lGordura";
            this.lGordura.Size = new System.Drawing.Size(0, 19);
            this.lGordura.TabIndex = 37;
            // 
            // lEnergetico
            // 
            this.lEnergetico.AutoSize = true;
            this.lEnergetico.BackColor = System.Drawing.Color.Transparent;
            this.lEnergetico.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lEnergetico.Location = new System.Drawing.Point(227, 75);
            this.lEnergetico.Name = "lEnergetico";
            this.lEnergetico.Size = new System.Drawing.Size(0, 19);
            this.lEnergetico.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(59, 256);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 19);
            this.label20.TabIndex = 36;
            this.label20.Text = "Carboidratos:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(59, 216);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 19);
            this.label19.TabIndex = 35;
            this.label19.Text = "Proteínas:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(59, 166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 19);
            this.label18.TabIndex = 34;
            this.label18.Text = "Açúcares:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(59, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 19);
            this.label17.TabIndex = 34;
            this.label17.Text = "Gorduras Totais:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(59, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 19);
            this.label16.TabIndex = 34;
            this.label16.Text = "Valor Energético:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Code Pro Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSalmon;
            this.label3.Location = new System.Drawing.Point(59, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor Nutricional";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ecoEats.Properties.Resources.cardNovo2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lAgua);
            this.panel1.Controls.Add(this.lImpacto);
            this.panel1.Controls.Add(this.lPerdas);
            this.panel1.Controls.Add(this.lEmbalagem);
            this.panel1.Controls.Add(this.lCultivo);
            this.panel1.Controls.Add(this.lCarbono);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(586, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 486);
            this.panel1.TabIndex = 14;
            // 
            // lAgua
            // 
            this.lAgua.AutoSize = true;
            this.lAgua.BackColor = System.Drawing.Color.Transparent;
            this.lAgua.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lAgua.Location = new System.Drawing.Point(171, 290);
            this.lAgua.Name = "lAgua";
            this.lAgua.Size = new System.Drawing.Size(0, 19);
            this.lAgua.TabIndex = 33;
            // 
            // lImpacto
            // 
            this.lImpacto.AutoSize = true;
            this.lImpacto.BackColor = System.Drawing.Color.Transparent;
            this.lImpacto.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lImpacto.Location = new System.Drawing.Point(198, 245);
            this.lImpacto.Name = "lImpacto";
            this.lImpacto.Size = new System.Drawing.Size(0, 19);
            this.lImpacto.TabIndex = 32;
            // 
            // lPerdas
            // 
            this.lPerdas.AutoSize = true;
            this.lPerdas.BackColor = System.Drawing.Color.Transparent;
            this.lPerdas.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lPerdas.Location = new System.Drawing.Point(176, 206);
            this.lPerdas.Name = "lPerdas";
            this.lPerdas.Size = new System.Drawing.Size(0, 19);
            this.lPerdas.TabIndex = 31;
            // 
            // lEmbalagem
            // 
            this.lEmbalagem.AutoSize = true;
            this.lEmbalagem.BackColor = System.Drawing.Color.Transparent;
            this.lEmbalagem.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lEmbalagem.Location = new System.Drawing.Point(158, 169);
            this.lEmbalagem.Name = "lEmbalagem";
            this.lEmbalagem.Size = new System.Drawing.Size(0, 19);
            this.lEmbalagem.TabIndex = 30;
            // 
            // lCultivo
            // 
            this.lCultivo.AutoSize = true;
            this.lCultivo.BackColor = System.Drawing.Color.Transparent;
            this.lCultivo.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lCultivo.Location = new System.Drawing.Point(144, 123);
            this.lCultivo.Name = "lCultivo";
            this.lCultivo.Size = new System.Drawing.Size(0, 19);
            this.lCultivo.TabIndex = 29;
            // 
            // lCarbono
            // 
            this.lCarbono.AutoSize = true;
            this.lCarbono.BackColor = System.Drawing.Color.Transparent;
            this.lCarbono.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lCarbono.Location = new System.Drawing.Point(165, 76);
            this.lCarbono.Name = "lCarbono";
            this.lCarbono.Size = new System.Drawing.Size(0, 19);
            this.lCarbono.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(57, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 19);
            this.label15.TabIndex = 28;
            this.label15.Text = "Embalagem:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(57, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 19);
            this.label14.TabIndex = 27;
            this.label14.Text = "Desperdício:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(57, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Impacto Geral:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(57, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "Total Água:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(57, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cultivo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Source Code Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(57, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Carbono/Kg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Code Pro Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(57, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Impacto Ambiental";
            // 
            // picSelo
            // 
            this.picSelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSelo.Location = new System.Drawing.Point(1428, 12);
            this.picSelo.Name = "picSelo";
            this.picSelo.Size = new System.Drawing.Size(375, 219);
            this.picSelo.TabIndex = 4;
            this.picSelo.TabStop = false;
            // 
            // picScore
            // 
            this.picScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picScore.Location = new System.Drawing.Point(12, 1);
            this.picScore.Name = "picScore";
            this.picScore.Size = new System.Drawing.Size(301, 317);
            this.picScore.TabIndex = 3;
            this.picScore.TabStop = false;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Source Code Pro Black", 12F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(1565, 262);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 20);
            this.label21.TabIndex = 21;
            this.label21.Text = "Valor:";
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Source Code Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(1639, 262);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(69, 20);
            this.lblPreco.TabIndex = 22;
            this.lblPreco.Text = "Valor:";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1815, 1037);
            this.Controls.Add(this.nome_produto);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnComprarSelo);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.lInterpretacao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picSelo);
            this.Controls.Add(this.picScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduto";
            this.Text = "FormProduto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion



        private System.Windows.Forms.PictureBox picScore;



        private System.Windows.Forms.PictureBox picSelo;



        private System.Windows.Forms.Label label1;



        private System.Windows.Forms.Label label2;



        private System.Windows.Forms.Label label3;



        private System.Windows.Forms.Panel panel1;



        private System.Windows.Forms.Panel panel2;



        private System.Windows.Forms.Label aa;



        private System.Windows.Forms.Panel panel3;



        private System.Windows.Forms.Label lFab;



        private System.Windows.Forms.Label lValidade;



        private System.Windows.Forms.Label lPreco;



        private System.Windows.Forms.Label lDescricao;



        private System.Windows.Forms.Label lLote;



        private System.Windows.Forms.Label lCategoria;



        private System.Windows.Forms.Label lCod;



        private System.Windows.Forms.Label label9;



        private System.Windows.Forms.Label label8;



        private System.Windows.Forms.Label label7;



        private System.Windows.Forms.Label label6;



        private System.Windows.Forms.Label label5;



        private System.Windows.Forms.Label label4;



        private System.Windows.Forms.Label label15;



        private System.Windows.Forms.Label label14;



        private System.Windows.Forms.Label label13;



        private System.Windows.Forms.Label label12;



        private System.Windows.Forms.Label label11;



        private System.Windows.Forms.Label label10;



        private System.Windows.Forms.Label lAgua;



        private System.Windows.Forms.Label lImpacto;



        private System.Windows.Forms.Label lPerdas;



        private System.Windows.Forms.Label lEmbalagem;



        private System.Windows.Forms.Label lCultivo;



        private System.Windows.Forms.Label lCarbono;



        private System.Windows.Forms.Label lCarbo;



        private System.Windows.Forms.Label lProt;



        private System.Windows.Forms.Label lAcucar;



        private System.Windows.Forms.Label lGordura;



        private System.Windows.Forms.Label lEnergetico;



        private System.Windows.Forms.Label label20;



        private System.Windows.Forms.Label label19;



        private System.Windows.Forms.Label label18;



        private System.Windows.Forms.Label label17;



        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label nome_produto;
        private System.Windows.Forms.Label lInterpretacao;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Button btnComprarSelo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblPreco;
    }
}