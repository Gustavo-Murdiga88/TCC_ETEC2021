using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using MySql.Data.MySqlClient;
using MySql;

namespace _200130_Projeto
{
    public partial class FrmRelatorios : Form
    {
        Mysql Banco = new Mysql();
        MySqlConnection conexao;
        MySqlCommand comando;
        String banco = "server=localhost;port=3308;uid=root;pwd=etecjau;database= db_vendas";
        MySqlDataAdapter Adaptador;
        DataTable datTabela;

        public FrmRelatorios()
        {
            InitializeComponent();
        }

        private void Relatórios_Load(object sender, EventArgs e)
        {

        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(Banco.conexao());
                conexao.Open();
                comando = new MySqlCommand("select c.descricao, sum(vd.qtde) Quantidade from categorias c " +
                                           "inner join produtos p on (c.id = p.id_categoria) " + 
                                           "inner join venda_det vd on (vd.id_produto = p.id) " + 
                                           "inner join venda_cab vc on (vc.id = vd.id_venda) " +
                                           "where vc.data >= @dataini and vc.data <= @datafim group by c.id", conexao);

                comando.Parameters.AddWithValue("@dataini", DateTime.Parse(dtpInicio.Value.ToString("dd/MM/yyyy")));
                comando.Parameters.AddWithValue("@datafim", DateTime.Parse(dtpFinal.Value.ToString("dd/MM/yyyy")));
                Adaptador = new MySqlDataAdapter(comando);
                Adaptador.Fill(datTabela = new DataTable());
                dvgConsulta.DataSource = datTabela;
                conexao.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace); 
            }
        }

        private void chartVendas_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Desenvolvimento do cabeçalho do relatório
            e.Graphics.DrawString("Relatório de Vendas", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 230, 10);
            e.Graphics.DrawLine(Pens.Black, 100, 90, 720, 90);
            e.Graphics.DrawString("Categoria", new Font("Arial", 10), Brushes.Black, 100, 95);
            e.Graphics.DrawString("Quantidade", new Font("Arial", 10), Brushes.Black, 600, 95);
            e.Graphics.DrawLine(Pens.Black, 100, 120, 720, 120);
            // Desenvolvimento da interface do corpo do relatório
            int posicao_y = 100;
            foreach (DataGridViewRow linha in dvgConsulta.Rows)
            {
                posicao_y += 30;
                e.Graphics.DrawString(linha.Cells[0].Value.ToString(), new Font("Arial", 10), Brushes.Black, 100, posicao_y);
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 600, posicao_y);
            }
            // Desenvolvimento da Interface do rodapé do relatório
            e.Graphics.DrawLine(Pens.Black, 100, 1060, 720, 1060);
            e.Graphics.DrawString("Total de Categorias:", new Font("Arial", 10), Brushes.Black, 100, 1065);
            e.Graphics.DrawString(dvgConsulta.RowCount.ToString(), new Font("Arial", 10), Brushes.Black, 250, 1065);
            e.Graphics.DrawString(System.DateTime.Now.ToString(), new Font("Arial", 10), Brushes.Black, 500, 1065);
            e.Graphics.DrawLine(Pens.Black, 100, 1090, 720, 1090);

        }

        private void btn_Grafico_Click(object sender, EventArgs e)
        {
            string[] categoria = new string[dvgConsulta.RowCount];
            double[] qtde = new double[dvgConsulta.RowCount];
            int i = 0;

            foreach (DataGridViewRow linha in dvgConsulta.Rows)
            {
                categoria[i] = linha.Cells[0].Value.ToString();
                qtde[i] = Convert.ToDouble(linha.Cells[1].Value);
                i += 1;
            }

            chartVendas.Series[0].ChartType = SeriesChartType.Pie;
            chartVendas.Titles.Add("Grafico de vendas");
            chartVendas.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartVendas.Series[0].Points.DataBindXY(categoria, qtde);

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
