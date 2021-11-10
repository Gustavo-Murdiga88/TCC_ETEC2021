
namespace _200130_Projeto
{
    partial class FrmCaixa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Venda = new System.Windows.Forms.TextBox();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.txt_nomeCliente = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.txt_Dinheiro = new System.Windows.Forms.TextBox();
            this.txt_Cheque = new System.Windows.Forms.TextBox();
            this.txt_Cartao = new System.Windows.Forms.TextBox();
            this.txt_Troco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Troco";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Realizar Pagamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Venda
            // 
            this.txt_Venda.Location = new System.Drawing.Point(75, 62);
            this.txt_Venda.Name = "txt_Venda";
            this.txt_Venda.Size = new System.Drawing.Size(113, 20);
            this.txt_Venda.TabIndex = 6;
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Location = new System.Drawing.Point(75, 24);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(113, 20);
            this.txt_Cliente.TabIndex = 7;
            // 
            // txt_nomeCliente
            // 
            this.txt_nomeCliente.Location = new System.Drawing.Point(194, 24);
            this.txt_nomeCliente.Name = "txt_nomeCliente";
            this.txt_nomeCliente.Size = new System.Drawing.Size(382, 20);
            this.txt_nomeCliente.TabIndex = 8;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(250, 62);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(326, 20);
            this.txt_Valor.TabIndex = 9;
            // 
            // txt_Dinheiro
            // 
            this.txt_Dinheiro.Location = new System.Drawing.Point(86, 26);
            this.txt_Dinheiro.Multiline = true;
            this.txt_Dinheiro.Name = "txt_Dinheiro";
            this.txt_Dinheiro.Size = new System.Drawing.Size(326, 35);
            this.txt_Dinheiro.TabIndex = 10;
            this.txt_Dinheiro.TextChanged += new System.EventHandler(this.txt_Dinheiro_TextChanged);
            // 
            // txt_Cheque
            // 
            this.txt_Cheque.Location = new System.Drawing.Point(86, 67);
            this.txt_Cheque.Multiline = true;
            this.txt_Cheque.Name = "txt_Cheque";
            this.txt_Cheque.Size = new System.Drawing.Size(326, 39);
            this.txt_Cheque.TabIndex = 11;
            this.txt_Cheque.TextChanged += new System.EventHandler(this.txt_Cheque_TextChanged);
            // 
            // txt_Cartao
            // 
            this.txt_Cartao.Location = new System.Drawing.Point(86, 112);
            this.txt_Cartao.Multiline = true;
            this.txt_Cartao.Name = "txt_Cartao";
            this.txt_Cartao.Size = new System.Drawing.Size(326, 38);
            this.txt_Cartao.TabIndex = 12;
            this.txt_Cartao.TextChanged += new System.EventHandler(this.txt_Cartao_TextChanged);
            // 
            // txt_Troco
            // 
            this.txt_Troco.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Troco.Location = new System.Drawing.Point(154, 275);
            this.txt_Troco.Multiline = true;
            this.txt_Troco.Name = "txt_Troco";
            this.txt_Troco.Size = new System.Drawing.Size(326, 39);
            this.txt_Troco.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dinheiro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cartão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cheque";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Dinheiro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Cheque);
            this.groupBox1.Controls.Add(this.txt_Cartao);
            this.groupBox1.Location = new System.Drawing.Point(69, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 169);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas de Pagamento";
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Troco);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.txt_nomeCliente);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.txt_Venda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmCaixa";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.FrmCaixa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Venda;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.TextBox txt_nomeCliente;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.TextBox txt_Dinheiro;
        private System.Windows.Forms.TextBox txt_Cheque;
        private System.Windows.Forms.TextBox txt_Cartao;
        private System.Windows.Forms.TextBox txt_Troco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}