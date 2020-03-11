using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaLojaCosmeticos
{
    public partial class frmFuncionarios : MetroFramework.Forms.MetroForm
    {
        public string tipo, estado;

        public int cargo;

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            lbdata.Text = DateTime.Now.ToString();

            cbEstado.Items.Add("AC");
            cbEstado.Items.Add("AL");
            cbEstado.Items.Add("AP");
            cbEstado.Items.Add("AM");
            cbEstado.Items.Add("BA");
            cbEstado.Items.Add("CE");
            cbEstado.Items.Add("DF");
            cbEstado.Items.Add("ES");
            cbEstado.Items.Add("GO");
            cbEstado.Items.Add("MA");
            cbEstado.Items.Add("MT");
            cbEstado.Items.Add("MS");
            cbEstado.Items.Add("MG");
            cbEstado.Items.Add("PA");
            cbEstado.Items.Add("PB");
            cbEstado.Items.Add("PR");
            cbEstado.Items.Add("PE");
            cbEstado.Items.Add("PI");
            cbEstado.Items.Add("RJ");
            cbEstado.Items.Add("RN");
            cbEstado.Items.Add("RS");
            cbEstado.Items.Add("RO");
            cbEstado.Items.Add("RR");
            cbEstado.Items.Add("SC");
            cbEstado.Items.Add("SP");
            cbEstado.Items.Add("SE");
            cbEstado.Items.Add("TO");

            cbEstado.Sorted = true;
            cbEstado.SelectedItem = "SP";
            txtNome.Focus();
            txtCod.Enabled = false;

            classFuncionarios cFunc = new classFuncionarios();
            cbCargo.DataSource = cFunc.BuscarCargo();
            cbCargo.DisplayMember = "NomeCargo";
            cbCargo.ValueMember = "CodigoCargo";
            cbCargo.SelectedIndex = -1;

            

            if (tipo == "Atualização")
            {
                label9.Text = "Atualização de Funcionario";
                buttonCadMarca.Enabled = false;
                checkboxStatus.Enabled = true;
                //cbCategoria.SelectedValue = categoria;
                // cbMarca.SelectedValue = marca;
                cbCargo.SelectedValue = cargo;

                cbEstado.SelectedItem = estado;
                buttonExcluirMarca.Enabled = true;
                buttonAtualizarMarca.Enabled = true;

                //classFuncionarios obj = new classFuncionarios();
                //cbEstado.DataSource = obj.BuscarEstado();
                //cbEstado.DisplayMember = "Estado";
                //cbEstado.ValueMember = "Estado";

            }

        }

        private void mskDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonSairMarca_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja fechar o cadastro de Funcionarios ?", "Atenção", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
        ) == DialogResult.Yes)
                this.Close();
        }

        private void buttonCadMarca_Click(object sender, EventArgs e)
        {
            classFuncionarios cFunc = new classFuncionarios();
            if ((mskTelefone.Text != "(  )    -" || mskCelular.Text != "(  )    -") && txtNome.Text != ""
                && mskCPF.Text != "   .   .   -" && mskDataNascimento.Text != "  /  /" && txtRua.Text != ""
                && txtNumero.Text != "" && txtEmail.Text != "" && mskDataAdmissao.Text != "  /  /")
            {

                cFunc.CodigoCargo = Convert.ToInt32(cbCargo.SelectedValue);
                cFunc.NomeFuncionario = txtNome.Text;
                cFunc.CPF = mskCPF.Text;
                cFunc.DataNascimento = Convert.ToDateTime(mskDataNascimento.Text);
                cFunc.Rua = txtRua.Text;
                cFunc.Numero = Convert.ToInt32(txtNumero.Text);
                cFunc.Complemento = txtComplemento.Text;
                cFunc.Bairro = txtBairro.Text;
                cFunc.Cidade = txtCidade.Text;
                cFunc.Estado = cbEstado.SelectedItem.ToString();
                cFunc.Email = txtEmail.Text;

                if (rbFeminino.Checked)
                    cFunc.Sexo = "Feminino";
                else
                    cFunc.Sexo = "Masculino";
                if (mskTelefone.Text != "(  )    -")
                    cFunc.TelefoneResidencial = mskTelefone.Text;
                else
                    cFunc.TelefoneResidencial = "";

                if (mskCelular.Text != "")
                    cFunc.TelefoneCelular = mskCelular.Text;
                else
                    cFunc.TelefoneCelular = "";
                if (mskRG.Text != "  .   .   -")
                    cFunc.RG = mskRG.Text;
                else
                    cFunc.RG = "";

                if (mskCEP.Text != "     -")
                    cFunc.CEP = mskCEP.Text;
                else
                    cFunc.CEP = "";

                int aux = cFunc.CadastrarFuncionario();
                if (aux != 0)
                {
                    MessageBox.Show(" Funcionario:" + cFunc.NomeFuncionario + " Cadastrado com Sucesso",
                        "Sistema Loja Cosmético", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonLimparFuncionario_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.BackColor = Color.LemonChiffon;
                mskCPF.BackColor = Color.LemonChiffon;
                mskDataNascimento.BackColor = Color.LemonChiffon;
                txtRua.BackColor = Color.LemonChiffon;
                txtNumero.BackColor = Color.LemonChiffon;
                txtEmail.BackColor = Color.LemonChiffon;
                mskCelular.BackColor = Color.Aqua;
                mskTelefone.BackColor = Color.Aqua;
                mskDataAdmissao.BackColor = Color.LemonChiffon;
                txtNome.Focus();
                cbCargo.BackColor = Color.LemonChiffon;
            }

        }

        private void buttonLimparFuncionario_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            mskCelular.Clear();
            mskCEP.Clear();
            mskCPF.Clear();
            mskDataNascimento.Clear();
            mskRG.Clear();
            mskTelefone.Clear();

        }

        private void buttonAtualizarMarca_Click(object sender, EventArgs e)
        {
            classFuncionarios obj = new classFuncionarios();

            if ((mskTelefone.Text !=  "(  )    -" || mskCelular.Text != "(  )    -") && txtNome.Text != ""&& mskCPF.Text != "   .   .   -" && mskDataNascimento.Text != "  /  /" && txtRua.Text != ""
                && txtNumero.Text != "" && txtEmail.Text != "" && mskDataAdmissao.Text != "  /  /")
            {


                obj.NomeFuncionario = txtNome.Text;
                obj.RG = mskRG.Text;
                obj.CPF = mskCPF.Text;
                obj.DataNascimento = Convert.ToDateTime(mskDataNascimento.Text);
                obj.DataAdimissao = Convert.ToDateTime(mskDataAdmissao.Text);
                obj.TelefoneCelular = mskCelular.Text;
                obj.TelefoneResidencial = mskTelefone.Text;
                obj.Email = txtEmail.Text;
                obj.Rua = txtRua.Text;
                obj.Numero = Convert.ToInt32(txtNumero.Text);
                obj.Cidade = txtCidade.Text;
                obj.Bairro = txtBairro.Text;
                obj.Complemento = txtComplemento.Text;
                obj.CEP = mskCEP.Text;
                obj.Estado = cbEstado.Text;
                obj.CodigoCargo = Convert.ToInt32(cbCargo.SelectedValue);

                if (rbFeminino.Checked)
                {
                    obj.Sexo = "Feminino";
                }
                
                else if (rbMasculino.Checked)
                {
                    obj.Sexo = "Masculino";
                }


                if (checkboxStatus.Checked == true)
                {
                    obj.Status = 1;
                }

                else
                {
                    obj.Status = 0;
                }

                obj.CodigoFuncionarios = Convert.ToInt32(txtCod.Text);
                bool aux = obj.AtualizarFuncionario();
                if (aux)
                {
                    MessageBox.Show("Funcionario: " + obj.NomeFuncionario + " atualizado com sucesso.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // fecha form
                }

                else
                {
                    MessageBox.Show("Erro ao atualizar o Funcionario " + obj.NomeFuncionario, " Sistema Loja Cosméticos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtNome.BackColor = Color.LemonChiffon;
                mskCPF.BackColor = Color.LemonChiffon;
                mskDataNascimento.BackColor = Color.LemonChiffon;
                txtRua.BackColor = Color.LemonChiffon;
                txtNumero.BackColor = Color.LemonChiffon;
                txtEmail.BackColor = Color.LemonChiffon;
                mskCelular.BackColor = Color.Aqua;
                mskTelefone.BackColor = Color.Aqua;
                mskDataAdmissao.BackColor = Color.LemonChiffon;
                txtNome.Focus();
                cbCargo.BackColor = Color.LemonChiffon;
            }
        }

        private void buttonExcluirMarca_Click(object sender, EventArgs e)
        {
            classFuncionarios obj = new classFuncionarios();
            obj.CodigoFuncionarios = Convert.ToInt32(txtCod.Text);

            if (MessageBox.Show("Deseja realmente excluir? A operação não poderá ser desfeita após a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = obj.ExcluirFuncionario();
                if (aux)
                {
                    MessageBox.Show("Funcionario: " + obj.NomeFuncionario + "Excluído com sucesso.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(obj.NomeFuncionario + "Este Funcionario está sendo usada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    }

