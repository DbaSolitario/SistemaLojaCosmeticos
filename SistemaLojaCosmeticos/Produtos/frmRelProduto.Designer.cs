namespace SistemaLojaCosmeticos
{
    partial class frmRelProduto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelProduto));
            this.classProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.rptv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbPreco = new System.Windows.Forms.GroupBox();
            this.precoate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Precode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.txtEstoqueate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstoquede = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbAniversariantes = new System.Windows.Forms.GroupBox();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btGerarRel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbPreco.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbEstoque.SuspendLayout();
            this.gbAniversariantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // classProdutoBindingSource
            // 
            this.classProdutoBindingSource.DataSource = typeof(SistemaLojaCosmeticos.classProduto);
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(162, 13);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(189, 21);
            this.cbTipoRel.TabIndex = 1;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // rptv
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classProdutoBindingSource;
            this.rptv.LocalReport.DataSources.Add(reportDataSource1);
            this.rptv.LocalReport.ReportEmbeddedResource = "SistemaLojaCosmeticos.Produtos.rptProduto.rdlc";
            this.rptv.Location = new System.Drawing.Point(12, 279);
            this.rptv.Name = "rptv";
            this.rptv.Size = new System.Drawing.Size(653, 216);
            this.rptv.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbPreco);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.gbEstoque);
            this.groupBox1.Controls.Add(this.gbAniversariantes);
            this.groupBox1.Controls.Add(this.btGerarRel);
            this.groupBox1.Controls.Add(this.cbTipoRel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 213);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // gbPreco
            // 
            this.gbPreco.Controls.Add(this.precoate);
            this.gbPreco.Controls.Add(this.label10);
            this.gbPreco.Controls.Add(this.Precode);
            this.gbPreco.Controls.Add(this.label11);
            this.gbPreco.Location = new System.Drawing.Point(262, 57);
            this.gbPreco.Name = "gbPreco";
            this.gbPreco.Size = new System.Drawing.Size(157, 54);
            this.gbPreco.TabIndex = 13;
            this.gbPreco.TabStop = false;
            this.gbPreco.Text = "Preço";
            // 
            // precoate
            // 
            this.precoate.Location = new System.Drawing.Point(113, 22);
            this.precoate.MaxLength = 5;
            this.precoate.Name = "precoate";
            this.precoate.Size = new System.Drawing.Size(32, 20);
            this.precoate.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Até:";
            // 
            // Precode
            // 
            this.Precode.Location = new System.Drawing.Point(36, 22);
            this.Precode.MaxLength = 5;
            this.Precode.Name = "Precode";
            this.Precode.Size = new System.Drawing.Size(32, 20);
            this.Precode.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "De:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(486, 94);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Marca:";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(486, 68);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 7;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(174, 117);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(137, 54);
            this.gbStatus.TabIndex = 6;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(61, 23);
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
            this.rbAtivo.Location = new System.Drawing.Point(6, 22);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbEstoque
            // 
            this.gbEstoque.Controls.Add(this.txtEstoqueate);
            this.gbEstoque.Controls.Add(this.label7);
            this.gbEstoque.Controls.Add(this.txtEstoquede);
            this.gbEstoque.Controls.Add(this.label6);
            this.gbEstoque.Location = new System.Drawing.Point(11, 117);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(157, 54);
            this.gbEstoque.TabIndex = 4;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Estoque";
            // 
            // txtEstoqueate
            // 
            this.txtEstoqueate.Location = new System.Drawing.Point(113, 22);
            this.txtEstoqueate.MaxLength = 5;
            this.txtEstoqueate.Name = "txtEstoqueate";
            this.txtEstoqueate.Size = new System.Drawing.Size(32, 20);
            this.txtEstoqueate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Até:";
            // 
            // txtEstoquede
            // 
            this.txtEstoquede.Location = new System.Drawing.Point(36, 22);
            this.txtEstoquede.MaxLength = 5;
            this.txtEstoquede.Name = "txtEstoquede";
            this.txtEstoquede.Size = new System.Drawing.Size(32, 20);
            this.txtEstoquede.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "De:";
            // 
            // gbAniversariantes
            // 
            this.gbAniversariantes.Controls.Add(this.dtpAte);
            this.gbAniversariantes.Controls.Add(this.label5);
            this.gbAniversariantes.Controls.Add(this.dtpDe);
            this.gbAniversariantes.Controls.Add(this.label4);
            this.gbAniversariantes.Location = new System.Drawing.Point(9, 54);
            this.gbAniversariantes.Name = "gbAniversariantes";
            this.gbAniversariantes.Size = new System.Drawing.Size(247, 57);
            this.gbAniversariantes.TabIndex = 3;
            this.gbAniversariantes.TabStop = false;
            this.gbAniversariantes.Text = "Data cadastro";
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(158, 19);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(79, 20);
            this.dtpAte.TabIndex = 16;
            this.dtpAte.Value = new System.DateTime(2017, 7, 4, 9, 49, 12, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Até:";
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(38, 19);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(79, 20);
            this.dtpDe.TabIndex = 14;
            this.dtpDe.Value = new System.DateTime(2017, 7, 4, 9, 49, 12, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "De:";
            // 
            // btGerarRel
            // 
            this.btGerarRel.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRel.Image")));
            this.btGerarRel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRel.Location = new System.Drawing.Point(486, 9);
            this.btGerarRel.Name = "btGerarRel";
            this.btGerarRel.Size = new System.Drawing.Size(121, 37);
            this.btGerarRel.TabIndex = 2;
            this.btGerarRel.Text = "Gerar Relatório";
            this.btGerarRel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerarRel.UseVisualStyleBackColor = true;
            this.btGerarRel.Click += new System.EventHandler(this.btGerarRel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Tipo de Relatório:";
            // 
            // frmRelProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 518);
            this.Controls.Add(this.rptv);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelProduto";
            this.Text = "Relatório de Produto";
            this.Load += new System.EventHandler(this.frmRelProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPreco.ResumeLayout(false);
            this.gbPreco.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            this.gbAniversariantes.ResumeLayout(false);
            this.gbAniversariantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoRel;
        private Microsoft.Reporting.WinForms.ReportViewer rptv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.TextBox txtEstoqueate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstoquede;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbAniversariantes;
        private System.Windows.Forms.Button btGerarRel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPreco;
        private System.Windows.Forms.TextBox precoate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Precode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource classProdutoBindingSource;
    }
}