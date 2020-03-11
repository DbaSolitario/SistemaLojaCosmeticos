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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void CadCategoria_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms.OfType<frmCategoria>().Count()> 0)
            {
                MessageBox.Show("O Formulário de cadastro de categoria já esta aberto","Atenção",MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else {
                
                 frmCategoria CadCategoria = new frmCategoria();
                CadCategoria.MdiParent = this;
                CadCategoria.Show();
                
            }
        }

        private void MenuCadastro_Click(object sender, EventArgs e)
        {

        }

        private void CadMarca_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmMarca>().Count() > 0)
            {
                MessageBox.Show("O Formulário de cadastro de marca já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {

                frmMarca CadMarca = new frmMarca();
                CadMarca.MdiParent = this;
                CadMarca.Show();
            }
        }

        private void CadProduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário de cadastro de produto já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                frmProduto CadProduto = new frmProduto();
                CadProduto.MdiParent = this;
                CadProduto.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja fechar do sistema ?", "Atenção", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question
                 ) == DialogResult.Yes)
                Application.Exit();


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {

            StatuslbData.Text = DateTime.Now.ToShortDateString();
            StatuslbHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void toolstripPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolstripbuttoncadFuncionario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFuncionarios>().Count() > 0)
            {
                MessageBox.Show("O Formulário de cadastro de funcionarios já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {


                frmFuncionarios CadFuncionarios = new frmFuncionarios();
                CadFuncionarios.MdiParent = this;
                CadFuncionarios.Show();
           }
        }

        private void toolStripButtoncadClientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmClientes>().Count() > 0)
            {
                MessageBox.Show("O Formulário de cadastro de clientes já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {

                frmClientes CadClientes = new frmClientes();
                CadClientes.MdiParent = this;
                CadClientes.Show();
            }
        }

        private void toolStripButtoncadVendas_Click(object sender, EventArgs e)
        {
          //  if (Application.OpenForms.OfType<frmVendas>().Count() > 0)
          //  {
               // MessageBox.Show("O Formulário de vendas já esta aberto", "Atenção", MessageBoxButtons.OK,
                  //  MessageBoxIcon.Exclamation);
          //  }
          //  else
           // {


              //  frmVendas CadVendas = new frmVendas();
              //  CadVendas.MdiParent = this;
             //   CadVendas.Show();

           // }
        }

        private void toolStripButtonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar do sistema ?", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.Yes)
                Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmClientes>().Count() > 0)
            {
                MessageBox.Show("O Formulário de cadastro de Cliente já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                frmClientes CadCliente = new frmClientes();
                CadCliente.MdiParent = this;
                CadCliente.Show();
            }
        }

        private void StatuslbData_Click(object sender, EventArgs e)
        {

        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCargo>().Count() > 0)
            {
                MessageBox.Show("O Formulário de cadastro de Cargo já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                frmCargo CadCargo = new frmCargo();
                CadCargo.MdiParent = this;
                CadCargo.Show();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmConsultaProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário de pesquisa de Produto já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {


                frmConsultaProduto obj = new frmConsultaProduto();
                obj.MdiParent = this;
                obj.Show();

            }
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPesquisaMarca>().Count() > 0)
            {
                MessageBox.Show("O Formulário de pesquisa de marca já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {


                frmPesquisaMarca obj = new frmPesquisaMarca();
                obj.MdiParent = this;
                obj.Show();

            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPesquisarCategoria>().Count() > 0)
            {
                MessageBox.Show("O Formulário de pesquisa de Categoria já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {


                frmPesquisarCategoria obj = new frmPesquisarCategoria();
                obj.MdiParent = this;
                obj.Show();

            }
        }

        private void cargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmConsultaCargo>().Count() > 0)
            {
                MessageBox.Show("O Formulário de pesquisa de Cargo já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            else
            {


                frmConsultaCargo obj = new frmConsultaCargo();
                obj.MdiParent = this;
                obj.Show();

            }

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPesquisaFuncionario>().Count() > 0)
            {
                MessageBox.Show("O Formulário de pesquisa de Funcionario já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            else
            {


                frmPesquisaFuncionario obj = new frmPesquisaFuncionario();
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmConsultaCliente>().Count() > 0)
            {
                MessageBox.Show("O Formulário de pesquisa de Cliente já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            else
            {


                frmConsultaCliente obj = new frmConsultaCliente();
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void marcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelMarca>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Relatório de Marca já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            else
            {


                frmRelMarca obj = new frmRelMarca();
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void cargoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelCargo>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Relatório de Cargo já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            else
            {


                frmRelCargo obj = new frmRelCargo();
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelCategoria>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Relatório de Categoria já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            else
            {


                frmRelCategoria obj = new frmRelCategoria();
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelCliente>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Relatório de Clientes já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            else
            {


                frmRelCliente obj = new frmRelCliente();
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelFuncionarios>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Relatório de Funcionarios já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            else
            {


                frmRelFuncionarios obj = new frmRelFuncionarios();
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário de Relatório de Produtos já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            else
            {


                frmRelProduto obj = new frmRelProduto();
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFuncionarios>().Count() > 0)
            {
                MessageBox.Show("O Formulário de cadastro de funcionarios já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {


                frmFuncionarios CadFuncionarios = new frmFuncionarios();
                CadFuncionarios.MdiParent = this;
                CadFuncionarios.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login flog = new Login();
            flog.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmVendaCliGrid>().Count() > 0)
            {
                MessageBox.Show("O Formulário de vendas já esta aberto", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {


                frmVendaCliGrid CadVendas = new frmVendaCliGrid();
                CadVendas.MdiParent = this;
                CadVendas.Show();

            }
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void NomeFunc_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
