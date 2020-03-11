namespace SistemaLojaCosmeticos
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkboxStatus = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonCadMarca = new System.Windows.Forms.Button();
            this.buttonSairMarca = new System.Windows.Forms.Button();
            this.buttonExcluirMarca = new System.Windows.Forms.Button();
            this.buttonAtualizarMarca = new System.Windows.Forms.Button();
            this.buttonLimparCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadastro de clientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.mskCelular);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.mskTelefone);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mskCPF);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.mskRG);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkboxStatus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mskDataNascimento);
            this.groupBox1.Controls.Add(this.txtCodCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbdata);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(320, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "* Preencher pelo menos um telefone";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(227, 135);
            this.mskCelular.Mask = "(00)0000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(92, 20);
            this.mskCelular.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(179, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Celular:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Telefone:";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(78, 135);
            this.mskTelefone.Mask = "(00)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(92, 20);
            this.mskTelefone.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "* Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(65, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(430, 77);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 4;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Checked = true;
            this.rbFeminino.Location = new System.Drawing.Point(357, 77);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 3;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sexo";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(220, 76);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(94, 20);
            this.mskCPF.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(175, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "* CPF";
            // 
            // mskRG
            // 
            this.mskRG.Location = new System.Drawing.Point(65, 74);
            this.mskRG.Mask = "00,000,000-00";
            this.mskRG.Name = "mskRG";
            this.mskRG.Size = new System.Drawing.Size(92, 20);
            this.mskRG.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "RG";
            // 
            // checkboxStatus
            // 
            this.checkboxStatus.AutoSize = true;
            this.checkboxStatus.Checked = true;
            this.checkboxStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxStatus.Enabled = false;
            this.checkboxStatus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkboxStatus.Location = new System.Drawing.Point(475, 15);
            this.checkboxStatus.Name = "checkboxStatus";
            this.checkboxStatus.Size = new System.Drawing.Size(50, 17);
            this.checkboxStatus.TabIndex = 10;
            this.checkboxStatus.Text = "Ativo";
            this.checkboxStatus.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "* Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "* Data de Nascimento";
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(436, 105);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(68, 20);
            this.mskDataNascimento.TabIndex = 6;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            this.mskDataNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDataNascimento_MaskInputRejected);
            this.mskDataNascimento.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mskDataNascimento_TypeValidationCompleted);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Location = new System.Drawing.Point(110, 13);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(47, 20);
            this.txtCodCliente.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "* Codigo Cliente";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdata.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbdata.Location = new System.Drawing.Point(284, 16);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(34, 13);
            this.lbdata.TabIndex = 4;
            this.lbdata.Text = "Data";
            this.lbdata.Click += new System.EventHandler(this.lbdata_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "* Data de Cadastro";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(441, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Nome ";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(437, 103);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(76, 21);
            this.cbEstado.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.mskCEP);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbEstado);
            this.groupBox2.Location = new System.Drawing.Point(6, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(388, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 29;
            this.label21.Text = "Estado:";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(309, 103);
            this.mskCEP.Mask = "00000-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(73, 20);
            this.mskCEP.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(267, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "CEP:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(100, 103);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(158, 20);
            this.txtComplemento.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Complemento:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(272, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(315, 63);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(191, 20);
            this.txtBairro.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(87, 63);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(171, 20);
            this.txtCidade.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Cidade:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(438, 26);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(90, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(375, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "* Número:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(87, 26);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(279, 20);
            this.txtEndereco.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "* Endereço:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(280, 361);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(258, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "Todos os campos com  *  são Obrigatórios !!";
            // 
            // buttonCadMarca
            // 
            this.buttonCadMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadMarca.Image = ((System.Drawing.Image)(resources.GetObject("buttonCadMarca.Image")));
            this.buttonCadMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadMarca.Location = new System.Drawing.Point(6, 386);
            this.buttonCadMarca.Name = "buttonCadMarca";
            this.buttonCadMarca.Size = new System.Drawing.Size(104, 47);
            this.buttonCadMarca.TabIndex = 0;
            this.buttonCadMarca.Text = "Cadastrar";
            this.buttonCadMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCadMarca.UseVisualStyleBackColor = true;
            this.buttonCadMarca.Click += new System.EventHandler(this.buttonCadMarca_Click);
            // 
            // buttonSairMarca
            // 
            this.buttonSairMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairMarca.Image = ((System.Drawing.Image)(resources.GetObject("buttonSairMarca.Image")));
            this.buttonSairMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSairMarca.Location = new System.Drawing.Point(445, 386);
            this.buttonSairMarca.Name = "buttonSairMarca";
            this.buttonSairMarca.Size = new System.Drawing.Size(95, 47);
            this.buttonSairMarca.TabIndex = 18;
            this.buttonSairMarca.Text = "Sair";
            this.buttonSairMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSairMarca.UseVisualStyleBackColor = true;
            this.buttonSairMarca.Click += new System.EventHandler(this.buttonSairMarca_Click);
            // 
            // buttonExcluirMarca
            // 
            this.buttonExcluirMarca.Enabled = false;
            this.buttonExcluirMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirMarca.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirMarca.Image")));
            this.buttonExcluirMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirMarca.Location = new System.Drawing.Point(241, 386);
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
            this.buttonAtualizarMarca.Location = new System.Drawing.Point(128, 386);
            this.buttonAtualizarMarca.Name = "buttonAtualizarMarca";
            this.buttonAtualizarMarca.Size = new System.Drawing.Size(95, 47);
            this.buttonAtualizarMarca.TabIndex = 15;
            this.buttonAtualizarMarca.Text = "Atualizar";
            this.buttonAtualizarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAtualizarMarca.UseVisualStyleBackColor = true;
            // 
            // buttonLimparCliente
            // 
            this.buttonLimparCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimparCliente.Image")));
            this.buttonLimparCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimparCliente.Location = new System.Drawing.Point(342, 386);
            this.buttonLimparCliente.Name = "buttonLimparCliente";
            this.buttonLimparCliente.Size = new System.Drawing.Size(95, 47);
            this.buttonLimparCliente.TabIndex = 20;
            this.buttonLimparCliente.Text = "Limpar";
            this.buttonLimparCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimparCliente.UseVisualStyleBackColor = true;
            this.buttonLimparCliente.Click += new System.EventHandler(this.buttonLimparCliente_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 440);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLimparCliente);
            this.Controls.Add(this.buttonCadMarca);
            this.Controls.Add(this.buttonSairMarca);
            this.Controls.Add(this.buttonExcluirMarca);
            this.Controls.Add(this.buttonAtualizarMarca);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(568, 479);
            this.MinimumSize = new System.Drawing.Size(568, 479);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkboxStatus;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskRG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonCadMarca;
        private System.Windows.Forms.Button buttonSairMarca;
        private System.Windows.Forms.Button buttonExcluirMarca;
        private System.Windows.Forms.Button buttonAtualizarMarca;
        private System.Windows.Forms.Button buttonLimparCliente;
    }
}