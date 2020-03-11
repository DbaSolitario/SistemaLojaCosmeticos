using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaLojaCosmeticos
{
    class classConexao
    {
        //PRECISAMOS USAR UM OBJETO PARA A CONEXÃO COM O BANCO O 
        //OBJETO SqlConnection TRATA A CONEXÃO COM O SQLSERVER
        private SqlConnection c;

        //SqlCommand TRATA OS TIPOS DE COMANDO E CADA AÇÃO QUE DEVERÁ SER TOMADA,
        //COMO POR EXEMPLO UM SELECT OU INSERT, OU UMA PROCEDURE
        private SqlCommand cmd;

        //PODEMOS CONECTAR COM O SqlDataAdapter (RESULTADO DO ExecuteREeader) APENAS PARA LEITURA OU PODEMOS USAR UM ADPTER
        //O SqlDataAdapter SERÁ USADO PARA EXECUTAR COMANDOS (SELECT/INSERT/UPDATE/DELETE) USANDO UM DataSet OU DataTable
        //DataSet -> ARMAZENA DADOS EM EM MEMÓRIA, PODEMOS TER UM CONJUNTO DE TABELAS
        //DataTable -> É UMA TABELA APENAS QUE PODEMOS MONTAR NO AMBIENTE DE PROGRAMAÇÃO
        private SqlDataAdapter mDAdap;

        private string erros;

        public classConexao()
        {
            this.c = new SqlConnection();
            this.cmd = null;
            this.mDAdap = null;
            erros = null;
        }

        //PROPRIEDADES
        public string ComandoErro
        {
            get { return erros; }
        }

        #region Propriedades da Conexão

        public string StringConexao
        {
            get { return c.ConnectionString; }
        }

        //TimeOut -> RETORNA O TEMPO DE ESPERA PARA QUE A CONEXÃO ESTEJA LIBERADA
        public string TimeOut
        {
            get { return c.ConnectionTimeout.ToString(); }
        }

        //NOME DO BANCO DE DADOS
        public string DataBaseCx
        {
            get { return c.Database; }
        }

        //NOME DA INSTÂNCIA DE CONEXÃO
        public string DataSourceIns
        {
            get { return c.DataSource; }
        }

        //VERSÃO DO SERVIDOR
        public string ServerVesao
        {
            get { return c.ServerVersion; }
        }

        //ESTADO DA CONEXÃO
        public string EstadoCx
        {
            get { return c.State.ToString(); }
        }

        #endregion

        #region Métodos para Gerenciar a Conexão

        // ABRIR A CONEXÃO COM O BANCO
        // CRIAMOS A STRING CONEXÃO, OU PRECISAMOS PEGAR ESTA STRING DE ALGUM LUGAR CADA SERVIDOR TEM SUA STRING DE CONEXÃO
        private void Conectar()
        {
            //string conex = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LojaCosmeticos10681;Data Source=.\SQLEXPRESS";
            string conex = @"Password=senac@pir01;Persist Security Info=True;User ID=sa;Initial Catalog=Loja_Cosmeticos;Data Source=.\SQLEXPRESS";

            //c.State -> STATE É UMA PROPRIEDADE QUE PODEMOS VERIFICAR O ESTADO DA CONEXÃO, COMO NO PROJETO VAMOS SEMPRE FECHAR A CONEXÃO 
            //PODEREMOS MANTER O ESTADO SEMPRE FECHADO DEPENDO DA SITUAÇÃO PODEREMOS REALIZAR E MANTER O ESTADO ABERTO  
            if (this.c.State == ConnectionState.Closed || this.c.State == ConnectionState.Broken)
            {
                //INFORMA QUAL É A CONEXÃO QUE VAMOS USAR
                this.c.ConnectionString = conex;
                //ABRIR A CONEXÃO 
                this.c.Open();
            }
        }

        //TODA A CONEXÃO DEVE SER FECHADA E LIBERADA
        //c.Dispose() LIBERA A CONEXÃO
        //c.Close() FECHA A CONEXÃO
        //PODEMOS LIBERAR E FECHAR EM QUALQUER MOMENTO CHAMANDO ESTE MÉTODO
        private void Desconectar()
        {
            if (this.c.State == ConnectionState.Open)
            {
                this.c.Dispose();
                this.c.Close();
            }
        }
        #endregion

        #region Métodos que trata o tipo de acesso

        //EXECUTA A QUERY E DEPENDE DO RETORNO DO BANCO SQL (0 OU 1)
        //0 -> QUANDO GERA ALGUM ERRO
        //1 -> QUANDO OCORRE TUDO CERTO 
        public int ExecutaQuery(string query)
        {
            try
            {
                //CONECTA AO BANCO
                Conectar();

                //PREPARA A COMUNICAÇÃO E EXECUTA A QUERY
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.c;
                this.cmd.CommandText = query;
                this.cmd.CommandType = CommandType.Text;

                //ExecuteNonQuery PARA REALIZAR A EXECUÇÃO DE UM COMANDO
                int aux = this.cmd.ExecuteNonQuery();

                Desconectar();
                return aux;
            }
            catch (SqlException sqlex)
            {
                erros = sqlex.Message;
                Desconectar();
                return 0;
            }
        }

        //USADO PARA CADASTRAR, QUANDO ESPERAMOS O CÓDIGO DE RETORNO, CHAVE PRIMÁRIA(PK)
        //SERÁ USADO NOS CADASTROS NxN
        public int ExecutaQueryID(string query)
        {
            try
            {
                int aux = 0;
                Conectar();

                this.cmd = new SqlCommand(query, this.c);
                //ExecuteScalar: RECUPERAR UM VALOR ÚNICO DE UM BANCO DE DADOS (PK)
                aux = Convert.ToInt32(cmd.ExecuteScalar());

                Desconectar();
                return aux;
            }
            catch (SqlException sqlex)
            {
                erros = sqlex.Message;
                Desconectar();
                return 0;
            }
        }

        //DataTable REPRESENTA UMA TABELA DE DADOS NA MEMÓRIA
        //USADO SEMPRE QUE UMA CONSULTA NO BD TEM QUE SER FEITA
        public DataTable RetornaDataTable(string query)
        {
            try
            {
                DataTable dt = new DataTable();

                this.cmd = new SqlCommand(query, this.c);
                this.cmd.CommandType = CommandType.Text;
                this.mDAdap = new SqlDataAdapter(this.cmd);

                Conectar();

                this.mDAdap.Fill(dt);
                this.mDAdap.Dispose();

                Desconectar();
                return dt;
            }
            catch (SqlException sqlex)
            {
                erros = sqlex.Message;
                Desconectar();
                return null;
            }
        }

        #endregion
    }
}
