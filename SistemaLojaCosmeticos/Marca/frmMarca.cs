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
    public partial class frmMarca : MetroFramework.Forms.MetroForm
    {

        public string tipo;

        public int marca;
        public frmMarca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxObsMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadMarca_Click(object sender, EventArgs e)
        {
            classMarca cMarca = new classMarca();
            string nomemarca;
            nomemarca = textBoxNomeMarca.Text;

            if (cMarca.ValidaMarca(nomemarca))
            {
                MessageBox.Show(" Marca:  " + nomemarca + "  já está Cadastrada no Sistema. ", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNomeMarca.Focus();
            }
            else




                
                if (textBoxNomeMarca.Text != "")
                {
                    

                    cMarca.NomeMarca = textBoxNomeMarca.Text;
                    cMarca.Observacao = textBoxObsMarca.Text;
                    int aux = cMarca.CadastrarMarca();

                    if (aux != 0)
                    {
                        MessageBox.Show(" Marca: " + cMarca.NomeMarca + "  Cadastrada com sucesso",
                            "Sistema Loja Cosmético", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonLimparMarca_Click(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Erro ao realizar o cadastro", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Verificar campos obrigatórios.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNomeMarca.BackColor = Color.LemonChiffon;
                    textBoxNomeMarca.Focus();
                }


            }
        

        private void buttonLimparMarca_Click(object sender, EventArgs e)
        {
      
            textBoxNomeMarca.Clear();
            textBoxObsMarca.Clear();
        }

        private void buttonSairMarca_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o cadastro de Marca ?", "Atenção", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
           ) == DialogResult.Yes)
                this.Close();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            lbdata.Text = DateTime.Now.ToString();

            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Marca";
                buttonCadMarca.Enabled = false;
                checkboxStatus.Enabled = true;
                //cbCategoria.SelectedValue = categoria;
                // cbMarca.SelectedValue = marca;
                buttonExcluirMarca.Enabled = true;
                buttonAtualizarMarca.Enabled = true;
            }
        }

        private void textBoxNomeMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAtualizarMarca_Click(object sender, EventArgs e)
        {
            classMarca obj = new classMarca();

            if (textBoxNomeMarca.Text != "")
            {


                obj.NomeMarca = textBoxNomeMarca.Text;
                obj.Observacao = textBoxObsMarca.Text;
                       
                if(checkboxStatus.Checked == true)
                {
                    obj.Status = 1;
                }

                else
                {
                    obj.Status = 0;
                }

                obj.CodigoMarca = Convert.ToInt32(textBoxCodMarca.Text);
                bool aux = obj.AtualizarMarca();
                if(aux)
                {
                    MessageBox.Show("Marca: " + obj.NomeMarca + " atualizado com sucesso.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // fecha form
                }

                else
                {
                    MessageBox.Show("Erro ao atualizar a Marca " + obj.NomeMarca, " Sistema Loja Cosméticos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
             }

            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                textBoxNomeMarca.BackColor = Color.LemonChiffon;
                textBoxObsMarca.BackColor = Color.LemonChiffon;
                textBoxNomeMarca.Focus();
            }


            }

        private void buttonExcluirMarca_Click(object sender, EventArgs e)
        {
            classMarca obj = new classMarca();
            obj.CodigoMarca = Convert.ToInt32(textBoxCodMarca.Text);

            if (MessageBox.Show("Deseja realmente excluir? A operação não poderá ser desfeita após a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = obj.ExcluirMarca();
                if (aux)
                {
                    MessageBox.Show("Marca: " + obj.NomeMarca + "Excluído com sucesso.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(obj.NomeMarca + "Erro ao excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

       
    }

