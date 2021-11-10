using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace _200130_Projeto
{
    public class Mysql
    {
        public static MySqlConnection Conexao;
        public static MySqlCommand Comando;
        public static String Banco;
        public static MySqlDataAdapter Adaptador;
        public static DataTable datTabela;


        public static void  Tabela()
        {
                Conexao = new MySqlConnection("server=" + FrmLogin.Server + ";port=" + FrmLogin.Port + ";uid=" + FrmLogin.User + ";pwd=" + FrmLogin.Password);
                //abre a conexao com o mysql
                Conexao.Open();
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS db_vendas; USE db_vendas;", Conexao);
                //executa o comando
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidades " +
                                            "(ID integer auto_increment primary key, " +
                                            "nome char(40), " +
                                            "uf char(02))", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Clientes " +
                                            "(id integer auto_increment primary key, " +
                                            "nome char(40), " +
                                            "endereco char(40), " +
                                            "bairro char(40), " +
                                            "id_cidade int(11), " +
                                            "cpf char(14), " +
                                            "rg char(12), " +
                                            "fone char(14), " +
                                            "celular char(14), " +
                                            "email varchar(50), " +
                                            "renda decimal(10,2), " +
                                            "data_nasc DATE, " +
                                            "foto varchar(100), " +
                                            "bloqueado bool)", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Categorias " +
                                            "(ID integer auto_increment primary key, " +
                                            "descricao char(30))", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Fornecedores " +
                                            "(ID integer auto_increment primary key, " +
                                            "Razao_Social char(40), " +
                                            "Fantasia char(30), " +
                                            "Endereco char(40), " +
                                            "Bairro char(30), " +
                                            "id_cidade int(11), " +
                                            "CNPJ char(18), " +
                                            "IE char(15), " +
                                            "Fone char(14), " +
                                            "Contato char(40), " +
                                            "Email varchar(60))", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Produtos " +
                                            "(ID integer auto_increment primary key, " +
                                            "Produto char(40), " +
                                            "CodigoBarra char(14), " +
                                            "ID_Categoria int(11), " +
                                            "ID_Fornecedor int(11), " +
                                            "Estoque decimal (10,0), " +
                                            "EstoqueMin decimal (10,0), " +
                                            "ValorVenda decimal (10,2), " +
                                            "ValorCusto decimal (10,2), " +
                                            "Foto varchar(300), " +
                                            "imagem varchar (100),"+
                                            "LinkVideo varchar(100), " +
                                            "ForaLinha bool)", Conexao);
                Comando.ExecuteNonQuery();

                //Criação da tabela Venda_cab
                Comando = new MySqlCommand("create table if not exists venda_cab (id int auto_increment primary key," +
                                            "id_cliente int," +
                                            "data date," +
                                            "total decimal(10, 2));", Conexao);
                Comando.ExecuteNonQuery();

                //Cria tabela Venda_det
                Comando = new MySqlCommand("create table if not exists venda_det (id int auto_increment primary key," +
                                        "id_venda int," +
                                        " id_produto int," +
                                        "qtde decimal(10, 3)," +
                                        "vlr_unit decimal(10, 2));", Conexao);
                Comando.ExecuteNonQuery();
                //Cria tabela do Caixa
                Comando = new MySqlCommand("create table if not exists caixa(id int auto_increment primary key," +
                                        "id_venda int not null, " +
                                        "dinheiro decimal(10, 2)," +
                                        "cartao decimal(10, 2)," +
                                        "cheque decimal(10, 2)," +
                                        "troco decimal(10, 2)," +
                                        "tipo_mov char(1));", Conexao);
                Comando.ExecuteNonQuery();
                //fecha conexão
                Conexao.Close();

        }

        public string conexao()
        {

            String Conexao = ("server=" + FrmLogin.Server + ";port=" + FrmLogin.Port + ";uid=" + FrmLogin.User + ";pwd=" + FrmLogin.Password);

            return Conexao; 
        }

    }
}
