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
    public partial class FrmCidades : Form
    {
        public FrmCidades()
        {
            InitializeComponent();
        }


        private void FrmCidades_Load(object sender, EventArgs e)
        {
            try
            {
                //executa o botão consulta para popular a dgv assim que inicia o form
                BtnConsulta.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();

            }
        }

        private void BtnInserir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TxtNome.Text != "" && TxtUF.Text != "")
                {
                    Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                    Mysql.Conexao.Open();
                    Mysql.Comando = new MySqlCommand("insert into cidades (nome, uf) values (@nome, @uf)", Mysql.Conexao);
                    Mysql.Comando.Parameters.AddWithValue("@nome", TxtNome.Text);
                    Mysql.Comando.Parameters.AddWithValue("@uf", TxtUF.Text);
                    Mysql.Comando.ExecuteNonQuery();
                    Mysql.Conexao.Close();

                    //limpa as TXT e manda o foco para o txt nome
                    BtnCancelar.PerformClick();
                    //atualiza a grid
                    BtnConsulta.PerformClick();
                }
                else
                {
                    MessageBox.Show("Insira o Cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Mysql.Conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
            }
        }

        private void DgvCidades_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCidades.RowCount > 0)
            {
                LblID.Text = DgvCidades.CurrentRow.Cells[0].Value.ToString();
                TxtNome.Text = DgvCidades.CurrentRow.Cells[1].Value.ToString();
                TxtUF.Text = DgvCidades.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void BtnAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {

                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                //atualiza a table cidades com os valores digitados na caixa de texto
                Mysql.Comando = new MySqlCommand("update cidades set nome = @nome, uf = @uf where id = @id", Mysql.Conexao);
                Mysql.Comando.Parameters.AddWithValue("@nome", TxtNome.Text);
                Mysql.Comando.Parameters.AddWithValue("@uf", TxtUF.Text);
                Mysql.Comando.Parameters.AddWithValue("@id", LblID.Text);
                Mysql.Comando.ExecuteNonQuery();
                Mysql.Conexao.Close();

                //limpa as TXT e manda o foco para o txt nome
                BtnCancelar.PerformClick();
                //atualiza a grid
                BtnConsulta.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();

            }
        }

        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o registo?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (DgvCidades.RowCount > 0)
                    {
                        Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                        Mysql.Conexao.Open();
                        //atualiza a table cidades com os valores digitados na caixa de texto
                        Mysql.Comando = new MySqlCommand("delete from cidades where id = @id", Mysql.Conexao);
                        Mysql.Comando.Parameters.AddWithValue("@id", LblID.Text);
                        Mysql.Comando.ExecuteNonQuery();
                        Mysql.Conexao.Close();

                        BtnCancelar.PerformClick();
                        BtnConsulta.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            LblID.ResetText();
            TxtNome.Clear();
            TxtPesquisa.Clear();
            TxtUF.Clear();
            TxtNome.Focus();
        }

        private void BtnConsulta_Click_1(object sender, EventArgs e)
        {
            try
            {
                //joga a conexão da string banco na var conexao
                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                //
                Mysql.Comando = new MySqlCommand("select * from cidades where nome like @nome order by nome", Mysql.Conexao);
                Mysql.Comando.Parameters.AddWithValue("@nome", TxtPesquisa.Text + "%");
                Mysql.Adaptador = new MySqlDataAdapter(Mysql.Comando);
                Mysql.Adaptador.Fill(Mysql.datTabela = new DataTable());
                DgvCidades.DataSource = Mysql.datTabela;
                Mysql.Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JustLetters(object sender, KeyPressEventArgs e)
        {
            //txt admite apenas letras e backspace
            if (char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
