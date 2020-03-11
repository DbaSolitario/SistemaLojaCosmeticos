using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLojaCosmeticos
{
    class classItensVenda
    {
        //VARIÁVEIS
        private int codigoitemvenda;
        private decimal preco;
        private int qtde;
        private int codigovenda;
        private int codigoproduto;

        public string erro;

        //CONSTRUTOR
        public classItensVenda()
        {
            codigoitemvenda = 0;
            preco = 0;
            qtde = 0;
            codigovenda = 0;
            codigoproduto = 0;
 
            erro = null;
        }

        //PROPRIEDADES
        public int CodigoItemVenda
        {
            get { return codigoitemvenda; }
            set { codigoitemvenda = value; }
        }

         public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public int CodigoVenda
        {
            get { return codigovenda; }
            set { codigovenda = value; }
        }

        public int CodigoProduto
        {
            get { return codigoproduto; }
            set { codigoproduto = value; }
        }

        public string Erro
        {
            get { return erro; }
        }
        
        public bool CadastraItemVenda()
        {
            string query = "insert into ItensVenda values ("+preco.ToString().Replace(",",".") +", "+ qtde +","+ codigovenda +", "+ codigoproduto +")";

            classConexao obj = new classConexao();

            int aux = obj.ExecutaQuery(query);

            if (aux != 0)
                return true;
            else
            {
                erro = obj.ComandoErro;
                return false;
            }
        }
    }
    
}
