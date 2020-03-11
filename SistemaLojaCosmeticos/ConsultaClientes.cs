using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLojaCosmeticos
{
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            cbTipoPesquisa.Items.Add("Nome");
            cbTipoPesquisa.Items.Add("CPF");
            cbTipoPesquisa.Items.Add("RG");
            cbTipoPesquisa.Items.Add("CEP");
            cbTipoPesquisa.Items.Add("Cidade");
            cbTipoPesquisa.Items.Add("Estado");
            cbTipoPesquisa.SelectedIndex = 0;

        }
    }
}
