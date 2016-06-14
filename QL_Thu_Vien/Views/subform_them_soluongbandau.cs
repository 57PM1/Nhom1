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
    public partial class subform_them_soluongbandau : Form
    {
        QL_Thu_VienEntities db = new QL_Thu_VienEntities();
        private frm_capnhat_sach form_sach;
        private int masach_update;
        public subform_them_soluongbandau(string masach, frm_capnhat_sach form)
        {
            InitializeComponent();
            if (masach != "")
            {
                masach_update = int.Parse(masach);
            }
            else
            {
                masach_update = 0;
            }
            this.form_sach = form;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_themsoluong.Text != "")
            {
                var dt = db.tbl_sach.Where(o => o.masach == masach_update).SingleOrDefault();
                dt.soluongbandau += int.Parse(txt_themsoluong.Text);
                MessageBox.Show("Bạn vừa thêm " + txt_themsoluong.Text + " cuốn sách " + dt.tensach);
                db.SaveChanges();
                form_sach.load_data();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn vui lòng nhập số vào ô trống!");
            }

        }

        private void txt_themsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b' || e.KeyChar == '-')
            {
                return;
            }

            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show(Constants.error_format_number);
                e.KeyChar = (char)0;
            }
        }
    }
}
