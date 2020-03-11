using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaLojaCosmeticos
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {

       classConexao obj = new classConexao();
        // private string obj;
        //private string strCoon;
        public bool logado = false;
        private string _Sql = string.Empty;
        public Login()
        {

            InitializeComponent();
        }





        public void logar()
        {

            classFuncionarios obj = new classFuncionarios();

            string nomefuncionario = txtLogin.Text;
            string cpf = txtSenha.Text;


            if (obj.login(nomefuncionario,cpf) || (txtLogin.Text == "admin" && txtSenha.Text == "admin"))
            {
                MessageBox.Show("Bem Vindo ao Sistema Funcionário: " + nomefuncionario ,"Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
                logado = true;
                this.Dispose();
               // this.Close();
            
            }
            else
            {
                MessageBox.Show("Nome e CPF não coincide.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
                logado = false;
            }


            //sqlConn = new SqlConnection();


            //string usu, pwd;



            //try
            //{
            //    usu = txtLogin.Text;
            //    pwd = txtSenha.Text;


            //    _Sql = "select count(CodigoFuncionarios) from Funcionarios where NomeFuncionario = @NomeFuncionario and RG = @RG";
            //    SqlCommand cmd = new SqlCommand(_Sql,sqlConn);


            //    cmd.Parameters.Add("@NomeFuncionario", SqlDbType.VarChar).Value = usu;

            //    cmd.Parameters.Add("@RG", SqlDbType.VarChar).Value = pwd;

            //    obj.RetornaDataTable(_Sql);
            //    //private string teste = _Sql;
            //    // int v = (int)cmd.ExecuteScalar();
                
            //    if (aux != "" )
            //    {
            //        MessageBox.Show("Login Realizado com sucesso");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Erro ao logar");
            //    }

            //}
            //catch(SqlException error)
            //{
            //    MessageBox.Show(error + "No Banco");
            //}

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != "" && txtLogin.Text != "")
            {
                logar();
            }
            else
            {
                MessageBox.Show("Favor inserir um Nome e CPF","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                logar();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
            
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void btRecuperar_Click(object sender, EventArgs e)
        {
            RecuperarSenha obj = new RecuperarSenha();
            obj.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != "" && txtLogin.Text != "")
            {
                logar();
            }
            else
            {
                MessageBox.Show("Favor inserir um Nome e CPF", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            RecuperarSenha obj = new RecuperarSenha();
            obj.Show();
        }
    }
}
