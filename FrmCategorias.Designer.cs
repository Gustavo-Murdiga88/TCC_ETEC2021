
namespace _200130_Projeto
{
    partial class FrmCategorias
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
            this.LblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvCategorias = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.GrpInsert = new System.Windows.Forms.GroupBox();
            this.GrpButtons = new System.Windows.Forms.GroupBox();
            this.GrpGrid = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).BeginInit();
            this.GrpInsert.SuspendLayout();
            this.GrpButtons.SuspendLayout();
            this.GrpGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblID.ForeColor = System.Drawing.Color.Green;
            this.LblID.Location = new System.Drawing.Point(59, 19);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(78, 20);
            this.LblID.TabIndex = 7;
            this.LblID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(156, 42);
            this.TxtCategoria.MaxLength = 30;
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(340, 20);
            this.TxtCategoria.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // DgvCategorias
            // 
            this.DgvCategorias.AllowUserToAddRows = false;
            this.DgvCategorias.AllowUserToDeleteRows = false;
            this.DgvCategorias.AllowUserToOrderColumns = true;
            this.DgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvCategorias.Location = new System.Drawing.Point(21, 67);
            this.DgvCategorias.Name = "DgvCategorias";
            this.DgvCategorias.ReadOnly = true;
            this.DgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCategorias.Size = new System.Drawing.Size(532, 204);
            this.DgvCategorias.TabIndex = 22;
            this.DgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(234, 26);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 38);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(6, 26);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(100, 38);
            this.BtnIncluir.TabIndex = 1;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFechar.Location = new System.Drawing.Point(462, 26);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(100, 38);
            this.BtnFechar.TabIndex = 5;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(348, 26);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(100, 38);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtualizar.Location = new System.Drawing.Point(120, 26);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(100, 38);
            this.BtnAtualizar.TabIndex = 2;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // GrpInsert
            // 
            this.GrpInsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GrpInsert.Controls.Add(this.TxtCategoria);
            this.GrpInsert.Controls.Add(this.label1);
            this.GrpInsert.Controls.Add(this.LblID);
            this.GrpInsert.Controls.Add(this.label2);
            this.GrpInsert.Location = new System.Drawing.Point(12, 12);
            this.GrpInsert.Name = "GrpInsert";
            this.GrpInsert.Size = new System.Drawing.Size(569, 89);
            this.GrpInsert.TabIndex = 29;
            this.GrpInsert.TabStop = false;
            this.GrpInsert.Enter += new System.EventHandler(this.GrpInsert_Enter);
            // 
            // GrpButtons
            // 
            this.GrpButtons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GrpButtons.Controls.Add(this.BtnAtualizar);
            this.GrpButtons.Controls.Add(this.BtnExcluir);
            this.GrpButtons.Controls.Add(this.BtnCancelar);
            this.GrpButtons.Controls.Add(this.BtnFechar);
            this.GrpButtons.Controls.Add(this.BtnIncluir);
            this.GrpButtons.Location = new System.Drawing.Point(12, 107);
            this.GrpButtons.Name = "GrpButtons";
            this.GrpButtons.Size = new System.Drawing.Size(569, 81);
            this.GrpButtons.TabIndex = 30;
            this.GrpButtons.TabStop = false;
            // 
            // GrpGrid
            // 
            this.GrpGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpGrid.Controls.Add(this.label11);
            this.GrpGrid.Controls.Add(this.TxtPesquisa);
            this.GrpGrid.Controls.Add(this.DgvCategorias);
            this.GrpGrid.Location = new System.Drawing.Point(12, 194);
            this.GrpGrid.Name = "GrpGrid";
            this.GrpGrid.Size = new System.Drawing.Size(571, 292);
            this.GrpGrid.TabIndex = 31;
            this.GrpGrid.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Digite a descrição para pesquisa";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(199, 32);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(354, 20);
            this.TxtPesquisa.TabIndex = 6;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 495);
            this.Controls.Add(this.GrpGrid);
            this.Controls.Add(this.GrpButtons);
            this.Controls.Add(this.GrpInsert);
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).EndInit();
            this.GrpInsert.ResumeLayout(false);
            this.GrpInsert.PerformLayout();
            this.GrpButtons.ResumeLayout(false);
            this.GrpGrid.ResumeLayout(false);
            this.GrpGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvCategorias;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.GroupBox GrpInsert;
        private System.Windows.Forms.GroupBox GrpButtons;
        private System.Windows.Forms.GroupBox GrpGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPesquisa;
    }
}