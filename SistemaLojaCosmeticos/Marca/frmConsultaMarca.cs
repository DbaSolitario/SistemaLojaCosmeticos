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
    public partial class frmPesquisaMarca : MetroFramework.Forms.MetroForm
    {
        public frmPesquisaMarca()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a pesquisa de Marca ?", "Atenção", MessageBoxButtons.YesNo,
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

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string Consulta = cbTipoPesquisa.SelectedItem.ToString();
            classMarca obj = new classMarca();
            switch (Consulta)
            {
                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        obj.Status = 1;
                        dtv.DataSource = obj.BuscarMarcaStatus();
                    }
                    else
                    {
                        obj.Status = 0;
                        dtv.DataSource = obj.BuscarMarcaStatus();
                    }
                    break;

                case "Descrição":
                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked)
                        {
                            obj.NomeMarca = txtNome.Text;
                            dtv.DataSource = obj.BuscarMarcaInicio();
                        }

                        else if (rbContem.Checked)
                        {
                            obj.NomeMarca = txtNome.Text;
                            dtv.DataSource = obj.BuscarMarcaContem();

                        }
                    }

                    else
                        MessageBox.Show("Favor informar uma Marca.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Código":
                    if (txtCod.Text != "")
                    {
                        
                            obj.CodigoMarca = Convert.ToInt32(txtCod.Text);
                            dtv.DataSource = obj.BuscarMarcaCod();
                    

                       
                    }

                    else
                        MessageBox.Show("Favor informar uma Marca.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }



        }

        private void frmConsultaMarca_Load(object sender, EventArgs e)
        {
            cbTipoPesquisa.Items.Add("Descrição");
            cbTipoPesquisa.Items.Add("Status");
            cbTipoPesquisa.Items.Add("Código");
            cbTipoPesquisa.SelectedIndex = 0;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dtv.SelectedCells.Count > 0)
            {
                classMarca obj = new classMarca();
                obj.RetornaMarca(Convert.ToInt32(dtv.SelectedRows[0].Cells[0].Value));
                frmMarca obj2 = new frmMarca();

                obj2.textBoxCodMarca.Text = obj.CodigoMarca.ToString();
                obj2.lbdata.Text = obj.DataCadastro.ToShortDateString();
                obj2.textBoxNomeMarca.Text = obj.NomeMarca;
               // obj2.txtQtde.Text = obj.QtdeEstoque.ToString();
               // obj2.txtPreco.Text = obj.PrecoVenda.ToString();
                obj2.textBoxObsMarca.Text = obj.Observacao;
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
                MessageBox.Show("Selecione a Marca a ser Atualizado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gbStatus_Enter(object sender, EventArgs e)
        {

        }

        private void rbInativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbPesquisar_Enter(object sender, EventArgs e)
        {

        }

        private void rbContem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbInicio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
