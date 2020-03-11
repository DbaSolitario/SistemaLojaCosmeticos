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

        public DataTable BuscarMarcaStatus()
        {
            string query = "select CodigoMarca[Código] , NomeMarca [Nome] , Status from Marca where status = "+ status +" order by NomeMarca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarMarcaInicio()
        {
            string query = "select CodigoMarca[Código] , NomeMarca [Nome] , Status from Marca where NomeMarca like '" + nomemarca + "%' and Status = 1 order by NomeMarca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarMarcaContem()
        {
            string query = "select CodigoMarca[Código] , NomeMarca [Nome] , Status from Marca where NomeMarca like '%" + nomemarca + "%' and Status = 1 order by NomeMarca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarMarcaCod()
        {
            string query = "select CodigoMarca[Código] , NomeMarca [Nome] , Status from Marca where codigomarca = " + codigomarca + " order by NomeMarca";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }
        //METODO PARA BUSCAR TODOS OS DADOS DO BANCO QUANDO O USUARIO ESCOLHER O PRODUTO NA GRID E CLICAR NO BOTAO EDITAR
        public bool RetornaMarca(int cod)

        {
            string query = "select * from Marca where CodigoMarca = " + cod;
            classConexao obj = new classConexao();
            DataTable dt = obj.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                codigomarca = Convert.ToInt32(dt.Rows[0]["CodigoMarca"]);
                datacadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                nomemarca = Convert.ToString(dt.Rows[0]["NomeMarca"]);
                //qtdeestoque = Convert.ToInt32(dt.Rows[0]["QtdeEstoque"]);
                //precovenda = Convert.ToDecimal(dt.Rows[0]["PrecoVenda"]);
                observacao = Convert.ToString(dt.Rows[0]["Observacao"]);
                status = Convert.ToInt32(dt.Rows[0]["Status"]);
                codigomarca = Convert.ToInt32(dt.Rows[0]["CodigoMarca"]);
               // codigocategoria = Convert.ToInt32(dt.Rows[0]["CodigoCategoria"]);

                return true;
            }
            else
            {
                return false;
            }


      }
        //ATUALIZAR Marca
        public bool AtualizarMarca()
        {
            string query = "update Marca set NomeMarca = '" + nomemarca + "', Observacao = '" + observacao + "', Status = '" + status + "' where CodigoMarca = " + codigomarca;
            classConexao obj = new classConexao();

            int aux = obj.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        //METODO PARA EXCLUIR PRODUTO
        public bool ExcluirMarca()
        {
            string query = "delete Marca where CodigoMarca = " + codigomarca;
            classConexao obj = new classConexao();
            int aux = obj.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }



        public DataTable RelMarca()
        {
            string query = "select CodigoMarca,NomeMarca,DataCadastro,Status from Marca WHERE Status = 1 order by NomeMarca";
            classConexao obj = new classConexao();
            return obj.RetornaDataTable(query);
        }

    }

}
