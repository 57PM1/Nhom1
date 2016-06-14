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
    public partial class frm_capnhat_xuphat : Form
    {
        public frm_capnhat_xuphat()
        {
            InitializeComponent();
            Utils.readOnly_text_box(new List<TextBox> { txt_lphat, txt_giatien, txt_ma }, true);
            btn_xoa.Enabled = false;
            btn_xoa.BackColor = Color.White;
            btn_sua.Enabled = false;
            btn_sua.BackColor = Color.White;
        }
        xuphat_ctl xp = new xuphat_ctl();
        xuphat_ett xp_ett = new xuphat_ett();
        Option option = new Option();

        private void get_info()
        {
            if (txt_ma.Text != null && txt_ma.Text != "")
            {
                xp_ett.maphat = int.Parse(txt_ma.Text);
            }
            else
                xp_ett.maphat = 0;
            xp_ett.loaiphat = txt_lphat.Text;
            xp_ett.giatien = long.Parse(txt_giatien.Text.ToString());
        }
        private void frm_capnhat_xuphat_Load(object sender, EventArgs e)
        {
            load_data();
            List<how_to_search> dt_source = new List<how_to_search>();
            dt_source.Add(new how_to_search("Loại phạt", "loaiphat"));
            dt_source.Add(new how_to_search("Giá tiền", "giatien"));

            cbx_tk.DataSource = dt_source;
            cbx_tk.DisplayMember = "value";
            cbx_tk.ValueMember = "key";
        }
        private void load_data()
        {
            var dt = xp.select_all_xuphat();
            switch (dt.errcode)
            {
                case Models.ErrorCode.NaN:
                    MessageBox.Show(dt.errInfor);
                    dtg_xuphat.DataSource = dt.data;
                    break;
                case Models.ErrorCode.sucess:
                    dtg_xuphat.DataSource = dt.data;
                    Utils.chang_title_datagridViewCell(dtg_xuphat, new List<string> { "Mã xử phạt", "Loại phạt", "Giá tiền" });
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (Utils.confirm_exit())
            {
                Application.Exit();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            option = Option.Nodata;
            Utils.erase_text_box(new List<TextBox> { txt_lphat, txt_giatien });
            Utils.readOnly_text_box(new List<TextBox> { txt_lphat, txt_giatien }, true);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Utils.erase_text_box(new List<TextBox> { txt_lphat, txt_giatien });
            Utils.readOnly_text_box(new List<TextBox> { txt_lphat, txt_giatien }, false);
            option = Option.Insert;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            option = Option.Edit;
            Utils.readOnly_text_box(new List<TextBox> { txt_lphat, txt_giatien }, false);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case Option.Nodata:

                    break;

                case Option.Insert:
                    var check_ten = Utils.err_null_data(txt_lphat);
                    if (check_ten != null)
                    {
                        MessageBox.Show(check_ten);
                        break;
                    }
                    get_info();
                    //check if existing data
                    var check = true;
                    var data = dtg_xuphat.Rows;
                    foreach (DataGridViewRow item in data)
                    {
                        if (int.Parse(item.Cells[0].Value.ToString()) == xp_ett.maphat)
                        {
                            check = false;
                        }
                    }
                    if (!check)
                    {
                        Utils.err_duplicate_data();
                        break;
                    }
                    var temp = xp.insert_xuphat(xp_ett);
                    switch (temp.errcode)
                    {
                        case ErrorCode.NaN:
                            break;
                        case ErrorCode.sucess:
                            MessageBox.Show(Constants.success_insert);
                            load_data();
                            Utils.erase_text_box(new List<TextBox> { txt_ma, txt_lphat, txt_giatien });
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
                    var data1 = dtg_xuphat.Rows;
                    foreach (DataGridViewRow item in data1)
                    {
                        if (int.Parse(item.Cells[0].Value.ToString()) == xp_ett.maphat)
                        {
                            check1 = false;
                        }
                    }
                    if (check1)
                    {
                        Utils.err_no_duplicate_data();
                        break;
                    }
                    var temp1 = xp.update_xuphat(xp_ett);
                    switch (temp1.errcode)
                    {
                        case ErrorCode.NaN:
                            break;
                        case ErrorCode.sucess:
                            MessageBox.Show(Constants.success_edit);
                            load_data();
                            Utils.erase_text_box(new List<TextBox> { txt_ma,txt_lphat,txt_giatien });
                            Utils.readOnly_text_box(new List<TextBox> { txt_lphat, txt_giatien}, true);
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
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow temp = dtg_xuphat.Rows[e.RowIndex];
                txt_ma.Text = temp.Cells[0].Value.ToString();
                txt_lphat.Text = temp.Cells[1].Value.ToString();
                txt_giatien.Text = temp.Cells[2].Value.ToString();
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var selected_r = dtg_xuphat.SelectedRows;
            if (selected_r.Count > 0)
            {
                if (Utils.confirm_delete())
                {
                    bool check = true;
                    string err_infor = "";
                    foreach (DataGridViewRow item in selected_r)
                    {
                        var temp = xp.delete_xuphat(int.Parse(item.Cells[0].Value.ToString()));
                        switch (temp.errcode)
                        {
                            case ErrorCode.NaN:
                                break;
                            case ErrorCode.sucess:
                                Utils.erase_text_box(new List<TextBox> { txt_ma, txt_lphat, txt_giatien });
                                Utils.readOnly_text_box(new List<TextBox> { txt_lphat, txt_giatien }, true);
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var select_cbx = cbx_tk.SelectedValue.ToString();
            var temp = xp.select_xuphat_fields(txt_search.Text, select_cbx);
            switch (temp.errcode)
            {
                case ErrorCode.NaN:
                    dtg_xuphat.DataSource = temp.data;
                    break;
                case ErrorCode.sucess:
                    dtg_xuphat.DataSource = temp.data;
                    Utils.chang_title_datagridViewCell(dtg_xuphat, new List<string> { "Mã xử phạt", "Loại phạt", "Giá tiền"});

                    break;
                case ErrorCode.fail:
                    dtg_xuphat.DataSource = temp.data;
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
