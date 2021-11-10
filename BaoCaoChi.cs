using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyNhaSach.DataBase;

namespace QuanLyNhaSach
{
    public partial class BaoCaoChi : Form
    {
        Model1 DbContext;
        public BaoCaoChi()
        {
            InitializeComponent();
            DbContext = new Model1();
        }

        private void BaoCaoChi_Load(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", DbContext.PhieuNhaps.ToList());
            this.reportViewer1.LocalReport.DataSources.Clear(); //clear
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport(); //ch y report
            this.reportViewer1.RefreshReport();
        }
    }
}
