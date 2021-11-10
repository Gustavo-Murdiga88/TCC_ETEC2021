
namespace _200130_Projeto
{
    partial class FrmProdutos
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.GrpDados = new System.Windows.Forms.GroupBox();
            this.LblID = new System.Windows.Forms.Label();
            this.ChkFora = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtValorVenda = new System.Windows.Forms.TextBox();
            this.TxtValorCusto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CboFornecedor = new System.Windows.Forms.ComboBox();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEstoque = new System.Windows.Forms.TextBox();
            this.TxtEstoqueMin = new System.Windows.Forms.TextBox();
            this.TxtBarra = new System.Windows.Forms.TextBox();
            this.TxtLink = new System.Windows.Forms.TextBox();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PicProduto = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GrpButton = new System.Windows.Forms.GroupBox();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.GrpGrid = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.OfdProduto = new System.Windows.Forms.OpenFileDialog();
            this.OfdLink = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.GrpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProduto)).BeginInit();
            this.GrpButton.SuspendLayout();
            this.GrpGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(23, 109);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 38);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(23, 19);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(100, 38);
            this.BtnIncluir.TabIndex = 11;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(23, 244);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(100, 38);
            this.BtnFechar.TabIndex = 16;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(23, 154);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(100, 38);
            this.BtnExcluir.TabIndex = 14;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.AllowUserToOrderColumns = true;
            this.DgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(22, 49);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            this.DgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProdutos.Size = new System.Drawing.Size(987, 171);
            this.DgvProdutos.TabIndex = 21;
            this.DgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellClick);
            this.DgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.link);
            this.DgvProdutos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvProdutos_DataBindingComplete);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPesquisa.Location = new System.Drawing.Point(489, 16);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(311, 20);
            this.TxtPesquisa.TabIndex = 10;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtualizar.Location = new System.Drawing.Point(23, 64);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(100, 38);
            this.BtnAtualizar.TabIndex = 12;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // GrpDados
            // 
            this.GrpDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GrpDados.Controls.Add(this.LblID);
            this.GrpDados.Controls.Add(this.ChkFora);
            this.GrpDados.Controls.Add(this.label1);
            this.GrpDados.Controls.Add(this.TxtValorVenda);
            this.GrpDados.Controls.Add(this.TxtValorCusto);
            this.GrpDados.Controls.Add(this.label3);
            this.GrpDados.Controls.Add(this.label9);
            this.GrpDados.Controls.Add(this.label10);
            this.GrpDados.Controls.Add(this.CboFornecedor);
            this.GrpDados.Controls.Add(this.CboCategoria);
            this.GrpDados.Controls.Add(this.label4);
            this.GrpDados.Controls.Add(this.TxtEstoque);
            this.GrpDados.Controls.Add(this.TxtEstoqueMin);
            this.GrpDados.Controls.Add(this.TxtBarra);
            this.GrpDados.Controls.Add(this.TxtLink);
            this.GrpDados.Controls.Add(this.TxtProduto);
            this.GrpDados.Controls.Add(this.label6);
            this.GrpDados.Controls.Add(this.label14);
            this.GrpDados.Controls.Add(this.label2);
            this.GrpDados.Controls.Add(this.PicProduto);
            this.GrpDados.Controls.Add(this.label5);
            this.GrpDados.Controls.Add(this.label7);
            this.GrpDados.Location = new System.Drawing.Point(17, 7);
            this.GrpDados.Name = "GrpDados";
            this.GrpDados.Size = new System.Drawing.Size(848, 301);
            this.GrpDados.TabIndex = 13;
            this.GrpDados.TabStop = false;
            this.GrpDados.Enter += new System.EventHandler(this.GrpDados_Enter);
            // 
            // LblID
            // 
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblID.ForeColor = System.Drawing.Color.Green;
            this.LblID.Location = new System.Drawing.Point(75, 14);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(53, 20);
            this.LblID.TabIndex = 5;
            this.LblID.Text = "0";
            this.LblID.Click += new System.EventHandler(this.LblID_Click);
            // 
            // ChkFora
            // 
            this.ChkFora.AutoSize = true;
            this.ChkFora.Location = new System.Drawing.Point(424, 21);
            this.ChkFora.Name = "ChkFora";
            this.ChkFora.Size = new System.Drawing.Size(91, 17);
            this.ChkFora.TabIndex = 9;
            this.ChkFora.Text = "Fora de Linha";
            this.ChkFora.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // TxtValorVenda
            // 
            this.TxtValorVenda.Location = new System.Drawing.Point(145, 218);
            this.TxtValorVenda.Name = "TxtValorVenda";
            this.TxtValorVenda.Size = new System.Drawing.Size(101, 20);
            this.TxtValorVenda.TabIndex = 7;
            this.TxtValorVenda.Text = "R$ 0000,00";
            this.TxtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbersEvirgula);
            // 
            // TxtValorCusto
            // 
            this.TxtValorCusto.Location = new System.Drawing.Point(28, 218);
            this.TxtValorCusto.Name = "TxtValorCusto";
            this.TxtValorCusto.Size = new System.Drawing.Size(101, 20);
            this.TxtValorCusto.TabIndex = 6;
            this.TxtValorCusto.Text = "R$ 0000,00";
            this.TxtValorCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbersEvirgula);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor de Venda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Link";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Valor de Custo";
            // 
            // CboFornecedor
            // 
            this.CboFornecedor.FormattingEnabled = true;
            this.CboFornecedor.Location = new System.Drawing.Point(249, 114);
            this.CboFornecedor.Name = "CboFornecedor";
            this.CboFornecedor.Size = new System.Drawing.Size(200, 21);
            this.CboFornecedor.TabIndex = 3;
            // 
            // CboCategoria
            // 
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(26, 115);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(200, 21);
            this.CboCategoria.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Código de Barras";
            // 
            // TxtEstoque
            // 
            this.TxtEstoque.Location = new System.Drawing.Point(145, 167);
            this.TxtEstoque.MaxLength = 50;
            this.TxtEstoque.Name = "TxtEstoque";
            this.TxtEstoque.Size = new System.Drawing.Size(100, 20);
            this.TxtEstoque.TabIndex = 5;
            this.TxtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbersEvirgula);
            // 
            // TxtEstoqueMin
            // 
            this.TxtEstoqueMin.Location = new System.Drawing.Point(28, 167);
            this.TxtEstoqueMin.MaxLength = 50;
            this.TxtEstoqueMin.Name = "TxtEstoqueMin";
            this.TxtEstoqueMin.Size = new System.Drawing.Size(100, 20);
            this.TxtEstoqueMin.TabIndex = 4;
            this.TxtEstoqueMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumbersEvirgula);
            // 
            // TxtBarra
            // 
            this.TxtBarra.Location = new System.Drawing.Point(426, 64);
            this.TxtBarra.MaxLength = 14;
            this.TxtBarra.Name = "TxtBarra";
            this.TxtBarra.Size = new System.Drawing.Size(149, 20);
            this.TxtBarra.TabIndex = 1;
            // 
            // TxtLink
            // 
            this.TxtLink.Location = new System.Drawing.Point(26, 265);
            this.TxtLink.MaxLength = 100;
            this.TxtLink.Multiline = true;
            this.TxtLink.Name = "TxtLink";
            this.TxtLink.Size = new System.Drawing.Size(806, 20);
            this.TxtLink.TabIndex = 8;
            // 
            // TxtProduto
            // 
            this.TxtProduto.Location = new System.Drawing.Point(26, 64);
            this.TxtProduto.MaxLength = 40;
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(375, 20);
            this.TxtProduto.TabIndex = 0;
            this.TxtProduto.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Estoque";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Estoque Mínimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto";
            // 
            // PicProduto
            // 
            this.PicProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicProduto.Location = new System.Drawing.Point(636, 35);
            this.PicProduto.Name = "PicProduto";
            this.PicProduto.Size = new System.Drawing.Size(164, 175);
            this.PicProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicProduto.TabIndex = 2;
            this.PicProduto.TabStop = false;
            this.PicProduto.Click += new System.EventHandler(this.PicProduto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fornecedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Categoria";
            // 
            // GrpButton
            // 
            this.GrpButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GrpButton.Controls.Add(this.BtnCancelar);
            this.GrpButton.Controls.Add(this.BtnIncluir);
            this.GrpButton.Controls.Add(this.BtnFechar);
            this.GrpButton.Controls.Add(this.BtnExcluir);
            this.GrpButton.Controls.Add(this.BtnAtualizar);
            this.GrpButton.Controls.Add(this.BtnImprimir);
            this.GrpButton.Location = new System.Drawing.Point(900, 7);
            this.GrpButton.Name = "GrpButton";
            this.GrpButton.Size = new System.Drawing.Size(147, 301);
            this.GrpButton.TabIndex = 12;
            this.GrpButton.TabStop = false;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(23, 199);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(100, 38);
            this.BtnImprimir.TabIndex = 15;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // GrpGrid
            // 
            this.GrpGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpGrid.Controls.Add(this.DgvProdutos);
            this.GrpGrid.Controls.Add(this.label11);
            this.GrpGrid.Controls.Add(this.TxtPesquisa);
            this.GrpGrid.Location = new System.Drawing.Point(17, 313);
            this.GrpGrid.Name = "GrpGrid";
            this.GrpGrid.Size = new System.Drawing.Size(1030, 236);
            this.GrpGrid.TabIndex = 11;
            this.GrpGrid.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Digite o nome do Produto para pesquisa";
            // 
            // OfdProduto
            // 
            this.OfdProduto.FileName = "OpenFileDialog1";
            // 
            // OfdLink
            // 
            this.OfdLink.FileName = "openFileDialog1";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 563);
            this.Controls.Add(this.GrpDados);
            this.Controls.Add(this.GrpButton);
            this.Controls.Add(this.GrpGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.GrpDados.ResumeLayout(false);
            this.GrpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProduto)).EndInit();
            this.GrpButton.ResumeLayout(false);
            this.GrpGrid.ResumeLayout(false);
            this.GrpGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.GroupBox GrpDados;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.CheckBox ChkFora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtValorVenda;
        private System.Windows.Forms.TextBox TxtValorCusto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CboFornecedor;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEstoque;
        private System.Windows.Forms.TextBox TxtEstoqueMin;
        private System.Windows.Forms.TextBox TxtBarra;
        private System.Windows.Forms.TextBox TxtLink;
        private System.Windows.Forms.TextBox TxtProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GrpButton;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.GroupBox GrpGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog OfdProduto;
        private System.Windows.Forms.PictureBox PicProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog OfdLink;
    }
}