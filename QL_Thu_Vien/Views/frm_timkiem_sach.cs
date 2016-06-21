using DoAnCNPM.Controllers;
using DoAnCNPM.Models;
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
    public partial class frm_timkiem_sach : Form
    {
        public frm_timkiem_sach()
        {
            InitializeComponent();
        }
        private sach_ctrl sach_ctrl = new sach_ctrl();
        private void load_data()
        {
            var dt = sach_ctrl.select_all_sachview();
            switch (dt.errcode)
            {
                case Models.ErrorCode.NaN:
                    dtgv.DataSource = dt.data;
                    break;
                case Models.ErrorCode.sucess:
                    dtgv.DataSource = dt.data;
                    Utils.chang_title_datagridViewCell(dtgv, new List<string> { "Mã sách", "Tên sách", "Nhà XB", "Lĩnh Vực", "Số trang", "Số lượng hiện tại", "Số lượng ban đầu", "Ngày nhập" });
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
        private void frm_capnhat_sach_Load(object sender, EventArgs e)
        {
           
            load_data();

            List<how_to_search> dt_source = new List<how_to_search>();
            dt_source.Add(new how_to_search("Tên sách", "tensach"));
            dt_source.Add(new how_to_search("Tác giả", "tacgia"));
            dt_source.Add(new how_to_search("Lĩnh vực", "linhvuc"));
            dt_source.Add(new how_to_search("Nhà xuất bản", "nxb"));

            cbx_option_search.DataSource = dt_source;
            cbx_option_search.DisplayMember = "value";
            cbx_option_search.ValueMember = "key";

            tacgia_ctrl tacgia = new tacgia_ctrl();
            linhvuc_ctrl linhvuc = new linhvuc_ctrl();
            nhaxuatban_ctrl nxb = new nhaxuatban_ctrl();

    }
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            var select_cbx = cbx_option_search.SelectedValue.ToString();
            var temp = sach_ctrl.select_sach_fields(txt_timkiem.Text, select_cbx);
            switch (temp.errcode)
            {
                case ErrorCode.NaN:
                    dtgv.DataSource = temp.data;
                    break;
                case ErrorCode.sucess:
                    dtgv.DataSource = temp.data;
                    Utils.chang_title_datagridViewCell(dtgv, new List<string> { "Mã sách", "Tên sách", "Nhà XB", "Lĩnh Vực", "Số trang", "Số lượng ban đầu", "Số lượng ban đầu", "Ngày nhập" });

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbx_option_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
