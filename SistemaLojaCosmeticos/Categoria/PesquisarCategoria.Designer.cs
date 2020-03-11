namespace SistemaLojaCosmeticos
{
    partial class frmPesquisarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarCategoria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbCod = new System.Windows.Forms.GroupBox();
            this.txtCod = new System.Windows.Forms.TextBox();
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
            this.btSair = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbCod.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).BeginInit();
            this.gbPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbCod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.dtv);
            this.groupBox1.Controls.Add(this.gbPesquisar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.cbTipoPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 307);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar um Tipo de Consulta:";
            // 
            // gbCod
            // 
            this.gbCod.Controls.Add(this.txtCod);
            this.gbCod.Location = new System.Drawing.Point(19, 77);
            this.gbCod.Name = "gbCod";
            this.gbCod.Size = new System.Drawing.Size(326, 42);
            this.gbCod.TabIndex = 13;
            this.gbCod.TabStop = false;
            this.gbCod.Text = "Pesquisar por Código:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(6, 16);
            this.txtCod.MaxLength = 30;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(314, 20);
            this.txtCod.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(502, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Para Atualizar ou Excluir uma Categoria selecione a Categoria e clique no botão E" +
    "ditar!";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btPesquisar.Location = new System.Drawing.Point(405, 125);
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
            this.gbStatus.Location = new System.Drawing.Point(379, 77);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(146, 42);
            this.gbStatus.TabIndex = 5;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(83, 17);
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
            this.dtv.Location = new System.Drawing.Point(0, 188);
            this.dtv.MultiSelect = false;
            this.dtv.Name = "dtv";
            this.dtv.ReadOnly = true;
            this.dtv.RowHeadersVisible = false;
            this.dtv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtv.Size = new System.Drawing.Size(531, 106);
            this.dtv.TabIndex = 4;
            // 
            // gbPesquisar
            // 
            this.gbPesquisar.Controls.Add(this.rbContem);
            this.gbPesquisar.Controls.Add(this.rbInicio);
            this.gbPesquisar.Location = new System.Drawing.Point(379, 19);
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
            this.txtNome.Size = new System.Drawing.Size(232, 20);
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
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btSair.Location = new System.Drawing.Point(462, 376);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(81, 31);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btEditar.Location = new System.Drawing.Point(12, 376);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(81, 31);
            this.btEditar.TabIndex = 6;
            this.btEditar.Text = "Editar";
            this.btEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // frmPesquisarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 418);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btEditar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 418);
            this.MinimumSize = new System.Drawing.Size(555, 418);
            this.Name = "frmPesquisarCategoria";
            this.Text = "Pesquisa de Categoria";
            this.Load += new System.EventHandler(this.frmPesquisarCategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCod.ResumeLayout(false);
            this.gbCod.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).EndInit();
            this.gbPesquisar.ResumeLayout(false);
            this.gbPesquisar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.GroupBox gbCod;
        private System.Windows.Forms.TextBox txtCod;
    }
}