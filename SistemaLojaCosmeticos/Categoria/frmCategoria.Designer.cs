namespace SistemaLojaCosmeticos
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxObsCategoria = new System.Windows.Forms.TextBox();
            this.lbDataCad = new System.Windows.Forms.Label();
            this.checkboxStatus = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNomeCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCodCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAtualizarCategoria = new System.Windows.Forms.Button();
            this.buttonExcluirCategoria = new System.Windows.Forms.Button();
            this.buttonLimparCategoria = new System.Windows.Forms.Button();
            this.buttonSairCategoria = new System.Windows.Forms.Button();
            this.buttonCadCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxObsCategoria);
            this.groupBox1.Controls.Add(this.lbDataCad);
            this.groupBox1.Controls.Add(this.checkboxStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxNomeCategoria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCodCategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(271, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Todos os campos com  *  são Obrigatórios !!";
            // 
            // textBoxObsCategoria
            // 
            this.textBoxObsCategoria.Location = new System.Drawing.Point(0, 131);
            this.textBoxObsCategoria.MaxLength = 50;
            this.textBoxObsCategoria.Multiline = true;
            this.textBoxObsCategoria.Name = "textBoxObsCategoria";
            this.textBoxObsCategoria.Size = new System.Drawing.Size(534, 85);
            this.textBoxObsCategoria.TabIndex = 3;
            // 
            // lbDataCad
            // 
            this.lbDataCad.AutoSize = true;
            this.lbDataCad.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbDataCad.Location = new System.Drawing.Point(297, 17);
            this.lbDataCad.Name = "lbDataCad";
            this.lbDataCad.Size = new System.Drawing.Size(30, 13);
            this.lbDataCad.TabIndex = 8;
            this.lbDataCad.Text = "Data";
            // 
            // checkboxStatus
            // 
            this.checkboxStatus.AutoSize = true;
            this.checkboxStatus.Checked = true;
            this.checkboxStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxStatus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkboxStatus.Location = new System.Drawing.Point(479, 16);
            this.checkboxStatus.Name = "checkboxStatus";
            this.checkboxStatus.Size = new System.Drawing.Size(50, 17);
            this.checkboxStatus.TabIndex = 1;
            this.checkboxStatus.Text = "Ativo";
            this.checkboxStatus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "* Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Observações:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxNomeCategoria
            // 
            this.textBoxNomeCategoria.Location = new System.Drawing.Point(138, 69);
            this.textBoxNomeCategoria.MaxLength = 20;
            this.textBoxNomeCategoria.Name = "textBoxNomeCategoria";
            this.textBoxNomeCategoria.Size = new System.Drawing.Size(344, 20);
            this.textBoxNomeCategoria.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "* Nome da categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Data Cadastro:";
            // 
            // textBoxCodCategoria
            // 
            this.textBoxCodCategoria.Enabled = false;
            this.textBoxCodCategoria.Location = new System.Drawing.Point(138, 13);
            this.textBoxCodCategoria.Name = "textBoxCodCategoria";
            this.textBoxCodCategoria.Size = new System.Drawing.Size(46, 20);
            this.textBoxCodCategoria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "* Código de Categoria:";
            // 
            // buttonAtualizarCategoria
            // 
            this.buttonAtualizarCategoria.Enabled = false;
            this.buttonAtualizarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtualizarCategoria.Image")));
            this.buttonAtualizarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtualizarCategoria.Location = new System.Drawing.Point(134, 324);
            this.buttonAtualizarCategoria.Name = "buttonAtualizarCategoria";
            this.buttonAtualizarCategoria.Size = new System.Drawing.Size(95, 47);
            this.buttonAtualizarCategoria.TabIndex = 1;
            this.buttonAtualizarCategoria.Text = "Atualizar";
            this.buttonAtualizarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAtualizarCategoria.UseVisualStyleBackColor = true;
            this.buttonAtualizarCategoria.Click += new System.EventHandler(this.buttonAtualizarCategoria_Click);
            // 
            // buttonExcluirCategoria
            // 
            this.buttonExcluirCategoria.Enabled = false;
            this.buttonExcluirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirCategoria.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirCategoria.Image")));
            this.buttonExcluirCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirCategoria.Location = new System.Drawing.Point(247, 324);
            this.buttonExcluirCategoria.Name = "buttonExcluirCategoria";
            this.buttonExcluirCategoria.Size = new System.Drawing.Size(95, 47);
            this.buttonExcluirCategoria.TabIndex = 2;
            this.buttonExcluirCategoria.Text = "Excluir";
            this.buttonExcluirCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirCategoria.UseVisualStyleBackColor = true;
            this.buttonExcluirCategoria.Click += new System.EventHandler(this.buttonExcluirCategoria_Click);
            // 
            // buttonLimparCategoria
            // 
            this.buttonLimparCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparCategoria.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimparCategoria.Image")));
            this.buttonLimparCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimparCategoria.Location = new System.Drawing.Point(348, 324);
            this.buttonLimparCategoria.Name = "buttonLimparCategoria";
            this.buttonLimparCategoria.Size = new System.Drawing.Size(95, 47);
            this.buttonLimparCategoria.TabIndex = 3;
            this.buttonLimparCategoria.Text = "Limpar";
            this.buttonLimparCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimparCategoria.UseVisualStyleBackColor = true;
            this.buttonLimparCategoria.Click += new System.EventHandler(this.buttonLimparCategoria_Click);
            // 
            // buttonSairCategoria
            // 
            this.buttonSairCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairCategoria.Image = ((System.Drawing.Image)(resources.GetObject("buttonSairCategoria.Image")));
            this.buttonSairCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSairCategoria.Location = new System.Drawing.Point(451, 324);
            this.buttonSairCategoria.Name = "buttonSairCategoria";
            this.buttonSairCategoria.Size = new System.Drawing.Size(95, 47);
            this.buttonSairCategoria.TabIndex = 4;
            this.buttonSairCategoria.Text = "Sair";
            this.buttonSairCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSairCategoria.UseVisualStyleBackColor = true;
            this.buttonSairCategoria.Click += new System.EventHandler(this.buttonSairCategoria_Click);
            // 
            // buttonCadCategoria
            // 
            this.buttonCadCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadCategoria.Image = ((System.Drawing.Image)(resources.GetObject("buttonCadCategoria.Image")));
            this.buttonCadCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadCategoria.Location = new System.Drawing.Point(12, 324);
            this.buttonCadCategoria.Name = "buttonCadCategoria";
            this.buttonCadCategoria.Size = new System.Drawing.Size(104, 47);
            this.buttonCadCategoria.TabIndex = 0;
            this.buttonCadCategoria.Text = "Cadastrar";
            this.buttonCadCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCadCategoria.UseVisualStyleBackColor = true;
            this.buttonCadCategoria.Click += new System.EventHandler(this.buttonCadCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Arabic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastro de Categoria";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 419);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCadCategoria);
            this.Controls.Add(this.buttonSairCategoria);
            this.Controls.Add(this.buttonLimparCategoria);
            this.Controls.Add(this.buttonExcluirCategoria);
            this.Controls.Add(this.buttonAtualizarCategoria);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 419);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(574, 419);
            this.Name = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAtualizarCategoria;
        private System.Windows.Forms.Button buttonExcluirCategoria;
        private System.Windows.Forms.Button buttonLimparCategoria;
        private System.Windows.Forms.Button buttonSairCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCadCategoria;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxCodCategoria;
        public System.Windows.Forms.TextBox textBoxNomeCategoria;
        public System.Windows.Forms.CheckBox checkboxStatus;
        public System.Windows.Forms.Label lbDataCad;
        public System.Windows.Forms.TextBox textBoxObsCategoria;
        private System.Windows.Forms.Label label1;
    }
}