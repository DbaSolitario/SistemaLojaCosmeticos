using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLojaCosmeticos
{
    class classCliente
    {
        private int codigocliente;
        private DateTime datacadastro;
        private string nomecliente;
        private string rg;
        private string cpf;
        private DateTime datanascimento;
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
        private string erro;

        public classCliente()
        {
            codigocliente = 0;
            datacadastro = DateTime.Now;
            nomecliente = null;
            rg = null;
            cpf = null;
            datanascimento = DateTime.Now;
            sexo = null;
            rua = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            cep = null;
            email = null;
            telefonecelular = null;
            telefoneresidencial = null;
            status = 0;
            erro = null;

        }

        public int CodigoCliente
        {
            get { return codigocliente; }
            set { codigocliente = value; }
        }

        public DateTime DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        public string NomeCliente
        {
            get { return nomecliente; }
            set { nomecliente = value; }
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
        public DateTime DataNascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
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
         public int Numero
        {
            get { return numero; }
            set { numero = value; }
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
        public string TelefoneResidencial
        {
            get { return telefoneresidencial; }
            set { telefoneresidencial = value; }
        }
        public string TelefoneCelular
        {
            get { return telefonecelular; }
            set { telefonecelular = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Erro
        {
            get { return erro; }
        }
        public int CadastrarCliente()
        {
            string query = "insert into Cliente values (getdate(),'"+NomeCliente+"','" + RG + "','" + CPF +"', convert(date,'"+ datanascimento + "',103),'" + Sexo + "','" + Rua +"','" + Numero + "','" + Complemento + "','" + Bairro + "','" + Cidade +"','" + Estado + "','" + CEP + "','" + Email + "','" + TelefoneResidencial +"','" + TelefoneCelular + "', 1)";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);

        }
    }
}
 
