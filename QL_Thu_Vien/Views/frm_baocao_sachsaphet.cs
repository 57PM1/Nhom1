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
    public partial class frm_baocao_sachsaphet : Form
    {
        public frm_baocao_sachsaphet()
        {
            InitializeComponent();
        }

        private sach_ctrl sach_ctrl = new sach_ctrl();
        private void load_data()
        {
            var dt = sach_ctrl.select_sachsaphet_null();
            switch (dt.errcode)
            {
                case Models.ErrorCode.NaN:
                    dtgv.DataSource = dt.data;
                    break;
                case Models.ErrorCode.sucess:
                    dtgv.DataSource = dt.data;
                    Utils.chang_title_datagridViewCell(dtgv, new List<string> { "Mã sách", "Tên sách", "Tên lĩnh vực", "Tên nhà XBc", "Số lượng", "Ngày nhập" });
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
            // TODO: This line of code loads data into the 'db_sachhethan.db_sach' table. You can move, or remove it, as needed.
            load_data();

            List<how_to_search> dt_source = new List<how_to_search>();
            dt_source.Add(new how_to_search("Tên sách", "tensach"));
            dt_source.Add(new how_to_search("Lĩnh vực", "tenlinhvuc"));
            dt_source.Add(new how_to_search("Nhà xuất bản", "tennxb"));

            cbx_option_search.DataSource = dt_source;
            cbx_option_search.DisplayMember = "value";
            cbx_option_search.ValueMember = "key";

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
                    Utils.chang_title_datagridViewCell(dtgv, new List<string> { "Mã sách", "Tên sách", "Tên lĩnh vực", "Tên nhà XBc", "Số lượng", "Ngày nhập" });

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
    }
}
