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
    public partial class frmCategoria : Form
    {
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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkboxStatus_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
