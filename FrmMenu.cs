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
using NAudio;
using NAudio.Wave;
using System.IO;

namespace _200130_Projeto
{
    public partial class FrmMenu : Form
    {

        public FrmMenu()
        {
            InitializeComponent();           
        }

        public void FrmMenu_Load(object sender, EventArgs e)
        {
            //Music.Akatsuki();
            FrmLogin login = new FrmLogin();
            login.Show();
            
        }

        private void FinalizarOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {   //inicia o contador e poe um tempo de 2800 milisegundos para ativar o tick
            //  timer.Start();
            // timer.Interval = 2800;

            //Music.Tensei();

            Application.Exit();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Criando um objeto do tipo do formulário que queremos abrir  
            FrmClientes frmclientes = new FrmClientes();

            //abrindo formulario
            frmclientes.Show();
        }

        private void CidadesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCidades frmcidades = new FrmCidades();
            frmcidades.Show();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias frmcategorias = new FrmCategorias();
            frmcategorias.Show();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmprodutos = new FrmProdutos();
            frmprodutos.Show();
        }

        private void FornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedores frmFornecedores = new FrmFornecedores();
            frmFornecedores.Show();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void VendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelatorios frmRelatorios = new FrmRelatorios();
            frmRelatorios.Show();
        }

        private void PedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMVendas Frmvendas = new FRMVendas();
            Frmvendas.Show();
        }
    }
}

