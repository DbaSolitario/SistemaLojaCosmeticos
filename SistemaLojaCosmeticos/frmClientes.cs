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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
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

            lbdata.Text = DateTime.Now.ToString();

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadMarca_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();
            if((mskTelefone.Text != "(  )    -" || mskCelular.Text != "(  )    -") && txtNome.Text != "" 
                && mskCPF.Text != "   .   .   -" && mskDataNascimento.Text != "  /  /" &&  txtEndereco.Text != ""
                && txtNumero.Text != "" && txtEmail.Text != "")

            {
                cCliente.NomeCliente = txtNome.Text;
                cCliente.CPF = mskCPF.Text;
                cCliente.DataNascimento = Convert.ToDateTime(mskDataNascimento.Text);
                cCliente.Rua = txtEndereco.Text;
                cCliente.Numero = Convert.ToInt32(txtNumero.Text);
                cCliente.Complemento = txtComplemento.Text;
                cCliente.Bairro = txtBairro.Text;
                cCliente.Cidade = txtCidade.Text;
                cCliente.Estado = cbEstado.SelectedItem.ToString();
                cCliente.Email = txtEmail.Text;

                if (rbFeminino.Checked)
                    cCliente.Sexo = "Feminino";
                else
                    cCliente.Sexo = "Masculino";
                if (mskTelefone.Text != "(  )    -")
                    cCliente.TelefoneResidencial = mskTelefone.Text;
                else
                    cCliente.TelefoneResidencial = "";

                if (mskCelular.Text != "")
                    cCliente.TelefoneCelular = mskCelular.Text;
                else
                    cCliente.TelefoneCelular = "";
                if (mskRG.Text != "  .   .   -")
                    cCliente.RG = mskRG.Text;
                else
                    cCliente.RG = "";

                if (mskCEP.Text != "     -")
                    cCliente.CEP = mskCEP.Text;
                else
                    cCliente.CEP = "";
             
                int aux = cCliente.CadastrarCliente();
                if (aux != 0)
                {
                    MessageBox.Show(" Cliente:" + cCliente.NomeCliente + " Cadastrado com Sucesso",
                        "Sistema Loja Cosmético", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonLimparCliente_Click(this, new EventArgs());
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
                txtEndereco.BackColor = Color.LemonChiffon;
                txtNumero.BackColor = Color.LemonChiffon;
                txtEmail.BackColor = Color.LemonChiffon;
                mskCelular.BackColor = Color.Aqua;
                mskTelefone.BackColor = Color.Aqua;
                txtNome.Focus();
            }

        }

        private void buttonLimparMarca_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimparCliente_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            mskCelular.Clear();
            mskCEP.Clear();
            mskCPF.Clear();
            mskDataNascimento.Clear();
            mskRG.Clear();
            mskTelefone.Clear();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSairMarca_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o cadastro de Clientes ?", "Atenção", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
        ) == DialogResult.Yes)
                this.Close();
        }

        private void mskDataNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data inválida", "Sistema loja cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mskDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas Números!", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lbdata_Click(object sender, EventArgs e)
        {

        }
    }
}
