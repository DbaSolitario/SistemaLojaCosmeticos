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
    public partial class frmConsultaProduto : Form
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
            cbTipoPesquisa.Items.Add("Status");



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
            if(cbTipoPesquisa.SelectedIndex == 0) //DESCRICAO
            {
                txtNome.Enabled = true;
               gbPesquisar.Enabled = true;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 1) //CATEGORIA  
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = true;
            }


            if (cbTipoPesquisa.SelectedIndex == 2) //Marca 
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = false;
                cbMarca.Enabled = true;
                cbCategoria.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 3) //Preço
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbPreco.Enabled = true;
                gbStatus.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
            }

            if (cbTipoPesquisa.SelectedIndex == 4) //Status
            {
                txtNome.Enabled = false;
                gbPesquisar.Enabled = false;
                gbPreco.Enabled = false;
                gbStatus.Enabled = true;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
            }

        }
    }
}
