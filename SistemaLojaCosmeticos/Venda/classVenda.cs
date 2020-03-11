using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLojaCosmeticos
{
    class classVenda
    {
        //VARIÁVEIS
        private int codigovenda;
        private DateTime datavenda;
        private decimal valortotal;
        private int qtdeitens;
        private decimal desconto;
        private string observacao;
        private string formapagamento;
        private int status;
        private int codigocliente;
        private int codigofuncionario;

        public string erro;

        //CONSTRUTOR
        public classVenda()
        {
            codigovenda = 0;
            datavenda = DateTime.Now;
            valortotal = 0;
            qtdeitens = 0;
            desconto = 0;
            observacao = null;
            formapagamento = null;
            status = 0;
            codigocliente = 0;
            codigofuncionario = 0;

            erro = null;
        }

        //PROPRIEDADES
        public int CodigoVenda
        {
            get { return codigovenda; }
            set { codigovenda = value; }
        }

        public DateTime DataVenda
        {
            get { return datavenda; }
            set { datavenda = value; }
        }

        public decimal ValorTotal
        {
            get { return valortotal; }
            set { valortotal = value; }
        }

        public int QtdeItens
        {
            get { return qtdeitens; }
            set { qtdeitens = value; }
        }

        public decimal Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        public string FormaPagamento
        {
            get { return formapagamento; }
            set { formapagamento = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public int CodigoCliente
        {
            get { return codigocliente; }
            set { codigocliente = value; }
        }

        public int CodigoFuncionario
        {
            get { return codigofuncionario; }
            set { codigofuncionario = value; }
        }

        public string Erro
        {
            get { return erro; }
        }


        // MÉTODO PARA CADASTRAR VENDA USANDO EXECUTAQUERYID (EXECUTE SCALAR)
        public bool CadastraVenda()
        {
            string query = "insert into Vendas values (getdate(), '" + valortotal.ToString().Replace(",", ".") + "', " + qtdeitens + ",  '" + desconto.ToString().Replace(",", ".") + "', '" + observacao + "', '" + formapagamento + "', 1, " + codigocliente + ", " + codigofuncionario + ") select SCOPE_IDENTITY()";

            classConexao obj = new classConexao();

            codigovenda = 0;
            codigovenda = obj.ExecutaQueryID(query);

            if (codigovenda != 0)
                return true;
            else
            {
                erro = obj.ComandoErro;
                return false;
            }
        }
        
    }
}
