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

        public bool AtualizarProduto()
        {
            string query = "update Produto ser NomeProduto = '" + nomeproduto + "', QtdeEstoque = " + qtdeestoque + ", PrecoVenda = '" + precovenda.ToString().Replace(",", ".") + "', Observacao = '" + observacao + "', Status = " + status + ", CodigoCategoria = " + codigocategoria + ",CodigoMarca = " + codigomarca + " where CodigoProduto = " + codigoproduto;
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

    }
}
