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
    public partial class frmConsultaCargo : MetroFramework.Forms.MetroForm
    {
        public frmConsultaCargo()
        {
            InitializeComponent();
        }

        private void frmConsultaCargo_Load(object sender, EventArgs e)
        {
            cbTipoPesquisa.Items.Add("Descrição");
            cbTipoPesquisa.Items.Add("Status");
            cbTipoPesquisa.Items.Add("Código");
            cbTipoPesquisa.SelectedIndex = 0;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dtv.SelectedCells.Count > 0)
            {
                classCargo obj = new classCargo();
                obj.RetornaCargo(Convert.ToInt32(dtv.SelectedRows[0].Cells[0].Value));
                frmCargo obj2 = new frmCargo();

                obj2.txtCodCargo.Text = obj.CodigoCargo.ToString();
                obj2.lbdata.Text = obj.DataCadastro.ToShortDateString();
                obj2.txtNome.Text = obj.NomeCargo;
                // obj2.txtQtde.Text = obj.QtdeEstoque.ToString();
                // obj2.txtPreco.Text = obj.PrecoVenda.ToString();
                obj2.txtObservacao.Text = obj.Observacao;
                // obj2.marca = obj.CodigoMarca;
                // obj2.categoria = obj.CodigoCategoria;

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
                MessageBox.Show("Selecione o Cargo a ser Atualizado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string Consulta = cbTipoPesquisa.SelectedItem.ToString();
            classCargo obj = new classCargo();
            switch (Consulta)
            {
                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        obj.Status = 1;
                        dtv.DataSource = obj.BuscarCargoStatus();
                    }
                    else
                    {
                        obj.Status = 0;
                        dtv.DataSource = obj.BuscarCargoStatus();
                    }
                    break;

                case "Descrição":
                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked)
                        {
                            obj.NomeCargo = txtNome.Text;
                            dtv.DataSource = obj.BuscarCargoInicio();
                        }

                        else if (rbContem.Checked)
                        {
                            obj.NomeCargo = txtNome.Text;
                            dtv.DataSource = obj.BuscarCargoContem();

                        }
                    }

                    else
                        MessageBox.Show("Favor informar um Cargo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Código":
                    if (txtCod.Text != "")
                    {

                        obj.CodigoCargo = Convert.ToInt32(txtCod.Text);
                        dtv.DataSource = obj.BuscarMarcaCod();



                    }

                    else
                        MessageBox.Show("Favor informar um Cargo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a pesquisa de Cargo?", "Atenção", MessageBoxButtons.YesNo,
     MessageBoxIcon.Question
     ) == DialogResult.Yes)
                this.Close();
        }

        private void cbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPesquisa.SelectedIndex == 0) //DESCRICAO
            {
                txtNome.Enabled = true;
                gbPesquisar.Enabled = true;
                gbStatus.Enabled = false;
                gbCod.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 1) //Status
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbStatus.Enabled = true;
                gbCod.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 2) //Status
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbStatus.Enabled = false;
                gbCod.Enabled = true;

            }
        }
    }
}
