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
    public partial class frm_report_dsSachGanHet : Form
    {
        public frm_report_dsSachGanHet()
        {
            InitializeComponent();
        }

        public dts_sachsaphet DataSource { get; set; }

        private void frm_report_dsSachGanHet_Load(object sender, EventArgs e)
        {
            rpt_dsSachSapHet Freport = new rpt_dsSachSapHet();

            Freport.SetDataSource(DataSource);

            report.ReportSource = Freport;
        }
    }
}
