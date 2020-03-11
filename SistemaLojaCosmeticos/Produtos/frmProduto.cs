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
    public partial class frmProduto : MetroFramework.Forms.MetroForm
    {

        public string tipo;

        public int marca, categoria;

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
            cbCategoria.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            
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

            if (txtNome.Text!= "" && txtQtde.Text != "" && txtPreco.Text != "" && txtQtde.Text != "" &&  cbCategoria.Text != "" && cbMarca.Text != "")
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
                cbCategoria.BackColor = Color.LemonChiffon;
                cbMarca.BackColor = Color.LemonChiffon;

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

            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Produtos";
                buttonCadProduto.Enabled = false;
                cbStatus.Enabled = true;
                cbCategoria.SelectedValue = categoria;
                cbMarca.SelectedValue = marca;
                buttonExcluirProduto.Enabled = true;
                buttonAtualizarProduto.Enabled = true;

          
            }
            
        }

        private void buttonExcluirProduto_Click(object sender, EventArgs e)
        {
            classProduto obj = new classProduto();
            obj.CodigoProduto = Convert.ToInt32(txtCod.Text);

            if(MessageBox.Show("Deseja realmente excluir? A operação não poderá ser desfeita após a exclusão.","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = obj.ExcluirProduto();
                if (aux)
                {
                    MessageBox.Show("Produto: " + obj.NomeProduto + "Excluído com sucesso.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(obj.NomeProduto + "Erro ao excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAtualizarProduto_Click(object sender, EventArgs e)
        {
            classProduto obj = new classProduto();

            if (txtNome.Text != "" && txtQtde.Text != "" && txtPreco.Text != "" && txtQtde.Text != "" && cbCategoria.Text != "" && cbMarca.Text != "")
            {
                obj.NomeProduto = txtNome.Text;
                obj.Observacao = txtObservacao.Text;
                obj.PrecoVenda = Convert.ToDecimal(txtPreco.Text);
                obj.QtdeEstoque = Convert.ToInt32(txtQtde.Text);
                obj.CodigoMarca = Convert.ToInt32(cbMarca.SelectedValue);
                obj.CodigoCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                if(cbStatus.Checked == true)
                {
                    obj.Status = 1;
                }

                else
                {
                    obj.Status = 0;
                }

                obj.CodigoProduto = Convert.ToInt32(txtCod.Text);
                bool aux = obj.AtualizarProduto();
                if(aux)
                {
                    MessageBox.Show("Produto: " + obj.NomeProduto + "atualizado com sucesso.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // fecha form
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o Produto " + obj.NomeProduto  , "Sistema Loja Cosméticos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.BackColor = Color.LemonChiffon;
                txtPreco.BackColor = Color.LemonChiffon;
                txtQtde.BackColor = Color.LemonChiffon;
                cbCategoria.BackColor = Color.LemonChiffon;
                cbMarca.BackColor = Color.LemonChiffon;

                txtNome.Focus();
            }

            }

        
    }
}
