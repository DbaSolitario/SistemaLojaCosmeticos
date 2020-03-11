using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        public bool RetornaCliente(int cod)

        {
            string query = "select * from Cliente where CodigoCliente = " + cod;
            classConexao obj = new classConexao();
            DataTable dt = obj.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                codigocliente = Convert.ToInt32(dt.Rows[0]["CodigoCliente"]);
                datacadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                nomecliente = Convert.ToString(dt.Rows[0]["NomeCliente"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);
                sexo = Convert.ToString(dt.Rows[0]["Sexo"]);
                cpf = Convert.ToString(dt.Rows[0]["CPF"]);
                telefonecelular = Convert.ToString(dt.Rows[0]["TelefoneCelular"]);
                telefoneresidencial = Convert.ToString(dt.Rows[0]["TelefoneResidencial"]);
                email = Convert.ToString(dt.Rows[0]["Email"]);
                rua = Convert.ToString(dt.Rows[0]["Rua"]);
                numero = Convert.ToInt32(dt.Rows[0]["Numero"]);
                cidade = Convert.ToString(dt.Rows[0]["Cidade"]);
                bairro = Convert.ToString(dt.Rows[0]["Bairro"]);
                complemento = Convert.ToString(dt.Rows[0]["Complemento"]);
                cep = Convert.ToString(dt.Rows[0]["Cep"]);
                estado = Convert.ToString(dt.Rows[0]["Estado"]);
                status = Convert.ToInt32(dt.Rows[0]["Status"]);
                datanascimento = Convert.ToDateTime(dt.Rows[0]["DataNascimento"]);


                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable BuscarEstado()
        {
            string query = "select Estado from Cliente";

            classConexao obj = new classConexao();
            return obj.RetornaDataTable(query);

        }

        public DataTable BuscarClienteNomeInicial()
        {
            string query = "select CodigoCliente[Código],NomeCliente[Nome],CPF,Sexo,Bairro,Status from Cliente where NomeCliente like  '"+nomecliente+"%' and Status = 1 order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarClienteNomeContem()
        {
            string query = "select CodigoCliente[Código],NomeCliente[Nome],CPF,Sexo,Bairro,Status from Cliente where NomeCliente like  '%" + nomecliente + "%' and Status = 1 order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarClienteCodInicial()
        {
            string query = "select CodigoCliente[Código],NomeCliente[Nome],CPF,Sexo,Bairro,Status from Cliente where CodigoCliente like '" + codigocliente + "%' and Status = 1 order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarClienteCodContem()
        {
            string query = "select CodigoCliente[Código],NomeCliente[Nome],CPF,Sexo,Bairro,Status from Cliente where CodigoCliente like '%" + codigocliente + "%' and Status = 1 order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarClienteCPF()
        {
            string query = "select CodigoCliente[Código],NomeCliente[Nome],CPF,Sexo,Bairro,Status from Cliente where CPF = " + cpf + " and Status = 1 order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarClienteStatus()
        {
            string query = "select CodigoCliente[Código],NomeCliente[Nome],CPF,Sexo,Bairro,Status from Cliente where Status = " + status + "  order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }
        //Buscar por dia e mes
        public DataTable BuscarClienteDiaMes(int dia, int mes)
        {
            string query = "select CodigoCliente[Código],NomeCliente[Nome],CPF,Sexo,Bairro,Status from Cliente where  DAY(DataNascimento) = " + dia + " and MONTH(DataNascimento) = " + mes + " and Status = 1  order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarClienteMes(int mes)
        {
            string query = "select CodigoCliente[Código],NomeCliente[Nome],CPF,Sexo,Bairro,Status from Cliente  where MONTH(DataNascimento) = " + mes + " and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


       

        //RETORNAR OS CLIENTES POR IDADE MAIORES DE
        //8766 NÚMERO DE HORAS EM UM ANO(APROXIMADAMENTE, POIS JÁ ANOS BISSEXTOS)
        public DataTable BuscarClienteIdadeMaior(int idadem)
        {
            string query = "select CodigoCliente[Código],NomeCliente[Nome],CPF,Sexo,Bairro,Status from Cliente where DATEDIFF(hour, DataNascimento, getdate()) / 8766 > " + idadem + "  and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES DE ACORDO COM A CIDADE
        public DataTable BuscarClienteCidade(string cidade)
        {
            string query = "select CodigoCliente[Código],NomeCliente[Nome],CPF,Sexo,Bairro,Status from Cliente where Cidade = '" + cidade + "' and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        public bool AtualizarCliente()
        {
            string query = "update Cliente set NomeCliente = '"+nomecliente+"', Status = '" + status + "', Sexo = '" + sexo + "', RG = '" + rg + "', CPF = '" + cpf + "', DataNascimento = convert(date, '" + datanascimento + "', 103), TelefoneResidencial = '" + telefoneresidencial + "', TelefoneCelular = '" + telefonecelular + "', Email = '" + email + "', Rua = '" + rua + "', Numero = '" + numero + "', Cidade = '" + cidade + "', Bairro = '" + bairro + "', Complemento = '" + complemento + "', CEP = '" + cep + "', Estado = '" + estado + "' where CodigoCliente = " + codigocliente;
            classConexao obj = new classConexao();

            int aux = obj.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        public bool ExcluirCliente()
        {
            string query = "delete Cliente where CodigoCliente = " + codigocliente ;
            classConexao obj = new classConexao();
            int aux = obj.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        ///////////// MÉTODOS DE RELATÓRIO COMPLETO DE CLIENTES

        //RETORNAR OS CLIENTES ANIVERSARIANTES DO MÊS
        public DataTable RelClienteMes(int mes)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status  from Cliente  where MONTH(DataNascimento) = " + mes + " and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES ANIVERSARIANTES DIA E MÊS
        public DataTable RelClienteDiaMes(int dia, int mes)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where DAY(DataNascimento) = " + dia + " and MONTH(DataNascimento) = " + mes + " and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES POR IDADE
        //8766 NÚMERO DE HORAS EM UM ANO(APROXIMADAMENTE, POIS JÁ ANOS BISSEXTOS)
        public DataTable RelClienteIdade(int idadei, int idadef)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where DATEDIFF(hour, DataNascimento, getdate()) / 8766 between " + idadei + "  and " + idadef + " and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES POR IDADE MAIORES DE
        //8766 NÚMERO DE HORAS EM UM ANO(APROXIMADAMENTE, POIS JÁ ANOS BISSEXTOS)
        public DataTable RelClienteIdadeMaior(int idadem)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where DATEDIFF(hour, DataNascimento, getdate()) / 8766 > " + idadem + "  and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES ANIVERSARIANTES DATA COMPLETA
        public DataTable RelClienteDataCompleta(DateTime dinicio, DateTime dfinal)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where DataNascimento between convert (date,'" + dinicio + "',103) and convert (date,'" + dfinal + "',103) and Status = 1 order by NomeCliente";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES DE ACORDO COM A CIDADE
        public DataTable RelClienteCidade(string cidade)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status From Cliente where Cidade = '" + cidade + "' and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES DE ACORDO COM O STATUS
        public DataTable RelClienteStatus(int status)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where Status = " + status + " order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS CLIENTES DE ACORDO COM O SEXO
        public DataTable RelClienteSexo(string sexo)
        {
            string query = "select CodigoCliente, CPF, NomeCliente, DataNascimento, Email, TelefoneCelular, Sexo, Status from Cliente where Sexo = '" + sexo + "' and Status = 1 order by NomeCliente";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //MÉTODO PARA CARREGAR COMBO DE CIDADES NO RELATÓRIO DE CLIENTES COMPLETO
        public DataTable BuscarCidade()
        {
            string query = "select distinct Cidade from Cliente  where Cidade != '' order by Cidade";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable BuscarCliente(string cli)
        {
            string query = "select CodigoCliente[Código], NomeCliente[Cliente] from Cliente where Status = 1 and NomeCliente like '%" + cli + "%' order by NomeCliente";
            classConexao obj = new classConexao();
            return obj.RetornaDataTable(query);
        }
    }
}
 
