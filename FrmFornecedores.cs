using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200130_Projeto
{
    public partial class FrmFornecedores : Form
    {

        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
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

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                Mysql.Comando = new MySqlCommand("Insert into Fornecedores " +
                                                "\n(Razao_Social, " +
                                                "\nFantasia, " +
                                                "\nCNPJ, " +
                                                "\nIE, " +
                                                "\nEndereco, " +
                                                "\nBairro, " +
                                                "\nid_cidade, " +
                                                "\nFone, " +
                                                "\nContato, " +
                                                "\nEmail)" +
                                                "values (@Razao_Social, " +
                                                "\n@Fantasia, " +
                                                "\n@CNPJ, " +
                                                "\n@IE, " +
                                                "\n@Endereco, " +
                                                "\n@Bairro, " +
                                                "\n@Cidade, " +
                                                "\n@Fone, " +
                                                "\n@Contato, " +
                                                "\n@Email)", Mysql.Conexao);

                Mysql.Comando.Parameters.AddWithValue("@Razao_Social", TxtRazaoSocial.Text);
                Mysql.Comando.Parameters.AddWithValue("@Fantasia", TxtFantasia.Text);
                Mysql.Comando.Parameters.AddWithValue("@CNPJ", MtbCNPJ.Text);
                Mysql.Comando.Parameters.AddWithValue("@IE", MtbIE.Text);
                Mysql.Comando.Parameters.AddWithValue("@Endereco", TxtEndereco.Text);
                Mysql.Comando.Parameters.AddWithValue("@Bairro", TxtBairro.Text);
                Mysql.Comando.Parameters.AddWithValue("@Cidade", CboCidade.SelectedValue);
                Mysql.Comando.Parameters.AddWithValue("@Fone", MtbTel.Text);
                Mysql.Comando.Parameters.AddWithValue("@Contato", TxtContato.Text);
                Mysql.Comando.Parameters.AddWithValue("@Email", TxtEmail.Text);
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

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                Mysql.Comando = new MySqlCommand("Update Fornecedores set " +
                                                "Razao_Social = @Razao_Social, " +
                                                "\nFantasia = @Fantasia, " +
                                                "\nCNPJ = @CNPJ, " +
                                                "\nIE = @IE, " +
                                                "\nEndereco = @Endereco, " +
                                                "\nBairro = @Bairro, " +
                                                "\nid_cidade = @Cidade, " +
                                                "\nFone = Fone, " +
                                                "\nContato = @Contato, " +
                                                "\nEmail = @Email where id=@id", Mysql.Conexao);

                Mysql.Comando.Parameters.AddWithValue("@Razao_Social", TxtRazaoSocial.Text);
                Mysql.Comando.Parameters.AddWithValue("@Fantasia", TxtFantasia.Text);
                Mysql.Comando.Parameters.AddWithValue("@CNPJ", MtbCNPJ.Text);
                Mysql.Comando.Parameters.AddWithValue("@IE", MtbIE.Text);
                Mysql.Comando.Parameters.AddWithValue("@Endereco", TxtEndereco.Text);
                Mysql.Comando.Parameters.AddWithValue("@Bairro", TxtBairro.Text);
                Mysql.Comando.Parameters.AddWithValue("@Cidade", CboCidade.SelectedValue);
                Mysql.Comando.Parameters.AddWithValue("@Fone", MtbTel.Text);
                Mysql.Comando.Parameters.AddWithValue("@Contato", TxtContato.Text);
                Mysql.Comando.Parameters.AddWithValue("@Email", TxtEmail.Text);
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

        private void DgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvFornecedores.RowCount > 0)
                {
                    LblID.Text = DgvFornecedores.CurrentRow.Cells[0].Value.ToString();
                    TxtRazaoSocial.Text = DgvFornecedores.CurrentRow.Cells[1].Value.ToString();
                    TxtFantasia.Text = DgvFornecedores.CurrentRow.Cells[2].Value.ToString();
                    TxtEndereco.Text = DgvFornecedores.CurrentRow.Cells[3].Value.ToString();
                    TxtBairro.Text = DgvFornecedores.CurrentRow.Cells[4].Value.ToString();
                    CboCidade.Text = DgvFornecedores.CurrentRow.Cells[5].Value.ToString();
                    MtbCNPJ.Text = DgvFornecedores.CurrentRow.Cells[6].Value.ToString();
                    MtbIE.Text = DgvFornecedores.CurrentRow.Cells[7].Value.ToString();
                    MtbTel.Text = DgvFornecedores.CurrentRow.Cells[8].Value.ToString();
                    TxtContato.Text = DgvFornecedores.CurrentRow.Cells[9].Value.ToString();
                    TxtEmail.Text = DgvFornecedores.CurrentRow.Cells[10].Value.ToString();
                    CboCidade.Text = DgvFornecedores.CurrentRow.Cells[11].Value.ToString();
                    LblUF.Text = DgvFornecedores.CurrentRow.Cells[12].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtBairro.Clear();
            TxtEmail.Clear();
            TxtEndereco.Clear();
            TxtFantasia.Clear();
            TxtPesquisa.Clear();
            TxtRazaoSocial.Clear();
            MtbCNPJ.Clear();
            TxtContato.Clear();
            MtbIE.Clear();
            MtbTel.Clear();
            CboCidade.ResetText();
            LblUF.ResetText();
            TxtRazaoSocial.Focus();
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
                    Mysql.Comando = new MySqlCommand("delete from fornecedores where id = @id", Mysql.Conexao);
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

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void CboCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCidade.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)CboCidade.SelectedItem;
                LblUF.Text = reg["uf"].ToString();// ou indice em vez do nome da coluna
            }
        }

        public void CarregarCBO()
        {
            Mysql.Conexao = new MySqlConnection(Mysql.Banco);
            Mysql.Conexao.Open();
            Mysql.Comando = new MySqlCommand("select * from cidades order by nome", Mysql.Conexao);
            Mysql.Adaptador = new MySqlDataAdapter(Mysql.Comando);
            Mysql.Adaptador.Fill(Mysql.datTabela = new DataTable());
            CboCidade.DataSource = Mysql.datTabela;
            CboCidade.DisplayMember = "nome";
            CboCidade.ValueMember = "id";
            Mysql.Conexao.Close();

        }

        private void Pesquisar()
        {
            try
            {
                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                //na pesquisa demos um inner join com a tabela cidades para exibir 2 rows: nome_cidade e uf
                Mysql.Comando = new MySqlCommand("select fornecedores.*, cidades.nome cidade, cidades.uf from fornecedores " +
                                                "inner join cidades on id_cidade = cidades.id " +
                                                "where fornecedores.fantasia like @fantasia order by fornecedores.fantasia", Mysql.Conexao);
                //Mysql.Comando = new MySqlCommand("select * from clientes where nome like @nome order by nome", Mysql.Conexao);
                Mysql.Comando.Parameters.AddWithValue("@fantasia", TxtPesquisa.Text + "%");
                Mysql.Adaptador = new MySqlDataAdapter(Mysql.Comando);
                Mysql.Adaptador.Fill(Mysql.datTabela = new DataTable());
                DgvFornecedores.DataSource = Mysql.datTabela;
                Mysql.Conexao.Close();
                //coluna 5 nao aparece na pesquisa
                DgvFornecedores.Columns[5].Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
            }
        }

        private void Textbox(object sender, EventArgs e)
        {
            TxtBairro.SelectAll();
            TxtEmail.SelectAll();
            TxtEndereco.SelectAll();
            TxtFantasia.SelectAll();
            TxtPesquisa.SelectAll();
            TxtRazaoSocial.SelectAll();
            MtbCNPJ.SelectAll();
            TxtContato.SelectAll();
            MtbIE.SelectAll();
            MtbTel.SelectAll();
        }

        private void TxtRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt admite apenas letras, backspace e space
            if (char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
    }
}
