using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _200130_Projeto
{
    public partial class FrmCaixa : Form
    {
        Mysql Banco = new Mysql();
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter adaptador;
        DataTable datTabela;

        public static int idCliente, idVenda; 
        public static string nomecliente;
        public static double total;

        double pago, dinheiro, cartao, cheque, troco;
        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            txt_nomeCliente.Text = nomecliente;
            txt_Cliente.Text = idCliente.ToString();
            txt_Venda.Text = idVenda.ToString();
            txt_Valor.Text = total.ToString("C");

            CalcularoTroco();
        }

        private void txt_Cartao_TextChanged(object sender, EventArgs e)
        {
            CalcularoTroco();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(troco <0)
                {
                    MessageBox.Show("Valor pago menor que o valor da compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; 
                }

                conexao = new MySqlConnection(Banco.conexao());
                conexao.Open();
                comando = new MySqlCommand("insert into caixa (id_venda,dinheiro, cartao, cheque, troco, tipo_mov)" +
                                          "values(@id_venda,@dinheiro, @cartao, @cheque, @troco, @tipo_mov)", conexao);
                comando.Parameters.AddWithValue("@id_venda", idVenda);
                comando.Parameters.AddWithValue("@dinheiro", dinheiro);
                comando.Parameters.AddWithValue("@cartao", cartao);
                comando.Parameters.AddWithValue("@cheque", cheque);
                comando.Parameters.AddWithValue("@troco", troco);
                comando.Parameters.AddWithValue("@tipo_mov", "E");
                comando.ExecuteNonQuery();
                conexao.Close();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "error");
                conexao.Close();
            }
        }

        private void txt_Cheque_TextChanged(object sender, EventArgs e)
        {
            CalcularoTroco();
        }

        private void txt_Dinheiro_TextChanged(object sender, EventArgs e)
        {
            CalcularoTroco();
        }

        public void CalcularoTroco()
        {
            if (txt_Dinheiro.Text == "") dinheiro = 0; else dinheiro = double.Parse(txt_Dinheiro.Text);
            if (txt_Cheque.Text == "") cheque = 0; else cheque = double.Parse(txt_Cheque.Text);
            if (txt_Cartao.Text == "") cartao = 0; else cartao = double.Parse(txt_Cartao.Text);

            pago = dinheiro + cartao + cheque;
            troco = pago - total;
            txt_Troco.Text = troco.ToString("c");

            if (troco < 0)
            {
                txt_Troco.ForeColor = Color.Red;
            }
            else
            {
                txt_Troco.ForeColor = Color.Blue;
            }
        }

        public FrmCaixa()
        {
            InitializeComponent();
        }
        
    }
}
