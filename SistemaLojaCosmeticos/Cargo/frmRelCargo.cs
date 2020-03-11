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
    public partial class frmRelCargo : MetroFramework.Forms.MetroForm
    {
        public frmRelCargo()
        {
            InitializeComponent();
        }

        private void frmRelCargo_Load(object sender, EventArgs e)
        {
                                  
            classCargo obj = new classCargo();
            classCargoBindingSource.DataSource = obj.RelCargo();
            
           
            
            this.rbtv.RefreshReport();
        }

        private void rbtv_Load(object sender, EventArgs e)
        {

        }

        private void classCargoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }
    }
}
