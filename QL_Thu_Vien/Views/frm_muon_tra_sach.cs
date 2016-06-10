using DoAnCNPM.Controllers;
using DoAnCNPM.Models;
using DoAnCNPM.Report;
using DoAnCNPM.Shareds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCNPM.Views
{
    public partial class frm_muon_tra_sach : Form
    {

        // enum variable used for select option
        private Option option = Option.Nodata;

        private phieumuontra_ctrl phieumuontra_ctrl = new phieumuontra_ctrl();

        // uses for save data from all textboxs
        private phieumuontra_ett phieumuontra_ett = new phieumuontra_ett();

        private List<chitietphieu_ett> chitietphieu = new List<chitietphieu_ett>();

        // Save temporary when clicking on a row.
        private List<chitietphieu_ett> temp_chitietphieu = new List<chitietphieu_ett>();

        QL_Thu_VienEntities db = new QL_Thu_VienEntities();

        public frm_muon_tra_sach()
        {
            InitializeComponent();

            dtpk_ngaytra.Value = dtpk_ngaymuon.Value = DateTime.Today;

            Utils.readOnly_text_box(new List<TextBox> { txt_ghichu }, true);
            Utils.enable_combobox(new List<ComboBox> { cbx_docgia }, false);
            chbox_xacnhantra.Enabled = false;
            dtgv_sachmuon.Enabled = false;
            dtpk_ngaymuon.Enabled = false;
            dtpk_ngaytra.Enabled = false;
            btn_xoa.Visible = false;
            btn_sua.Visible = false;

            DataGridViewComboBoxColumn data_sach = new DataGridViewComboBoxColumn();
            data_sach.HeaderText = "Sách";
            data_sach.Name = "data_sach";

            sach_ctrl sach = new sach_ctrl();
            var data_source = sach.select_all_sachview();
            switch (data_source.errcode)
            {
                case ErrorCode.NaN:
                    break;
                case ErrorCode.sucess:
                    data_sach.DisplayMember = "tensach";
                    data_sach.ValueMember = "masach";
                    data_sach.DataSource = data_source.data;
                    data_sach.FlatStyle = FlatStyle.Flat;
                    break;
                case ErrorCode.fail:
                    break;
                default:
                    break;
            }
            dtgv_sachmuon.Columns.Add(data_sach);

            DataGridViewComboBoxColumn data_trangthai = new DataGridViewComboBoxColumn();
            data_trangthai.HeaderText = "Trạng thái sách";
            data_trangthai.Items.Add(Constants.TrangThai_BinhThuong);
            data_trangthai.Items.Add(Constants.TrangThai_RachNat);
            data_trangthai.Items.Add(Constants.TrangThai_Mat);
            data_trangthai.FlatStyle = FlatStyle.Flat;
            dtgv_sachmuon.Columns.Add(data_trangthai);
            dtgv_sachmuon.Font = new Font("Verdana", 9, FontStyle.Regular);
            dtgv_sachmuon.Columns[1].Width = 150;
            dtgv_sachmuon.Columns[0].Width = 150;

        }

        private void frm_capnhat_docgia_Load(object sender, EventArgs e)
        {
            load_data();
            List<how_to_search> dt_source = new List<how_to_search>();
            dt_source.Add(new how_to_search("Số phiếu mượn", "sophieumuon"));
            dt_source.Add(new how_to_search("Độc giả", "docgia"));

            cbx_option_search.DataSource = dt_source;
            cbx_option_search.DisplayMember = "value";
            cbx_option_search.ValueMember = "key";

            docgia_ctrl docgia = new docgia_ctrl();
            nhanvien_ctrl nhanvien = new nhanvien_ctrl();

            var data_docgia = docgia.select_all_docgia();
            switch (data_docgia.errcode)
            {
                case ErrorCode.NaN:
                    break;
                case ErrorCode.sucess:
                    cbx_docgia.DisplayMember = "ma_ten";
                    cbx_docgia.ValueMember = "madocgia";
                    cbx_docgia.DataSource = data_docgia.data;
                    cbx_docgia.SelectedIndex = -1;
                    break;
                case ErrorCode.fail:
                    break;
                default:
                    break;
            }

            dtgv_sachmuon.Rows[0].Cells[0].Selected = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            #region check Doc gia
            var check_docgia = Utils.err_null_data_cbx(cbx_docgia);
            if (check_docgia != null)
            {
                MessageBox.Show(check_docgia);
                return;
            }

            if (cbx_docgia.SelectedValue == null)
            {
                MessageBox.Show(Constants.error_not_list);
                cbx_docgia.Focus();
                return;
            }

            #endregion

            get_ds_sach();

            switch (option)
            {
                case Option.Insert:

                    if (!Check_Valid_Data_ChiTietPhieu(chitietphieu))
                    {
                        MessageBox.Show("Không thể cho mượn sách đã mất! Vui lòng kiểm tra lại chi tiết phiếu mượn.");
                        return;
                    };

                    get_info();
                    #region check for Phieu muon check if existing data 
                    var check = true;
                    var data = dtgv.Rows;
                    foreach (DataGridViewRow item in data)
                    {
                        if (int.Parse(item.Cells[0].Value.ToString()) == phieumuontra_ett.sophieumuon)
                        {
                            check = false;
                        }
                    }
                    if (!check)
                    {
                        Utils.err_duplicate_data();
                        break;
                    }
                    #endregion

                    var temp = phieumuontra_ctrl.insert_phieumuontra(phieumuontra_ett, chitietphieu);
                    switch (temp.errcode)
                    {
                        case ErrorCode.NaN:
                            break;
                        case ErrorCode.sucess:
                            MessageBox.Show(Constants.success_insert);
                            ResetAction();
                            break;
                        case ErrorCode.fail:
                            Utils.Show_Error(temp.errInfor);
                            break;
                        default:
                            break;
                    }
                    break;

                case Option.Edit:

                    get_info();
                    #region check for update : check if existing data
                    var check1 = true;
                    var data1 = dtgv.Rows;
                    foreach (DataGridViewRow item in data1)
                    {
                        if (int.Parse(item.Cells[0].Value.ToString()) == phieumuontra_ett.sophieumuon)
                        {
                            check1 = false;
                        }
                    }
                    if (check1)
                    {
                        Utils.err_no_duplicate_data();
                        break;
                    }

                    #endregion

                    var temp1 = phieumuontra_ctrl.edit_phieumuontra(phieumuontra_ett, chitietphieu);

                    var sopm1 = phieumuontra_ett.sophieumuon;
                    chitietphieu_ctrl chitiet_ctrl1 = new chitietphieu_ctrl();
                    var list_sach = chitiet_ctrl1.select_all_chitietphieu_by_sopm(phieumuontra_ett.sophieumuon);
                    if (list_sach.data != null)
                    {
                        foreach (chitietphieu_ett item in list_sach.data)
                        {
                            chitiet_ctrl1.delete_chitietphieu(item.sophieumuon, item.masach);
                        }
                    }

                    switch (temp1.errcode)
                    {
                        case ErrorCode.NaN:
                            break;
                        case ErrorCode.sucess:
                            MessageBox.Show(Constants.success_edit);
                            load_data();
                            get_ds_sach();
                            foreach (chitietphieu_ett item in chitietphieu)
                            {
                                item.sophieumuon = sopm1;
                                chitiet_ctrl1.insert_chitietphieu(item);
                            }

                            #region  Tính tổng tiền phạt ở đây;
                            int tienphat = 0;
                            var phieumuon = db.tbl_phieumuon_tra.SqlQuery("Select * from tbl_phieumuon_tra where sophieumuon = " + phieumuontra_ett.sophieumuon).FirstOrDefault();


                            if (chbox_xacnhantra.Checked)
                            {

                                var date_now = DateTime.Now.Date;
                                DateTime date_tra = DateTime.ParseExact(dtpk_ngaytra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                                if (date_now > date_tra)
                                {
                                    int days = (date_now - date_tra).Days;
                                    int giatien = (int)db.tbl_xuphat.SqlQuery("Select * from tbl_xuphat where loaiphat = N'Quá hạn theo ngày'").FirstOrDefault().giatien;

                                    tienphat += days * giatien;
                                }


                                chitietphieu.Clear();
                                get_ds_sach();
                                var edit_data = chitietphieu;
                                var old_data = temp_chitietphieu;

                                if (edit_data.Count > 0 && old_data.Count > 0)
                                {
                                    foreach (var item in old_data)
                                    {
                                        foreach (var item1 in edit_data)
                                        {
                                            if (item.sophieumuon == item1.sophieumuon && item.masach == item1.masach && item.trangthaisach != item1.trangthaisach)
                                            {
                                                switch (item1.trangthaisach)
                                                {
                                                    case Constants.TrangThai_RachNat:
                                                        int giatien = (int)db.tbl_xuphat.SqlQuery("Select * from tbl_xuphat where loaiphat = N'Hỏng sách'").FirstOrDefault().giatien;

                                                        tienphat += giatien;
                                                        break;

                                                    case Constants.TrangThai_Mat:
                                                        giatien = (int)db.tbl_xuphat.SqlQuery("Select * from tbl_xuphat where loaiphat = N'Mất sách'").FirstOrDefault().giatien;

                                                        tienphat += giatien;
                                                        break;

                                                    default:
                                                        break;
                                                }
                                            }
                                        }
                                    }
                                }

                                phieumuon.sotienphat = tienphat;
                                db.SaveChanges();

                                Show_So_Tien_Phat();
                                txt_sotienphat.Text = tienphat.ToString();
                                #endregion End tính tiền phạt

                            }

                            if (!chbox_xacnhantra.Checked)
                            {
                                ResetAction();
                            }

                            break;
                        case ErrorCode.fail:
                            Utils.Show_Error(temp1.errInfor);
                            break;
                    }
                    break;
            }
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                QL_Thu_VienEntities db_local = new QL_Thu_VienEntities();

                DataGridViewRow temp = dtgv.Rows[e.RowIndex];
                string current_phieumuon = temp.Cells[0].Value.ToString();
                txt_soPM.Text = current_phieumuon;

                var phieumuontra = db_local.tbl_phieumuon_tra.Where(o => o.sophieumuon.ToString() == current_phieumuon).SingleOrDefault();

                cbx_docgia.SelectedValue = phieumuontra.madg;

                dtpk_ngaymuon.Value = DateTime.ParseExact(phieumuontra.ngaymuon, "dd/MM/yyyy", null);
                dtpk_ngaytra.Value = DateTime.ParseExact(phieumuontra.ngaytra, "dd/MM/yyyy", null);

                chbox_xacnhantra.Checked = phieumuontra.xacnhantra != null ? ((bool)phieumuontra.xacnhantra ? true : false) : false;
                txt_ghichu.Text = phieumuontra.ghichu;

                if (chbox_xacnhantra.Checked)
                {
                    btn_sua.Enabled = btn_xoa.Enabled = btn_luu.Enabled = false;

                    Show_So_Tien_Phat();
                    txt_sotienphat.Text = phieumuontra.sotienphat == null ? "0" : phieumuontra.sotienphat.ToString();

                }
                else
                {
                    btn_sua.Enabled = btn_xoa.Enabled = btn_luu.Enabled = true;
                    Hide_So_Tien_Phat();
                }

                chitietphieu_ctrl chitiet_ctrl = new chitietphieu_ctrl();
                var list_sach = chitiet_ctrl.select_all_chitietphieu_by_sopm(int.Parse(txt_soPM.Text));
                var data_sach = list_sach.data;
                temp_chitietphieu = data_sach;
                if (data_sach != null)
                {
                    dtgv_sachmuon.RowCount = data_sach.Count() + 1;
                    for (int i = 0; i < data_sach.Count(); i++)
                    {
                        dtgv_sachmuon.Rows[i].Cells[0].Value = data_sach[i].masach;
                        dtgv_sachmuon.Rows[i].Cells[1].Value = data_sach[i].trangthaisach;
                    }
                }
                else
                {
                    dtgv_sachmuon.Rows.Clear();
                }

                Utils.readOnly_text_box(new List<TextBox> { txt_ghichu }, true);
                Utils.enable_combobox(new List<ComboBox> { cbx_docgia }, false);
                chbox_xacnhantra.Enabled = false;
                dtgv_sachmuon.Enabled = false;
                dtpk_ngaytra.Enabled = false;
                dtpk_ngaymuon.Enabled = false;

            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            var select_cbx = cbx_option_search.SelectedValue.ToString();
            var temp = phieumuontra_ctrl.select_phieumuontra_fields(txt_timkiem.Text, select_cbx);
            switch (temp.errcode)
            {
                case ErrorCode.NaN:
                    dtgv.DataSource = temp.data;
                    break;
                case ErrorCode.sucess:
                    dtgv.DataSource = temp.data;
                    Utils.chang_title_datagridViewCell(dtgv, new List<string> { "Số PM", "Độc giả", "Nhân viên", "Ngày mượn", "Ngày trả", "Xác nhận trả", "ghi chú" });
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
            Utils.readOnly_text_box(new List<TextBox> { txt_ghichu }, false);
            Utils.enable_combobox(new List<ComboBox> { cbx_docgia }, true);
            chbox_xacnhantra.Enabled = true;
            dtgv_sachmuon.Enabled = true;
            dtpk_ngaytra.Enabled = true;
            dtpk_ngaymuon.Enabled = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (Utils.confirm_exit())
            {
                Application.Exit();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ResetAction();
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
                        var temp = phieumuontra_ctrl.delete_phieumuontra(int.Parse(item.Cells[0].Value.ToString()));
                        switch (temp.errcode)
                        {
                            case ErrorCode.NaN:
                                break;
                            case ErrorCode.sucess:
                                ResetAction();
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

        private void txt_sophieumuon_TextChanged(object sender, EventArgs e)
        {
            if (txt_soPM.Text == null || txt_soPM.Text == "")
            {
                btn_xoa.Visible = false;
                btn_sua.Visible = false;
            }
            else
            {
                btn_xoa.Visible = true;
                btn_sua.Visible = true;
            }
        }

        private void dtgv_sachmuon_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
                ((ComboBox)e.Control).AutoCompleteSource = AutoCompleteSource.ListItems;
                ((ComboBox)e.Control).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }

        private void dtgv_sachmuon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var data_check = dtgv_sachmuon.Rows;
                var cur_cell = dtgv_sachmuon[e.ColumnIndex, e.RowIndex];
                var check = 0;

                //MessageBox.Show(cur_cell.Value.ToString());
                foreach (DataGridViewRow item in data_check)
                {
                    if (item.Cells[0].FormattedValue == cur_cell.FormattedValue)
                    {
                        check++;
                    }
                }
                if (check == 2)
                {
                    MessageBox.Show("Mã sách này đã được nhập mời bạn nhập mã sách khác");
                    dtgv_sachmuon.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    cur_cell.Value = null;

                    //var x = dtgv_sachmuon.CanFocus;
                    //var y = dtgv_sachmuon.CurrentCellAddress;

                    //dtgv_sachmuon.CurrentCell = dtgv_sachmuon.Rows[y.Y].Cells[y.X];
                    //var z = dtgv_sachmuon.SelectedCells;
                    //cur_cell.Selected = true;
                    //dtgv_sachmuon.BeginEdit(true);
                    //return;
                }
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            if (txt_soPM.Text != "")
            {
                var db = new QL_Thu_VienEntities();
                var phieumuontra_tbl = db.tbl_phieumuon_tra.FirstOrDefault(o => o.sophieumuon.ToString() == txt_soPM.Text);

                frm_report_PhieuMuonTra f_report = new frm_report_PhieuMuonTra();

                f_report.SoPM = phieumuontra_tbl.sophieumuon.ToString();
                f_report.DocGia = phieumuontra_tbl.tbl_docgia.tendg;
                f_report.NhanVien = phieumuontra_tbl.tbl_nhanvien.tennv;
                f_report.NgayMuon = phieumuontra_tbl.ngaymuon;
                f_report.NgayTra = phieumuontra_tbl.ngaytra;
                f_report.GhiChu = phieumuontra_tbl.ghichu;

                dts_PhieuMuonTra rpt_source = new dts_PhieuMuonTra();
                var chitietphieus = db.tbl_chitietphieu.Where(o => o.sophieumuon == phieumuontra_tbl.sophieumuon);

                foreach (var item in chitietphieus)
                {
                    DataRow row = rpt_source.PhieuMuonTra.Rows.Add();

                    row[0] = item.masach;
                    row[1] = item.tbl_sach.tensach;
                    row[2] = item.trangthaisach;
                }

                f_report.List_ChiTietPhieu = rpt_source;

                f_report.ShowDialog();

            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetAction();
        }

        #region supported method


        // set value to caculate later on

        private bool Check_Valid_Data_ChiTietPhieu(List<chitietphieu_ett> chitietphieus)
        {
            foreach (var item in chitietphieus)
            {
                if (item.trangthaisach == Constants.TrangThai_Mat)
                {
                    return false;
                }
            }

            return true;
        }

        private void get_ds_sach()
        {
            chitietphieu.Clear();
            get_info();
            var data = dtgv_sachmuon.Rows;
            foreach (DataGridViewRow item in data)
            {
                chitietphieu_ett temp = new chitietphieu_ett();
                if (item.Cells[0].Value == null)
                {
                    break;
                }
                temp.sophieumuon = phieumuontra_ett.sophieumuon;
                temp.masach = int.Parse(item.Cells[0].Value.ToString());
                if (item.Cells[1].Value == null) temp.trangthaisach = Constants.TrangThai_BinhThuong;
                else temp.trangthaisach = item.Cells[1].Value.ToString();

                chitietphieu.Add(temp);
            }
        }

        private void get_info()
        {
            if (txt_soPM.Text != null && txt_soPM.Text != "")
            {
                phieumuontra_ett.sophieumuon = int.Parse(txt_soPM.Text);
            }
            else phieumuontra_ett.sophieumuon = 0;
            if (cbx_docgia.SelectedValue != null)
            {
                phieumuontra_ett.madg = int.Parse(cbx_docgia.SelectedValue.ToString());
            }

            phieumuontra_ett.manv = Utils.ID_Account;
            phieumuontra_ett.ngaymuon = dtpk_ngaymuon.Text;
            phieumuontra_ett.ngaytra = dtpk_ngaytra.Text;
            phieumuontra_ett.ghichu = txt_ghichu.Text;
            phieumuontra_ett.xacnhantra = chbox_xacnhantra.Checked;
        }

        //update data for dtgv
        private void load_data()
        {
            var dt = phieumuontra_ctrl.select_all_phieumuontra_view();
            switch (dt.errcode)
            {
                case Models.ErrorCode.NaN:
                    dtgv.DataSource = dt.data;
                    break;
                case Models.ErrorCode.sucess:
                    dtgv.DataSource = dt.data;
                    Utils.chang_title_datagridViewCell(dtgv, new List<string> { "Số PM", "Độc giả", "Nhân viên", "Ngày mượn", "Ngày trả", "Xác nhận trả", "ghi chú" });
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

        private void Show_So_Tien_Phat()
        {
            lbl_sotienphat.Visible = true;
            txt_sotienphat.Visible = true;
        }

        private void Hide_So_Tien_Phat()
        {
            lbl_sotienphat.Visible = false;
            txt_sotienphat.Visible = false;
        }

        private void ResetAction()
        {
            Utils.erase_text_box(new List<TextBox> { txt_soPM, txt_ghichu });
            Utils.erase_combobox(new List<ComboBox> { cbx_docgia });
            Utils.readOnly_text_box(new List<TextBox> { txt_ghichu }, false);
            Utils.enable_combobox(new List<ComboBox> { cbx_docgia }, true);


            chbox_xacnhantra.Enabled = false;
            chbox_xacnhantra.Checked = false;
            dtgv_sachmuon.Enabled = true;
            dtgv_sachmuon.Rows.Clear();
            dtpk_ngaytra.Enabled = true;
            dtpk_ngaymuon.Enabled = true;
            cbx_docgia.Focus();
            option = Option.Insert;
            btn_sua.Enabled = btn_xoa.Enabled = btn_luu.Enabled = true;


            Hide_So_Tien_Phat();
            load_data();
        }

        #region empty method

        private void cbx_docgia_Leave(object sender, EventArgs e)
        {
            //List<docgia_ett> temp = cbx_docgia.Items.OfType<docgia_ett>().ToList();
            //var x = temp.Where(o => o.tendocgia == cbx_docgia.Text);
            //if (x.Count() == 0)
            //{
            //    MessageBox.Show(Constants.error_not_list);
            //    cbx_docgia.Focus();
            //}
        }

        private void cbx_nhanvien_Leave(object sender, EventArgs e)
        {
            //List<nhanvien_ett> temp = cbx_nhanvien.Items.OfType<nhanvien_ett>().ToList();
            //var x = temp.Where(o => o.tennhanvien == cbx_nhanvien.Text);
            //if (x.Count() == 0)
            //{
            //    MessageBox.Show(Constants.error_not_list);
            //    cbx_nhanvien.Focus();
            //}
        }

        private void chbox_xacnhantra_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void load_data_sachmuon()
        {

        }
        #endregion
        #endregion

        //    #region Check độc giả
        //    List<docgia_ett> temp_check_docgia = cbx_docgia.Items.OfType<docgia_ett>().ToList();
        //    var x_check_docgia = temp_check_docgia.Where(o => o.madocgia.ToString() == cbx_docgia.SelectedValue.ToString());
        //        if (x_check_docgia.Count() == 0)
        //        {
        //            MessageBox.Show(Constants.error_not_list);
        //            cbx_docgia.Focus();

        //            return;
        //        }
        //#endregion

    }
}
