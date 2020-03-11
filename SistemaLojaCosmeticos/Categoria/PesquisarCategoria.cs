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
    public partial class frmPesquisarCategoria : MetroFramework.Forms.MetroForm
    {
        public frmPesquisarCategoria()
        {
            InitializeComponent();
        }

        private void frmPesquisarCategoria_Load(object sender, EventArgs e)
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
                classCategoria obj = new classCategoria();
                obj.RetornaCategoria(Convert.ToInt32(dtv.SelectedRows[0].Cells[0].Value));
                frmCategoria obj2 = new frmCategoria();

                obj2.textBoxCodCategoria.Text = obj.CodigoCategoria.ToString();
                obj2.lbDataCad.Text = obj.DataCadastro.ToShortDateString();
                obj2.textBoxNomeCategoria.Text = obj.NomeCategoria;
                // obj2.txtQtde.Text = obj.QtdeEstoque.ToString();
                // obj2.txtPreco.Text = obj.PrecoVenda.ToString();
                obj2.textBoxObsCategoria.Text = obj.Observacao;
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
                MessageBox.Show("Selecione a Categoria a ser Atualizado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string Consulta = cbTipoPesquisa.SelectedItem.ToString();
            classCategoria obj = new classCategoria();
            switch (Consulta)
            {
                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        obj.Status = 1;
                        dtv.DataSource = obj.BuscarCategoriaStatus();
                    }
                    else
                    {
                        obj.Status = 0;
                        dtv.DataSource = obj.BuscarCategoriaStatus();
                    }
                    break;

                case "Descrição":
                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked)
                        {
                            obj.NomeCategoria = txtNome.Text;
                            dtv.DataSource = obj.BuscarCategoriaInicio();
                        }

                        else if (rbContem.Checked)
                        {
                            obj.NomeCategoria = txtNome.Text;
                            dtv.DataSource = obj.BuscarCategoriaContem();

                        }
                    }

                    else
                        MessageBox.Show("Favor informar uma Categoria.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Código":
                    if (txtCod.Text != "")
                    {

                        obj.CodigoCategoria = Convert.ToInt32(txtCod.Text);
                        dtv.DataSource = obj.BuscarCategoriaCod();



                    }

                    else
                        MessageBox.Show("Favor informar uma Categoria.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

            }
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

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a pesquisa de Categoria?", "Atenção", MessageBoxButtons.YesNo,
      MessageBoxIcon.Question
      ) == DialogResult.Yes)
                this.Close();
        }
    }
}
