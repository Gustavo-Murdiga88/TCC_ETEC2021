
namespace _200130_Projeto
{
    partial class FrmFornecedores
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
            this.GrpGrid = new System.Windows.Forms.GroupBox();
            this.DgvFornecedores = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.GrpDados = new System.Windows.Forms.GroupBox();
            this.LblUF = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboCidade = new System.Windows.Forms.ComboBox();
            this.MtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.MtbIE = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtFantasia = new System.Windows.Forms.TextBox();
            this.TxtContato = new System.Windows.Forms.TextBox();

            this.TxtRazaoSocial = new System.Windows.Forms.TextBox();
            this.MtbTel = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrpButton = new System.Windows.Forms.GroupBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();

            this.GrpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedores)).BeginInit();
            this.GrpDados.SuspendLayout();
            this.GrpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpGrid
            // 
            this.GrpGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpGrid.Controls.Add(this.DgvFornecedores);
            this.GrpGrid.Controls.Add(this.label11);
            this.GrpGrid.Controls.Add(this.TxtPesquisa);
            this.GrpGrid.Location = new System.Drawing.Point(9, 308);
            this.GrpGrid.Name = "GrpGrid";
            this.GrpGrid.Size = new System.Drawing.Size(1094, 279);
            this.GrpGrid.TabIndex = 11;
            this.GrpGrid.TabStop = false;
            // 
            // DgvFornecedores
            // 
            this.DgvFornecedores.AllowUserToAddRows = false;
            this.DgvFornecedores.AllowUserToDeleteRows = false;
            this.DgvFornecedores.AllowUserToOrderColumns = true;
            this.DgvFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFornecedores.Location = new System.Drawing.Point(21, 70);
            this.DgvFornecedores.Name = "DgvFornecedores";
            this.DgvFornecedores.ReadOnly = true;
            this.DgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFornecedores.Size = new System.Drawing.Size(1051, 199);
            this.DgvFornecedores.TabIndex = 21;
            this.DgvFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFornecedores_CellClick);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Digite o nome do Fornecedor para pesquisa";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPesquisa.Location = new System.Drawing.Point(473, 22);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(375, 20);

            this.TxtPesquisa.TabIndex = 16;

            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            this.TxtPesquisa.Enter += new System.EventHandler(this.Textbox);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(23, 102);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 38);

            this.BtnCancelar.TabIndex = 12;

            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(23, 12);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(100, 38);

            this.BtnIncluir.TabIndex = 10;

            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // GrpDados
            // 
            this.GrpDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpDados.Controls.Add(this.LblUF);
            this.GrpDados.Controls.Add(this.LblID);
            this.GrpDados.Controls.Add(this.label1);
            this.GrpDados.Controls.Add(this.CboCidade);
            this.GrpDados.Controls.Add(this.MtbCNPJ);
            this.GrpDados.Controls.Add(this.MtbIE);
            this.GrpDados.Controls.Add(this.TxtEmail);
            this.GrpDados.Controls.Add(this.TxtFantasia);
            this.GrpDados.Controls.Add(this.TxtContato);
            this.GrpDados.Controls.Add(this.TxtRazaoSocial);
            this.GrpDados.Controls.Add(this.MtbTel);
            this.GrpDados.Controls.Add(this.label13);
            this.GrpDados.Controls.Add(this.label8);
            this.GrpDados.Controls.Add(this.label14);
            this.GrpDados.Controls.Add(this.label4);
            this.GrpDados.Controls.Add(this.label2);
            this.GrpDados.Controls.Add(this.label12);
            this.GrpDados.Controls.Add(this.label9);
            this.GrpDados.Controls.Add(this.TxtBairro);
            this.GrpDados.Controls.Add(this.TxtEndereco);
            this.GrpDados.Controls.Add(this.label5);
            this.GrpDados.Controls.Add(this.label6);
            this.GrpDados.Controls.Add(this.label15);
            this.GrpDados.Controls.Add(this.label3);
            this.GrpDados.Location = new System.Drawing.Point(9, 15);
            this.GrpDados.Name = "GrpDados";
            this.GrpDados.Size = new System.Drawing.Size(818, 287);
            this.GrpDados.TabIndex = 13;
            this.GrpDados.TabStop = false;
            // 
            // LblUF
            // 
            this.LblUF.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LblUF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LblUF.Location = new System.Drawing.Point(249, 243);
            this.LblUF.Name = "LblUF";
            this.LblUF.Size = new System.Drawing.Size(53, 21);
            this.LblUF.TabIndex = 11;
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
            // CboCidade
            // 
            this.CboCidade.FormattingEnabled = true;
            this.CboCidade.Location = new System.Drawing.Point(29, 243);
            this.CboCidade.Name = "CboCidade";
            this.CboCidade.Size = new System.Drawing.Size(200, 21);

            this.CboCidade.TabIndex = 9;

            this.CboCidade.SelectedIndexChanged += new System.EventHandler(this.CboCidade_SelectedIndexChanged);
            // 
            // MtbCNPJ
            // 
            this.MtbCNPJ.Location = new System.Drawing.Point(28, 110);
            this.MtbCNPJ.Mask = "00,000,000/0000-00";
            this.MtbCNPJ.Name = "MtbCNPJ";
            this.MtbCNPJ.Size = new System.Drawing.Size(114, 20);
            this.MtbCNPJ.TabIndex = 2;
            this.MtbCNPJ.Enter += new System.EventHandler(this.Textbox);
            // 
            // MtbIE
            // 
            this.MtbIE.Location = new System.Drawing.Point(168, 110);
            this.MtbIE.Mask = "00000000-00";
            this.MtbIE.Name = "MtbIE";
            this.MtbIE.Size = new System.Drawing.Size(82, 20);
            this.MtbIE.TabIndex = 3;
            this.MtbIE.Enter += new System.EventHandler(this.Textbox);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(28, 156);
            this.TxtEmail.MaxLength = 50;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(395, 20);
            this.TxtEmail.TabIndex = 6;
            this.TxtEmail.Enter += new System.EventHandler(this.Textbox);
            // 
            // TxtFantasia
            // 
            this.TxtFantasia.Location = new System.Drawing.Point(427, 64);
            this.TxtFantasia.MaxLength = 30;
            this.TxtFantasia.Name = "TxtFantasia";
            this.TxtFantasia.Size = new System.Drawing.Size(279, 20);

            this.TxtFantasia.TabIndex = 1;
            this.TxtFantasia.Enter += new System.EventHandler(this.Textbox);
            this.TxtFantasia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRazaoSocial_KeyPress);
            // 
            // TxtContato
            // 
            this.TxtContato.Location = new System.Drawing.Point(422, 110);
            this.TxtContato.MaxLength = 40;
            this.TxtContato.Name = "TxtContato";
            this.TxtContato.Size = new System.Drawing.Size(374, 20);
            this.TxtContato.TabIndex = 5;
            this.TxtContato.Enter += new System.EventHandler(this.Textbox);
            this.TxtContato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRazaoSocial_KeyPress);
            // 

            // TxtRazaoSocial
            // 
            this.TxtRazaoSocial.Location = new System.Drawing.Point(26, 64);
            this.TxtRazaoSocial.MaxLength = 40;
            this.TxtRazaoSocial.Name = "TxtRazaoSocial";
            this.TxtRazaoSocial.Size = new System.Drawing.Size(375, 20);
            this.TxtRazaoSocial.TabIndex = 0;
            this.TxtRazaoSocial.Enter += new System.EventHandler(this.Textbox);
            this.TxtRazaoSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRazaoSocial_KeyPress);
            // 
            // MtbTel
            // 
            this.MtbTel.Location = new System.Drawing.Point(281, 110);
            this.MtbTel.Mask = "(00)00000-0000";
            this.MtbTel.Name = "MtbTel";
            this.MtbTel.Size = new System.Drawing.Size(120, 20);
            this.MtbTel.TabIndex = 4;
            this.MtbTel.Enter += new System.EventHandler(this.Textbox);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(419, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Contato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Telefone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome Fantasia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razão Social";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "CNPJ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "I.E.";
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(383, 200);
            this.TxtBairro.MaxLength = 30;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(268, 20);
            this.TxtBairro.TabIndex = 8;

            this.TxtBairro.Enter += new System.EventHandler(this.Textbox);
            this.TxtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRazaoSocial_KeyPress);
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(26, 200);
            this.TxtEndereco.MaxLength = 40;
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(334, 20);
            this.TxtEndereco.TabIndex = 7;

            this.TxtEndereco.Enter += new System.EventHandler(this.Textbox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "UF";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(380, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Bairro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Endereço";
            // 
            // GrpButton
            // 
            this.GrpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpButton.Controls.Add(this.BtnCancelar);
            this.GrpButton.Controls.Add(this.BtnIncluir);
            this.GrpButton.Controls.Add(this.BtnFechar);
            this.GrpButton.Controls.Add(this.BtnExcluir);
            this.GrpButton.Controls.Add(this.BtnAtualizar);
            this.GrpButton.Controls.Add(this.BtnImprimir);
            this.GrpButton.Location = new System.Drawing.Point(863, 15);
            this.GrpButton.Name = "GrpButton";
            this.GrpButton.Size = new System.Drawing.Size(147, 287);
            this.GrpButton.TabIndex = 12;
            this.GrpButton.TabStop = false;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(23, 237);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(100, 38);
            this.BtnFechar.TabIndex = 15;

            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(23, 147);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(100, 38);
            this.BtnExcluir.TabIndex = 13;

            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtualizar.Location = new System.Drawing.Point(23, 57);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(100, 38);
            this.BtnAtualizar.TabIndex = 11;

            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(23, 192);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(100, 38);
            this.BtnImprimir.TabIndex = 14;

            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 

            // TxtContato
            // 
            this.TxtContato.Location = new System.Drawing.Point(422, 110);
            this.TxtContato.MaxLength = 40;
            this.TxtContato.Name = "TxtContato";
            this.TxtContato.Size = new System.Drawing.Size(374, 20);
            this.TxtContato.TabIndex = 5;
            this.TxtContato.Enter += new System.EventHandler(this.Textbox);
            this.TxtContato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRazaoSocial_KeyPress);
            // 

            // FrmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 602);
            this.Controls.Add(this.GrpGrid);
            this.Controls.Add(this.GrpDados);
            this.Controls.Add(this.GrpButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFornecedores_Load);
            this.GrpGrid.ResumeLayout(false);
            this.GrpGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedores)).EndInit();
            this.GrpDados.ResumeLayout(false);
            this.GrpDados.PerformLayout();
            this.GrpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpGrid;
        private System.Windows.Forms.DataGridView DgvFornecedores;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.GroupBox GrpDados;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboCidade;
        private System.Windows.Forms.MaskedTextBox MtbCNPJ;
        private System.Windows.Forms.MaskedTextBox MtbIE;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtRazaoSocial;
        private System.Windows.Forms.MaskedTextBox MtbTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GrpButton;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.TextBox TxtFantasia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblUF;
        private System.Windows.Forms.TextBox TxtContato;
    }
}