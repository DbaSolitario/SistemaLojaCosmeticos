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
    public partial class frmPesquisaFuncionario : MetroFramework.Forms.MetroForm
    {
        public frmPesquisaFuncionario()
        {
            InitializeComponent();
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPesquisa.SelectedIndex == 0) //Nome
            {
                txtNome.Enabled = true;
                gbPesquisar.Enabled = true;
               // gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbCargo.Enabled = false;
                //gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
               // gbEstoque.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 1) //CPF
            {
                txtNome.Enabled = true;
                gbPesquisar.Enabled = false;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbCargo.Enabled = false;
               // gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                // gbEstoque.Enabled = false;
                txtNome.MaxLength = 14;
            }

            if (cbTipoPesquisa.SelectedIndex == 2) //Cargo
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbCargo.Enabled = true;
               // gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                // gbEstoque.Enabled = false;
            }

          

            if (cbTipoPesquisa.SelectedIndex == 3) //Código
            {
                txtNome.Enabled = true;
                gbPesquisar.Enabled = true;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbCargo.Enabled = false;
               // gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                // gbEstoque.Enabled = false;
            }
            if (cbTipoPesquisa.SelectedIndex == 4) //Status
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = true;
                cbCargo.Enabled = false;
                //gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                // gbEstoque.Enabled = false;
            }
        }

        private void frmPesquisaFuncionario_Load(object sender, EventArgs e)
        {
            cbTipoPesquisa.Items.Add("Nome");
            cbTipoPesquisa.Items.Add("CPF");
            cbTipoPesquisa.Items.Add("Cargo");
           
            cbTipoPesquisa.Items.Add("Código");
            cbTipoPesquisa.Items.Add("Status");

            cbTipoPesquisa.SelectedIndex = 0;

            classFuncionarios cCategoria = new classFuncionarios();
            cbCargo.DataSource = cCategoria.BuscarCargo();
            cbCargo.DisplayMember = "NomeCargo";
            cbCargo.ValueMember = "CodigoCargo";
            cbCargo.SelectedIndex = -1;


        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string Consulta = cbTipoPesquisa.SelectedItem.ToString();
            classFuncionarios obj = new classFuncionarios();
            switch (Consulta)
            {
                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        obj.Status = 1;
                        dtv.DataSource = obj.BuscarFuncionarioStatus();
                    }
                    else
                    {
                        obj.Status = 0;
                        dtv.DataSource = obj.BuscarFuncionarioStatus();
                    }
                    break;

                case "Nome":
                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked)
                        {
                            obj.NomeFuncionario = txtNome.Text;
                            dtv.DataSource = obj.BuscarFuncionarioNomeInicial();
                        }

                        else if (rbContem.Checked)
                        {
                            obj.NomeFuncionario = txtNome.Text;
                            dtv.DataSource = obj.BuscarFuncionarioNomeContem();

                        }
                    }

                    else
                        MessageBox.Show("Favor informar um Funcionário.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Código":
                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked)
                        {
                            obj.CodigoFuncionarios = Convert.ToInt32(txtNome.Text);
                            dtv.DataSource = obj.BuscarFuncionarioCodigoInicial();
                        }

                        else if (rbContem.Checked)
                        {
                            obj.CodigoFuncionarios = Convert.ToInt32(txtNome.Text);
                            dtv.DataSource = obj.BuscarFuncionarioCodigoContem();
                        }


                        }

                    else
                        MessageBox.Show("Favor informar um Codigo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                    case "Cargo":
                    if (cbCargo.Text != "")
                    {
                        obj.CodigoCargo = Convert.ToInt32(cbCargo.SelectedValue);
                        dtv.DataSource = obj.BuscarFuncionarioCargo();
                    }
                    else
                        MessageBox.Show("Favor escolher um cargo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    break;


                case "CPF":
                      if (txtNome.Text != "")
                    {
                        obj.CPF = txtNome.Text;
                        dtv.DataSource = obj.BuscarFuncionarioCPF();

                    }

                break;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a pesquisa de Funcionario ?", "Atenção", MessageBoxButtons.YesNo,
      MessageBoxIcon.Question
      ) == DialogResult.Yes)
                this.Close();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dtv.SelectedCells.Count > 0)
            {
                classFuncionarios obj = new classFuncionarios();
                obj.RetornaFuncionario(Convert.ToInt32(dtv.SelectedRows[0].Cells[0].Value));
                frmFuncionarios obj2 = new frmFuncionarios();

                obj2.txtCod.Text = obj.CodigoFuncionarios.ToString();
                obj2.lbdata.Text = obj.DataCadastro.ToShortDateString();
                obj2.txtNome.Text = obj.NomeFuncionario;
                obj2.mskRG.Text = obj.RG;
                obj2.mskCPF.Text = obj.CPF;
                obj2.cargo = obj.CodigoCargo;
                obj2.mskDataAdmissao.Text = obj.DataAdimissao.ToString();
                obj2.mskDataNascimento.Text = obj.DataNascimento.ToString();
                obj2.mskTelefone.Text = obj.TelefoneResidencial;
                obj2.mskCelular.Text = obj.TelefoneCelular;
                obj2.txtEmail.Text = obj.Email;
                obj2.txtRua.Text = obj.Rua;
                obj2.txtNumero.Text = obj.Numero.ToString();
                obj2.txtCidade.Text = obj.Cidade;
                obj2.txtBairro.Text = obj.Bairro;
                obj2.txtComplemento.Text = obj.Complemento;
                obj2.mskCEP.Text = obj.CEP.ToString();
                obj2.estado = obj.Estado;



                if (obj.Sexo == "Feminino")
                {
                    obj2.rbFeminino.Checked = true;
                    obj2.rbMasculino.Checked = false;
                }

                else if (obj.Sexo == "Masculino")
                {
                    obj2.rbFeminino.Checked = false;
                    obj2.rbMasculino.Checked = true;
                }


                if (obj.Status == 1)
                {
                    obj2.checkboxStatus.Checked = true;
                }

                else
                {
                    obj2.checkboxStatus.Checked = false;
                }

                obj2.tipo = "Atualização";
                obj2.ShowDialog();
                btPesquisar_Click(this, new EventArgs());
            }

            else
            {
                MessageBox.Show("Selecione o Funcionario a ser Atualizado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
