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
    public partial class frm_capnhat_sach : Form
    {
        // enum variable used for select option
        private Option option = Option.Nodata;

        private sach_ctrl sach_ctrl = new sach_ctrl();

        // uses for save data from all textboxs
        private sach_ett sach_ett = new sach_ett();

        //list for tacgia
        List<tacgia_ett> lst_tacgias = new List<tacgia_ett>();


        // set value to caculate later on
        private void get_info()
        {
            if (txt_masach.Text != null && txt_masach.Text != "")
            {
                sach_ett.masach = int.Parse(txt_masach.Text);
            }
            else sach_ett.masach = 0;
            sach_ett.tensach = txt_tensach.Text;
            if (cbx_linhvuc.SelectedValue != null)
            {
                sach_ett.malv = int.Parse(cbx_linhvuc.SelectedValue.ToString());
            }
            if (cbx_nxb.SelectedValue != null)
            {
                sach_ett.manxb = int.Parse(cbx_nxb.SelectedValue.ToString());
            }
            if (txt_slbd.Text != null && txt_slbd.Text != "")
            {
                sach_ett.soluongbandau = int.Parse(txt_slbd.Text);
            }
            if (txt_slht.Text != null && txt_slht.Text != "")
            {
                sach_ett.soluonghientai = int.Parse(txt_slht.Text);
            }
            else sach_ett.sotrang = 0;
            if (txt_sotrang.Text != null && txt_sotrang.Text != "")
            {
                sach_ett.sotrang = int.Parse(txt_sotrang.Text);
            }
            else sach_ett.sotrang = 0;
            sach_ett.ngaynhap = dtpk_ngaynhap.Text;
        }

        //update data for dtgv
        public void load_data()
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

        public frm_capnhat_sach()
        {
            InitializeComponent();
            Utils.readOnly_text_box(new List<TextBox> { txt_masach, txt_sotrang, txt_slbd, txt_tensach, txt_slht }, true);
            dtpk_ngaynhap.Enabled = false;
            cbx_tacgias.Enabled = false; 
            btn_add_soluong.Visible = false;
            btn_xoa.Visible = false;
            btn_sua.Visible = false;
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



            var dt_cbx_tacgias = tacgia.select_all_tacgia();
            switch (dt_cbx_tacgias.errcode)
            {
                case ErrorCode.NaN:
                    break;
                case ErrorCode.sucess:
                    cbx_tacgias.DisplayMember = "tentacgia";
                    cbx_tacgias.ValueMember = "matacgia";
                    cbx_tacgias.DataSource = dt_cbx_tacgias.data;
                    cbx_tacgias.SelectedIndex = -1;
                    break;
                case ErrorCode.fail:
                    break;
                default:
                    break;
            }

            var dt_cbx_nxb = nxb.select_all_nhaxuatban();
            switch (dt_cbx_nxb.errcode)
            {
                case ErrorCode.NaN:
                    break;
                case ErrorCode.sucess:
                    cbx_nxb.DisplayMember = "tennxb";
                    cbx_nxb.ValueMember = "manxb";
                    cbx_nxb.DataSource = dt_cbx_nxb.data;
                    cbx_nxb.SelectedIndex = -1;
                    break;
                case ErrorCode.fail:
                    break;
                default:
                    break;
            }

            var dt_cbx_linhvuc = linhvuc.select_all_linhvuc();
            switch (dt_cbx_linhvuc.errcode)
            {
                case ErrorCode.NaN:
                    break;
                case ErrorCode.sucess:
                    cbx_linhvuc.DisplayMember = "tenlinhvuc";
                    cbx_linhvuc.ValueMember = "malinhvuc";
                    cbx_linhvuc.DataSource = dt_cbx_linhvuc.data;
                    cbx_linhvuc.SelectedIndex = -1;
                    break;
                case ErrorCode.fail:
                    break;
                default:
                    break;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (Utils.confirm_exit())
            {
                Application.Exit();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Utils.enable_combobox(new List<ComboBox> { cbx_linhvuc, cbx_nxb, cbx_tacgias }, false);
            Utils.erase_text_box(new List<TextBox> { txt_masach, txt_sotrang, txt_slbd, txt_tensach, txt_slht });
            Utils.erase_combobox(new List<ComboBox> { cbx_linhvuc, cbx_nxb, cbx_tacgias });
            Utils.readOnly_text_box(new List<TextBox> { txt_sotrang, txt_slbd, txt_tensach, txt_slht }, true);
            dtpk_ngaynhap.Enabled = false;
            option = Option.Nodata;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Utils.erase_text_box(new List<TextBox> { txt_masach, txt_sotrang, txt_slbd, txt_tensach, txt_slht });
            Utils.erase_combobox(new List<ComboBox> { cbx_linhvuc, cbx_nxb, cbx_tacgias });
            Utils.readOnly_text_box(new List<TextBox> { txt_sotrang, txt_slbd, txt_tensach, txt_slht }, false);
            dtpk_ngaynhap.Enabled = true;
            lst_tacgia_rs.Enabled = true;
            lst_tacgia_rs.Items.Clear();
            Utils.enable_combobox(new List<ComboBox> { cbx_linhvuc, cbx_nxb, cbx_tacgias }, true);
            txt_tensach.Focus();
            option = Option.Insert;

        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Utils.readOnly_text_box(new List<TextBox> { txt_sotrang, txt_slbd, txt_tensach, txt_slht }, true);
            dtpk_ngaynhap.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow temp = dtgv.Rows[e.RowIndex];
                txt_masach.Text = temp.Cells[0].Value.ToString();
                txt_tensach.Text = temp.Cells[1].Value.ToString();
                cbx_linhvuc.Text = temp.Cells[3].Value.ToString();
                cbx_nxb.Text = temp.Cells[2].Value.ToString();
                txt_sotrang.Text = temp.Cells[4].Value.ToString();
                txt_slbd.Text = temp.Cells[5].Value.ToString();
                txt_slht.Text = temp.Cells[6].Value.ToString();
                var ngaynhap = temp.Cells[7].Value.ToString();
                dtpk_ngaynhap.Value = DateTime.ParseExact(ngaynhap, "dd/MM/yyyy", null);
                lst_tacgias=sach_ctrl.select_tacgia(txt_masach.Text.ToString()).data;
                lst_tacgia_rs.Items.Clear();
                foreach (var item in lst_tacgias)
                {
                    var row = new ListViewItem(item.matacgia.ToString());
                    row.SubItems.Add(item.tentacgia);
                    lst_tacgia_rs.Items.Add(row);
                }
            }
        }



        private void btn_them_tacgia_Click(object sender, EventArgs e)
        {
            if (cbx_tacgias.SelectedItem==null)
            {
                return;
            }
            foreach (var item in lst_tacgias)
            {
                if(item.matacgia.ToString() == cbx_tacgias.SelectedValue.ToString())
                {
                    return;
                }
            }
            lst_tacgias.Add(new tacgia_ett(int.Parse(cbx_tacgias.SelectedValue.ToString()), cbx_tacgias.GetItemText(cbx_tacgias.SelectedItem)));

            //update listview from list of tacgia
            lst_tacgia_rs.Items.Clear();
            foreach (var item in lst_tacgias)
            {
                var row = new ListViewItem(item.matacgia.ToString());
                row.SubItems.Add(item.tentacgia);
                lst_tacgia_rs.Items.Add(row);
            }
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            option = Option.Edit;
            Utils.readOnly_text_box(new List<TextBox> { txt_sotrang, txt_slbd, txt_tensach, txt_slht }, false);
            dtpk_ngaynhap.Enabled = true;
            lst_tacgia_rs.Enabled = true;
            Utils.enable_combobox(new List<ComboBox> { cbx_linhvuc, cbx_nxb, cbx_tacgias }, true);

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case Option.Nodata:

                    break;

                case Option.Insert:
                    var check_ten = Utils.err_null_data(txt_tensach);
                    if (check_ten != null)
                    {
                        MessageBox.Show(check_ten);
                        break;
                    }
                    //var check_tacgia = Utils.err_null_data_cbx(cbx_tacgias);
                    //if (check_tacgia != null)
                    //{
                    //    MessageBox.Show(check_tacgia);
                    //    break;
                    //}
                    var check_nxb = Utils.err_null_data_cbx(cbx_nxb);
                    if (check_nxb != null)
                    {
                        MessageBox.Show(check_nxb);
                        break;
                    }
                    var check_linhvuc = Utils.err_null_data_cbx(cbx_linhvuc);
                    if (check_linhvuc != null)
                    {
                        MessageBox.Show(check_linhvuc);
                        break;
                    }

                    var check_soluong1 = Utils.err_null_data(txt_slbd);
                    var check_soluong2 = Utils.err_null_data(txt_slht);
                    if (check_soluong1 != null && check_soluong2 != null)
                    {
                        MessageBox.Show(check_soluong1 + " " + check_soluong2);
                        break;
                    }
                    get_info();
                    //check if existing data
                    var check = true;
                    var data = dtgv.Rows;
                    foreach (DataGridViewRow item in data)
                    {
                        if (int.Parse(item.Cells[0].Value.ToString()) == sach_ett.masach)
                        {
                            check = false;
                        }
                    }
                    if (!check)
                    {
                        Utils.err_duplicate_data();
                        break;
                    }
                    var temp = sach_ctrl.insert_sach(sach_ett, lst_tacgias);
                    switch (temp.errcode)
                    {
                        case ErrorCode.NaN:
                            break;
                        case ErrorCode.sucess:
                            MessageBox.Show(Constants.success_insert);
                            load_data();
                            Utils.erase_text_box(new List<TextBox> { txt_masach, txt_sotrang, txt_slbd, txt_tensach, txt_slht });
                            Utils.erase_combobox(new List<ComboBox> { cbx_linhvuc, cbx_nxb, cbx_tacgias });
                            break;
                        case ErrorCode.fail:
                            break;
                        default:
                            break;
                    }
                    break;

                case Option.Edit:
                    get_info();
                    //check if existing data
                    var check1 = true;
                    var data1 = dtgv.Rows;
                    foreach (DataGridViewRow item in data1)
                    {
                        if (int.Parse(item.Cells[0].Value.ToString()) == sach_ett.masach)
                        {
                            check1 = false;
                        }
                    }
                    if (check1)
                    {
                        Utils.err_no_duplicate_data();
                        break;
                    }
                    var temp1 = sach_ctrl.edit_sach(sach_ett, lst_tacgias);
                    switch (temp1.errcode)
                    {
                        case ErrorCode.NaN:
                            break;
                        case ErrorCode.sucess:
                            MessageBox.Show(Constants.success_edit);
                            load_data();
                            Utils.erase_text_box(new List<TextBox> { txt_masach, txt_sotrang, txt_slbd, txt_tensach, txt_slht });
                            Utils.readOnly_text_box(new List<TextBox> { txt_sotrang, txt_slbd, txt_tensach, txt_slht }, true);
                            dtpk_ngaynhap.Enabled = false;
                            Utils.enable_combobox(new List<ComboBox> { cbx_linhvuc, cbx_nxb, cbx_tacgias }, false);
                            Utils.erase_combobox(new List<ComboBox> { cbx_linhvuc, cbx_nxb, cbx_tacgias });
                            break;
                        case ErrorCode.fail:
                            if (Utils.switch_false())
                            {
                                MessageBox.Show(temp1.errInfor);
                            }
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // get data user selected;
            var selected_r = dtgv.SelectedRows;
            if (selected_r.Count > 0)
            {
                if (Utils.confirm_delete())
                {
                    bool check = true;
                    string err_infor = "";
                    foreach (DataGridViewRow item in selected_r)
                    {
                        var temp = sach_ctrl.delete_sach(int.Parse(item.Cells[0].Value.ToString()));
                        switch (temp.errcode)
                        {
                            case ErrorCode.NaN:
                                break;
                            case ErrorCode.sucess:
                                Utils.erase_text_box(new List<TextBox> { txt_masach, txt_sotrang, txt_slbd, txt_tensach, txt_slht });
                                Utils.erase_combobox(new List<ComboBox> { cbx_linhvuc, cbx_nxb, cbx_tacgias });
                                Utils.readOnly_text_box(new List<TextBox> { txt_sotrang, txt_slbd, txt_tensach, txt_slht }, true);
                                dtpk_ngaynhap.Enabled = false;
                                lst_tacgia_rs.Enabled = false;
                                option = Option.Nodata;
                                break;
                            case ErrorCode.fail:
                                check = false;
                                err_infor = temp.errInfor;
                                break;
                            default:
                                break;
                        }
                    }

                    if (check)
                    {
                        MessageBox.Show(Constants.success_delete);
                        load_data();
                    }
                    else
                    {
                        MessageBox.Show(Constants.not_allow_to_delete);
                    }
                }
            }
        }

        private void txt_masach_TextChanged(object sender, EventArgs e)
        {
            if (txt_masach.Text == null || txt_masach.Text == "")
            {
                btn_xoa.Visible = false;
                btn_sua.Visible = false;
                btn_add_soluong.Visible = false;
            }
            else
            {
                btn_xoa.Visible = true;
                btn_sua.Visible = true;
                btn_add_soluong.Visible = true;
            }


        }

        //private void cbx_tacgia_Leave(object sender, EventArgs e)
        //{
        //    List<tacgia_ett> temp = cbx_tacgia.Items.OfType<tacgia_ett>().ToList();
        //    var x = temp.Where(o => o.tentacgia == cbx_tacgia.Text);
        //    if (x.Count() == 0)
        //    {
        //        MessageBox.Show(Constants.error_not_list);
        //        cbx_tacgia.Focus();
        //    }
        //}

        private void cbx_nxb_Leave(object sender, EventArgs e)
        {
            List<nhaxuatban_ett> temp = cbx_nxb.Items.OfType<nhaxuatban_ett>().ToList();
            var x = temp.Where(o => o.tennxb == cbx_nxb.Text);
            if (x.Count() == 0)
            {
                MessageBox.Show(Constants.error_not_list);
                cbx_nxb.Focus();
            }
        }

        private void cbx_linhvuc_Leave(object sender, EventArgs e)
        {
            List<linhvuc_ett> temp = cbx_linhvuc.Items.OfType<linhvuc_ett>().ToList();
            var x = temp.Where(o => o.tenlinhvuc == cbx_linhvuc.Text);
            if (x.Count() == 0)
            {
                MessageBox.Show(Constants.error_not_list);
                cbx_linhvuc.Focus();
            }
        }

        private void txt_sotrang_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\b')
            {
                return;
            }

            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show(Constants.error_format_number);
                e.KeyChar = (char)0;
            }
        }

        private void btn_add_soluong_Click(object sender, EventArgs e)
        {
            sub_frm_them_soluongsach sub_form = new sub_frm_them_soluongsach(int.Parse(txt_masach.Text), this);
            sub_form.Show();
        }

        private void btn_xoa_tacgia_Click(object sender, EventArgs e)
        {
            if (lst_tacgia_rs.SelectedIndices.Count==0)
            {
                return;
            }
            else
            {
                var pos = lst_tacgia_rs.SelectedIndices[0];
                lst_tacgia_rs.Items.RemoveAt(pos);
                lst_tacgias.RemoveAt(pos);
            }
        }

        private void cbx_option_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        //private void cbx_tacgias_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show(cbx_tacgias.SelectedValue.ToString());
        //}
    }
}
