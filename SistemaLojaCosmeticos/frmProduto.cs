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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void buttonLimparProduto_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtNome.Clear();
            txtObservacao.Clear();
            txtPreco.Clear();
            txtQtde.Clear();
            
        }

        private void buttonSairProduto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o cadastro de Produto ?", "Atenção", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
        ) == DialogResult.Yes)
                this.Close();
        }

        private void buttonCadProduto_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();

           
            string nomeproduto;
            nomeproduto = txtNome.Text;

            if (cProduto.ValidaProduto(nomeproduto))
            {
                MessageBox.Show(" Categoria: " + nomeproduto + "  já está Cadastrada no Sistema. ", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else

            if (txtNome.Text!= "" && txtQtde.Text != "" && txtPreco.Text != "")
            {
                cProduto.NomeProduto = txtNome.Text;
                cProduto.Observacao = txtObservacao.Text;
                cProduto.PrecoVenda = Convert.ToDecimal(txtPreco.Text);
                cProduto.QtdeEstoque = Convert.ToInt32(txtQtde.Text);
                cProduto.CodigoMarca = Convert.ToInt32(cbMarca.SelectedValue);
                cProduto.CodigoCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
               

                int aux = cProduto.CadastrarProduto();
                if (aux != 0)
                {
                    MessageBox.Show(" Produto: " + cProduto.NomeProduto + "  Castrado com sucesso", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonLimparProduto_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro", "Sistema loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.BackColor = Color.LemonChiffon;
                txtPreco.BackColor = Color.LemonChiffon;
                txtQtde.BackColor = Color.LemonChiffon;
                txtNome.Focus();
            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            lbdata.Text = DateTime.Now.ToString();

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

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
