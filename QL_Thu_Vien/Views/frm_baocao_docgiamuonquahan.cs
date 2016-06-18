using DoAnCNPM.Controllers;
using DoAnCNPM.Models;
using DoAnCNPM.Report;
using DoAnCNPM.Shareds;
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
    public partial class frm_baocao_docgiamuonquahan : Form
    {
        public frm_baocao_docgiamuonquahan()
        {
            InitializeComponent();
        }

        private docgia_ctrl docgia_ctrl = new docgia_ctrl();
        //update data for dtgv
        private void load_data()
        {
            var dt = docgia_ctrl.select_expired_docgia();
            switch (dt.errcode)
            {
                case Models.ErrorCode.NaN:
                    dtgv.DataSource = dt.data;
                    break;
                case Models.ErrorCode.sucess:
                    var data = dt.data;
                    dtgv.DataSource = data;
                    list = data;
                    Utils.chang_title_datagridViewCell(dtgv, new List<string> { "Mã ĐG", "Tên ĐG", "Ngày sinh", "Giới tính", "Lớp", "Địa chỉ", "Email" });
                    break;
                case Models.ErrorCode.fail:
                    if (Utils.switch_false())
                    {
                        MessageBox.Show(dt.errInfor);
                    }
                    break;
                default:
                    break;
            }
        }

        private void frm_timkiem_docgia_Load(object sender, EventArgs e)
        {

            load_data();

            List<how_to_search> dt_source = new List<how_to_search>();
            dt_source.Add(new how_to_search("Họ tên", "tendg"));
            dt_source.Add(new how_to_search("Lớp", "lop"));
            dt_source.Add(new how_to_search("email", "email"));

            cbx_option_search.DataSource = dt_source;
            cbx_option_search.DisplayMember = "value";
            cbx_option_search.ValueMember = "key";
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            var select_cbx = cbx_option_search.SelectedValue.ToString();
            var temp = docgia_ctrl.select_hethan_fields(txt_timkiem.Text, select_cbx);
            switch (temp.errcode)
            {
                case ErrorCode.NaN:
                    dtgv.DataSource = temp.data;
                    break;
                case ErrorCode.sucess:
                    var data = temp.data;
                    dtgv.DataSource = data;
                    list = data;
                    Utils.chang_title_datagridViewCell(dtgv, new List<string> { "Mã ĐG", "Tên ĐG", "Ngày sinh", "Giới tính", "Lớp", "Địa chỉ", "Email" });

                    break;
                case ErrorCode.fail:
                    dtgv.DataSource = temp.data;
                    if (Utils.switch_false())
                    {
                        MessageBox.Show(temp.errInfor);
                    }
                    break;
                default:
                    break;
            }
        }

        private List<view_quahan_ett> list = new List<view_quahan_ett>();

        private void btn_in_Click(object sender, EventArgs e)
        {
            frm_report_dsDocGiaMuonQuaHan frm_report = new frm_report_dsDocGiaMuonQuaHan();

            dts_DocGiaQuaHan rpt_source = new dts_DocGiaQuaHan();

            foreach (var item in list)
            {
                DataRow row = rpt_source.DocGiaQuaHan.Rows.Add();

                row[0] = item.madg;
                row[1] = item.tendg;
                row[2] = item.ngaysinh;
                row[3] = item.gioitinh;
                row[4] = item.lop;
                row[5] = item.diachi;
                row[6] = item.email;
            }

            frm_report.DataSource = rpt_source;

            frm_report.ShowDialog();
        }
    }
}
