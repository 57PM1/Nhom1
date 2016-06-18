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
    public partial class frm_report_ThongKeTienPhieuMuon : Form
    {
        public frm_report_ThongKeTienPhieuMuon()
        {
            InitializeComponent();
        }

        public dts_ThongKeTienPhat Data_Source { get; set; }
        public string Tong_Tien { get; set; }

        private void frm_report_ThongKeTienPhieuMuon_Load(object sender, EventArgs e)
        {
            rpt_ThongKeTienPhat Creport = new rpt_ThongKeTienPhat();

            Creport.SetDataSource(Data_Source);

            Creport.SetParameterValue("TongTien", Tong_Tien);

            report.ReportSource = Creport;
        }
    }
}
