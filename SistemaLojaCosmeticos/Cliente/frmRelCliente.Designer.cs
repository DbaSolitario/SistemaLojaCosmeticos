namespace SistemaLojaCosmeticos
{
    partial class frmRelCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelCliente));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbMaiores = new System.Windows.Forms.GroupBox();
            this.txtMaiorDe = new System.Windows.Forms.TextBox();
            this.gbIdade = new System.Windows.Forms.GroupBox();
            this.txtIdadeAte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdadeDe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbAniversariantes = new System.Windows.Forms.GroupBox();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btGerarRel = new System.Windows.Forms.Button();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rptv = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classClienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbMaiores.SuspendLayout();
            this.gbIdade.SuspendLayout();
            this.gbAniversariantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // classClienteBindingSource
            // 
            this.classClienteBindingSource.DataSource = typeof(SistemaLojaCosmeticos.classCliente);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCidade);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbSexo);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.gbMaiores);
            this.groupBox1.Controls.Add(this.gbIdade);
            this.groupBox1.Controls.Add(this.gbAniversariantes);
            this.groupBox1.Controls.Add(this.btGerarRel);
            this.groupBox1.Controls.Add(this.cbTipoRel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cidade:";
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(456, 141);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(121, 21);
            this.cbCidade.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(456, 114);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 7;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(263, 117);
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
            // gbMaiores
            // 
            this.gbMaiores.Controls.Add(this.txtMaiorDe);
            this.gbMaiores.Location = new System.Drawing.Point(174, 117);
            this.gbMaiores.Name = "gbMaiores";
            this.gbMaiores.Size = new System.Drawing.Size(83, 54);
            this.gbMaiores.TabIndex = 5;
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
            // gbIdade
            // 
            this.gbIdade.Controls.Add(this.txtIdadeAte);
            this.gbIdade.Controls.Add(this.label7);
            this.gbIdade.Controls.Add(this.txtIdadeDe);
            this.gbIdade.Controls.Add(this.label6);
            this.gbIdade.Location = new System.Drawing.Point(11, 117);
            this.gbIdade.Name = "gbIdade";
            this.gbIdade.Size = new System.Drawing.Size(157, 54);
            this.gbIdade.TabIndex = 4;
            this.gbIdade.TabStop = false;
            this.gbIdade.Text = "Idade";
            // 
            // txtIdadeAte
            // 
            this.txtIdadeAte.Location = new System.Drawing.Point(113, 22);
            this.txtIdadeAte.MaxLength = 3;
            this.txtIdadeAte.Name = "txtIdadeAte";
            this.txtIdadeAte.Size = new System.Drawing.Size(32, 20);
            this.txtIdadeAte.TabIndex = 9;
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
            // txtIdadeDe
            // 
            this.txtIdadeDe.Location = new System.Drawing.Point(36, 22);
            this.txtIdadeDe.MaxLength = 3;
            this.txtIdadeDe.Name = "txtIdadeDe";
            this.txtIdadeDe.Size = new System.Drawing.Size(32, 20);
            this.txtIdadeDe.TabIndex = 7;
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
            this.gbAniversariantes.Controls.Add(this.cbMes);
            this.gbAniversariantes.Controls.Add(this.label3);
            this.gbAniversariantes.Controls.Add(this.cbDia);
            this.gbAniversariantes.Controls.Add(this.label2);
            this.gbAniversariantes.Location = new System.Drawing.Point(9, 54);
            this.gbAniversariantes.Name = "gbAniversariantes";
            this.gbAniversariantes.Size = new System.Drawing.Size(568, 57);
            this.gbAniversariantes.TabIndex = 3;
            this.gbAniversariantes.TabStop = false;
            this.gbAniversariantes.Text = "Aniversariantes";
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(482, 24);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(79, 20);
            this.dtpAte.TabIndex = 8;
            this.dtpAte.Value = new System.DateTime(2017, 7, 4, 9, 49, 12, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Até:";
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(362, 24);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(79, 20);
            this.dtpDe.TabIndex = 6;
            this.dtpDe.Value = new System.DateTime(2017, 7, 4, 9, 49, 12, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "De:";
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
            // btGerarRel
            // 
            this.btGerarRel.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRel.Image")));
            this.btGerarRel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRel.Location = new System.Drawing.Point(456, 13);
            this.btGerarRel.Name = "btGerarRel";
            this.btGerarRel.Size = new System.Drawing.Size(121, 37);
            this.btGerarRel.TabIndex = 2;
            this.btGerarRel.Text = "Gerar Relatório";
            this.btGerarRel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerarRel.UseVisualStyleBackColor = true;
            this.btGerarRel.Click += new System.EventHandler(this.btGerarRel_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Tipo de Relatório:";
            // 
            // rptv
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classClienteBindingSource;
            this.rptv.LocalReport.DataSources.Add(reportDataSource1);
            this.rptv.LocalReport.ReportEmbeddedResource = "SistemaLojaCosmeticos.rptCliente.rdlc";
            this.rptv.Location = new System.Drawing.Point(12, 250);
            this.rptv.Name = "rptv";
            this.rptv.Size = new System.Drawing.Size(621, 275);
            this.rptv.TabIndex = 1;
            // 
            // frmRelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 538);
            this.Controls.Add(this.rptv);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(644, 538);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(644, 538);
            this.Name = "frmRelCliente";
            this.Text = "Relatório de Clientes";
            this.Load += new System.EventHandler(this.frmRelCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classClienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbMaiores.ResumeLayout(false);
            this.gbMaiores.PerformLayout();
            this.gbIdade.ResumeLayout(false);
            this.gbIdade.PerformLayout();
            this.gbAniversariantes.ResumeLayout(false);
            this.gbAniversariantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Button btGerarRel;
        private System.Windows.Forms.GroupBox gbAniversariantes;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.GroupBox gbMaiores;
        private System.Windows.Forms.TextBox txtMaiorDe;
        private System.Windows.Forms.GroupBox gbIdade;
        private System.Windows.Forms.TextBox txtIdadeAte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdadeDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCidade;
        private Microsoft.Reporting.WinForms.ReportViewer rptv;
        private System.Windows.Forms.BindingSource classClienteBindingSource;
    }
}