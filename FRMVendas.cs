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
    public partial class FRMVendas : Form 
    {
        Mysql Banco = new Mysql();
        // introdução a conexão ao banco
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter adaptador;
        DataTable datTabela;

        bool bloqueado = false;
        double total = 0; 

        public FRMVendas()
        {
            InitializeComponent();
        }

        private void dvgclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            try
            {
                dvgProdutos.RowCount = 0; 
                cbo_Clientes.SelectedIndex = -1;
                cbo_Produtos.SelectedIndex = -1;
                txt_cidade.Clear();
                txt_endereco.Clear();
                txt_preco.Clear();
                txt_quantidade.Clear();
                txt_UF.Clear();
                txt_estoque.Clear();
                mtbCelular.Clear();
                mtbCPF.Clear();
                mtbDataNascimento.Clear();
                picCliente.ImageLocation = "";
                picProduto.ImageLocation = "";
                total = 0;
                lbl_resultado.Text = total.ToString("C");
                grbClientes.Enabled = true;
                grbProdutos.Enabled = false;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cbo_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Clientes.SelectedIndex != -1)
                {
                    DataRowView reg = (DataRowView)cbo_Clientes.SelectedItem; 
                    txt_endereco.Text = reg["ENDERECO"].ToString();
                    txt_cidade.Text = reg["NOME"].ToString();
                    txt_UF.Text = reg["UF"].ToString();
                    mtbCPF.Text = reg["CPF"].ToString();
                    mtbCelular.Text = reg["CELULAR"].ToString();
                    mtbDataNascimento.Text = reg["DATA_NASC"].ToString();
                    picCliente.ImageLocation = reg["FOTO"].ToString();
                    bloqueado = bool.Parse(reg["BLOQUEADO"].ToString());
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

            if (cbo_Clientes.SelectedIndex != -1)
            {

                if (bloqueado == true)
                {
                    MessageBox.Show("Cliente bloqueado para venda", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_cancelar.PerformClick();
                    return;
                }

                grbClientes.Enabled = false;
                grbProdutos.Enabled = true;
            }

        }
    
           
        

        private void cbo_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Produtos.SelectedIndex != -1)
                {
                    DataRowView reg = (DataRowView)cbo_Produtos.SelectedItem;
                    txt_estoque.Text = reg["estoque"].ToString();
                    txt_preco.Text = reg["ValorVenda"].ToString();
                    picProduto.ImageLocation = reg["foto"].ToString();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.StackTrace, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexao.Close();
            }
        }

        private void btn_InserirPRoduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_quantidade.Text) > Convert.ToDouble(txt_estoque.Text))
                {
                    MessageBox.Show("Estoque insuficiente", "vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_quantidade.SelectAll();
                    return;
                }

                dvgProdutos.Rows.Add(cbo_Produtos.SelectedValue, cbo_Produtos.Text, txt_quantidade.Text, txt_preco.Text);

                double quantidade = double.Parse(txt_quantidade.Text);
                double preco = double.Parse(txt_preco.Text);
                total += quantidade * preco;
                lbl_resultado.Text = total.ToString("C");
                cbo_Produtos.SelectedIndex = -1;
                txt_estoque.Clear();
                txt_preco.Clear();
                txt_quantidade.Clear();
                picProduto.ImageLocation = "";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "error");
            }
        }

        private void bnt_RemoverPRoduto_Click(object sender, EventArgs e)
        {
            if (dvgProdutos.Rows.Count > 0)
            {
                double quantidade = double.Parse(dvgProdutos.CurrentRow.Cells[2].Value.ToString());
                double preco = double.Parse(dvgProdutos.CurrentRow.Cells[3].Value.ToString());

                total -= quantidade * preco;
                lbl_resultado.Text = total.ToString("C");
                dvgProdutos.Rows.RemoveAt(dvgProdutos.CurrentRow.Index); 
            }
        }

        private void grbClientes_Enter(object sender, EventArgs e)
        {

        }

        private void FRMVendas_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(Banco.conexao());
                conexao.Open();
                comando = new MySqlCommand("select cl.*, ci.nome cidade, ci.uf from clientes cl inner join cidades ci on (ci.id = cl.id_cidade) order by nome", conexao);
                adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(datTabela = new DataTable());
                cbo_Clientes.DataSource = datTabela;
                cbo_Clientes.DisplayMember = "nome";
                cbo_Clientes.ValueMember = "id";
                conexao.Close();

                conexao = new MySqlConnection(Banco.conexao());
                conexao.Open();
                comando = new MySqlCommand("Select * from produtos order by produto", conexao);
                adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(datTabela = new DataTable());
                cbo_Produtos.DataSource = datTabela;
                cbo_Produtos.DisplayMember = "produto";
                cbo_Produtos.ValueMember = "id";
                conexao.Close();
                btn_cancelar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "erro");
                conexao.Close();
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            try
            {
                //Gravando o venda_cab 
                conexao = new MySqlConnection(Banco.conexao());
                conexao.Open();
                comando = new MySqlCommand("insert into venda_cab(id_cliente, data, total) " +
                                                                 "values (@id_cliente, @data_venda, @total);", conexao);
                comando.Parameters.AddWithValue("@id_cliente", cbo_Clientes.SelectedValue);
                comando.Parameters.AddWithValue("@data_venda", DateTime.Now);
                comando.Parameters.AddWithValue("@total", total);
                comando.ExecuteNonQuery();
                //Retornar o Maior ID para gravar no detalhe
                int IDVenda = int.Parse(comando.LastInsertedId.ToString());
                //Gravando o detalhe da venda
                foreach (DataGridViewRow linha in dvgProdutos.Rows)
                {
                    comando = new MySqlCommand("insert into venda_det (id_venda, id_produto, qtde, vlr_unit)" +
                        "values(@id_venda, @id_produto, @qtde, @vlr_unit);", conexao);
                    comando.Parameters.AddWithValue("@id_venda",IDVenda);
                    comando.Parameters.AddWithValue("@id_produto", linha.Cells[0].Value);
                    comando.Parameters.AddWithValue("@qtde", double.Parse(linha.Cells[2].Value.ToString()));
                    comando.Parameters.AddWithValue("@vlr_unit", double.Parse(linha.Cells[3].Value.ToString()));
                    comando.ExecuteNonQuery();
                    //atualizando o estoque de vendas
                    comando = new MySqlCommand("update produtos set estoque = estoque - @qtde where id = @id", conexao);
                    comando.Parameters.AddWithValue("@qtde", double.Parse(linha.Cells[2].Value.ToString()));
                    comando.Parameters.AddWithValue("@id", linha.Cells[0].Value);
                    comando.ExecuteNonQuery();
                }
                conexao.Close();

                FrmCaixa.idCliente = int.Parse(cbo_Clientes.SelectedIndex.ToString());
                FrmCaixa.nomecliente = cbo_Clientes.Text;
                FrmCaixa.idVenda = IDVenda;
                FrmCaixa.total = total;
                // instanciando a tabela
                FrmCaixa form = new FrmCaixa();
                form.Show();
                btn_cancelar.PerformClick();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.StackTrace, "erro", MessageBoxButtons.OK);
            }
            
        }

        private void txt_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_preco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_estoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mtbCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void picCliente_Click(object sender, EventArgs e)
        {

        }

        private void txt_UF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ofdFoto_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void picProduto_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    } 
}

