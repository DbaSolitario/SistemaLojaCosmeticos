namespace SistemaLojaCosmeticos
{
    partial class frmConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCliente));
            this.btSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.gbMaiores = new System.Windows.Forms.GroupBox();
            this.txtMaiorDe = new System.Windows.Forms.TextBox();
            this.gbAniversariantes = new System.Windows.Forms.GroupBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.dtv = new System.Windows.Forms.DataGridView();
            this.gbPesquisar = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbMaiores.SuspendLayout();
            this.gbAniversariantes.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).BeginInit();
            this.gbPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btSair.Location = new System.Drawing.Point(505, 418);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(81, 31);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCidade);
            this.groupBox1.Controls.Add(this.gbMaiores);
            this.groupBox1.Controls.Add(this.gbAniversariantes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.dtv);
            this.groupBox1.Controls.Add(this.gbPesquisar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.cbTipoPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 355);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar um Tipo de Consulta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cidade:";
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(447, 130);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(121, 21);
            this.cbCidade.TabIndex = 15;
            // 
            // gbMaiores
            // 
            this.gbMaiores.Controls.Add(this.txtMaiorDe);
            this.gbMaiores.Location = new System.Drawing.Point(6, 133);
            this.gbMaiores.Name = "gbMaiores";
            this.gbMaiores.Size = new System.Drawing.Size(83, 54);
            this.gbMaiores.TabIndex = 13;
            this.gbMaiores.TabStop = false;
            this.gbMaiores.Text = "Maiores de :";
            // 
            // txtMaiorDe
            // 
            this.txtMaiorDe.Location = new System.Drawing.Point(20, 22);
            this.txtMaiorDe.MaxLength = 3;
            this.txtMaiorDe.Name = "txtMaiorDe";
            this.txtMaiorDe.Size = new System.Drawing.Size(46, 20);
            this.txtMaiorDe.TabIndex = 10;
            // 
            // gbAniversariantes
            // 
            this.gbAniversariantes.Controls.Add(this.cbMes);
            this.gbAniversariantes.Controls.Add(this.label3);
            this.gbAniversariantes.Controls.Add(this.cbDia);
            this.gbAniversariantes.Controls.Add(this.label2);
            this.gbAniversariantes.Location = new System.Drawing.Point(6, 70);
            this.gbAniversariantes.Name = "gbAniversariantes";
            this.gbAniversariantes.Size = new System.Drawing.Size(416, 57);
            this.gbAniversariantes.TabIndex = 12;
            this.gbAniversariantes.TabStop = false;
            this.gbAniversariantes.Text = "Aniversariantes";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(204, 24);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 21);
            this.cbMes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mês:";
            // 
            // cbDia
            // 
            this.cbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Location = new System.Drawing.Point(38, 24);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 21);
            this.cbDia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(10, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(423, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Para Atualizar ou Excluir um Cliente selecione  e clique no botão Editar!!!";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btPesquisar.Location = new System.Drawing.Point(453, 157);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(113, 44);
            this.btPesquisar.TabIndex = 10;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(430, 70);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(140, 42);
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
            this.dtv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv.Location = new System.Drawing.Point(9, 204);
            this.dtv.MultiSelect = false;
            this.dtv.Name = "dtv";
            this.dtv.ReadOnly = true;
            this.dtv.RowHeadersVisible = false;
            this.dtv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtv.Size = new System.Drawing.Size(557, 147);
            this.dtv.TabIndex = 4;
            this.dtv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_CellContentClick);
            // 
            // gbPesquisar
            // 
            this.gbPesquisar.Controls.Add(this.rbContem);
            this.gbPesquisar.Controls.Add(this.rbInicio);
            this.gbPesquisar.Location = new System.Drawing.Point(424, 16);
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
            this.txtNome.Location = new System.Drawing.Point(181, 30);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(237, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cbTipoPesquisa
            // 
            this.cbTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPesquisa.FormattingEnabled = true;
            this.cbTipoPesquisa.Location = new System.Drawing.Point(8, 30);
            this.cbTipoPesquisa.Name = "cbTipoPesquisa";
            this.cbTipoPesquisa.Size = new System.Drawing.Size(167, 21);
            this.cbTipoPesquisa.TabIndex = 0;
            this.cbTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbTipoPesquisa_SelectedIndexChanged);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btEditar.Location = new System.Drawing.Point(12, 418);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(81, 31);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Editar";
            this.btEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 461);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btEditar);
            this.MaximumSize = new System.Drawing.Size(598, 461);
            this.MinimumSize = new System.Drawing.Size(598, 461);
            this.Name = "frmConsultaCliente";
            this.Text = "Consulta de Cliente";
            this.Load += new System.EventHandler(this.frmConsultaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMaiores.ResumeLayout(false);
            this.gbMaiores.PerformLayout();
            this.gbAniversariantes.ResumeLayout(false);
            this.gbAniversariantes.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).EndInit();
            this.gbPesquisar.ResumeLayout(false);
            this.gbPesquisar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.DataGridView dtv;
        private System.Windows.Forms.GroupBox gbPesquisar;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbTipoPesquisa;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.GroupBox gbMaiores;
        private System.Windows.Forms.TextBox txtMaiorDe;
        private System.Windows.Forms.GroupBox gbAniversariantes;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.Label label2;
    }
}