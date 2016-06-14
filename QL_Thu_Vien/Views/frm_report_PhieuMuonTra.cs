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
    public partial class frm_report_PhieuMuonTra : Form
    {
        public string SoPM { get; set; }

        public string NgayMuon { get; set; }

        public string DocGia { get; set; }

        public string NhanVien { get; set; }

        public string NgayTra { get; set; }

        public string GhiChu { get; set; }

        public dts_PhieuMuonTra List_ChiTietPhieu { get; set; } 


        public frm_report_PhieuMuonTra()
        {
            InitializeComponent();
        }

        private void frm_report_PhieuMuonTra_Load(object sender, EventArgs e)
        {
            rpt_PhieuMuonTra freport = new rpt_PhieuMuonTra();

            freport.SetDataSource(List_ChiTietPhieu);


            freport.SetParameterValue("SoPM", SoPM);
            freport.SetParameterValue("NgayMuon", NgayMuon);
            freport.SetParameterValue("NgayTra", NgayTra);
            freport.SetParameterValue("DocGia", DocGia);
            freport.SetParameterValue("NhanVien", NhanVien);
            freport.SetParameterValue("GhiChu", GhiChu);


            report.ReportSource = freport;
        }
    }
}
