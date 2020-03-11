namespace SistemaLojaCosmeticos
{
    partial class RecuperarSenha
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
            this.dtv = new System.Windows.Forms.DataGridView();
            this.btRecu = new System.Windows.Forms.Button();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtCpf = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv
            // 
            this.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv.Location = new System.Drawing.Point(23, 201);
            this.dtv.Name = "dtv";
            this.dtv.Size = new System.Drawing.Size(319, 76);
            this.dtv.TabIndex = 0;
            // 
            // btRecu
            // 
            this.btRecu.Location = new System.Drawing.Point(23, 172);
            this.btRecu.Name = "btRecu";
            this.btRecu.Size = new System.Drawing.Size(319, 23);
            this.btRecu.TabIndex = 1;
            this.btRecu.Text = "Recuperar";
            this.btRecu.UseVisualStyleBackColor = true;
            this.btRecu.Click += new System.EventHandler(this.btRecu_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(161, 81);
            this.txtEmail.MaxLength = 25;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(161, 110);
            this.txtCpf.MaxLength = 14;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(181, 23);
            this.txtCpf.TabIndex = 3;
            this.txtCpf.Click += new System.EventHandler(this.txtCpf_Click);
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(111, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Email:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(119, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "CPF:";
            // 
            // RecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 292);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btRecu);
            this.Controls.Add(this.dtv);
            this.Name = "RecuperarSenha";
            this.Text = "Recuperar senha ";
            this.Load += new System.EventHandler(this.RecuSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv;
        private System.Windows.Forms.Button btRecu;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtCpf;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}