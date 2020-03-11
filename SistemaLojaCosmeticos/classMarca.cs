using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaCosmeticos
{
    class classMarca
    {
        private int codigomarca;
        private DateTime datacadastro;
        private string nomemarca;
        private string observacao;
        private int status;
        private string erro;

        public classMarca()
        {
            codigomarca = 0;
            datacadastro = DateTime.Now;
            nomemarca = null;
            observacao = null;
            status = 0;
            erro = null;


        }

        public int CodigoMarca
        {
            get { return codigomarca; }
            set { codigomarca = value; }
        }

        public DateTime DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }

        }

        public string NomeMarca
        {
            get { return nomemarca; }
            set { nomemarca = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
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
        public int CadastrarMarca()
        {
            string query = "insert into Marca values (getdate(),'" + NomeMarca + "','" + observacao + "', 1)";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);

        }
        public bool ValidaMarca(string marca)
        {
            classConexao cConexao = new classConexao();
            string query = "Declare @i bit set @i = 0";
            query += "if exists (select NomeMarca from Marca where NomeMarca = '" + marca + "')";
            query += "set @i = 0 else set @i = 1";
            query += "select @i[resp]";

            DataTable dt = cConexao.RetornaDataTable(query);
            int resp = Convert.ToInt32(dt.Rows[0][0]);
            if (resp == 0) //Caso já existir alguma categoria com esse nome retorne 0
                return true;
            else
                return false;// se não 1


        }

        public DataTable BuscarMarca()
        {
            string query = "select CodigoMarca, NomeMarca from Marca where Status = 1 order by NomeMarca";

            classConexao obj = new classConexao();
            return obj.RetornaDataTable(query);
        }
    }

}
