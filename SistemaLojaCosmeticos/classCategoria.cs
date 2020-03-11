using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SistemaLojaCosmeticos
{
    class classCategoria
    {

        //Variáveis
        private int codigocategoria;
        private DateTime datacadastro;
        private string nomecategoria;
        private string observacao;
        private int status;
        private string erro;


        //Construtor - Inicia as variaveis 
        public classCategoria() // Nome igual da Classe 
        {

            codigocategoria = 0;
            datacadastro = DateTime.Now;
            nomecategoria = null;
            observacao = null;
            status = 0;
            erro = null;

        }


        //Propriedades - Ler e gravar as informações do BD
        //Mesmo nome dos campos do BD para as propriedades
        public int CodigoCategoria
        {
            get { return codigocategoria; } //Leitura
            set { codigocategoria = value; } //Gravar os dados

        }

        public DateTime DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        public string NomeCategoria
        {
            get { return nomecategoria; }
            set { nomecategoria = value; }

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

        //MÉTODO PARA CADASTRAR CATEGORIA   
         public int CadastrarCategoria()
        {
            string query = "insert into Categoria values (getdate(),'"+ nomecategoria +"','"+ observacao +"', 1)";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);

        }
        public bool ValidaCategoria(string categoria)
        {
            classConexao cConexao = new classConexao();
            string query = "Declare @i bit set @i = 0";
            query += "if exists (select NomeCategoria from Categoria where NomeCategoria = '" + categoria + "')";
            query += "set @i = 0 else set @i = 1";
            query += "select @i[resp]";

            DataTable dt = cConexao.RetornaDataTable(query);
            int resp = Convert.ToInt32(dt.Rows[0][0]);
            if (resp == 0) //Caso já existir alguma categoria com esse nome retorne 0
                return true;
            else
                return false;// se não 1


        }

        public DataTable BuscarCategoria()
        {
            string query = "select CodigoCategoria, NomeCategoria from Categoria where Status = 1 order by NomeCategoria";

            classConexao obj = new classConexao();
            return obj.RetornaDataTable(query);
        }
    }

}
