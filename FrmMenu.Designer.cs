
namespace _200130_Projeto
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RelatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FinalizarOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastroToolStripMenuItem,
            this.VendasToolStripMenuItem,
            this.RelatóriosToolStripMenuItem,
            this.conectarToolStripMenuItem,
            this.FinalizarOSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CadastroToolStripMenuItem
            // 
            this.CadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientesToolStripMenuItem,
            this.FornecedoresToolStripMenuItem,
            this.CategoriasToolStripMenuItem,
            this.ProdutosToolStripMenuItem,
            this.CidadesToolStripMenuItem});
            this.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem";
            this.CadastroToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.CadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // ClientesToolStripMenuItem
            // 
            this.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            this.ClientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ClientesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.ClientesToolStripMenuItem.Text = "C&lientes";
            this.ClientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // FornecedoresToolStripMenuItem
            // 
            this.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem";
            this.FornecedoresToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.FornecedoresToolStripMenuItem.Text = "&Fornecedores";
            this.FornecedoresToolStripMenuItem.Click += new System.EventHandler(this.FornecedoresToolStripMenuItem_Click);
            // 
            // CategoriasToolStripMenuItem
            // 
            this.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem";
            this.CategoriasToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.CategoriasToolStripMenuItem.Text = "C&ategorias";
            this.CategoriasToolStripMenuItem.Click += new System.EventHandler(this.CategoriasToolStripMenuItem_Click);
            // 
            // ProdutosToolStripMenuItem
            // 
            this.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem";
            this.ProdutosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.ProdutosToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.ProdutosToolStripMenuItem.Text = "&Produtos";
            this.ProdutosToolStripMenuItem.Click += new System.EventHandler(this.ProdutosToolStripMenuItem_Click);
            // 
            // CidadesToolStripMenuItem
            // 
            this.CidadesToolStripMenuItem.Name = "CidadesToolStripMenuItem";
            this.CidadesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.CidadesToolStripMenuItem.Text = "C&idades";
            this.CidadesToolStripMenuItem.Click += new System.EventHandler(this.CidadesToolStripMenuItem_Click_1);
            // 
            // VendasToolStripMenuItem
            // 
            this.VendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PedidosToolStripMenuItem});
            this.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem";
            this.VendasToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.VendasToolStripMenuItem.Text = "Vendas";
            // 
            // PedidosToolStripMenuItem
            // 
            this.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem";
            this.PedidosToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.PedidosToolStripMenuItem.Text = "Pedidos";
            this.PedidosToolStripMenuItem.Click += new System.EventHandler(this.PedidosToolStripMenuItem_Click);
            // 
            // RelatóriosToolStripMenuItem
            // 
            this.RelatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VendasToolStripMenuItem1});
            this.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem";
            this.RelatóriosToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.RelatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // VendasToolStripMenuItem1
            // 
            this.VendasToolStripMenuItem1.Name = "VendasToolStripMenuItem1";
            this.VendasToolStripMenuItem1.Size = new System.Drawing.Size(122, 24);
            this.VendasToolStripMenuItem1.Text = "Vendas";
            this.VendasToolStripMenuItem1.Click += new System.EventHandler(this.VendasToolStripMenuItem1_Click);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // FinalizarOSistemaToolStripMenuItem
            // 
            this.FinalizarOSistemaToolStripMenuItem.Name = "FinalizarOSistemaToolStripMenuItem";
            this.FinalizarOSistemaToolStripMenuItem.Size = new System.Drawing.Size(133, 23);
            this.FinalizarOSistemaToolStripMenuItem.Text = "Finalizar o Sistema";
            this.FinalizarOSistemaToolStripMenuItem.Click += new System.EventHandler(this.FinalizarOSistemaToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2800;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "Gestão e-grocery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RelatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FinalizarOSistemaToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
    }
}

