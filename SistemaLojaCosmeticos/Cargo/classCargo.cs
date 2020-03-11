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

        public DataTable BuscarCargo()
        {
            string query = "select CodigoCargo, NomeCargo from Cargo where Status = 1 order by NomeCargo";

            classConexao obj = new classConexao();
            return obj.RetornaDataTable(query);
        }

        public DataTable BuscarCargoStatus()
        {
            string query = " select CodigoCargo[Codigo], NomeCargo[Nome], Status from Cargo where status = " + status + " order by NomeCargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarMarcaCargo()
        {
            string query = "select CodigoCargo[Código] , NomeCargo [Nome] , Status from Cargo where status = " + status + " order by NomeCargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarCargoInicio()
        {
            string query = "select CodigoCargo[Código] , NomeCargo [Nome] , Status from Cargo where NomeCargo like '" + nomecargo + "%' and Status = 1 order by NomeCargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarCargoContem()
        {
            string query = "select CodigoCargo[Código] , NomeCargo [Nome] , Status from Cargo where NomeCargo like '%" + nomecargo + "%' and Status = 1 order by NomeCargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarMarcaCod()
        {
            string query = "select CodigoCargo[Código] , NomeCargo [Nome] , Status from Cargo where codigocargo = " + codigocargo + " order by NomeCargo";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        //METODO PARA BUSCAR TODOS OS DADOS DO BANCO QUANDO O USUARIO ESCOLHER O PRODUTO NA GRID E CLICAR NO BOTAO EDITAR
        public bool RetornaCargo(int cod)

        {
            string query = "select * from Cargo where CodigoCargo = " + cod;
            classConexao obj = new classConexao();
            DataTable dt = obj.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                codigocargo = Convert.ToInt32(dt.Rows[0]["CodigoCargo"]);
                DataCadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                nomecargo = Convert.ToString(dt.Rows[0]["NomeCargo"]);
                //qtdeestoque = Convert.ToInt32(dt.Rows[0]["QtdeEstoque"]);
                //precovenda = Convert.ToDecimal(dt.Rows[0]["PrecoVenda"]);
                observacao = Convert.ToString(dt.Rows[0]["Observacao"]);
                status = Convert.ToInt32(dt.Rows[0]["Status"]);
                //codigomarca = Convert.ToInt32(dt.Rows[0]["CodigoMarca"]);
                // codigocategoria = Convert.ToInt32(dt.Rows[0]["CodigoCategoria"]);

                return true;
            }
            else
            {
                return false;
            }


        }

        //ATUALIZAR Marca
        public bool AtualizarCargo()
        {
            string query = "update Cargo set NomeCargo = '" + nomecargo + "', Observacao = '" + observacao + "', Status = '" + status + "' where CodigoCargo = " + codigocargo;
            classConexao obj = new classConexao();

            int aux = obj.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        //METODO PARA EXCLUIR PRODUTO
        public bool ExcluirCargo()
        {
            string query = "delete Cargo where CodigoCargo = " + codigocargo;
            classConexao obj = new classConexao();
            int aux = obj.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }


        public DataTable RelCargo()
        {
            string query = "select CodigoCargo,NomeCargo,DataCadastro,Status from Cargo WHERE Status = 1 order by NomeCargo";
            classConexao obj = new classConexao();
            
                return obj.RetornaDataTable(query);
        }

    }
}
