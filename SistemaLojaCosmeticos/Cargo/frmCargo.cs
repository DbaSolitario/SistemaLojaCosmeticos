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
    public partial class frmCargo : MetroFramework.Forms.MetroForm
    {

        public string tipo;

        public int cargo;
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

            if (tipo == "Atualização")
            {
                label2.Text = "Atualização de Cargo";
                buttonCadMarca.Enabled = false;
                checkboxStatus.Enabled = true;
                //cbCategoria.SelectedValue = categoria;
                // cbMarca.SelectedValue = marca;
                buttonExcluirMarca.Enabled = true;
                buttonAtualizarMarca.Enabled = true;
            }
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
                    MessageBox.Show("Cargo:  " + cCargo.NomeCargo + "  Cadastrado com sucesso", "Sistema Loja Cosmético", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonAtualizarMarca_Click(object sender, EventArgs e)
        {
            classCargo obj = new classCargo();

            if (txtNome.Text != "")
            {


                obj.NomeCargo = txtNome.Text;
                obj.Observacao = txtObservacao.Text;
                

                if (checkboxStatus.Checked == true)
                {
                    obj.Status = 1;
                }

                else
                {
                    obj.Status = 0;
                }

                obj.CodigoCargo = Convert.ToInt32(txtCodCargo.Text);
                bool aux = obj.AtualizarCargo();
                if (aux)
                {
                    MessageBox.Show("Cargo: " + obj.NomeCargo + " atualizado com sucesso.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // fecha form
                }

                else
                {
                    MessageBox.Show("Erro ao atualizar a Marca " + obj.NomeCargo, " Sistema Loja Cosméticos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtNome.BackColor = Color.LemonChiffon;
                txtObservacao.BackColor = Color.LemonChiffon;
                txtNome.Focus();
            }
        }

        private void buttonExcluirMarca_Click(object sender, EventArgs e)
        {
            classCargo obj = new classCargo();
            obj.CodigoCargo = Convert.ToInt32(txtCodCargo.Text);

            if (MessageBox.Show("Deseja realmente excluir? A operação não poderá ser desfeita após a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = obj.ExcluirCargo();
                if (aux)
                {
                    MessageBox.Show("Cargo: " + obj.NomeCargo + "Excluído com sucesso.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(obj.NomeCargo + "Erro ao excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
