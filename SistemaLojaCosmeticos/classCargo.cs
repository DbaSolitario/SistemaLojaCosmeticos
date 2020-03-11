using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaCosmeticos
{
    class classCargo
    {
        private int codigocargo;
        private DateTime datacadstro;
        private string nomecargo;
        private string observacao;
        private int status;
        private string erro;

        public classCargo()
        {
            codigocargo = 0;
            datacadstro = DateTime.Now;
            nomecargo = null;
            observacao = null;
            status = 0;
            erro = null;

        }

        public int CodigoCargo
        {
            get { return codigocargo; }
            set { codigocargo = value; }
        }

        public DateTime DataCadastro
        {
            get{ return datacadstro; }
            set { datacadstro = value; }
        }

        public string NomeCargo
        {
            get { return nomecargo; }
            set { nomecargo = value; }
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
        public int CadastrarCargo()
        {
            string query = "insert into Cargo values (getdate(),'" + NomeCargo +"','" + Observacao + "', 1)";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);

        }

        public bool ValidaCargo(string cargo)
        {
            classConexao cConexao = new classConexao();
            string query = "Declare @i bit set @i = 0";
            query += "if exists (select NomeCargo from Cargo where NomeCargo = '" + cargo + "')";
            query += "set @i = 0 else set @i = 1";
            query += "select @i[resp]";

            DataTable dt = cConexao.RetornaDataTable(query);
            int resp = Convert.ToInt32(dt.Rows[0][0]);
            if (resp == 0) //Caso já existir alguma categoria com esse nome retorne 0
                return true;
            else
                return false;// se não 1


        }
    }
}
