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
    public partial class FrmCategorias : Form
    {

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            Pesquisar();
            TxtCategoria.Focus();
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            try
            {

                Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                Mysql.Conexao.Open();
                Mysql.Comando = new MySqlCommand("select * from categorias where descricao like @categoria order by descricao", Mysql.Conexao);
                Mysql.Comando.Parameters.AddWithValue("@categoria", TxtPesquisa.Text + "%");
                Mysql.Adaptador = new MySqlDataAdapter(Mysql.Comando);
                Mysql.Adaptador.Fill(Mysql.datTabela = new DataTable());
                DgvCategorias.DataSource = Mysql.datTabela;
                Mysql.Conexao.Close();

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
                Mysql.Comando = new MySqlCommand("insert into categorias (descricao)" +
                                                 "values (@descricao)", Mysql.Conexao);
                Mysql.Comando.Parameters.AddWithValue("@descricao", TxtCategoria.Text);
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
                Mysql.Comando = new MySqlCommand("update categorias set descricao= @descricao where id=@id", Mysql.Conexao);
                Mysql.Comando.Parameters.AddWithValue("@descricao", TxtCategoria.Text);
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

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCategorias.RowCount > 0)
            {
                LblID.Text = DgvCategorias.CurrentRow.Cells[0].Value.ToString();
                TxtCategoria.Text = DgvCategorias.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LblID.Text = "";
            TxtCategoria.Text = "";
            TxtCategoria.Focus();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvCategorias.RowCount > 0)
                {
                    if (MessageBox.Show("Deseja excluir o registo?", "Exclusão", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        Mysql.Conexao = new MySqlConnection(Mysql.Banco);
                        Mysql.Conexao.Open();
                        //atualiza a table cidades com os valores digitados na caixa de texto
                        Mysql.Comando = new MySqlCommand("delete from categorias where id = @id", Mysql.Conexao);
                        Mysql.Comando.Parameters.AddWithValue("@id", LblID.Text);
                        Mysql.Comando.ExecuteNonQuery();
                        Mysql.Conexao.Close();

                        BtnCancelar.PerformClick();
                        Pesquisar();
                    }
                }
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

        private void GrpInsert_Enter(object sender, EventArgs e)
        {

        }
    }
}
