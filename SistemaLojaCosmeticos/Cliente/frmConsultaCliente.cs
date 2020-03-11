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
    public partial class frmConsultaCliente : MetroFramework.Forms.MetroForm
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            cbTipoPesquisa.Items.Add("Nome");
            cbTipoPesquisa.Items.Add("CPF");
            cbTipoPesquisa.Items.Add("Código");
            cbTipoPesquisa.Items.Add("Status");
            cbTipoPesquisa.Items.Add("Aniversariantes por Dia e Mês");
            cbTipoPesquisa.Items.Add("Aniversariantes do Mês");
            cbTipoPesquisa.Items.Add("Aniversariantes Idade");
            cbTipoPesquisa.Items.Add("Cidade");
            cbTipoPesquisa.SelectedIndex = 0;

            classCliente cCliente = new classCliente();
            cbCidade.DataSource = cCliente.BuscarCidade(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE CLIENTE
            cbCidade.DisplayMember = "Cidade"; // EXIBIR NA COMBO (CIDADE)
            cbCidade.ValueMember = "Cidade"; // GUARDAR NO BD (CIDADE)
            cbCidade.SelectedIndex = -1;

            //CARREGAR COMBO MÊS
            cbMes.Items.Add("Escolha um Mês");
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");
            cbMes.SelectedIndex = 0;

            //CARREGAR COMBO DIA
            cbDia.Items.Add("Escolha um Dia");
            cbDia.Items.Add("01");
            cbDia.Items.Add("02");
            cbDia.Items.Add("03");
            cbDia.Items.Add("04");
            cbDia.Items.Add("05");
            cbDia.Items.Add("06");
            cbDia.Items.Add("07");
            cbDia.Items.Add("08");
            cbDia.Items.Add("09");
            cbDia.Items.Add("10");
            cbDia.Items.Add("11");
            cbDia.Items.Add("12");
            cbDia.Items.Add("13");
            cbDia.Items.Add("14");
            cbDia.Items.Add("15");
            cbDia.Items.Add("16");
            cbDia.Items.Add("17");
            cbDia.Items.Add("18");
            cbDia.Items.Add("19");
            cbDia.Items.Add("20");
            cbDia.Items.Add("21");
            cbDia.Items.Add("22");
            cbDia.Items.Add("23");
            cbDia.Items.Add("24");
            cbDia.Items.Add("25");
            cbDia.Items.Add("26");
            cbDia.Items.Add("27");
            cbDia.Items.Add("28");
            cbDia.Items.Add("29");
            cbDia.Items.Add("30");
            cbDia.Items.Add("31");
            cbDia.SelectedIndex = 0;


        }

        private void cbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPesquisa.SelectedIndex == 0) //Nome
            {
                txtNome.Enabled = true;
                gbPesquisar.Enabled = true;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                // cbCargo.Enabled = false;
                //gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                // gbEstoque.Enabled = false;
                gbAniversariantes.Enabled = false;
                gbMaiores.Enabled = false;
                cbCidade.Enabled = false; 
            }

            if (cbTipoPesquisa.SelectedIndex == 1) //CPF
            {
                txtNome.Enabled = true;
                gbPesquisar.Enabled = false;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                //cbCargo.Enabled = false;
                // gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                // gbEstoque.Enabled = false;
                txtNome.MaxLength = 13;
                gbAniversariantes.Enabled = false;
                gbMaiores.Enabled = false;
                cbCidade.Enabled = false;
            }

       



            if (cbTipoPesquisa.SelectedIndex == 2) //Código
            {
                txtNome.Enabled = true;
                gbPesquisar.Enabled = true;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                // cbCargo.Enabled = false;
                // gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                // gbEstoque.Enabled = false;
                txtNome.MaxLength = 8;
                gbAniversariantes.Enabled = false;
                gbMaiores.Enabled = false;
                cbCidade.Enabled = false;
            }
            if (cbTipoPesquisa.SelectedIndex == 3) //Status
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = true;
                // cbCargo.Enabled = false;
                //gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                gbAniversariantes.Enabled = false;
                gbMaiores.Enabled = false;
                cbCidade.Enabled = false;

                // gbEstoque.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 4) //Aniversariantes por Dia e Mês
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                // cbCargo.Enabled = false;
                //gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                gbAniversariantes.Enabled = true;
                gbMaiores.Enabled = false;
                cbCidade.Enabled = false;

                // gbEstoque.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 5) //Aniversariantes do Mês
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                // cbCargo.Enabled = false;
                //gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                gbAniversariantes.Enabled = true;
                cbDia.Enabled = false;
                gbMaiores.Enabled = false;
                cbCidade.Enabled = false;

                // gbEstoque.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 6) //Aniversariantes Idade
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                // cbCargo.Enabled = false;
                //gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                gbAniversariantes.Enabled = false;
                
                gbMaiores.Enabled = true;
                cbCidade.Enabled = false;

                // gbEstoque.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 7) //Cidade
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                // gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                // cbCargo.Enabled = false;
                //gbSalario.Enabled = false;
                //cbCategoria.Enabled = false;
                gbAniversariantes.Enabled = false;

                gbMaiores.Enabled = false;
                cbCidade.Enabled = true;

                // gbEstoque.Enabled = false;
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string Consulta = cbTipoPesquisa.SelectedItem.ToString();
            classCliente obj = new classCliente();
            switch (Consulta)
            {
                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        obj.Status = 1;
                        dtv.DataSource = obj.BuscarClienteStatus();
                    }
                    else
                    {
                        obj.Status = 0;
                        dtv.DataSource = obj.BuscarClienteStatus();
                    }
                    break;

                case "Nome":
                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked)
                        {
                            obj.NomeCliente = txtNome.Text;
                            dtv.DataSource = obj.BuscarClienteNomeInicial();
                        }

                        else if (rbContem.Checked)
                        {
                            obj.NomeCliente = txtNome.Text;
                            dtv.DataSource = obj.BuscarClienteNomeContem();

                        }
                    }

                    else
                        MessageBox.Show("Favor informar um Cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Código":
                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked)
                        {
                            obj.CodigoCliente = Convert.ToInt32(txtNome.Text);
                            dtv.DataSource = obj.BuscarClienteCodInicial();
                        }

                        else if (rbContem.Checked)
                        {
                            obj.CodigoCliente = Convert.ToInt32(txtNome.Text);
                            dtv.DataSource = obj.BuscarClienteCodContem();
                        }


                    }

                    else
                        MessageBox.Show("Favor informar um Codigo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "CPF":
                    if (txtNome.Text != "")
                    {
                        obj.CPF = txtNome.Text;
                        dtv.DataSource = obj.BuscarClienteCPF();

                    }

                    break;

                case "Aniversariantes do Mês":
                    if (cbMes.Text != "Escolha um Mês")
                    {
                        int mes = Convert.ToInt32(cbMes.SelectedIndex);
                        dtv.DataSource = obj.BuscarClienteMes(mes);
                        
                    }

                    else
                    {
                        MessageBox.Show("Favor escolher um mês.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;


                case "Aniversariantes por Dia e Mês":
                    if (cbDia.Text != "" && cbMes.Text != "")
                    {
                        int mes1 = Convert.ToInt32(cbMes.SelectedIndex);
                        int dia = Convert.ToInt32(cbDia.SelectedIndex);
                        dtv.DataSource = obj.BuscarClienteDiaMes(dia, mes1);

                       
                    }

                    else
                    {
                        MessageBox.Show("Favor escolher um Dia e Mês.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Cidade":
                    if (cbCidade.Text != "")
                    {
                        string cidade = Convert.ToString(cbCidade.Text);
                        //obj.Cidade = Convert.ToInt32(cbCidade.SelectedItem);
                        dtv.DataSource = obj.BuscarClienteCidade(cidade);
                        //this.rptv.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher uma Cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Aniversariantes Idade":
                    if (txtMaiorDe.Text != "")
                    {
                        int idadeE = Convert.ToInt32(txtMaiorDe.Text);
                       // i/nt idadef = Convert.ToInt32(txtIdadeDe.Text);
                        dtv.DataSource = obj.BuscarClienteIdadeMaior(idadeE);
                       // this.rptv.RefreshReport();
                    }

                    else
                    {
                        MessageBox.Show("Favor escrever uma Idade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
         }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dtv.SelectedCells.Count > 0)
            {
                classCliente obj = new classCliente();
                obj.RetornaCliente(Convert.ToInt32(dtv.SelectedRows[0].Cells[0].Value));
                frmClientes obj2 = new frmClientes();

                obj2.txtCodCliente.Text = obj.CodigoCliente.ToString();
                obj2.lbdata.Text = obj.DataCadastro.ToShortDateString();
                obj2.txtNome.Text = obj.NomeCliente;
                obj2.mskRG.Text = obj.RG;
                obj2.mskCPF.Text = obj.CPF;
                obj2.mskDataNascimento.Text = obj.DataNascimento.ToString();
                obj2.mskTelefone.Text = obj.TelefoneResidencial;
                obj2.mskCelular.Text = obj.TelefoneCelular;
                obj2.txtEmail.Text = obj.Email;
                obj2.txtEndereco.Text = obj.Rua;
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
                MessageBox.Show("Selecione o Cliente a ser Atualizado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja fechar a pesquisa de Cliente ?", "Atenção", MessageBoxButtons.YesNo,
      MessageBoxIcon.Question
      ) == DialogResult.Yes)
                this.Close();
        }
    }
}
