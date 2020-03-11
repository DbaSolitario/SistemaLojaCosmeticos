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
            get { return codigofuncionarios; }
            set { codigofuncionarios = value; }
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

        public DataTable BuscarEstado()
        {
            string query = "select Estado from Funcionarios where Status = 1  ";

            classConexao obj = new classConexao();
            return obj.RetornaDataTable(query);

        }


        //BUSCARFUNCIONARIO

        public DataTable BuscarFuncionarioNomeInicial()
        {
            string query = "select CodigoFuncionarios[Código], NomeFuncionario[Nome], CPF, Sexo, Cidade, Cargo.NomeCargo[Cargo], Funcionarios.Status from Funcionarios join	Cargo on Funcionarios.CodigoCargo = Cargo.CodigoCargo WHERE Funcionarios.NomeFuncionario like '" + nomefuncionario + "%' and Funcionarios.Status = 1 order by Funcionarios.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarFuncionarioNomeContem()
        {
            string query = "select CodigoFuncionarios[Código], NomeFuncionario[Nome], CPF, Sexo, Cidade, Cargo.NomeCargo[Cargo], Funcionarios.Status from Funcionarios join	Cargo on Funcionarios.CodigoCargo = Cargo.CodigoCargo WHERE Funcionarios.NomeFuncionario like '%" + nomefuncionario + "%' and Funcionarios.Status = 1 order by Funcionarios.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarFuncionarioCodigoContem()
        {
            string query = "select CodigoFuncionarios[Código], NomeFuncionario[Nome], CPF, Sexo, Cidade, Cargo.NomeCargo[Cargo], Funcionarios.Status from Funcionarios join	Cargo on Funcionarios.CodigoCargo = Cargo.CodigoCargo WHERE Funcionarios.CodigoFuncionarios like '%" + codigofuncionarios + "%' and Funcionarios.Status = 1 order by Funcionarios.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarFuncionarioCodigoInicial()
        {
            string query = "select CodigoFuncionarios[Código], NomeFuncionario[Nome], CPF, Sexo, Cidade, Cargo.NomeCargo[Cargo], Funcionarios.Status from Funcionarios join	Cargo on Funcionarios.CodigoCargo = Cargo.CodigoCargo WHERE Funcionarios.CodigoFuncionarios like '" + codigofuncionarios + "%' and Funcionarios.Status = 1 order by Funcionarios.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarFuncionarioCargo()
        {
            string query = "select CodigoFuncionarios[Código], NomeFuncionario[Nome], CPF, Sexo, Cidade, Cargo.NomeCargo[Cargo], Funcionarios.Status from Funcionarios join	Cargo on Funcionarios.CodigoCargo = Cargo.CodigoCargo WHERE Funcionarios.CodigoCargo = " + codigocargo + " and Funcionarios.Status = 1 order by Funcionarios.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarFuncionarioCPF()
        {
            string query = "select CodigoFuncionarios[Código], NomeFuncionario[Nome], CPF, Sexo, Cidade, Cargo.NomeCargo[Cargo], Funcionarios.Status from Funcionarios join	Cargo on Funcionarios.CodigoCargo = Cargo.CodigoCargo WHERE Funcionarios.CPF = '" + cpf + "' and Funcionarios.Status = 1 order by Funcionarios.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }


        public DataTable BuscarFuncionarioStatus()
        {
            string query = "select CodigoFuncionarios[Código], NomeFuncionario[Nome], CPF, Sexo, Cidade, Cargo.NomeCargo[Cargo], Funcionarios.Status from Funcionarios join	Cargo on Funcionarios.CodigoCargo = Cargo.CodigoCargo WHERE Funcionarios.Status = " + status + "order by Funcionarios.NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public bool RetornaFuncionario(int cod)

        {
            string query = "select * from  Funcionarios where CodigoFuncionarios = " + cod;
            classConexao obj = new classConexao();
            DataTable dt = obj.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                codigofuncionarios = Convert.ToInt32(dt.Rows[0]["CodigoFuncionarios"]);
                datacadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                nomefuncionario = Convert.ToString(dt.Rows[0]["NomeFuncionario"]);
                sexo = Convert.ToString(dt.Rows[0]["Sexo"]);
                rg = Convert.ToString(dt.Rows[0]["RG"]);
                cpf = Convert.ToString(dt.Rows[0]["CPF"]);
                dataadmissao = Convert.ToDateTime(dt.Rows[0]["DataAdmissao"]);
                datacadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                telefonecelular= Convert.ToString(dt.Rows[0]["TelefoneCelular"]);
                telefoneresidencial= Convert.ToString(dt.Rows[0]["TelefoneResidencial"]);
                email= Convert.ToString(dt.Rows[0]["Email"]);
                rua= Convert.ToString(dt.Rows[0]["Rua"]);
                numero= Convert.ToInt32(dt.Rows[0]["Numero"]);
                cidade= Convert.ToString(dt.Rows[0]["Cidade"]);
                bairro = Convert.ToString(dt.Rows[0]["Bairro"]);
                complemento = Convert.ToString(dt.Rows[0]["Complemento"]);
                cep = Convert.ToString(dt.Rows[0]["Cep"]);
                estado = Convert.ToString(dt.Rows[0]["Estado"]);
                status = Convert.ToInt32(dt.Rows[0]["Status"]);
                codigocargo = Convert.ToInt32(dt.Rows[0]["CodigoCargo"]);
                

                return true;
            }
            else
            {
                return false;
            }

        }



        public bool AtualizarFuncionario()
        {
            string query = "update Funcionarios set NomeFuncionario = '" + nomefuncionario + "', Status = '" + status + "', Sexo = '" + sexo + "',RG = '" + rg + "',CPF = '" + cpf + "', CodigoCargo = '" + codigocargo + "',DataAdmissao = convert(date, '" + dataadmissao + "', 103), DataNascimento = convert(date, '" + datanascimento + "', 103), TelefoneResidencial = '" + telefoneresidencial + "', TelefoneCelular = '" + telefonecelular + "', Email = '" + email + "', Rua = '" + rua + "', Numero = '" + numero + "', Cidade = '" + cidade + "', Bairro = '" + bairro + "', Complemento = '" + complemento + "', CEP = '" + cep + "', Estado = '" + estado + "' where CodigoFuncionarios = " + codigofuncionarios;
            classConexao obj = new classConexao();

            int aux = obj.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        //METODO PARA EXCLUIR PRODUTO
        public bool ExcluirFuncionario()
        {
            string query = "delete Funcionarios where Codigofuncionarios = " + codigofuncionarios;
            classConexao obj = new classConexao();
            int aux = obj.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }
        ///////////// MÉTODOS DE RELATÓRIO COMPLETO DE CLIENTES

        //RETORNAR OS Funcionarios ANIVERSARIANTES DO MÊS
        public DataTable RelFunMes(int mes)
        {
            string query = "select CodigoFuncionarios, CPF, NomeFuncionario, DataNascimento, Email,DataAdmissao[DataAdimissao],Sexo,Status from Funcionarios  where MONTH(DataNascimento) = " + mes + " and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS Funcionarios ANIVERSARIANTES DIA E MÊS
        public DataTable RelFunDiaMes(int dia, int mes)
        {
            string query = "select CodigoFuncionarios, CPF, NomeFuncionario, DataNascimento, Email,DataAdmissao[DataAdimissao],Sexo,Status from Funcionarios  where DAY(DataNascimento) = " + dia + " and MONTH(DataNascimento) = " + mes + " and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS Funcionarios POR IDADE
        //8766 NÚMERO DE HORAS EM UM ANO(APROXIMADAMENTE, POIS JÁ ANOS BISSEXTOS)
        public DataTable RelFunIdade(int idadei, int idadef)
        {
            string query = "select CodigoFuncionarios, CPF, NomeFuncionario, DataNascimento, Email,DataAdmissao[DataAdimissao],Sexo,Status from Funcionarios  where DATEDIFF(hour, DataNascimento, getdate()) / 8766 between " + idadei + "  and " + idadef + " and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS Funcionarios POR IDADE MAIORES DE
        //8766 NÚMERO DE HORAS EM UM ANO(APROXIMADAMENTE, POIS JÁ ANOS BISSEXTOS)
        public DataTable RelFunIdadeMaior(int idadem)
        {
            string query = "select CodigoFuncionarios, CPF, NomeFuncionario, DataNascimento, Email,DataAdmissao[DataAdimissao],Sexo,Status from Funcionarios  where DATEDIFF(hour, DataNascimento, getdate()) / 8766 > " + idadem + "  and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS Funcionarios ANIVERSARIANTES DATA COMPLETA
        public DataTable RelFunDataCompleta(DateTime dinicio, DateTime dfinal)
        {
            string query = "select CodigoFuncionarios, CPF, NomeFuncionario, DataNascimento, Email,DataAdmissao[DataAdimissao],Sexo,Status from Funcionarios where DataNascimento between convert (date,'" + dinicio + "',103) and convert (date,'" + dfinal + "',103) and Status = 1 order by NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //RETORNAR OS Funcionarios DE ACORDO COM A CIDADE
        public DataTable RelFunCidade(string cidade)
        {
            string query = "select CodigoFuncionarios, CPF, NomeFuncionario, DataNascimento, Email,DataAdmissao[DataAdimissao],Sexo,Status from Funcionarios  where Cidade = '" + cidade + "' and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS Funcionarios DE ACORDO COM O STATUS
        public DataTable RelFunStatus(int status)
        {
            string query = "select CodigoFuncionarios, CPF, NomeFuncionario, DataNascimento, Email,DataAdmissao[DataAdimissao],Sexo,Status from Funcionarios  where Status = " + status + " order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RETORNAR OS Funcionarios DE ACORDO COM O SEXO
        public DataTable RelFunSexo(string sexo)
        {
            string query = "select CodigoFuncionarios, CPF, NomeFuncionario, DataNascimento, Email,DataAdmissao[DataAdimissao],Sexo,Status from Funcionarios where Sexo = '" + sexo + "' and Status = 1 order by NomeFuncionario";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //MÉTODO PARA CARREGAR COMBO DE CIDADES NO RELATÓRIO DE CLIENTES COMPLETO
        public DataTable BuscarCidade()
        {
            string query = "select distinct Cidade from Funcionarios  where Cidade != '' order by Cidade";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable RelFunCargo(int cargo)
        {
            string query = "select CodigoFuncionarios, CPF, NomeFuncionario, DataNascimento, Email,DataAdmissao[DataAdimissao],Sexo,Status from Funcionarios where CodigoCargo = " + cargo ;

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable RelFunDataAdmissao(DateTime dinicio, DateTime dfinal)
        {
            string query = "select CodigoFuncionarios, CPF, NomeFuncionario, DataNascimento, Email,DataAdmissao[DataAdimissao],Sexo,Status from Funcionarios where DataAdmissao between convert (date,'" + dinicio + "',103) and convert (date,'" + dfinal + "',103) and Status = 1 order by NomeFuncionario";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public bool login(string funcionario, string cpf)
        {
            classConexao cConexao = new classConexao();
            string query = "Declare @i bit set @i = 0";
            query += "if exists ( select CPF,NomeFuncionario from Funcionarios where NomeFuncionario= '" + funcionario+"' and CPF = '" + cpf+"')";
            query += "set @i = 0 else set @i = 1";
            query += "select @i[resp]";

            DataTable dt = cConexao.RetornaDataTable(query);
            int resp = Convert.ToInt32(dt.Rows[0][0]);
            if (resp == 0) //Caso já existir alguma categoria com esse nome retorne 0
                return true;
            else
                return false;// se não 1


        }
        // select NomeFuncionario, RG from Funcionarios where NomeFuncionario = '""' and RG = '""'


        public DataTable recuSenha()
        {
            string query = "select NomeFuncionario, CPF, Email from Funcionarios where CPF = '"+cpf+"' or Email = '"+email+"'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }



        public DataTable BuscaFuncionario ()
        {
            string query = "select CodigoFuncionarios,NomeFuncionario from Funcionarios where CodigoCargo = 1 and Status = 1 order by CodigoCargo";
            classConexao obj = new classConexao();
            return obj.RetornaDataTable(query);
        }
    }
}
