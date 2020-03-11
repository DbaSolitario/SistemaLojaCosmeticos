using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace SistemaLojaCosmeticos
{
    class classProduto
    {
        private int codigoproduto;
        private DateTime datacadastro;
        private string nomeproduto;
        private int qtdeestoque;
        private decimal precovenda;
        private string observacao;
        private int status;
        private int codigocategoria;
        private int codigomarca;
        private string erro;

        public classProduto()
        {
            codigoproduto = 0;
            datacadastro = DateTime.Now;
            nomeproduto = null;
            qtdeestoque = 0;
            precovenda = 0;
            observacao = null;
            status = 0;
            erro = null;

        }

        public int CodigoProduto
        {
            get { return codigoproduto; }
            set { codigoproduto = value; }
        }
        public DateTime DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value;  }
        }
        public string NomeProduto
        {
            get { return nomeproduto; }
            set { nomeproduto = value; }
        }
              
        public int QtdeEstoque
        {
            get { return qtdeestoque; }
            set { qtdeestoque = value; }
        }

        public decimal PrecoVenda
        {
            get { return precovenda; }
            set { precovenda = value; }
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

        public int CodigoCategoria
        {
            get { return codigocategoria; }
            set { codigocategoria = value; }
        }
        public int CodigoMarca
        {
            get { return codigomarca; }
            set { codigomarca = value; }
        }
        public string Erro
        {
            get { return erro; }
        }

        public bool ValidaProduto(string produto)
        {
            classConexao cConexao = new classConexao();
            string query = "Declare @i bit set @i = 0";
            query += "if exists (select NomeProduto from Produto where NomeProduto = '" + produto + "')";
            query += "set @i = 0 else set @i = 1";
            query += "select @i[resp]";

            DataTable dt = cConexao.RetornaDataTable(query);
            int resp = Convert.ToInt32(dt.Rows[0][0]);
            if (resp == 0) //Caso já existir alguma categoria com esse nome retorne 0
                return true;
            else
                return false;// se não 1


        }

        public int CadastrarProduto()
        {
            string query = "insert into Produto values (getdate(),'" + NomeProduto + "','" + QtdeEstoque + "','" + PrecoVenda.ToString().Replace(",", ".") + "', '" + Observacao + "',1,'" + CodigoCategoria + "','" + CodigoMarca + "')";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);

        }
        //Buscar produto

        public DataTable BuscarProdutoDescricaoInicial()
        {
            string query = "select Produto.CodigoProduto [Código], Produto.NomeProduto [Produto], Produto.QtdeEstoque [Estoque], PrecoVenda[Preço (R$)], Categoria.NomeCategoria[Categoria], Marca.NomeMarca [Marca], Produto.Status [Ativo] From Produto join Marca on Produto.CodigoMarca = Marca.CodigoMarca join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.NomeProduto like '"+nomeproduto+"%' and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
            

        }

        public DataTable BuscarProdutoDescricaoContem()
        {
            string query = "select Produto.CodigoProduto [Código], Produto.NomeProduto [Produto], Produto.QtdeEstoque [Estoque], PrecoVenda[Preço (R$)], Categoria.NomeCategoria[Categoria], Marca.NomeMarca [Marca], Produto.Status [Ativo] From Produto join Marca on Produto.CodigoMarca = Marca.CodigoMarca join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.NomeProduto like '%" + nomeproduto + "%' and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarProdutoMarca()
        {
            string query = "select Produto.CodigoProduto [Código], Produto.NomeProduto [Produto], Produto.QtdeEstoque [Estoque], PrecoVenda[Preço (R$)], Categoria.NomeCategoria[Categoria], Marca.NomeMarca [Marca], Produto.Status [Ativo] From Produto join Marca on Produto.CodigoMarca = Marca.CodigoMarca join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.CodigoMarca = "+codigomarca+" and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }
        public DataTable BuscarProdutoCategoria()
        {
            string query = "select Produto.CodigoProduto [Código], Produto.NomeProduto [Produto], Produto.QtdeEstoque [Estoque], PrecoVenda[Preço (R$)], Categoria.NomeCategoria[Categoria], Marca.NomeMarca [Marca], Produto.Status [Ativo] From Produto join Marca on Produto.CodigoMarca = Marca.CodigoMarca join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.CodigoCategoria = " + codigocategoria + " and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarProdutoStatus()
        {
            string query = "select Produto.CodigoProduto [Código], Produto.NomeProduto [Produto], Produto.QtdeEstoque [Estoque], PrecoVenda[Preço (R$)], Categoria.NomeCategoria[Categoria], Marca.NomeMarca [Marca], Produto.Status [Ativo] From Produto join Marca on Produto.CodigoMarca = Marca.CodigoMarca join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.Status = " + status + " order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }
        public DataTable BuscarProdutoPreco(decimal precoi, decimal precof)
        {
            string query = "select Produto.CodigoProduto [Código], Produto.NomeProduto [Produto], Produto.QtdeEstoque [Estoque], PrecoVenda[Preço (R$)], Categoria.NomeCategoria[Categoria], Marca.NomeMarca [Marca], Produto.Status [Ativo] From Produto join Marca on Produto.CodigoMarca = Marca.CodigoMarca join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.PrecoVenda between'"+precoi.ToString().Replace(",", ".")+"' and '"+precof.ToString().Replace(",", ".")+"' and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarProdutoMaior(decimal precoM)
        {
            string query = "select Produto.CodigoProduto [Código], Produto.NomeProduto [Produto], Produto.QtdeEstoque [Estoque], PrecoVenda[Preço (R$)], Categoria.NomeCategoria[Categoria], Marca.NomeMarca [Marca], Produto.Status [Ativo] From Produto join Marca on Produto.CodigoMarca = Marca.CodigoMarca join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.PrecoVenda >'" + precoM.ToString().Replace(",", ".") + "' and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarProdutoEstoqueMaior(decimal EstoqueMaior)
        {
            string query = "select Produto.CodigoProduto [Código], Produto.NomeProduto [Produto], Produto.QtdeEstoque [Estoque], PrecoVenda[Preço (R$)], Categoria.NomeCategoria[Categoria], Marca.NomeMarca [Marca], Produto.Status [Ativo] From Produto join Marca on Produto.CodigoMarca = Marca.CodigoMarca join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.QtdeEstoque >'" + EstoqueMaior.ToString().Replace(",", ".") + "' and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }

        public DataTable BuscarProdutoEstoqueMenor(decimal EstoqueMenor)
        {
            string query = "select Produto.CodigoProduto [Código], Produto.NomeProduto [Produto], Produto.QtdeEstoque [Estoque], PrecoVenda[Preço (R$)], Categoria.NomeCategoria[Categoria], Marca.NomeMarca [Marca], Produto.Status [Ativo] From Produto join Marca on Produto.CodigoMarca = Marca.CodigoMarca join Categoria on Categoria.CodigoCategoria = Produto.CodigoCategoria where Produto.QtdeEstoque <'" + EstoqueMenor.ToString().Replace(",", ".") + "' and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);


        }
        //METODO PARA BUSCAR TODOS OS DADOS DO BANCO QUANDO O USUARIO ESCOLHER O PRODUTO NA GRID E CLICAR NO BOTAO EDITAR
        public bool RetornaProduto (int cod)

        {
            string query = "select * from Produto where CodigoProduto = " + cod;
            classConexao obj = new classConexao();
            DataTable dt = obj.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                codigoproduto = Convert.ToInt32(dt.Rows[0]["CodigoProduto"]);
                datacadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                nomeproduto = Convert.ToString(dt.Rows[0]["NomeProduto"]);
                qtdeestoque = Convert.ToInt32(dt.Rows[0]["QtdeEstoque"]);
                precovenda = Convert.ToDecimal(dt.Rows[0]["PrecoVenda"]);
                observacao = Convert.ToString(dt.Rows[0]["Observacao"]);
                status = Convert.ToInt32(dt.Rows[0]["Status"]);
                codigomarca = Convert.ToInt32(dt.Rows[0]["CodigoMarca"]);
             codigocategoria = Convert.ToInt32(dt.Rows[0]["CodigoCategoria"]);

                return true;
            }
            else
            {
                return false;
            }

        }
        //ATUALIZAR PRODUTO
        public bool AtualizarProduto()
        {
            string query = "update Produto set NomeProduto = '" + nomeproduto + "', QtdeEstoque = '" + qtdeestoque + "', PrecoVenda = '" + precovenda.ToString().Replace(",", ".") + "', Observacao = '" + observacao + "', Status = '" + status + "', CodigoCategoria = '" + codigocategoria + "',CodigoMarca = '" + codigomarca + "' where CodigoProduto = " + codigoproduto;
            classConexao obj = new classConexao();

            int aux = obj.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }

        //METODO PARA EXCLUIR PRODUTO
        public bool ExcluirProduto()
        {
            string query = "delete Produto where CodigoProduto = " + codigoproduto;
            classConexao obj = new classConexao();
            int aux = obj.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }


        // metodos de Rel
        public DataTable RelProdQtdeEstoque(int qtdeinicial,int qtdefinal)
        {
            string query = " select Produto.NomeProduto, Produto.DataCadastro, Produto.QtdeEstoque, Produto.PrecoVenda, Categoria.NomeCategoria[CodigoCategoria], Marca.NomeMarca[CodigoMarca], produto.Status  from Produto left join Categoria on Produto.CodigoCategoria = Produto.CodigoCategoria  left join Marca  on Produto.CodigoMarca = Marca.CodigoMarca  where QtdeEstoque between " + qtdeinicial + " and " + qtdefinal + " and Produto.Status = 1 order by NomeProduto ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        public DataTable RelProdutoStatus(int status)
        {
            string query = " select Produto.NomeProduto,Produto.DataCadastro,Produto.QtdeEstoque,Produto.PrecoVenda,Categoria.NomeCategoria[CodigoCategoria],Marca.NomeMarca[CodigoMarca],produto.Status  from Produto left join Categoria on Produto.CodigoCategoria = Produto.CodigoCategoria  left join Marca  on Produto.CodigoMarca = Marca.CodigoMarca where Produto.Status = " + status + " order by NomeProduto";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        public DataTable RelProdutoPreco(decimal precoi, decimal precof)
        {

            string query = " select Produto.NomeProduto,Produto.DataCadastro,Produto.QtdeEstoque,Produto.PrecoVenda,Categoria.NomeCategoria[CodigoCategoria],Marca.NomeMarca[CodigoMarca],produto.Status  from Produto left join Categoria on Produto.CodigoCategoria = Produto.CodigoCategoria  left join Marca  on Produto.CodigoMarca = Marca.CodigoMarca where Produto.PrecoVenda between'"+precoi.ToString().Replace(",", ".")+"' and '"+precof.ToString().Replace(",", ".")+"' and Produto.Status = 1 order by Produto.NomeProduto";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        public DataTable RelCategoria(int categoria)
        {

            string query = "select Produto.NomeProduto,Produto.DataCadastro,Produto.QtdeEstoque,Produto.PrecoVenda,Categoria.NomeCategoria[CodigoCategoria],Marca.NomeMarca[CodigoMarca],produto.Status  from Produto left join Categoria on Produto.CodigoCategoria = Produto.CodigoCategoria  left join Marca  on Produto.CodigoMarca = Marca.CodigoMarca where Produto.CodigoCategoria = " + categoria + " and Produto.Status = 1 order by Produto.NomeProduto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        public DataTable RelMarca(int marca)
        {

            string query = "select Produto.NomeProduto, Produto.DataCadastro, Produto.QtdeEstoque,Produto.PrecoVenda,Categoria.NomeCategoria[CodigoCategoria],Marca.NomeMarca[CodigoMarca],produto.Status  from Produto left join Categoria on Produto.CodigoCategoria = Produto.CodigoCategoria  left join Marca  on Produto.CodigoMarca = Marca.CodigoMarca where Produto.CodigoMarca = " +marca + " and Produto.Status = 1 order by Produto.NomeProduto";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        public DataTable RelProdutoDataCadastro(DateTime dinicio, DateTime dfinal)
        {
            string query = "select Produto.NomeProduto, Produto.DataCadastro, Produto.QtdeEstoque,Produto.PrecoVenda,Categoria.NomeCategoria[CodigoCategoria],Marca.NomeMarca[CodigoMarca],produto.Status  from Produto left join Categoria on Produto.CodigoCategoria = Produto.CodigoCategoria  left join Marca  on Produto.CodigoMarca = Marca.CodigoMarca where Produto.DataCadastro between convert (date,'" + dinicio + "',103) and convert (date,'" + dfinal + "',103) and Status = 1 order by Produto.NomeProduto";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        // Pesquisar Porduto por Nome ;
        public DataTable BuscarProdutoNome (string produto)
        {
            string query = "select CodigoProduto[Código],NomeProduto[Nome],QtdeEstoque[Quantidade],PrecoVenda[Preço] from Produto where Status = 1 and NomeProduto like '%" + produto+ "%' and QtdeEstoque > 0 order by NomeProduto";
            classConexao obj = new classConexao();
            return obj.RetornaDataTable(query);

        }


        public bool BuscarProdutoId (int cod)
        {
            string query = "select NomeProduto, PrecoVenda, QtdeEstoque from Produto where CodigoProduto = "+cod;
            classConexao obj = new classConexao();
            DataTable dt = obj.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                NomeProduto = (string)dt.Rows[0]["NomeProduto"];
                PrecoVenda = (decimal)dt.Rows[0]["PrecoVenda"];
                QtdeEstoque = (int)dt.Rows[0]["QtdeEstoque"];
                return true;
            }
            else
                return false;
        }

         public string BuscarNomeProd(int cod)
        {
            string query = "select NomeProduto[Produto] from Produto where CodigoProduto ="+ cod;
            classConexao obj = new classConexao();
            DataTable dt = obj.RetornaDataTable(query);
            if (dt.Rows.Count>0)
            {
                NomeProduto = dt.Rows[0]["Produto"].ToString();

            }
            return NomeProduto;
        }


        public bool AtualizarQtde(int qtde, int cod)
        {
            string query = "update Produto Set QtdeEstoque =" + qtde + "where CodigoProduto =" + cod;
            classConexao obj = new classConexao();
            int aux = obj.ExecutaQuery(query);
            if (aux != 0)
                return true;
            else
                return false;
        }
   }
}
