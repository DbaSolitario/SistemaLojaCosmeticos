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
    public partial class frmCategoria : MetroFramework.Forms.MetroForm
    {

        public string tipo;

        public int categoria;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            lbDataCad.Text = DateTime.Now.ToString();

            if (tipo == "Atualização")
            {
                label1.Text = "Atualização de Categoria";
                buttonCadCategoria.Enabled = false;
                checkboxStatus.Enabled = true;
                //cbCategoria.SelectedValue = categoria;
                // cbMarca.SelectedValue = marca;
                buttonExcluirCategoria.Enabled = true;
                buttonAtualizarCategoria.Enabled = true;
            }
        }

       

        
        private void buttonCadCategoria_Click(object sender, EventArgs e)
        {
         

            classCategoria cCategoria = new classCategoria();
            string nomecategoria;
            nomecategoria = textBoxNomeCategoria.Text;

            if(cCategoria.ValidaCategoria(nomecategoria))
            {
                MessageBox.Show(" Categoria: " + nomecategoria + "  já está Cadastrada no Sistema. ", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNomeCategoria.Focus();
            }
            else




            if (textBoxNomeCategoria.Text != "")
            {
                cCategoria.NomeCategoria = textBoxNomeCategoria.Text;
                cCategoria.Observacao = textBoxObsCategoria.Text;

                int aux = cCategoria.CadastrarCategoria();

                if (aux != 0)
                {
                    MessageBox.Show(" Categoria: " + cCategoria.NomeCategoria + "Cadastrada com sucesso",
                        "Sistema Loja de Comsméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonLimparCategoria_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxNomeCategoria.BackColor = Color.LemonChiffon;
                textBoxNomeCategoria.Focus();
            }
       
            
          

        }

        private void buttonLimparCategoria_Click(object sender, EventArgs e)
        {
            textBoxNomeCategoria.Clear();
            textBoxObsCategoria.Clear();
        }

        private void buttonSairCategoria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o cadastro de Categoria ?", "Atenção", MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
          ) == DialogResult.Yes)
                this.Close();
        }

        private void buttonAtualizarCategoria_Click(object sender, EventArgs e)
        {
            classCategoria obj = new classCategoria();
            if (textBoxNomeCategoria.Text != "")
            {

                obj.NomeCategoria = textBoxNomeCategoria.Text;
                obj.Observacao = textBoxObsCategoria.Text;

                if(checkboxStatus.Checked == true)
                {
                    obj.Status = 1;
                }
                else
                {
                    obj.Status = 0;
                }

                obj.CodigoCategoria = Convert.ToInt32(textBoxCodCategoria.Text);
                bool aux = obj.AtualizarCategoria();
                if(aux)
                {
                    MessageBox.Show("Categoria: " + obj.NomeCategoria + " atualizado com sucesso.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // fecha form

                }

                else
                {
                    MessageBox.Show("Erro ao atualizar a Categoria " + obj.NomeCategoria, " Sistema Loja Cosméticos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Verificar campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                textBoxNomeCategoria.BackColor = Color.LemonChiffon;
                textBoxObsCategoria.BackColor = Color.LemonChiffon;
                textBoxNomeCategoria.Focus();
            }
        }

        private void buttonExcluirCategoria_Click(object sender, EventArgs e)
        {
            classCategoria obj = new classCategoria();
            obj.CodigoCategoria = Convert.ToInt32(textBoxCodCategoria.Text);

            if (MessageBox.Show("Deseja realmente excluir? A operação não poderá ser desfeita após a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = obj.ExcluirCategoria();
                if (aux)
                {
                    MessageBox.Show("Categoria: " + obj.NomeCategoria + "Excluído com sucesso.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(obj.NomeCategoria + "Esta Categoria está sendo usada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
