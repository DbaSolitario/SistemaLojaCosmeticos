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
    public partial class frmConsultaProduto : MetroFramework.Forms.MetroForm
    {
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a pesquisa de Produto ?", "Atenção", MessageBoxButtons.YesNo,
      MessageBoxIcon.Question
      ) == DialogResult.Yes)
                this.Close();
        }

        private void txtPrecoInicial_Load(object sender, EventArgs e)
        {
            cbTipoPesquisa.Items.Add("Descrição");
            cbTipoPesquisa.Items.Add("Categoria");
            cbTipoPesquisa.Items.Add("Marca");
            cbTipoPesquisa.Items.Add("Preço");
            cbTipoPesquisa.Items.Add("Preço >");
            cbTipoPesquisa.Items.Add("Status");
            cbTipoPesquisa.Items.Add("Estoque >");
            cbTipoPesquisa.Items.Add("Estoque <");


            cbTipoPesquisa.SelectedIndex = 0;

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




        }
        // dependendo da escolha do usuario ela ira liberar as opçoes

        private void cbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPesquisa.SelectedIndex == 0) //DESCRICAO
            {
                txtNome.Enabled = true;
                gbPesquisar.Enabled = true;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
                gbEstoque.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 1) //CATEGORIA  
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = true;
                gbEstoque.Enabled = false;
            }


            if (cbTipoPesquisa.SelectedIndex == 2) //Marca 
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbMarca.Enabled = true;
                cbCategoria.Enabled = false;
                gbEstoque.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 3) //Preço
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbPreco.Enabled = true;
                txtMaiorque.Enabled = false;
                txtPrecoInicial.Enabled = true;
                txtPrecoFinal.Enabled = true;
                gbStatus.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
                gbEstoque.Enabled = false;
            }
            if (cbTipoPesquisa.SelectedIndex == 4) //Preço >
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                txtPrecoFinal.Enabled = false;
                txtPrecoInicial.Enabled = false;
                txtMaiorque.Enabled = true;
                gbPreco.Enabled = true;
                gbStatus.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
                gbEstoque.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 5) //Status
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = true;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
                gbEstoque.Enabled = false;
            }
            if (cbTipoPesquisa.SelectedIndex == 6) //Estoque >
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
                gbEstoque.Enabled = true;
                txtEstoqueMaior.Enabled = true;
                txtEstoqueMenor.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 7) //Estoque <
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
                gbEstoque.Enabled = true;
                txtEstoqueMaior.Enabled = false;
                txtEstoqueMenor.Enabled = true;
            }

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string Consulta = cbTipoPesquisa.SelectedItem.ToString();
            classProduto obj = new classProduto();
            switch (Consulta)
            {
              case "Descrição":
                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked)
                        {
                            obj.NomeProduto = txtNome.Text;
                            dtv.DataSource = obj.BuscarProdutoDescricaoInicial();
                        }

                        else if (rbContem.Checked)
                        {
                            obj.NomeProduto = txtNome.Text;
                            dtv.DataSource = obj.BuscarProdutoDescricaoContem();

                        }
                    }

                    else
                        MessageBox.Show("Favor informar uma descrição.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;

                case "Categoria":
                    if (cbCategoria.Text != "")
                    {
                        obj.CodigoCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                        dtv.DataSource = obj.BuscarProdutoCategoria();
                    }
                    else 
                       MessageBox.Show("Favor escolher uma categoria.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                    break;

                case "Status":
                    if(rbAtivo.Checked == true)
                    {
                        obj.Status = 1;
                        dtv.DataSource = obj.BuscarProdutoStatus();
                    }
                    else
                    {
                        obj.Status = 0;
                        dtv.DataSource = obj.BuscarProdutoStatus();
                    }
                    break;

                case "Marca":
                    if(cbMarca.Text != "")
                    {
                        obj.CodigoMarca = Convert.ToInt32(cbMarca.SelectedValue);
                        dtv.DataSource = obj.BuscarProdutoMarca();
                    }
                    else
                        MessageBox.Show("Favor escolher uma marca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Preço":
                    if(txtPrecoInicial.Text !="" && txtPrecoFinal.Text != "")
                    { 
                        decimal precoi = Convert.ToDecimal(txtPrecoInicial.Text);
                        decimal precof = Convert.ToDecimal(txtPrecoFinal.Text);
                        dtv.DataSource = obj.BuscarProdutoPreco(precoi, precof);
                    }
                    else
                        MessageBox.Show("Favor escolher um Preço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Preço >":
                    if(txtMaiorque.Text != "")
                    {
                        decimal precoM = Convert.ToDecimal(txtMaiorque.Text);
                        dtv.DataSource = obj.BuscarProdutoMaior(precoM);
                    }
                    break;

                case "Estoque >":
                    if (txtEstoqueMaior.Text != "")
                    {
                        decimal EstoqueMaior = Convert.ToDecimal(txtEstoqueMaior.Text);
                       
                        dtv.DataSource = obj.BuscarProdutoEstoqueMaior(EstoqueMaior);
                    }
                    break;

                case "Estoque <":
                    if (txtEstoqueMenor.Text != "")
                    {
                        decimal EstoqueMenor = Convert.ToDecimal(txtEstoqueMenor.Text);

                        dtv.DataSource = obj.BuscarProdutoEstoqueMenor(EstoqueMenor);
                    }
                    break;






            }
    }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if(dtv.SelectedCells.Count > 0)
            {
                classProduto obj = new classProduto();
                obj.RetornaProduto(Convert.ToInt32(dtv.SelectedRows[0].Cells[0].Value));
                frmProduto formProduto = new frmProduto();

                formProduto.txtCod.Text = obj.CodigoProduto.ToString();
                formProduto.lbdata.Text = obj.DataCadastro.ToShortDateString();
                formProduto.txtNome.Text = obj.NomeProduto;
                formProduto.txtQtde.Text = obj.QtdeEstoque.ToString();
                formProduto.txtPreco.Text = obj.PrecoVenda.ToString();
                formProduto.txtObservacao.Text = obj.Observacao;
                formProduto.marca = obj.CodigoMarca;
                formProduto.categoria = obj.CodigoCategoria;

                if (obj.Status == 1)
                {
                    formProduto.cbStatus.Checked = true;
                }

                else
                {
                    formProduto.cbStatus.Checked = false;
                }

                formProduto.tipo = "Atualização";
                formProduto.ShowDialog();
                btPesquisar_Click(this, new EventArgs());
            }

            else
            {
                MessageBox.Show("Selecione o Produto a ser Atualizado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
