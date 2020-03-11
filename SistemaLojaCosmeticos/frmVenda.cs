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
    public partial class frmVendaCliGrid : Form
    {
        public frmVendaCliGrid()
        {
            InitializeComponent();
        }
        private List<classItensVenda> ListaItensVenda = new List<classItensVenda>();
        private decimal VendaTotal = 0;
        private int itensVenda = 0;

        private void frmVendaCliGrid_Load(object sender, EventArgs e)
        {
            classFuncionarios obj = new classFuncionarios();
            cbFuncionario.DataSource = obj.BuscaFuncionario();
            cbFuncionario.DisplayMember = "NomeFuncionario";
            cbFuncionario.ValueMember = "CodigoFuncionarios";
            cbFuncionario.SelectedIndex = -1;

            cbFormaPagamento.Items.Add("Dinheiro");
            cbFormaPagamento.Items.Add("Cartão de Credito");
            cbFormaPagamento.Items.Add("Cartão de Débito");
            cbFormaPagamento.Items.Add("Crediário");
            cbFormaPagamento.SelectedIndex = 0;
        }

        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesqCliente.Text))
                MessageBox.Show("Favor informar um Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                classCliente cCliente = new classCliente();
                dgvCliente.DataSource = cCliente.BuscarCliente(txtPesqCliente.Text);
            }
        }

        private void btBuscaProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesqProduto.Text))
                MessageBox.Show("Favor informar um Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                classProduto cProduto = new classProduto();
                dgvProduto.DataSource = cProduto.BuscarProdutoNome(txtPesqProduto.Text);
            }
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {

            if (txtQtde.Text != "")
            {
                int qtde = Convert.ToInt32(txtQtde.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);
                txtTotal.Text = (qtde * valor).ToString();

            }

            else
            {
                MessageBox.Show("Favor informar uma quantidade ", "Sistema Loja de Cosmético", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            classProduto cProduto = new classProduto();
            bool aux = cProduto.BuscarProdutoId((int)dgvProduto.SelectedRows[0].Cells[0].Value);

            if (aux)
            {
                txtProduto.Text = cProduto.NomeProduto;
                txtQtdeEstoque.Text = cProduto.QtdeEstoque.ToString();
                txtValor.Text = cProduto.PrecoVenda.ToString("n2");
                txtQtde.Text = "01";
                txtQtde_TextChanged(this, new EventArgs());
                txtQtde.Select();


            }
        }

        private void txtValorDesconto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorDesconto.Text))
            {
                decimal valor = Convert.ToDecimal(txtValorTotal.Text);
                decimal desc = 0;
                txtTotalVenda.Text = (valor * (1 - (desc / 100))).ToString("n2");
                txtTotalDesconto.Text = (valor - (valor * (1 - (desc / 100)))).ToString("n2");
            }

            else
            {
                decimal valor = Convert.ToDecimal(txtValorTotal.Text);
                decimal desc = Convert.ToDecimal(txtValorDesconto.Text);
                txtTotalVenda.Text = (valor * (1 - (desc / 100))).ToString("n2");
                txtTotalDesconto.Text = (valor - (valor * (1 - (desc / 100)))).ToString("n2");
            }
        }

        private void AtualizaGrid()
        {
            classProduto obj = new classProduto();
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("Código"));
            dt.Columns.Add(new DataColumn("Produto"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Preço"));


            foreach (classItensVenda item in ListaItensVenda)
            {
                dt.Rows.Add(item.CodigoProduto, obj.BuscarNomeProd(item.CodigoProduto), item.Qtde, item.Preco);
                dt.AcceptChanges();
            }
            dgvItens.DataSource = dt;
        }

        private void btAddProduto_Click(object sender, EventArgs e)
        {
            classItensVenda cItensVenda = new classItensVenda();
            decimal vTotal = 0;
            if (string.IsNullOrEmpty(txtProduto.Text))
            {
                MessageBox.Show("Não há produto para ser inserido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int qtdevendida = Convert.ToInt32(txtQtde.Text);
                int qtdeestoque = Convert.ToInt32(txtQtdeEstoque.Text);
                if (qtdevendida > qtdeestoque)
                {
                    MessageBox.Show("Quantidade disponivel no estoque é de: " + qtdeestoque + " unidades!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQtde.Text = "01";
                    txtQtde.Select();
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtTotal.Text))
                    {
                        vTotal = Convert.ToDecimal(txtTotal.Text);
                        VendaTotal = VendaTotal + vTotal;
                        txtValorTotal.Text = VendaTotal.ToString("");
                        txtQtdeEstoque.Text = (qtdeestoque = qtdevendida).ToString();
                        itensVenda++;

                        cItensVenda.Preco = Convert.ToDecimal(txtTotal.Text);
                        cItensVenda.CodigoProduto = (int)(dgvProduto.SelectedRows[0].Cells[0].Value);
                        cItensVenda.Qtde = Convert.ToInt32(txtQtde.Text);

                        ListaItensVenda.Add(cItensVenda);
                        txtQtdeItens.Text = itensVenda.ToString();
                        txtQtdeItens.Text = ListaItensVenda.Count.ToString();

                        AtualizaGrid();

                        txtValorDesconto.Text = "0";
                        txtValorDesconto_TextChanged(this, new EventArgs());
                        txtValorDesconto.Select();
                        txtProduto.Clear();
                        txtQtde.Text = "01";
                        txtQtdeEstoque.Clear();
                        txtValor.Clear();
                        txtTotal.Clear();



                    }
                    else

                        MessageBox.Show("Escolha um produto", "Nome Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
                    
                


        //ATUALIZA QUANTIDADE
        private void AtualizaEstoque(int qtde, int cod)
        {
            classProduto obj = new classProduto();
            obj.BuscarProdutoId(cod);
            int estoque = obj.QtdeEstoque;
            obj.AtualizarQtde(estoque - qtde, cod);
        }


                private void Limpa()
        {
            ListaItensVenda.Clear();
            AtualizaGrid();
            dgvItens.Refresh();
            VendaTotal = 0;

            txtValorDesconto.Text = "";
            txtTotalDesconto.Text = "0";
            txtTotalVenda.Text = "0";
            txtQtdeItens.Text = "0";
            txtValorTotal.Clear();

            cbFuncionario.SelectedIndex = -1;
            cbFormaPagamento.SelectedIndex = 0;
            txtObservacao.Clear();
            txtPesqProduto.Clear();
            dgvProduto.DataSource = null;
            txtPesqCliente.Clear();
            dgvCliente.DataSource = null;
        }

        private void btFechaVenda_Click(object sender, EventArgs e)
        {
            if (cbFuncionario.Text != "" && dgvCliente.DataSource != null && txtPesqProduto.Text != "" && dgvItens.DataSource != null && cbFormaPagamento.Text != "")
            {
                classVenda obj = new classVenda();
                obj.CodigoCliente = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value);
                obj.CodigoFuncionario = (int)(cbFuncionario.SelectedValue);
                obj.QtdeItens = Convert.ToInt32(txtQtdeItens.Text);
                obj.ValorTotal = Convert.ToDecimal(txtTotalVenda.Text);
                obj.Observacao = txtObservacao.Text;
                obj.FormaPagamento = cbFormaPagamento.SelectedItem.ToString();
                obj.Desconto = Convert.ToDecimal(txtTotalDesconto.Text);

                bool aux = obj.CadastraVenda();

                if (aux)
                {
                    aux = false;
                    foreach (classItensVenda item in ListaItensVenda)
                    {
                        item.CodigoVenda = obj.CodigoVenda;
                        aux = item.CadastraItemVenda();

                        AtualizaEstoque(item.Qtde, item.CodigoProduto);

                    }

                    if (aux)
                    {
                        MessageBox.Show("Venda Cadastrada.Total de Produtos: "+txtQtdeItens.Text, "Sistema Loja Cosmetico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpa();
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao realizar venda", "Sistema Loja Cosmetico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("Preencha os campos necessários","Sistema Loja Cosmético",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


           

        }

        private void btRemoveProduto_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count > 0)
            {
                decimal valor = Convert.ToDecimal(dgvItens.SelectedRows[0].Cells[3].Value);
                VendaTotal = VendaTotal - valor;
                txtValorTotal.Text = VendaTotal.ToString("n2");
                txtTotalVenda.Text = VendaTotal.ToString("n2");

                ListaItensVenda.RemoveAt(dgvItens.CurrentRow.Index);
                AtualizaGrid();
                txtQtdeItens.Text = ListaItensVenda.Count.ToString();
                txtValorDesconto_TextChanged(this, new EventArgs());

            }

            else
                MessageBox.Show("Não há itens para ser removido.","Sistema Loja de Cosméticos",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

        
        


