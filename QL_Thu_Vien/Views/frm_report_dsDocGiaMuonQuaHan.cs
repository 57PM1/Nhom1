using DoAnCNPM.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCNPM.Views
{
    public partial class frm_report_dsDocGiaMuonQuaHan : Form
    {
        public frm_report_dsDocGiaMuonQuaHan()
        {
            InitializeComponent();
        }

        public dts_DocGiaQuaHan DataSource { get; set; }

        private void frm_report_dsDocGiaMuonQuaHan_Load(object sender, EventArgs e)
        {
            rpt_dsDocGiaQuaHan Freport = new rpt_dsDocGiaQuaHan();

            Freport.SetDataSource(DataSource);

            report.ReportSource = Freport;
        }
    }
}
