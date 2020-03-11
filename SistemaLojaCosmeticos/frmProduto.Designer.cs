namespace SistemaLojaCosmeticos
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCadProduto = new System.Windows.Forms.Button();
            this.buttonSairProduto = new System.Windows.Forms.Button();
            this.buttonLimparProduto = new System.Windows.Forms.Button();
            this.buttonExcluirProduto = new System.Windows.Forms.Button();
            this.buttonAtualizarProduto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cadastro de Produto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtQtde);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbdata);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 246);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(379, 73);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 2;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Marca:";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(379, 105);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(9, 141);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(491, 99);
            this.txtObservacao.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(167, 105);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(77, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "* Preço de Venda:";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(167, 79);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(77, 20);
            this.txtQtde.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "* Quantidade em Estoque:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(130, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(149, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "* Nome do Produto:";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cbStatus.Location = new System.Drawing.Point(446, 16);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(50, 17);
            this.cbStatus.TabIndex = 12;
            this.cbStatus.Text = "Ativo";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "* Status:";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbdata.Location = new System.Drawing.Point(276, 16);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(33, 13);
            this.lbdata.TabIndex = 3;
            this.lbdata.Text = "Data ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Data Cadastro:";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(119, 13);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(44, 20);
            this.txtCod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "* Codigo Produto:";
            // 
            // buttonCadProduto
            // 
            this.buttonCadProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadProduto.Image = ((System.Drawing.Image)(resources.GetObject("buttonCadProduto.Image")));
            this.buttonCadProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadProduto.Location = new System.Drawing.Point(7, 326);
            this.buttonCadProduto.Name = "buttonCadProduto";
            this.buttonCadProduto.Size = new System.Drawing.Size(104, 47);
            this.buttonCadProduto.TabIndex = 0;
            this.buttonCadProduto.Text = "Cadastrar";
            this.buttonCadProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCadProduto.UseVisualStyleBackColor = true;
            this.buttonCadProduto.Click += new System.EventHandler(this.buttonCadProduto_Click);
            // 
            // buttonSairProduto
            // 
            this.buttonSairProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairProduto.Image = ((System.Drawing.Image)(resources.GetObject("buttonSairProduto.Image")));
            this.buttonSairProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSairProduto.Location = new System.Drawing.Point(420, 326);
            this.buttonSairProduto.Name = "buttonSairProduto";
            this.buttonSairProduto.Size = new System.Drawing.Size(95, 47);
            this.buttonSairProduto.TabIndex = 18;
            this.buttonSairProduto.Text = "Sair";
            this.buttonSairProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSairProduto.UseVisualStyleBackColor = true;
            this.buttonSairProduto.Click += new System.EventHandler(this.buttonSairProduto_Click);
            // 
            // buttonLimparProduto
            // 
            this.buttonLimparProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparProduto.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimparProduto.Image")));
            this.buttonLimparProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimparProduto.Location = new System.Drawing.Point(319, 326);
            this.buttonLimparProduto.Name = "buttonLimparProduto";
            this.buttonLimparProduto.Size = new System.Drawing.Size(95, 47);
            this.buttonLimparProduto.TabIndex = 17;
            this.buttonLimparProduto.Text = "Limpar";
            this.buttonLimparProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimparProduto.UseVisualStyleBackColor = true;
            this.buttonLimparProduto.Click += new System.EventHandler(this.buttonLimparProduto_Click);
            // 
            // buttonExcluirProduto
            // 
            this.buttonExcluirProduto.Enabled = false;
            this.buttonExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirProduto.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirProduto.Image")));
            this.buttonExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirProduto.Location = new System.Drawing.Point(218, 326);
            this.buttonExcluirProduto.Name = "buttonExcluirProduto";
            this.buttonExcluirProduto.Size = new System.Drawing.Size(95, 47);
            this.buttonExcluirProduto.TabIndex = 16;
            this.buttonExcluirProduto.Text = "Excluir";
            this.buttonExcluirProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizarProduto
            // 
            this.buttonAtualizarProduto.Enabled = false;
            this.buttonAtualizarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizarProduto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtualizarProduto.Image")));
            this.buttonAtualizarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtualizarProduto.Location = new System.Drawing.Point(117, 326);
            this.buttonAtualizarProduto.Name = "buttonAtualizarProduto";
            this.buttonAtualizarProduto.Size = new System.Drawing.Size(95, 47);
            this.buttonAtualizarProduto.TabIndex = 15;
            this.buttonAtualizarProduto.Text = "Atualizar";
            this.buttonAtualizarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAtualizarProduto.UseVisualStyleBackColor = true;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 396);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCadProduto);
            this.Controls.Add(this.buttonSairProduto);
            this.Controls.Add(this.buttonLimparProduto);
            this.Controls.Add(this.buttonExcluirProduto);
            this.Controls.Add(this.buttonAtualizarProduto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(546, 435);
            this.MinimumSize = new System.Drawing.Size(546, 435);
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button buttonCadProduto;
        private System.Windows.Forms.Button buttonSairProduto;
        private System.Windows.Forms.Button buttonLimparProduto;
        private System.Windows.Forms.Button buttonExcluirProduto;
        private System.Windows.Forms.Button buttonAtualizarProduto;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}