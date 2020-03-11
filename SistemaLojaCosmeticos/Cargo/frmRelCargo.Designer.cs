namespace SistemaLojaCosmeticos
{
    partial class frmRelCargo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbtv = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classCargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classCargoBindingSource
            // 
            this.classCargoBindingSource.DataSource = typeof(SistemaLojaCosmeticos.classCargo);
            this.classCargoBindingSource.CurrentChanged += new System.EventHandler(this.classCargoBindingSource_CurrentChanged);
            // 
            // rbtv
            // 
            this.rbtv.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classCargoBindingSource;
            this.rbtv.LocalReport.DataSources.Add(reportDataSource1);
            this.rbtv.LocalReport.ReportEmbeddedResource = "SistemaLojaCosmeticos.rptCargo.rdlc";
            this.rbtv.Location = new System.Drawing.Point(20, 60);
            this.rbtv.Name = "rbtv";
            this.rbtv.Size = new System.Drawing.Size(593, 300);
            this.rbtv.TabIndex = 0;
            this.rbtv.Load += new System.EventHandler(this.rbtv_Load);
            // 
            // frmRelCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 380);
            this.Controls.Add(this.rbtv);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(633, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(633, 380);
            this.Name = "frmRelCargo";
            this.Text = "Relatório de Cargo";
            this.Load += new System.EventHandler(this.frmRelCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classCargoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rbtv;
        private System.Windows.Forms.BindingSource classCargoBindingSource;
    }
}