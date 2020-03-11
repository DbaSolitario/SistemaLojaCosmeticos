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
    public partial class frmRelCategoria : MetroFramework.Forms.MetroForm
    {
        public frmRelCategoria()
        {
            InitializeComponent();
        }

        private void frmRelCategoria_Load(object sender, EventArgs e)
        {
            classCategoria obj = new classCategoria();
        classCategoriaBindingSource.DataSource = obj.RelCategoria();
            this.reportViewer1.RefreshReport();
        }
    }
}
