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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public static string User;
        public static string Password;
        public static string Port;
        public static string Server;

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            User = "";
            Password = "";
            Port = "";
            Server = "";
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                User = TxtUser.Text;
                Password = TxtPassword.Text;
                Port = TxtPort.Text;
                Server = TxtServer.Text;
                Mysql.Banco = "server=" + TxtServer.Text + ";port=" + TxtPort.Text + ";uid=" + TxtUser.Text + ";pwd=" + TxtPassword.Text + ";database=db_vendas";
                Mysql.Tabela();
                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mysql.Conexao.Close();
                return;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
