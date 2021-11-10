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
    public partial class FrmProdutos : Form
    {



        public FrmProdutos()
        {
            InitializeComponent();
        }


        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarCBO();
                //executa o botão consulta para popular a dgv assim que inicia o form
                Pesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void PicProduto_Click(object sender, EventArgs e)
        {
            OfdProduto.InitialDirectory = "C:\\Downloads\\";
            OfdProduto.FileName = "";
            OfdProduto.ShowDialog();
            PicProduto.ImageLocation = OfdProduto.FileName;

        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                /*if(CboCategoria.SelectedIndex != -1) { 
                    
                    MessageBox.Show("Erro","Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(CboFornecedor.SelectedIndex != -1) {
                    MessageBox.Show("Erro", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
                //se conecta ao banco
                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                //insere as informações das caixas de controles
                Mysql.Comando = new MySqlCommand("Insert into Produtos" +
                                            "\n (Produto, " +
                                            "\n CodigoBarra, " +
                                            "\n ID_Categoria, " +
                                            "\n ID_Fornecedor, " +
                                            "\n Estoque, " +
                                            "\n EstoqueMin, " +
                                            "\n ValorVenda, " +
                                            "\n ValorCusto, " +
                                            "\n Foto, " +
                                            "\n imagem," + 
                                            "\n LinkVideo, " +
                                            "\n ForaLinha)" +
                                            "\n values (@produto, " +
                                            "\n @CodigoBarra, " +
                                            "\n @Categoria, " +
                                            "\n @Fornecedor, " +
                                            "\n @Estoque, " +
                                            "\n @EstoqueMin, " +
                                            "\n @ValorVenda, " +
                                            "\n @ValorCusto, " +
                                            "\n @Foto, " +
                                            "\n @imagem, " + 
                                            "\n @LinkVideo, " +
                                            "\n @ForaLinha)", Mysql.Conexao);

                Mysql.Comando.Parameters.AddWithValue("@produto", TxtProduto.Text);
                Mysql.Comando.Parameters.AddWithValue("@CodigoBarra", TxtBarra.Text);
                Mysql.Comando.Parameters.AddWithValue("@Categoria", CboCategoria.SelectedValue);
                Mysql.Comando.Parameters.AddWithValue("@Fornecedor", CboFornecedor.SelectedValue);
                Mysql.Comando.Parameters.AddWithValue("@Estoque", Convert.ToInt32(TxtEstoque.Text));
                Mysql.Comando.Parameters.AddWithValue("@EstoqueMin", Convert.ToInt32(TxtEstoqueMin.Text));
                Mysql.Comando.Parameters.AddWithValue("@ValorVenda", Convert.ToDouble(TxtValorVenda.Text));
                Mysql.Comando.Parameters.AddWithValue("@ValorCusto", Convert.ToDouble(TxtValorCusto.Text));
                Mysql.Comando.Parameters.AddWithValue("@Foto", PicProduto.ImageLocation);
                Mysql.Comando.Parameters.AddWithValue("@imagem", PicProduto.ImageLocation.Substring(28));
                Mysql.Comando.Parameters.AddWithValue("@LinkVideo", TxtLink.Text);
                Mysql.Comando.Parameters.AddWithValue("@ForaLinha", Convert.ToBoolean(ChkFora.Checked));
                //Executa o Mysql.Comando pra inserção e fecha a conexao
                Mysql.Comando.ExecuteNonQuery();
                Mysql.Conexao.Close();
                //Limpa os controles e att a grid
                BtnCancelar.PerformClick();
                Pesquisar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                Mysql.Comando = new MySqlCommand("update produtos set Produto = @Produto, " +
                                            "\n CodigoBarra = @CodigoBarra, " +
                                            "\n ID_Categoria = @Categoria, " +
                                            "\n ID_Fornecedor = @Fornecedor, " +
                                            "\n Estoque = @Estoque, " +
                                            "\n EstoqueMin = @EstoqueMin, " +
                                            "\n ValorVenda = @ValorVenda, " +
                                            "\n ValorCusto = @ValorCusto, " +
                                            "\n Foto = @Foto, " +
                                            "\n LinkVideo = @LinkVideo, " +
                                            "\n ForaLinha = @ForaLinha where id=@id", Mysql.Conexao);

                Mysql.Comando.Parameters.AddWithValue("@produto", TxtProduto.Text);
                Mysql.Comando.Parameters.AddWithValue("@CodigoBarra", TxtBarra.Text);
                Mysql.Comando.Parameters.AddWithValue("@Categoria", CboCategoria.SelectedValue);
                Mysql.Comando.Parameters.AddWithValue("@Fornecedor", CboFornecedor.SelectedValue);
                Mysql.Comando.Parameters.AddWithValue("@Estoque", Convert.ToInt32(TxtEstoque.Text));
                Mysql.Comando.Parameters.AddWithValue("@EstoqueMin", Convert.ToInt32(TxtEstoqueMin.Text));
                Mysql.Comando.Parameters.AddWithValue("@ValorVenda", Convert.ToDouble(TxtValorVenda.Text));
                Mysql.Comando.Parameters.AddWithValue("@ValorCusto", Convert.ToDouble(TxtValorCusto.Text));
                Mysql.Comando.Parameters.AddWithValue("@Foto", PicProduto.ImageLocation);
                Mysql.Comando.Parameters.AddWithValue("@LinkVideo", TxtLink.Text);
                Mysql.Comando.Parameters.AddWithValue("@ForaLinha", Convert.ToBoolean(ChkFora.Checked));
                Mysql.Comando.Parameters.AddWithValue("@id", LblID.Text);


                Mysql.Comando.ExecuteNonQuery();
                Mysql.Conexao.Close();
                BtnCancelar.PerformClick();
                Pesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
            }
        }


        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvProdutos.RowCount > 0)
            {
                LblID.Text = DgvProdutos.CurrentRow.Cells[0].Value.ToString();
                TxtProduto.Text = DgvProdutos.CurrentRow.Cells[1].Value.ToString();
                TxtBarra.Text = DgvProdutos.CurrentRow.Cells[2].Value.ToString();
                //exibe nas control box o id
                CboCategoria.Text = DgvProdutos.CurrentRow.Cells[3].Value.ToString();
                CboFornecedor.Text = DgvProdutos.CurrentRow.Cells[4].Value.ToString();
                //
                TxtEstoque.Text = DgvProdutos.CurrentRow.Cells[5].Value.ToString();
                TxtEstoqueMin.Text = DgvProdutos.CurrentRow.Cells[6].Value.ToString();
                TxtValorVenda.Text = DgvProdutos.CurrentRow.Cells[7].Value.ToString();
                TxtValorCusto.Text = DgvProdutos.CurrentRow.Cells[8].Value.ToString();
                PicProduto.ImageLocation = DgvProdutos.CurrentRow.Cells[9].Value.ToString();
                TxtLink.Text = DgvProdutos.CurrentRow.Cells[11].Value.ToString();
                ChkFora.Checked = (Boolean)DgvProdutos.CurrentRow.Cells[12].Value;
                //exibe o nome da categoria e fornecedor no control box. Foi criado 2 cells para isso
                CboCategoria.Text = DgvProdutos.CurrentRow.Cells[13].Value.ToString();
                CboFornecedor.Text = DgvProdutos.CurrentRow.Cells[14].Value.ToString();
            }
            
        }

        private void link(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvProdutos.RowCount > 0 && TxtLink.Text != "" && DgvProdutos.CurrentRow.Cells[10].Selected == true)
                {
                    //abre no navegador padrao
                    System.Diagnostics.Process.Start(TxtLink.Text);
                }
                else return;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtProduto.Clear();
            TxtBarra.Clear();
            TxtEstoque.Clear();
            TxtEstoqueMin.Clear();
            TxtLink.Clear();
            TxtPesquisa.Clear();
            TxtValorCusto.Text = "0.00";
            TxtValorVenda.Text = "0.00";
            ChkFora.Checked = false;
            PicProduto.ImageLocation = null;
            CboCategoria.ResetText();
            CboFornecedor.ResetText();
            TxtProduto.Focus();
            LblID.Text = null; 
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o registo?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                    Mysql.Conexao.Open();
                    //atualiza a table cidades com os valores digitados na caixa de texto
                    Mysql.Comando = new MySqlCommand("delete from produtos where id = @id", Mysql.Conexao);
                    Mysql.Comando.Parameters.AddWithValue("@id", LblID.Text);
                    Mysql.Comando.ExecuteNonQuery();
                    Mysql.Conexao.Close();
                    BtnCancelar.PerformClick();
                    Pesquisar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregarCBO()
        {
            try
            {
                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                Mysql.Comando = new MySqlCommand("select * from categorias order by descricao", Mysql.Conexao);
                Mysql.Adaptador = new MySqlDataAdapter(Mysql.Comando);
                Mysql.Adaptador.Fill(Mysql.datTabela = new DataTable());

                //puxa os valores da grid categoria atraves do id e mostra o nome
                CboCategoria.DataSource = Mysql.datTabela;
                CboCategoria.DisplayMember = "descricao";
                CboCategoria.ValueMember = "id";

                //puxa os valores da grid fornecedor atraves do id e mostra o nome
                Mysql.Comando = new MySqlCommand("select * from fornecedores order by fantasia", Mysql.Conexao);
                Mysql.Adaptador = new MySqlDataAdapter(Mysql.Comando);
                Mysql.Adaptador.Fill(Mysql.datTabela = new DataTable());
                CboFornecedor.DataSource = Mysql.datTabela;
                CboFornecedor.DisplayMember = "fantasia";
                CboFornecedor.ValueMember = "id";
                Mysql.Conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
            }

        }

        private void Pesquisar()
        {
            try
            {
                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                //na pesquisa demos um inner join com a tabela categoria e fornecedor para exibir 2 rows: categoria e nome fantasia
                //Mysql.Comando = new MySqlCommand("select produtos.*, categorias.descricao Categoria from produtos " +
                Mysql.Comando = new MySqlCommand("select produtos.*, categorias.descricao Categoria, fornecedores.fantasia Fantasia from produtos " +
                                           "inner join categorias on ID_Categoria = categorias.id " +
                                           "inner join fornecedores on ID_Fornecedor = fornecedores.id " +
                                           "where produtos.produto like @pesquisa order by produtos.produto", Mysql.Conexao);
                
                Mysql.Comando.Parameters.AddWithValue("@pesquisa", TxtPesquisa.Text + "%");
                Mysql.Adaptador = new MySqlDataAdapter(Mysql.Comando);
                Mysql.Adaptador.Fill(Mysql.datTabela = new DataTable());
                DgvProdutos.DataSource = Mysql.datTabela;
                DgvProdutos.Columns[9].Visible = false;
                DgvProdutos.Columns[10].Visible = false;
                DgvProdutos.Columns[11].Visible = true;    
                Mysql.Conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TxtProduto.SelectAll();
            TxtBarra.SelectAll();
            TxtEstoque.SelectAll();
            TxtEstoqueMin.SelectAll();
            TxtLink.SelectAll();
            TxtPesquisa.SelectAll();
            TxtValorCusto.SelectAll();
            TxtValorVenda.SelectAll();
        }

        private void JustNumbersEvirgula(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';               
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void DgvProdutos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in DgvProdutos.Rows)
            {
                if (Uri.IsWellFormedUriString(r.Cells[10].Value.ToString(), UriKind.Absolute))
                {
                    r.Cells[10] = new DataGridViewLinkCell();

                    // Se quiser outra cor de link deve colocar aqui
                    DataGridViewLinkCell c = r.Cells[10] as DataGridViewLinkCell;
                    c.LinkColor = Color.Blue;
                    c.VisitedLinkColor = Color.Red;
                }
            }
        }

        private void GrpDados_Enter(object sender, EventArgs e)
        {

        }

        private void LblID_Click(object sender, EventArgs e)
        {

        }
    }
}
