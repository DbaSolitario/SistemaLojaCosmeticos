namespace SistemaLojaCosmeticos
{
    partial class frmCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.checkboxStatus = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodCargo = new System.Windows.Forms.TextBox();
            this.buttonCadMarca = new System.Windows.Forms.Button();
            this.buttonSairCargo = new System.Windows.Forms.Button();
            this.buttonLimparCargo = new System.Windows.Forms.Button();
            this.buttonExcluirMarca = new System.Windows.Forms.Button();
            this.buttonAtualizarMarca = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Codigo cargo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadastro de cargo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.checkboxStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbdata);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodCargo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(247, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Todos os campos com  *  são Obrigatórios !!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(6, 96);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(475, 59);
            this.txtObservacao.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "* Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(202, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkboxStatus
            // 
            this.checkboxStatus.AutoSize = true;
            this.checkboxStatus.Checked = true;
            this.checkboxStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxStatus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkboxStatus.Location = new System.Drawing.Point(431, 15);
            this.checkboxStatus.Name = "checkboxStatus";
            this.checkboxStatus.Size = new System.Drawing.Size(50, 17);
            this.checkboxStatus.TabIndex = 8;
            this.checkboxStatus.Text = "Ativo";
            this.checkboxStatus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "* Status:";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbdata.Location = new System.Drawing.Point(264, 16);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(28, 13);
            this.lbdata.TabIndex = 3;
            this.lbdata.Text = "data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Data Cadastro:";
            // 
            // txtCodCargo
            // 
            this.txtCodCargo.Location = new System.Drawing.Point(107, 13);
            this.txtCodCargo.Name = "txtCodCargo";
            this.txtCodCargo.Size = new System.Drawing.Size(48, 20);
            this.txtCodCargo.TabIndex = 1;
            // 
            // buttonCadMarca
            // 
            this.buttonCadMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadMarca.Image = ((System.Drawing.Image)(resources.GetObject("buttonCadMarca.Image")));
            this.buttonCadMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadMarca.Location = new System.Drawing.Point(12, 320);
            this.buttonCadMarca.Name = "buttonCadMarca";
            this.buttonCadMarca.Size = new System.Drawing.Size(104, 47);
            this.buttonCadMarca.TabIndex = 0;
            this.buttonCadMarca.Text = "Cadastrar";
            this.buttonCadMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCadMarca.UseVisualStyleBackColor = true;
            this.buttonCadMarca.Click += new System.EventHandler(this.buttonCadMarca_Click);
            // 
            // buttonSairCargo
            // 
            this.buttonSairCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairCargo.Image = ((System.Drawing.Image)(resources.GetObject("buttonSairCargo.Image")));
            this.buttonSairCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSairCargo.Location = new System.Drawing.Point(428, 320);
            this.buttonSairCargo.Name = "buttonSairCargo";
            this.buttonSairCargo.Size = new System.Drawing.Size(95, 47);
            this.buttonSairCargo.TabIndex = 18;
            this.buttonSairCargo.Text = "Sair";
            this.buttonSairCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSairCargo.UseVisualStyleBackColor = true;
            this.buttonSairCargo.Click += new System.EventHandler(this.buttonSairCargo_Click);
            // 
            // buttonLimparCargo
            // 
            this.buttonLimparCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparCargo.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimparCargo.Image")));
            this.buttonLimparCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimparCargo.Location = new System.Drawing.Point(325, 320);
            this.buttonLimparCargo.Name = "buttonLimparCargo";
            this.buttonLimparCargo.Size = new System.Drawing.Size(95, 47);
            this.buttonLimparCargo.TabIndex = 17;
            this.buttonLimparCargo.Text = "Limpar";
            this.buttonLimparCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimparCargo.UseVisualStyleBackColor = true;
            this.buttonLimparCargo.Click += new System.EventHandler(this.buttonLimparCargo_Click);
            // 
            // buttonExcluirMarca
            // 
            this.buttonExcluirMarca.Enabled = false;
            this.buttonExcluirMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirMarca.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirMarca.Image")));
            this.buttonExcluirMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirMarca.Location = new System.Drawing.Point(224, 320);
            this.buttonExcluirMarca.Name = "buttonExcluirMarca";
            this.buttonExcluirMarca.Size = new System.Drawing.Size(95, 47);
            this.buttonExcluirMarca.TabIndex = 16;
            this.buttonExcluirMarca.Text = "Excluir";
            this.buttonExcluirMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirMarca.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizarMarca
            // 
            this.buttonAtualizarMarca.Enabled = false;
            this.buttonAtualizarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizarMarca.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtualizarMarca.Image")));
            this.buttonAtualizarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtualizarMarca.Location = new System.Drawing.Point(123, 320);
            this.buttonAtualizarMarca.Name = "buttonAtualizarMarca";
            this.buttonAtualizarMarca.Size = new System.Drawing.Size(95, 47);
            this.buttonAtualizarMarca.TabIndex = 15;
            this.buttonAtualizarMarca.Text = "Atualizar";
            this.buttonAtualizarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAtualizarMarca.UseVisualStyleBackColor = true;
            // 
            // frmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 379);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCadMarca);
            this.Controls.Add(this.buttonSairCargo);
            this.Controls.Add(this.buttonLimparCargo);
            this.Controls.Add(this.buttonExcluirMarca);
            this.Controls.Add(this.buttonAtualizarMarca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cargo";
            this.Load += new System.EventHandler(this.frmCargo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbdata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkboxStatus;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCadMarca;
        private System.Windows.Forms.Button buttonSairCargo;
        private System.Windows.Forms.Button buttonLimparCargo;
        private System.Windows.Forms.Button buttonExcluirMarca;
        private System.Windows.Forms.Button buttonAtualizarMarca;
        private System.Windows.Forms.Label label8;
    }
}