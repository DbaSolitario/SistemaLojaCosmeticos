namespace SistemaLojaCosmeticos
{
    partial class frmConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProduto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstoqueMaior = new System.Windows.Forms.TextBox();
            this.txtEstoqueMenor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.dtv = new System.Windows.Forms.DataGridView();
            this.gbPreco = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaiorque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoFinal = new System.Windows.Forms.TextBox();
            this.txtPrecoInicial = new System.Windows.Forms.TextBox();
            this.gbPesquisar = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbEstoque.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).BeginInit();
            this.gbPreco.SuspendLayout();
            this.gbPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbEstoque);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.dtv);
            this.groupBox1.Controls.Add(this.gbPreco);
            this.groupBox1.Controls.Add(this.gbPesquisar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.cbTipoPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(11, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar um Tipo de Consulta:";
            // 
            // gbEstoque
            // 
            this.gbEstoque.Controls.Add(this.label8);
            this.gbEstoque.Controls.Add(this.label9);
            this.gbEstoque.Controls.Add(this.txtEstoqueMaior);
            this.gbEstoque.Controls.Add(this.txtEstoqueMenor);
            this.gbEstoque.Location = new System.Drawing.Point(6, 167);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(329, 61);
            this.gbEstoque.TabIndex = 12;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Estoque:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Maior que:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Menor que:";
            // 
            // txtEstoqueMaior
            // 
            this.txtEstoqueMaior.Location = new System.Drawing.Point(228, 19);
            this.txtEstoqueMaior.MaxLength = 10;
            this.txtEstoqueMaior.Name = "txtEstoqueMaior";
            this.txtEstoqueMaior.Size = new System.Drawing.Size(83, 20);
            this.txtEstoqueMaior.TabIndex = 3;
            // 
            // txtEstoqueMenor
            // 
            this.txtEstoqueMenor.Location = new System.Drawing.Point(74, 19);
            this.txtEstoqueMenor.MaxLength = 10;
            this.txtEstoqueMenor.Name = "txtEstoqueMenor";
            this.txtEstoqueMenor.Size = new System.Drawing.Size(78, 20);
            this.txtEstoqueMenor.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(483, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Para Atualizar ou Excluir um Produto selecione o Produto e clique no botão Editar" +
    "!!!";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btPesquisar.Location = new System.Drawing.Point(364, 172);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(113, 44);
            this.btPesquisar.TabIndex = 10;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(246, 234);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 7;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(58, 234);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 6;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(341, 71);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(146, 42);
            this.gbStatus.TabIndex = 5;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(79, 17);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(6, 17);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // dtv
            // 
            this.dtv.AllowUserToAddRows = false;
            this.dtv.AllowUserToDeleteRows = false;
            this.dtv.AllowUserToResizeColumns = false;
            this.dtv.AllowUserToResizeRows = false;
            this.dtv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv.Location = new System.Drawing.Point(6, 283);
            this.dtv.MultiSelect = false;
            this.dtv.Name = "dtv";
            this.dtv.ReadOnly = true;
            this.dtv.RowHeadersVisible = false;
            this.dtv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtv.Size = new System.Drawing.Size(481, 147);
            this.dtv.TabIndex = 4;
            // 
            // gbPreco
            // 
            this.gbPreco.Controls.Add(this.label6);
            this.gbPreco.Controls.Add(this.txtMaiorque);
            this.gbPreco.Controls.Add(this.label2);
            this.gbPreco.Controls.Add(this.label1);
            this.gbPreco.Controls.Add(this.txtPrecoFinal);
            this.gbPreco.Controls.Add(this.txtPrecoInicial);
            this.gbPreco.Location = new System.Drawing.Point(6, 71);
            this.gbPreco.Name = "gbPreco";
            this.gbPreco.Size = new System.Drawing.Size(329, 91);
            this.gbPreco.TabIndex = 3;
            this.gbPreco.TabStop = false;
            this.gbPreco.Text = "Valores:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Maiores que:";
            // 
            // txtMaiorque
            // 
            this.txtMaiorque.Location = new System.Drawing.Point(81, 55);
            this.txtMaiorque.MaxLength = 10;
            this.txtMaiorque.Name = "txtMaiorque";
            this.txtMaiorque.Size = new System.Drawing.Size(78, 20);
            this.txtMaiorque.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preço Inicial:";
            // 
            // txtPrecoFinal
            // 
            this.txtPrecoFinal.Location = new System.Drawing.Point(234, 19);
            this.txtPrecoFinal.MaxLength = 10;
            this.txtPrecoFinal.Name = "txtPrecoFinal";
            this.txtPrecoFinal.Size = new System.Drawing.Size(83, 20);
            this.txtPrecoFinal.TabIndex = 3;
            this.txtPrecoFinal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPrecoInicial
            // 
            this.txtPrecoInicial.Location = new System.Drawing.Point(81, 19);
            this.txtPrecoInicial.MaxLength = 10;
            this.txtPrecoInicial.Name = "txtPrecoInicial";
            this.txtPrecoInicial.Size = new System.Drawing.Size(78, 20);
            this.txtPrecoInicial.TabIndex = 2;
            // 
            // gbPesquisar
            // 
            this.gbPesquisar.Controls.Add(this.rbContem);
            this.gbPesquisar.Controls.Add(this.rbInicio);
            this.gbPesquisar.Location = new System.Drawing.Point(341, 19);
            this.gbPesquisar.Name = "gbPesquisar";
            this.gbPesquisar.Size = new System.Drawing.Size(146, 42);
            this.gbPesquisar.TabIndex = 2;
            this.gbPesquisar.TabStop = false;
            this.gbPesquisar.Text = "Tipo de Pesquisa:";
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Checked = true;
            this.rbContem.Location = new System.Drawing.Point(79, 17);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(61, 17);
            this.rbContem.TabIndex = 1;
            this.rbContem.TabStop = true;
            this.rbContem.Text = "Contém";
            this.rbContem.UseVisualStyleBackColor = true;
            // 
            // rbInicio
            // 
            this.rbInicio.AutoSize = true;
            this.rbInicio.Location = new System.Drawing.Point(6, 17);
            this.rbInicio.Name = "rbInicio";
            this.rbInicio.Size = new System.Drawing.Size(52, 17);
            this.rbInicio.TabIndex = 0;
            this.rbInicio.Text = "Início";
            this.rbInicio.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(133, 35);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(202, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cbTipoPesquisa
            // 
            this.cbTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPesquisa.FormattingEnabled = true;
            this.cbTipoPesquisa.Location = new System.Drawing.Point(6, 35);
            this.cbTipoPesquisa.Name = "cbTipoPesquisa";
            this.cbTipoPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPesquisa.TabIndex = 0;
            this.cbTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbTipoPesquisa_SelectedIndexChanged);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btEditar.Location = new System.Drawing.Point(10, 499);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(81, 31);
            this.btEditar.TabIndex = 1;
            this.btEditar.Text = "Editar";
            this.btEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btSair.Location = new System.Drawing.Point(422, 499);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(81, 31);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 542);
            this.ControlBox = false;
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(532, 467);
            this.Name = "frmConsultaProduto";
            this.Text = "Consulta de Produto";
            this.Load += new System.EventHandler(this.txtPrecoInicial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).EndInit();
            this.gbPreco.ResumeLayout(false);
            this.gbPreco.PerformLayout();
            this.gbPesquisar.ResumeLayout(false);
            this.gbPesquisar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbPesquisar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbTipoPesquisa;
        private System.Windows.Forms.GroupBox gbPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoFinal;
        private System.Windows.Forms.TextBox txtPrecoInicial;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtv;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaiorque;
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstoqueMaior;
        private System.Windows.Forms.TextBox txtEstoqueMenor;
    }
}