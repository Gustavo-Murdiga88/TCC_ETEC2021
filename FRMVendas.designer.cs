
using System;

namespace _200130_Projeto
{
    partial class FRMVendas
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
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.dvgProdutos = new System.Windows.Forms.DataGridView();
            this.CÓDIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnt_RemoverPRoduto = new System.Windows.Forms.Button();
            this.btn_InserirPRoduto = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Produtos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_estoque = new System.Windows.Forms.TextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.txt_UF = new System.Windows.Forms.TextBox();
            this.grbClientes = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.cbo_Clientes = new System.Windows.Forms.ComboBox();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            this.grbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.grbProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            this.ofdFoto.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdFoto_FileOk);
            // 
            // dvgProdutos
            // 
            this.dvgProdutos.AllowUserToAddRows = false;
            this.dvgProdutos.AllowUserToDeleteRows = false;
            this.dvgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CÓDIGO,
            this.PRODUTO,
            this.QTDE,
            this.VALOR});
            this.dvgProdutos.Location = new System.Drawing.Point(31, 425);
            this.dvgProdutos.Name = "dvgProdutos";
            this.dvgProdutos.ReadOnly = true;
            this.dvgProdutos.Size = new System.Drawing.Size(858, 254);
            this.dvgProdutos.TabIndex = 123;
            this.dvgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgclientes_CellContentClick);
            // 
            // CÓDIGO
            // 
            this.CÓDIGO.HeaderText = "CÓDIGO";
            this.CÓDIGO.Name = "CÓDIGO";
            this.CÓDIGO.ReadOnly = true;
            // 
            // PRODUTO
            // 
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            // 
            // QTDE
            // 
            this.QTDE.HeaderText = "QTDE";
            this.QTDE.Name = "QTDE";
            this.QTDE.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // bnt_RemoverPRoduto
            // 
            this.bnt_RemoverPRoduto.Location = new System.Drawing.Point(280, 144);
            this.bnt_RemoverPRoduto.Name = "bnt_RemoverPRoduto";
            this.bnt_RemoverPRoduto.Size = new System.Drawing.Size(75, 39);
            this.bnt_RemoverPRoduto.TabIndex = 116;
            this.bnt_RemoverPRoduto.Text = "Remover Produto";
            this.bnt_RemoverPRoduto.UseVisualStyleBackColor = true;
            this.bnt_RemoverPRoduto.Click += new System.EventHandler(this.bnt_RemoverPRoduto_Click);
            // 
            // btn_InserirPRoduto
            // 
            this.btn_InserirPRoduto.Location = new System.Drawing.Point(199, 144);
            this.btn_InserirPRoduto.Name = "btn_InserirPRoduto";
            this.btn_InserirPRoduto.Size = new System.Drawing.Size(75, 39);
            this.btn_InserirPRoduto.TabIndex = 114;
            this.btn_InserirPRoduto.Text = "Inserir Produto";
            this.btn_InserirPRoduto.UseVisualStyleBackColor = true;
            this.btn_InserirPRoduto.Click += new System.EventHandler(this.btn_InserirPRoduto_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 128;
            this.label2.Text = "Produto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbo_Produtos
            // 
            this.cbo_Produtos.FormattingEnabled = true;
            this.cbo_Produtos.Location = new System.Drawing.Point(105, 36);
            this.cbo_Produtos.Name = "cbo_Produtos";
            this.cbo_Produtos.Size = new System.Drawing.Size(374, 21);
            this.cbo_Produtos.TabIndex = 129;
            this.cbo_Produtos.SelectedIndexChanged += new System.EventHandler(this.cbo_Produtos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 130;
            this.label4.Text = "Quantidade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(105, 63);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(248, 20);
            this.txt_quantidade.TabIndex = 131;
            this.txt_quantidade.TextChanged += new System.EventHandler(this.txt_quantidade_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 132;
            this.label5.Text = "Preço";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(105, 89);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(248, 20);
            this.txt_preco.TabIndex = 133;
            this.txt_preco.TextChanged += new System.EventHandler(this.txt_preco_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 134;
            this.label7.Text = "Estoque";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_estoque
            // 
            this.txt_estoque.Location = new System.Drawing.Point(105, 115);
            this.txt_estoque.Name = "txt_estoque";
            this.txt_estoque.Size = new System.Drawing.Size(248, 20);
            this.txt_estoque.TabIndex = 135;
            this.txt_estoque.TextChanged += new System.EventHandler(this.txt_estoque_TextChanged);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(236, 122);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(86, 20);
            this.mtbCPF.TabIndex = 106;
            this.mtbCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCPF_MaskInputRejected);
            // 
            // mtbDataNascimento
            // 
            this.mtbDataNascimento.Location = new System.Drawing.Point(99, 122);
            this.mtbDataNascimento.Mask = "00/00/0000";
            this.mtbDataNascimento.Name = "mtbDataNascimento";
            this.mtbDataNascimento.Size = new System.Drawing.Size(79, 20);
            this.mtbDataNascimento.TabIndex = 108;
            this.mtbDataNascimento.ValidatingType = typeof(System.DateTime);
            this.mtbDataNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbDataNascimento_MaskInputRejected);
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(74, 87);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(134, 20);
            this.txt_cidade.TabIndex = 112;
            this.txt_cidade.TextChanged += new System.EventHandler(this.txt_cidade_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 105;
            this.label11.Text = "CPF ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 107;
            this.label12.Text = "Data Nascimento";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 111;
            this.label15.Text = "Cidade";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(74, 52);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(335, 20);
            this.txt_endereco.TabIndex = 101;
            this.txt_endereco.TextChanged += new System.EventHandler(this.txt_endereco_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "Endereço";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(389, 122);
            this.mtbCelular.Mask = "(00) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(90, 20);
            this.mtbCelular.TabIndex = 122;
            this.mtbCelular.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCelular_MaskInputRejected);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(337, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 121;
            this.label18.Text = "Celular";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // picCliente
            // 
            this.picCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCliente.Location = new System.Drawing.Point(543, 17);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(198, 146);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCliente.TabIndex = 125;
            this.picCliente.TabStop = false;
            this.picCliente.Click += new System.EventHandler(this.picCliente_Click);
            // 
            // txt_UF
            // 
            this.txt_UF.Location = new System.Drawing.Point(255, 87);
            this.txt_UF.Name = "txt_UF";
            this.txt_UF.Size = new System.Drawing.Size(100, 20);
            this.txt_UF.TabIndex = 110;
            this.txt_UF.TextChanged += new System.EventHandler(this.txt_UF_TextChanged);
            // 
            // grbClientes
            // 
            this.grbClientes.Controls.Add(this.label8);
            this.grbClientes.Controls.Add(this.btn_confirmar);
            this.grbClientes.Controls.Add(this.cbo_Clientes);
            this.grbClientes.Controls.Add(this.txt_UF);
            this.grbClientes.Controls.Add(this.picCliente);
            this.grbClientes.Controls.Add(this.label18);
            this.grbClientes.Controls.Add(this.mtbCelular);
            this.grbClientes.Controls.Add(this.label1);
            this.grbClientes.Controls.Add(this.label3);
            this.grbClientes.Controls.Add(this.txt_endereco);
            this.grbClientes.Controls.Add(this.label15);
            this.grbClientes.Controls.Add(this.label12);
            this.grbClientes.Controls.Add(this.label11);
            this.grbClientes.Controls.Add(this.txt_cidade);
            this.grbClientes.Controls.Add(this.mtbDataNascimento);
            this.grbClientes.Controls.Add(this.mtbCPF);
            this.grbClientes.Location = new System.Drawing.Point(31, 12);
            this.grbClientes.Name = "grbClientes";
            this.grbClientes.Size = new System.Drawing.Size(858, 193);
            this.grbClientes.TabIndex = 128;
            this.grbClientes.TabStop = false;
            this.grbClientes.Enter += new System.EventHandler(this.grbClientes_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 138;
            this.label8.Text = "UF";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(379, 148);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(83, 45);
            this.btn_confirmar.TabIndex = 137;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // cbo_Clientes
            // 
            this.cbo_Clientes.FormattingEnabled = true;
            this.cbo_Clientes.Location = new System.Drawing.Point(74, 17);
            this.cbo_Clientes.Name = "cbo_Clientes";
            this.cbo_Clientes.Size = new System.Drawing.Size(374, 21);
            this.cbo_Clientes.TabIndex = 136;
            this.cbo_Clientes.SelectedIndexChanged += new System.EventHandler(this.cbo_Clientes_SelectedIndexChanged);
            // 
            // picProduto
            // 
            this.picProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProduto.Location = new System.Drawing.Point(543, 39);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(198, 146);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduto.TabIndex = 140;
            this.picProduto.TabStop = false;
            this.picProduto.Click += new System.EventHandler(this.picProduto_Click);
            // 
            // grbProdutos
            // 
            this.grbProdutos.Controls.Add(this.btn_Gravar);
            this.grbProdutos.Controls.Add(this.btn_fechar);
            this.grbProdutos.Controls.Add(this.btn_cancelar);
            this.grbProdutos.Controls.Add(this.cbo_Produtos);
            this.grbProdutos.Controls.Add(this.picProduto);
            this.grbProdutos.Controls.Add(this.btn_InserirPRoduto);
            this.grbProdutos.Controls.Add(this.label7);
            this.grbProdutos.Controls.Add(this.bnt_RemoverPRoduto);
            this.grbProdutos.Controls.Add(this.txt_estoque);
            this.grbProdutos.Controls.Add(this.label2);
            this.grbProdutos.Controls.Add(this.label5);
            this.grbProdutos.Controls.Add(this.txt_quantidade);
            this.grbProdutos.Controls.Add(this.txt_preco);
            this.grbProdutos.Controls.Add(this.label4);
            this.grbProdutos.Location = new System.Drawing.Point(31, 211);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Size = new System.Drawing.Size(858, 208);
            this.grbProdutos.TabIndex = 141;
            this.grbProdutos.TabStop = false;
            this.grbProdutos.Enter += new System.EventHandler(this.grbProdutos_Enter);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(118, 146);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(75, 37);
            this.btn_Gravar.TabIndex = 143;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(454, 142);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 41);
            this.btn_fechar.TabIndex = 142;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(361, 144);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 39);
            this.btn_cancelar.TabIndex = 141;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 711);
            this.label6.MaximumSize = new System.Drawing.Size(1580, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 142;
            this.label6.Text = "Total:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_resultado.Location = new System.Drawing.Point(80, 706);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(91, 20);
            this.lbl_resultado.TabIndex = 143;
            this.lbl_resultado.Text = "Resultado";
            this.lbl_resultado.Click += new System.EventHandler(this.lbl_resultado_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // FRMVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 745);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grbProdutos);
            this.Controls.Add(this.grbClientes);
            this.Controls.Add(this.dvgProdutos);
            this.Name = "FRMVendas";
            this.Text = "FrmVendas";
            this.Load += new System.EventHandler(this.FRMVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            this.grbClientes.ResumeLayout(false);
            this.grbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.grbProdutos.ResumeLayout(false);
            this.grbProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void grbProdutos_Enter(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.DataGridView dvgProdutos;
        private System.Windows.Forms.Button bnt_RemoverPRoduto;
        private System.Windows.Forms.Button btn_InserirPRoduto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Produtos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_estoque;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbDataNascimento;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.TextBox txt_UF;
        private System.Windows.Forms.GroupBox grbClientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.ComboBox cbo_Clientes;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.GroupBox grbProdutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CÓDIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_Gravar;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

