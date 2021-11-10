
namespace _200130_Projeto
{
    partial class FrmClientes
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MtbDataNasci = new System.Windows.Forms.MaskedTextBox();
            this.CboCidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MtbTel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GrpGrid = new System.Windows.Forms.GroupBox();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.GrpButton = new System.Windows.Forms.GroupBox();
            this.GrpDados = new System.Windows.Forms.GroupBox();
            this.LblUF = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.ChkBloq = new System.Windows.Forms.CheckBox();
            this.TxtRenda = new System.Windows.Forms.TextBox();
            this.MtbRG = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.MtbCel = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.OfdCliente = new System.Windows.Forms.OpenFileDialog();
            this.GrpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.GrpButton.SuspendLayout();
            this.GrpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            this.SuspendLayout();
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
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(26, 64);
            this.TxtNome.MaxLength = 40;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(375, 20);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.Enter += new System.EventHandler(this.TextBox);
            this.TxtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetters);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(26, 200);
            this.TxtEndereco.MaxLength = 40;
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(334, 20);
            this.TxtEndereco.TabIndex = 8;
            this.TxtEndereco.Enter += new System.EventHandler(this.TextBox);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data de Nascimento";
            // 
            // MtbDataNasci
            // 
            this.MtbDataNasci.Location = new System.Drawing.Point(426, 64);
            this.MtbDataNasci.Mask = "00/00/0000";
            this.MtbDataNasci.Name = "MtbDataNasci";
            this.MtbDataNasci.Size = new System.Drawing.Size(101, 20);
            this.MtbDataNasci.TabIndex = 1;
            this.MtbDataNasci.ValidatingType = typeof(System.DateTime);
            this.MtbDataNasci.Enter += new System.EventHandler(this.TextBox);
            // 
            // CboCidade
            // 
            this.CboCidade.FormattingEnabled = true;
            this.CboCidade.Location = new System.Drawing.Point(29, 243);
            this.CboCidade.Name = "CboCidade";
            this.CboCidade.Size = new System.Drawing.Size(200, 21);
            this.CboCidade.TabIndex = 10;
            this.CboCidade.SelectedIndexChanged += new System.EventHandler(this.CboCidade_SelectedIndexChanged);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Telefone";
            // 
            // MtbTel
            // 
            this.MtbTel.Location = new System.Drawing.Point(266, 110);
            this.MtbTel.Mask = "(00)00000-0000";
            this.MtbTel.Name = "MtbTel";
            this.MtbTel.Size = new System.Drawing.Size(120, 20);
            this.MtbTel.TabIndex = 4;
            this.MtbTel.Enter += new System.EventHandler(this.TextBox);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "CPF";
            // 
            // MtbCPF
            // 
            this.MtbCPF.Location = new System.Drawing.Point(148, 110);
            this.MtbCPF.Mask = "000,000,000-00";
            this.MtbCPF.Name = "MtbCPF";
            this.MtbCPF.Size = new System.Drawing.Size(99, 20);
            this.MtbCPF.TabIndex = 3;
            this.MtbCPF.Enter += new System.EventHandler(this.TextBox);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Renda";
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(23, 12);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(100, 38);
            this.BtnIncluir.TabIndex = 13;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(23, 102);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 38);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(23, 147);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(100, 38);
            this.BtnExcluir.TabIndex = 16;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(23, 192);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(100, 38);
            this.BtnImprimir.TabIndex = 17;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(23, 237);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(100, 38);
            this.BtnFechar.TabIndex = 20;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // GrpGrid
            // 
            this.GrpGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpGrid.Controls.Add(this.DgvClientes);
            this.GrpGrid.Controls.Add(this.label11);
            this.GrpGrid.Controls.Add(this.TxtPesquisa);
            this.GrpGrid.Location = new System.Drawing.Point(11, 305);
            this.GrpGrid.Name = "GrpGrid";
            this.GrpGrid.Size = new System.Drawing.Size(1094, 279);
            this.GrpGrid.TabIndex = 7;
            this.GrpGrid.TabStop = false;
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.AllowUserToOrderColumns = true;
            this.DgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(21, 70);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(1051, 199);
            this.DgvClientes.TabIndex = 21;
            this.DgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Digite o nome do Cliente para pesquisa";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPesquisa.Location = new System.Drawing.Point(473, 22);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(375, 20);
            this.TxtPesquisa.TabIndex = 18;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.Text_Pesquisar);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtualizar.Location = new System.Drawing.Point(23, 57);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(100, 38);
            this.BtnAtualizar.TabIndex = 14;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
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
            this.GrpButton.Location = new System.Drawing.Point(826, 12);
            this.GrpButton.Name = "GrpButton";
            this.GrpButton.Size = new System.Drawing.Size(147, 287);
            this.GrpButton.TabIndex = 9;
            this.GrpButton.TabStop = false;
            // 
            // GrpDados
            // 
            this.GrpDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpDados.Controls.Add(this.LblUF);
            this.GrpDados.Controls.Add(this.LblID);
            this.GrpDados.Controls.Add(this.ChkBloq);
            this.GrpDados.Controls.Add(this.label1);
            this.GrpDados.Controls.Add(this.TxtRenda);
            this.GrpDados.Controls.Add(this.label10);
            this.GrpDados.Controls.Add(this.CboCidade);
            this.GrpDados.Controls.Add(this.label4);
            this.GrpDados.Controls.Add(this.MtbRG);
            this.GrpDados.Controls.Add(this.MtbCPF);
            this.GrpDados.Controls.Add(this.TxtEmail);
            this.GrpDados.Controls.Add(this.TxtNome);
            this.GrpDados.Controls.Add(this.MtbCel);
            this.GrpDados.Controls.Add(this.MtbTel);
            this.GrpDados.Controls.Add(this.label13);
            this.GrpDados.Controls.Add(this.label8);
            this.GrpDados.Controls.Add(this.MtbDataNasci);
            this.GrpDados.Controls.Add(this.label14);
            this.GrpDados.Controls.Add(this.label2);
            this.GrpDados.Controls.Add(this.PicFoto);
            this.GrpDados.Controls.Add(this.label12);
            this.GrpDados.Controls.Add(this.label9);
            this.GrpDados.Controls.Add(this.TxtBairro);
            this.GrpDados.Controls.Add(this.TxtEndereco);
            this.GrpDados.Controls.Add(this.label5);
            this.GrpDados.Controls.Add(this.label6);
            this.GrpDados.Controls.Add(this.label15);
            this.GrpDados.Controls.Add(this.label3);
            this.GrpDados.Location = new System.Drawing.Point(11, 12);
            this.GrpDados.Name = "GrpDados";
            this.GrpDados.Size = new System.Drawing.Size(773, 287);
            this.GrpDados.TabIndex = 10;
            this.GrpDados.TabStop = false;
            // 
            // LblUF
            // 
            this.LblUF.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LblUF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LblUF.Location = new System.Drawing.Point(249, 245);
            this.LblUF.Name = "LblUF";
            this.LblUF.Size = new System.Drawing.Size(53, 21);
            this.LblUF.TabIndex = 12;
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
            // ChkBloq
            // 
            this.ChkBloq.AutoSize = true;
            this.ChkBloq.Location = new System.Drawing.Point(424, 21);
            this.ChkBloq.Name = "ChkBloq";
            this.ChkBloq.Size = new System.Drawing.Size(77, 17);
            this.ChkBloq.TabIndex = 12;
            this.ChkBloq.Text = "Bloqueado";
            this.ChkBloq.UseVisualStyleBackColor = true;
            // 
            // TxtRenda
            // 
            this.TxtRenda.Location = new System.Drawing.Point(440, 156);
            this.TxtRenda.Name = "TxtRenda";
            this.TxtRenda.Size = new System.Drawing.Size(101, 20);
            this.TxtRenda.TabIndex = 7;
            this.TxtRenda.Text = "0.00";
            this.TxtRenda.Enter += new System.EventHandler(this.TextBox);
            // 
            // MtbRG
            // 
            this.MtbRG.Location = new System.Drawing.Point(28, 110);
            this.MtbRG.Mask = "00,000,000-0";
            this.MtbRG.Name = "MtbRG";
            this.MtbRG.Size = new System.Drawing.Size(99, 20);
            this.MtbRG.TabIndex = 2;
            this.MtbRG.Enter += new System.EventHandler(this.TextBox);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(28, 156);
            this.TxtEmail.MaxLength = 50;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(395, 20);
            this.TxtEmail.TabIndex = 6;
            this.TxtEmail.Enter += new System.EventHandler(this.TextBox);
            // 
            // MtbCel
            // 
            this.MtbCel.Location = new System.Drawing.Point(407, 110);
            this.MtbCel.Mask = "(00)00000-0000";
            this.MtbCel.Name = "MtbCel";
            this.MtbCel.Size = new System.Drawing.Size(120, 20);
            this.MtbCel.TabIndex = 5;
            this.MtbCel.Enter += new System.EventHandler(this.TextBox);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(404, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Celular";
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
            // PicFoto
            // 
            this.PicFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicFoto.Location = new System.Drawing.Point(585, 19);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(164, 175);
            this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFoto.TabIndex = 2;
            this.PicFoto.TabStop = false;
            this.PicFoto.Click += new System.EventHandler(this.PicFoto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "RG";
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(383, 200);
            this.TxtBairro.MaxLength = 30;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(268, 20);
            this.TxtBairro.TabIndex = 9;
            this.TxtBairro.Enter += new System.EventHandler(this.TextBox);
            this.TxtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetters);
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
            // OfdCliente
            // 
            this.OfdCliente.FileName = "OpenFileDialog1";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 602);
            this.Controls.Add(this.GrpDados);
            this.Controls.Add(this.GrpButton);
            this.Controls.Add(this.GrpGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.GrpGrid.ResumeLayout(false);
            this.GrpGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.GrpButton.ResumeLayout(false);
            this.GrpDados.ResumeLayout(false);
            this.GrpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PicFoto;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MtbDataNasci;
        private System.Windows.Forms.ComboBox CboCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MtbTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox MtbCPF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.GroupBox GrpGrid;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.GroupBox GrpButton;
        private System.Windows.Forms.GroupBox GrpDados;
        private System.Windows.Forms.CheckBox ChkBloq;
        private System.Windows.Forms.OpenFileDialog OfdCliente;
        private System.Windows.Forms.MaskedTextBox MtbRG;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.MaskedTextBox MtbCel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtRenda;
        private System.Windows.Forms.Label LblUF;
    }
}