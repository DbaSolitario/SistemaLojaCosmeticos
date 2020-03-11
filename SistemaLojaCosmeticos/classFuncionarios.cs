using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaCosmeticos
{
    class classFuncionarios
    {
        private int codigofuncionarios;
        private DateTime datacadastro;
        private string nomefuncionario;
        private string rg;
        private string cpf;
        private DateTime datanascimento;
        private DateTime dataadmissao;
        private string sexo;
        private string rua;
        private int numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        private string email;
        private string telefoneresidencial;
        private string telefonecelular;
        private int status;
        private int codigocargo;

        public classFuncionarios()
        {
            codigofuncionarios = 0;
            datacadastro = DateTime.Now;
            nomefuncionario = null;
            rg = null;
            cpf = null;
            datanascimento = DateTime.Now;
            dataadmissao = DateTime.Now;
            sexo = null;
            rua = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            CEP = null;
            email = null;
            telefonecelular = null;
            telefoneresidencial = null;
            status = 0;
            codigocargo = 0;

        }

        public int CodigoFuncionarios
        {
            get { return codigocargo; }
            set { codigocargo = value; }
         }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public int CodigoCargo
        {
            get { return codigocargo; }
            set { codigocargo = value; }
        }

        public DateTime DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        public DateTime DataAdimissao
        {
            get { return dataadmissao; }
            set { dataadmissao = value; }
 
        }

        public DateTime DataNascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }

        public string NomeFuncionario
        {
            get { return nomefuncionario; }
            set { nomefuncionario = value; }
        }
        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string TelefoneCelular
        {
            get { return telefonecelular; }
            set { telefonecelular = value; }
        }
        public string TelefoneResidencial
        {
            get { return telefoneresidencial; }
            set { telefoneresidencial = value; }
        }

        


        public int CadastrarFuncionario()
        {
            string query = "insert into Funcionarios values (getdate(),'" + nomefuncionario + "','"+RG+"','" +CPF+ "', convert(date, '"+ datanascimento + "', 103), convert(date, '" + dataadmissao + "', 103),'" + sexo+ "','" +rua+ "','" +Numero+ "','" +complemento+ "','" +bairro+ "','" +cidade+ "','" +estado+"','" +CEP+ "','" +email+ "','" +telefoneresidencial+ "','" +telefonecelular+ "',1 ," +CodigoCargo+")";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }


        public bool ValidaFuncionario(string funcionario)
        {
            classConexao cConexao = new classConexao();
            string query = "Declare @i bit set @i = 0";
            query += "if exists (select NomeFuncionario from Funcionario where NomeFuncionario = '"+funcionario+"')";
            query += "set @i = 0 else set @i = 1";
            query += "select @i[resp]";

            DataTable dt = cConexao.RetornaDataTable(query);
            int resp = Convert.ToInt32(dt.Rows[0][0]);
            if (resp == 0)
                return true;
            else
                return false;
        }
        public DataTable BuscarCargo()
        {
            string query = "select CodigoCargo, NomeCargo from Cargo where Status = 1 order by NomeCargo";

            classConexao obj = new classConexao();
            return obj.RetornaDataTable(query);

        }

    }
}
