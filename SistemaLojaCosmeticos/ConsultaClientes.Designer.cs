namespace SistemaLojaCosmeticos
{
    partial class ConsultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaClientes));
            this.btSair = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.gbPesquisar = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.dtv = new System.Windows.Forms.DataGridView();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btSair.Location = new System.Drawing.Point(424, 418);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(81, 31);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(133, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(202, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cbTipoPesquisa
            // 
            this.cbTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPesquisa.FormattingEnabled = true;
            this.cbTipoPesquisa.Location = new System.Drawing.Point(6, 33);
            this.cbTipoPesquisa.Name = "cbTipoPesquisa";
            this.cbTipoPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPesquisa.TabIndex = 0;
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
            // gbPesquisar
            // 
            this.gbPesquisar.Controls.Add(this.rbContem);
            this.gbPesquisar.Controls.Add(this.rbInicio);
            this.gbPesquisar.Location = new System.Drawing.Point(341, 17);
            this.gbPesquisar.Name = "gbPesquisar";
            this.gbPesquisar.Size = new System.Drawing.Size(146, 42);
            this.gbPesquisar.TabIndex = 2;
            this.gbPesquisar.TabStop = false;
            this.gbPesquisar.Text = "Tipo de Pesquisa:";
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
            // dtv
            // 
            this.dtv.AllowUserToAddRows = false;
            this.dtv.AllowUserToDeleteRows = false;
            this.dtv.AllowUserToResizeColumns = false;
            this.dtv.AllowUserToResizeRows = false;
            this.dtv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv.Location = new System.Drawing.Point(7, 233);
            this.dtv.MultiSelect = false;
            this.dtv.Name = "dtv";
            this.dtv.ReadOnly = true;
            this.dtv.RowHeadersVisible = false;
            this.dtv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtv.Size = new System.Drawing.Size(481, 147);
            this.dtv.TabIndex = 4;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(27, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Para Atualizar ou Excluir um Funcionario selecione  e clique no botão Editar!!!";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btPesquisar.Location = new System.Drawing.Point(364, 170);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(113, 44);
            this.btPesquisar.TabIndex = 10;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(341, 69);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(146, 42);
            this.gbStatus.TabIndex = 5;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.dtv);
            this.groupBox1.Controls.Add(this.gbPesquisar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.cbTipoPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.MaximumSize = new System.Drawing.Size(493, 400);
            this.groupBox1.MinimumSize = new System.Drawing.Size(493, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 400);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar um Tipo de Consulta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(7, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 51);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cidade, Estado, Cep";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 2;
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 455);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes";
            this.Load += new System.EventHandler(this.ConsultaClientes_Load);
            this.gbPesquisar.ResumeLayout(false);
            this.gbPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbTipoPesquisa;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.GroupBox gbPesquisar;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.DataGridView dtv;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}