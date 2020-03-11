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
    public partial class frmRelProduto : MetroFramework.Forms.MetroForm
    {
        public frmRelProduto()
        {
            InitializeComponent();
        }

        private void frmRelProduto_Load(object sender, EventArgs e)
        {
            cbTipoRel.Items.Add("Data de Cadastro");
            cbTipoRel.Items.Add("Categoria");
            cbTipoRel.Items.Add("Marca");
            cbTipoRel.Items.Add("Preço");
            cbTipoRel.Items.Add("Estoque");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 5;


            //CARREGAR COMBO CATEGORIA
            classCategoria cCategoria = new classCategoria();
            cbCategoria.DataSource = cCategoria.BuscarCategoria();
            cbCategoria.DisplayMember = "NomeCategoria";
            cbCategoria.ValueMember = "CodigoCategoria";
            cbCategoria.SelectedIndex = -1;

            classMarca cMarca = new classMarca();
            cbMarca.DataSource = cMarca.BuscarMarca();
            cbMarca.DisplayMember = "NomeMarca";
            cbMarca.ValueMember = "CodigoMarca";
            cbMarca.SelectedIndex = -1;

            this.rptv.RefreshReport();




        }

        private void btGerarRel_Click(object sender, EventArgs e)
        {
            string Consulta = cbTipoRel.SelectedItem.ToString();
            classProduto obj = new classProduto();
            switch (Consulta)
            {
                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        obj.Status = 1;

                        classProdutoBindingSource.DataSource = obj.RelProdutoStatus(obj.Status);
                        this.rptv.RefreshReport();
                    }
                    else
                    {
                        obj.Status = 0;

                        classProdutoBindingSource.DataSource = obj.RelProdutoStatus(obj.Status);
                        this.rptv.RefreshReport();
                    }
                    break;

                case "Data de Cadastro":
                    DateTime dinicio, dfinal;
                    dinicio = Convert.ToDateTime(dtpDe.Text);
                    dfinal = Convert.ToDateTime(dtpAte.Text);
                    classProdutoBindingSource.DataSource = obj.RelProdutoDataCadastro(dinicio, dfinal);
                    this.rptv.RefreshReport();
                    break;

                case "Categoria":
                    int categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                    
                    classProdutoBindingSource.DataSource = obj.RelCategoria(categoria);
                    this.rptv.RefreshReport();
                    break;

                case "Marca":
                    int marca = Convert.ToInt32(cbMarca.SelectedValue);

                    classProdutoBindingSource.DataSource = obj.RelMarca(marca);
                    this.rptv.RefreshReport();
                    break;

                case "Preço":

                    if (precoate.Text != "" && Precode.Text != "")
                    {
                        decimal precoi = Convert.ToDecimal(Precode.Text);
                        decimal precof = Convert.ToDecimal(precoate.Text);
                        classProdutoBindingSource.DataSource = obj.RelProdutoPreco(precoi, precof);
                        this.rptv.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor informar um preço inicial e final.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Estoque":
                    if (txtEstoqueate.Text != "" && txtEstoquede.Text != "")
                    {
                        int qtdei = Convert.ToInt32(txtEstoquede.Text);
                        int qtdef = Convert.ToInt32(txtEstoqueate.Text);
                        classProdutoBindingSource.DataSource = obj.RelProdQtdeEstoque(qtdei, qtdef);
                        this.rptv.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor informar uma Quantidade de estoque inicial e final.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

            }
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0) //DataCadastro
            {
                cbCategoria.Enabled = false;
                cbMarca.Enabled = false;
                gbAniversariantes.Enabled = true;
                gbEstoque.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;

            }

            if (cbTipoRel.SelectedIndex == 1) //Categoria
            {
                cbCategoria.Enabled = true;
                cbMarca.Enabled = false;
                gbAniversariantes.Enabled = false;
                gbEstoque.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;

            }


            if (cbTipoRel.SelectedIndex == 2) //Marca
            {
                cbCategoria.Enabled = false;
                cbMarca.Enabled = true;
                gbAniversariantes.Enabled = false;
                gbEstoque.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;

            }

            if (cbTipoRel.SelectedIndex == 3) //Preço
            {
                cbCategoria.Enabled = false;
                cbMarca.Enabled = false;
                gbAniversariantes.Enabled = false;
                gbEstoque.Enabled = false;
                gbPreco.Enabled = true;
                gbStatus.Enabled = false;

            }

            if (cbTipoRel.SelectedIndex == 4) //Estoque
            {
                cbCategoria.Enabled = false;
                cbMarca.Enabled = false;
                gbAniversariantes.Enabled = false;
                gbEstoque.Enabled = true;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;

            }

            if (cbTipoRel.SelectedIndex == 5) //Status
            {
                cbCategoria.Enabled = false;
                cbMarca.Enabled = false;
                gbAniversariantes.Enabled = false;
                gbEstoque.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = true;

            }
        }
    }
}
