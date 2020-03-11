namespace SistemaLojaCosmeticos
{
    partial class frmVendaCliGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendaCliGrid));
            this.btRemoveProduto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalDesconto = new System.Windows.Forms.TextBox();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtQtdeItens = new System.Windows.Forms.TextBox();
            this.txtQtdeEstoque = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtPesqProduto = new System.Windows.Forms.TextBox();
            this.btBuscaProduto = new System.Windows.Forms.Button();
            this.btFechaVenda = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPesqCliente = new System.Windows.Forms.TextBox();
            this.btBuscaCliente = new System.Windows.Forms.Button();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRemoveProduto
            // 
            this.btRemoveProduto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRemoveProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRemoveProduto.Image = ((System.Drawing.Image)(resources.GetObject("btRemoveProduto.Image")));
            this.btRemoveProduto.Location = new System.Drawing.Point(901, 83);
            this.btRemoveProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btRemoveProduto.Name = "btRemoveProduto";
            this.btRemoveProduto.Size = new System.Drawing.Size(45, 48);
            this.btRemoveProduto.TabIndex = 160;
            this.btRemoveProduto.UseVisualStyleBackColor = true;
            this.btRemoveProduto.Click += new System.EventHandler(this.btRemoveProduto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtObservacao);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 481);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(468, 83);
            this.groupBox3.TabIndex = 158;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observações:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtObservacao.Location = new System.Drawing.Point(7, 27);
            this.txtObservacao.MaxLength = 150;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(449, 49);
            this.txtObservacao.TabIndex = 66;
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(504, 533);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(150, 31);
            this.txtTotalVenda.TabIndex = 157;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(504, 507);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 23);
            this.label11.TabIndex = 156;
            this.label11.Text = "Total da Venda (R$)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(685, 469);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 155;
            this.label2.Text = "=";
            // 
            // txtTotalDesconto
            // 
            this.txtTotalDesconto.Enabled = false;
            this.txtTotalDesconto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDesconto.Location = new System.Drawing.Point(704, 465);
            this.txtTotalDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDesconto.Name = "txtTotalDesconto";
            this.txtTotalDesconto.Size = new System.Drawing.Size(80, 31);
            this.txtTotalDesconto.TabIndex = 154;
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDesconto.Location = new System.Drawing.Point(643, 465);
            this.txtValorDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorDesconto.MaxLength = 2;
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(42, 31);
            this.txtValorDesconto.TabIndex = 153;
            this.txtValorDesconto.TextChanged += new System.EventHandler(this.txtValorDesconto_TextChanged);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(504, 465);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(120, 31);
            this.txtValorTotal.TabIndex = 152;
            // 
            // txtQtdeItens
            // 
            this.txtQtdeItens.Enabled = false;
            this.txtQtdeItens.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItens.Location = new System.Drawing.Point(674, 533);
            this.txtQtdeItens.Name = "txtQtdeItens";
            this.txtQtdeItens.Size = new System.Drawing.Size(110, 31);
            this.txtQtdeItens.TabIndex = 151;
            // 
            // txtQtdeEstoque
            // 
            this.txtQtdeEstoque.Enabled = false;
            this.txtQtdeEstoque.Location = new System.Drawing.Point(847, 45);
            this.txtQtdeEstoque.Name = "txtQtdeEstoque";
            this.txtQtdeEstoque.Size = new System.Drawing.Size(99, 27);
            this.txtQtdeEstoque.TabIndex = 150;
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(503, 45);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(332, 27);
            this.txtProduto.TabIndex = 149;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProduto);
            this.groupBox1.Controls.Add(this.txtPesqProduto);
            this.groupBox1.Controls.Add(this.btBuscaProduto);
            this.groupBox1.Location = new System.Drawing.Point(13, 257);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(468, 220);
            this.groupBox1.TabIndex = 148;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa de Produtos:";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.Location = new System.Drawing.Point(8, 71);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(448, 142);
            this.dgvProduto.TabIndex = 0;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            // 
            // txtPesqProduto
            // 
            this.txtPesqProduto.Location = new System.Drawing.Point(7, 31);
            this.txtPesqProduto.Name = "txtPesqProduto";
            this.txtPesqProduto.Size = new System.Drawing.Size(399, 27);
            this.txtPesqProduto.TabIndex = 1;
            // 
            // btBuscaProduto
            // 
            this.btBuscaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaProduto.Image")));
            this.btBuscaProduto.Location = new System.Drawing.Point(412, 23);
            this.btBuscaProduto.Name = "btBuscaProduto";
            this.btBuscaProduto.Size = new System.Drawing.Size(44, 42);
            this.btBuscaProduto.TabIndex = 3;
            this.btBuscaProduto.UseVisualStyleBackColor = true;
            this.btBuscaProduto.Click += new System.EventHandler(this.btBuscaProduto_Click);
            // 
            // btFechaVenda
            // 
            this.btFechaVenda.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechaVenda.Image = ((System.Drawing.Image)(resources.GetObject("btFechaVenda.Image")));
            this.btFechaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFechaVenda.Location = new System.Drawing.Point(790, 503);
            this.btFechaVenda.Name = "btFechaVenda";
            this.btFechaVenda.Size = new System.Drawing.Size(176, 62);
            this.btFechaVenda.TabIndex = 146;
            this.btFechaVenda.Text = "            Fechar Venda";
            this.btFechaVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFechaVenda.UseVisualStyleBackColor = true;
            this.btFechaVenda.Click += new System.EventHandler(this.btFechaVenda_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(643, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 23);
            this.label13.TabIndex = 145;
            this.label13.Text = "Desconto (%)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(504, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 23);
            this.label10.TabIndex = 144;
            this.label10.Text = "Valor Total (R$)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(669, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 143;
            this.label9.Text = "Qtde Itens:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvItens);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(493, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 289);
            this.groupBox2.TabIndex = 142;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens da Venda:";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeColumns = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.Location = new System.Drawing.Point(5, 25);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(462, 254);
            this.dgvItens.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(728, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 141;
            this.label7.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(730, 103);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(105, 27);
            this.txtTotal.TabIndex = 140;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 139;
            this.label6.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(611, 103);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(105, 27);
            this.txtValor.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 137;
            this.label5.Text = "Qtde";
            // 
            // txtQtde
            // 
            this.txtQtde.BackColor = System.Drawing.Color.White;
            this.txtQtde.Location = new System.Drawing.Point(503, 103);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(95, 27);
            this.txtQtde.TabIndex = 136;
            this.txtQtde.TextChanged += new System.EventHandler(this.txtQtde_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(857, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 135;
            this.label4.Text = "Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 134;
            this.label3.Text = "Produto";
            // 
            // btAddProduto
            // 
            this.btAddProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAddProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAddProduto.Image = ((System.Drawing.Image)(resources.GetObject("btAddProduto.Image")));
            this.btAddProduto.Location = new System.Drawing.Point(847, 83);
            this.btAddProduto.Name = "btAddProduto";
            this.btAddProduto.Size = new System.Drawing.Size(45, 48);
            this.btAddProduto.TabIndex = 133;
            this.btAddProduto.UseVisualStyleBackColor = true;
            this.btAddProduto.Click += new System.EventHandler(this.btAddProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 132;
            this.label1.Text = "* Funcionário:";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFuncionario.Location = new System.Drawing.Point(116, 21);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(365, 27);
            this.cbFuncionario.TabIndex = 131;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.Location = new System.Drawing.Point(7, 70);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(448, 117);
            this.dgvCliente.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCliente);
            this.groupBox4.Controls.Add(this.txtPesqCliente);
            this.groupBox4.Controls.Add(this.btBuscaCliente);
            this.groupBox4.Location = new System.Drawing.Point(13, 55);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(468, 194);
            this.groupBox4.TabIndex = 149;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisa de Clientes:";
            // 
            // txtPesqCliente
            // 
            this.txtPesqCliente.Location = new System.Drawing.Point(7, 31);
            this.txtPesqCliente.Name = "txtPesqCliente";
            this.txtPesqCliente.Size = new System.Drawing.Size(399, 27);
            this.txtPesqCliente.TabIndex = 1;
            // 
            // btBuscaCliente
            // 
            this.btBuscaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaCliente.Image")));
            this.btBuscaCliente.Location = new System.Drawing.Point(412, 23);
            this.btBuscaCliente.Name = "btBuscaCliente";
            this.btBuscaCliente.Size = new System.Drawing.Size(44, 42);
            this.btBuscaCliente.TabIndex = 3;
            this.btBuscaCliente.UseVisualStyleBackColor = true;
            this.btBuscaCliente.Click += new System.EventHandler(this.btBuscaCliente_Click);
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFormaPagamento.Location = new System.Drawing.Point(791, 466);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(162, 27);
            this.cbFormaPagamento.TabIndex = 162;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(801, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 23);
            this.label12.TabIndex = 161;
            this.label12.Text = "Forma Pagamento:";
            // 
            // frmVendaCliGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 576);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btRemoveProduto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTotalVenda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalDesconto);
            this.Controls.Add(this.txtValorDesconto);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtQtdeItens);
            this.Controls.Add(this.txtQtdeEstoque);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btFechaVenda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAddProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFuncionario);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendaCliGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmVendaCliGrid_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRemoveProduto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalDesconto;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtQtdeItens;
        private System.Windows.Forms.TextBox txtQtdeEstoque;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtPesqProduto;
        private System.Windows.Forms.Button btBuscaProduto;
        private System.Windows.Forms.Button btFechaVenda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPesqCliente;
        private System.Windows.Forms.Button btBuscaCliente;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label12;

    }
}