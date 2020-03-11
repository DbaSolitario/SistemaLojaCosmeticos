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
    public partial class RecuperarSenha : MetroFramework.Forms.MetroForm
    {
        public RecuperarSenha()
        {
            InitializeComponent();
        }

        private void RecuSenha_Load(object sender, EventArgs e)
        {

            
        }

        private void btRecu_Click(object sender, EventArgs e)
        {
            
            if (txtCpf.Text != "")
            {
                classFuncionarios obj = new classFuncionarios();
                obj.CPF = txtCpf.Text;
                dtv.DataSource = obj.recuSenha();
                txtCpf.Text = "";
                if (dtv.RowCount == 1)
                {
                    MessageBox.Show("Nenhum Funcionário encontrado com esse CPF:  "+obj.CPF+ "","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dtv.DataSource = null;
                }
              
                     
                
            }
            

            else if (txtEmail.Text != "")
            {
                classFuncionarios obj = new classFuncionarios();
                obj.Email = txtEmail.Text;
                dtv.DataSource = obj.recuSenha();
                //txtEmail.Text = "";
                if (dtv.RowCount == 1)
                {
                    MessageBox.Show("Nenhum Funcionário encontrado com esse E-mail:  " + obj.Email + " ", "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    dtv.DataSource = null;
                }

                txtEmail.Text = "";
            }
        }

        private void txtCpf_Click(object sender, EventArgs e)
        {

        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////Se a tecla digitada não for número
            //if (!char.IsDigit(e.KeyChar))
            //{
            //    //Atribui True no Handled para cancelar o evento
            //    e.Handled = true;
            //    MessageBox.Show("Este campo aceita Letras");
            //}
            //else
            //{
            //    MessageBox.Show("Este campo aceita Letras");
            //}
        }
    }
}
