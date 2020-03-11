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
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            lbdata.Text = DateTime.Now.ToString();
            txtCodCargo.Enabled = false;
        }

        private void buttonCadMarca_Click(object sender, EventArgs e)
        {
            classCargo cCargo = new classCargo();
            string nomecargo;
            nomecargo = txtNome.Text;


            if (cCargo.ValidaCargo(nomecargo))
            {
                MessageBox.Show(" Cargo:  " + nomecargo + "  já está Cadastrada no Sistema. ", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else

            if (txtNome.Text != "")
            {
                cCargo.NomeCargo = txtNome.Text;
                cCargo.Observacao = txtObservacao.Text;
                int aux = cCargo.CadastrarCargo();

                if (aux != 0)
                {
                    MessageBox.Show("Marca:  " + cCargo.NomeCargo + "  Cadastrado com sucesso", "Sistema Loja Cosmético", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonLimparCargo_Click(this, new EventArgs());

                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.BackColor = Color.LemonChiffon;
                txtNome.Focus();
            }

            }
        

        private void buttonLimparCargo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtObservacao.Clear();
        }

        private void buttonSairCargo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o cadastro de Cargo ?", "Atenção", MessageBoxButtons.YesNo,
      MessageBoxIcon.Question
      ) == DialogResult.Yes)
                this.Close();
        }
    }
}
