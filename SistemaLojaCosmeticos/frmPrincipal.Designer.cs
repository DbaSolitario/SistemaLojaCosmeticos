namespace SistemaLojaCosmeticos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.CadCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.CadMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.CadProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusPrincipal = new System.Windows.Forms.StatusStrip();
            this.StatuslbData = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatuslbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatuslbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nomefuncionario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.lbNome = new System.Windows.Forms.Label();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.StatusPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.consultasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 400);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(888, 40);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadCategoria,
            this.CadMarca,
            this.CadProduto,
            this.clienteToolStripMenuItem,
            this.cargoToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.MenuCadastro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCadastro.Image = ((System.Drawing.Image)(resources.GetObject("MenuCadastro.Image")));
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(102, 36);
            this.MenuCadastro.Text = "Cadastro";
            this.MenuCadastro.Click += new System.EventHandler(this.MenuCadastro_Click);
            // 
            // CadCategoria
            // 
            this.CadCategoria.Name = "CadCategoria";
            this.CadCategoria.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.CadCategoria.Size = new System.Drawing.Size(191, 22);
            this.CadCategoria.Text = "Categoria";
            this.CadCategoria.Click += new System.EventHandler(this.CadCategoria_Click);
            // 
            // CadMarca
            // 
            this.CadMarca.Name = "CadMarca";
            this.CadMarca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.CadMarca.Size = new System.Drawing.Size(191, 22);
            this.CadMarca.Text = "Marca";
            this.CadMarca.Click += new System.EventHandler(this.CadMarca_Click);
            // 
            // CadProduto
            // 
            this.CadProduto.Name = "CadProduto";
            this.CadProduto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.CadProduto.Size = new System.Drawing.Size(191, 22);
            this.CadProduto.Text = "Produto";
            this.CadProduto.Click += new System.EventHandler(this.CadProduto_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cargoToolStripMenuItem.Text = "Cargo";
            this.cargoToolStripMenuItem.Click += new System.EventHandler(this.cargoToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6)));
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.clienteToolStripMenuItem1,
            this.cargoToolStripMenuItem1,
            this.funcionarioToolStripMenuItem,
            this.vendasToolStripMenuItem1});
            this.consultasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasToolStripMenuItem.Image")));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(105, 36);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // cargoToolStripMenuItem1
            // 
            this.cargoToolStripMenuItem1.Name = "cargoToolStripMenuItem1";
            this.cargoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.cargoToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.cargoToolStripMenuItem1.Text = "Cargo";
            this.cargoToolStripMenuItem1.Click += new System.EventHandler(this.cargoToolStripMenuItem1_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F6)));
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionário";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem1,
            this.marcaToolStripMenuItem1,
            this.produtoToolStripMenuItem1,
            this.clientesToolStripMenuItem,
            this.cargoToolStripMenuItem2,
            this.funcionarioToolStripMenuItem1,
            this.vendasToolStripMenuItem2});
            this.relatóriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatóriosToolStripMenuItem.Image")));
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.categoriaToolStripMenuItem1_Click);
            // 
            // marcaToolStripMenuItem1
            // 
            this.marcaToolStripMenuItem1.Name = "marcaToolStripMenuItem1";
            this.marcaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.marcaToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.marcaToolStripMenuItem1.Text = "Marca";
            this.marcaToolStripMenuItem1.Click += new System.EventHandler(this.marcaToolStripMenuItem1_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.clientesToolStripMenuItem.Text = "Cliente";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // cargoToolStripMenuItem2
            // 
            this.cargoToolStripMenuItem2.Name = "cargoToolStripMenuItem2";
            this.cargoToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5)));
            this.cargoToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.cargoToolStripMenuItem2.Text = "Cargo";
            this.cargoToolStripMenuItem2.Click += new System.EventHandler(this.cargoToolStripMenuItem2_Click);
            // 
            // funcionarioToolStripMenuItem1
            // 
            this.funcionarioToolStripMenuItem1.Name = "funcionarioToolStripMenuItem1";
            this.funcionarioToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F6)));
            this.funcionarioToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.funcionarioToolStripMenuItem1.Text = "Funcionário";
            this.funcionarioToolStripMenuItem1.Click += new System.EventHandler(this.funcionarioToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(73, 36);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // StatusPrincipal
            // 
            this.StatusPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatuslbData,
            this.StatuslbHora,
            this.StatuslbMensagem,
            this.Nomefuncionario});
            this.StatusPrincipal.Location = new System.Drawing.Point(0, 0);
            this.StatusPrincipal.Name = "StatusPrincipal";
            this.StatusPrincipal.Size = new System.Drawing.Size(888, 22);
            this.StatusPrincipal.TabIndex = 2;
            this.StatusPrincipal.Text = "statusStrip1";
            // 
            // StatuslbData
            // 
            this.StatuslbData.Name = "StatuslbData";
            this.StatuslbData.Size = new System.Drawing.Size(31, 17);
            this.StatuslbData.Text = "Data";
            this.StatuslbData.Click += new System.EventHandler(this.StatuslbData_Click);
            // 
            // StatuslbHora
            // 
            this.StatuslbHora.Name = "StatuslbHora";
            this.StatuslbHora.Size = new System.Drawing.Size(33, 17);
            this.StatuslbHora.Text = "Hora";
            // 
            // StatuslbMensagem
            // 
            this.StatuslbMensagem.Name = "StatuslbMensagem";
            this.StatuslbMensagem.Size = new System.Drawing.Size(135, 17);
            this.StatuslbMensagem.Text = " Bem vindo ao sistema !!";
            // 
            // Nomefuncionario
            // 
            this.Nomefuncionario.Name = "Nomefuncionario";
            this.Nomefuncionario.Size = new System.Drawing.Size(0, 17);
            this.Nomefuncionario.Click += new System.EventHandler(this.toolStripStatusLabel1_Click_1);
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Enabled = true;
            this.timerPrincipal.Tick += new System.EventHandler(this.timerPrincipal_Tick);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(135, 35);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(0, 13);
            this.lbNome.TabIndex = 5;
            this.lbNome.Click += new System.EventHandler(this.NomeFunc_Click);
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            // 
            // vendasToolStripMenuItem2
            // 
            this.vendasToolStripMenuItem2.Name = "vendasToolStripMenuItem2";
            this.vendasToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.vendasToolStripMenuItem2.Text = "Vendas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 440);
            this.ControlBox = false;
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.StatusPrincipal);
            this.Controls.Add(this.MenuPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(890, 442);
            this.Name = "frmPrincipal";
            this.Text = "Sistema Cosmetico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.StatusPrincipal.ResumeLayout(false);
            this.StatusPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem CadCategoria;
        private System.Windows.Forms.ToolStripMenuItem CadMarca;
        private System.Windows.Forms.ToolStripMenuItem CadProduto;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel StatuslbMensagem;
        private System.Windows.Forms.ToolStripStatusLabel StatuslbData;
        private System.Windows.Forms.ToolStripStatusLabel StatuslbHora;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ToolStripStatusLabel Nomefuncionario;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem2;
    }
}

