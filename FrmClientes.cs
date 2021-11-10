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
    public partial class FrmClientes : Form
    {

        public FrmClientes()
        {
            InitializeComponent();
        }

        public void FrmClientes_Load(object sender, EventArgs e)
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

        private void PicFoto_Click(object sender, EventArgs e)
        {
            OfdCliente.InitialDirectory = "C:\\Downloads\\";
            OfdCliente.FileName = "";
            OfdCliente.ShowDialog();
            PicFoto.ImageLocation = OfdCliente.FileName;
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                //se conecta ao Mysql.Banco
                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                //insere as informações das caixas de controles
                Mysql.Comando = new MySqlCommand("Insert into clientes" +

                                                "\n (nome, " +
                                                "\n endereco, " +
                                                "\n bairro, " +
                                                "\n id_cidade, " +
                                                "\n cpf, " +
                                                "\n rg, " +
                                                "\n fone, " +
                                                "\n celular, " +
                                                "\n email, " +
                                                "\n renda, " +
                                                "\n data_nasc, " +
                                                "\n foto, " +
                                                "\n bloqueado)" +
                                                "\n values (@nome, " +
                                                "\n @endereco, " +
                                                "\n @bairro, " +
                                                "\n @cidade, " +
                                                "\n @cpf, " +
                                                "\n @rg, " +
                                                "\n @fone, " +
                                                "\n @celular, " +
                                                "\n @email, " +
                                                "\n @renda, " +
                                                "\n @data_nasc, " +
                                                "\n @foto, " +
                                                "\n @bloqueado)", Mysql.Conexao);

                Mysql.Comando.Parameters.AddWithValue("@nome", TxtNome.Text);
                Mysql.Comando.Parameters.AddWithValue("@endereco", TxtEndereco.Text);
                Mysql.Comando.Parameters.AddWithValue("@bairro", TxtBairro.Text);
                Mysql.Comando.Parameters.AddWithValue("@cidade", CboCidade.SelectedValue);
                Mysql.Comando.Parameters.AddWithValue("@cpf", MtbCPF.Text);
                Mysql.Comando.Parameters.AddWithValue("@rg", MtbRG.Text);
                Mysql.Comando.Parameters.AddWithValue("@fone", MtbTel.Text);
                Mysql.Comando.Parameters.AddWithValue("@celular", MtbCel.Text);
                Mysql.Comando.Parameters.AddWithValue("@email", TxtEmail.Text);
                Mysql.Comando.Parameters.AddWithValue("@renda", Convert.ToDouble(TxtRenda.Text));
                Mysql.Comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(MtbDataNasci.Text));
                Mysql.Comando.Parameters.AddWithValue("@foto", PicFoto.ImageLocation);
                Mysql.Comando.Parameters.AddWithValue("@bloqueado", Convert.ToBoolean(ChkBloq.Checked));
                //Executa o Mysql.Comando pra inserção e fecha a Mysql.Conexao
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LblID.Text = null;
            TxtNome.Clear();
            TxtBairro.Clear();
            TxtEmail.Clear();
            TxtEndereco.Clear();
            TxtRenda.Clear();
            LblUF.ResetText();
            CboCidade.ResetText();
            MtbCel.Clear();
            MtbCPF.Clear();
            MtbDataNasci.Clear();
            MtbRG.Clear();
            MtbTel.Clear();
            TxtPesquisa.Clear();
            PicFoto.Image = null;
            ChkBloq.Checked = false;
            TxtNome.Focus();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                Mysql.Comando = new MySqlCommand("update clientes set nome = @nome, " +
                                            "\n endereco = @endereco, " +
                                            "\n bairro = @bairro, " +
                                            "\n id_cidade = @cidade, " +
                                            "\n cpf = @cpf, " +
                                            "\n rg = @rg, " +
                                            "\n fone = @fone, " +
                                            "\n celular = @celular, " +
                                            "\n email = @email, " +
                                            "\n renda = @renda, " +
                                            "\n data_nasc = @data_nasc, " +
                                            "\n foto = @foto, " +
                                            "\n bloqueado = @bloqueado where id=@id", Mysql.Conexao);

                Mysql.Comando.Parameters.AddWithValue("@nome", TxtNome.Text);
                Mysql.Comando.Parameters.AddWithValue("@endereco", TxtEndereco.Text);
                Mysql.Comando.Parameters.AddWithValue("@bairro", TxtBairro.Text);
                Mysql.Comando.Parameters.AddWithValue("@cidade", CboCidade.SelectedValue);
                Mysql.Comando.Parameters.AddWithValue("@cpf", MtbCPF.Text);
                Mysql.Comando.Parameters.AddWithValue("@rg", MtbRG.Text);
                Mysql.Comando.Parameters.AddWithValue("@fone", MtbTel.Text);
                Mysql.Comando.Parameters.AddWithValue("@celular", MtbCel.Text);
                Mysql.Comando.Parameters.AddWithValue("@email", TxtEmail.Text);
                Mysql.Comando.Parameters.AddWithValue("@renda", Convert.ToDouble(TxtRenda.Text));
                Mysql.Comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(MtbDataNasci.Text));
                Mysql.Comando.Parameters.AddWithValue("@foto", PicFoto.ImageLocation);
                Mysql.Comando.Parameters.AddWithValue("@bloqueado", Convert.ToBoolean(ChkBloq.Checked));
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

        public void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (DgvClientes.RowCount > 0)
            if (DgvClientes.RowCount > 0)
            {

                LblID.Text = DgvClientes.CurrentRow.Cells[0].Value.ToString();
                TxtNome.Text = DgvClientes.CurrentRow.Cells[1].Value.ToString();
                TxtEndereco.Text = DgvClientes.CurrentRow.Cells[2].Value.ToString();
                TxtBairro.Text = DgvClientes.CurrentRow.Cells[3].Value.ToString();
                //exibe nas control box o id da cidade
                CboCidade.Text = DgvClientes.CurrentRow.Cells[4].Value.ToString();
                MtbCPF.Text = DgvClientes.CurrentRow.Cells[5].Value.ToString();
                MtbRG.Text = DgvClientes.CurrentRow.Cells[6].Value.ToString();
                MtbTel.Text = DgvClientes.CurrentRow.Cells[7].Value.ToString();
                MtbCel.Text = DgvClientes.CurrentRow.Cells[8].Value.ToString();
                TxtEmail.Text = DgvClientes.CurrentRow.Cells[9].Value.ToString();
                TxtRenda.Text = DgvClientes.CurrentRow.Cells[10].Value.ToString();
                MtbDataNasci.Text = DgvClientes.CurrentRow.Cells[11].Value.ToString();
                PicFoto.ImageLocation = DgvClientes.CurrentRow.Cells[12].Value.ToString();
                ChkBloq.Checked = (Boolean)DgvClientes.CurrentRow.Cells[13].Value;
                //exibe a cidade e o uf no control box. Foi criado 2 cells para isso
                CboCidade.Text = DgvClientes.CurrentRow.Cells[14].Value.ToString();
                LblUF.Text = DgvClientes.CurrentRow.Cells[15].Value.ToString();

            }
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
                    Mysql.Comando = new MySqlCommand("delete from clientes where id = @id", Mysql.Conexao);
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

        private void CboCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCidade.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)CboCidade.SelectedItem;
                LblUF.Text = reg["uf"].ToString();// ou indice em vez do nome da coluna
            }
        }

        private void Text_Pesquisar(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void JustLetters(object sender, KeyPressEventArgs e)
        {
            //txt admite apenas letras e backspace
            if (char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBox(object sender, EventArgs e)
        {
            TxtBairro.SelectAll();
            TxtEmail.SelectAll();
            TxtEndereco.SelectAll();
            TxtNome.SelectAll();
            TxtPesquisa.SelectAll();
            TxtRenda.SelectAll();
            MtbCel.SelectAll();
            MtbCPF.SelectAll();
            MtbDataNasci.SelectAll();
            MtbRG.SelectAll();
            MtbTel.SelectAll();
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
                Mysql.Comando = new MySqlCommand("select clientes.*, cidades.nome cidade, cidades.uf from clientes " +
                                            "inner join cidades on id_cidade = cidades.id " +
                                            "where clientes.nome like @nome order by clientes.nome", Mysql.Conexao);
                //Mysql.Comando = new MySqlCommand("select * from clientes where nome like @nome order by nome", Mysql.Conexao);
                Mysql.Comando.Parameters.AddWithValue("@nome", TxtPesquisa.Text + "%");
                Mysql.Adaptador = new MySqlDataAdapter(Mysql.Comando);
                Mysql.Adaptador.Fill(Mysql.datTabela = new DataTable());
                DgvClientes.DataSource = Mysql.datTabela;
                Mysql.Conexao.Close();

                //coluna 4 nao aparece na pesquisa
                DgvClientes.Columns[4].Visible = false;
                DgvClientes.Columns[12].Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Mysql.Conexao.Close();

            }
        }
    }
}
