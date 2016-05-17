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
    public partial class frm_capnhat_phat : Form
    {
        private Option option = Option.Nodata;
        private phat_ett phat = new phat_ett();
        private phat_ctrl phat_ctrl = new phat_ctrl();

        public frm_capnhat_phat()
        {
            InitializeComponent();
            Utils.readOnly_text_box(new List<TextBox> { txt_maphat, txt_loaiphat, txt_giatien}, true);
            btn_delete.Visible = false;
            btn_edit.Visible = false;
            dtgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void load_data()
        {
            var dt = phat_ctrl.select_all();
            switch (dt.errcode)
            {
                case Models.ErrorCode.NaN:
                    dtgv.DataSource = dt.data;
                    break;
                case Models.ErrorCode.sucess:
                    dtgv.DataSource = dt.data;
                    Utils.chang_title_datagridViewCell(dtgv, new List<string> { "Mã mức phạt", "Tên mức phạt", "Số tiền" });
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

        private void frm_capnhat_phat_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow temp = dtgv.Rows[e.RowIndex];
                txt_giatien.Text = temp.Cells[2].Value.ToString();
                txt_maphat.Text = temp.Cells[0].Value.ToString();
                txt_loaiphat.Text = temp.Cells[1].Value.ToString();
                btn_edit.Visible = true;
                btn_delete.Visible= true;
                Utils.readOnly_text_box(new List<TextBox> { txt_maphat, txt_loaiphat, txt_giatien }, true);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            option = Option.Nodata;
            Utils.erase_text_box(new List<TextBox> { txt_maphat, txt_loaiphat, txt_giatien });
            Utils.readOnly_text_box(new List<TextBox> { txt_maphat, txt_loaiphat, txt_giatien }, true);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Utils.erase_text_box(new List<TextBox> { txt_maphat, txt_loaiphat, txt_giatien });
            Utils.readOnly_text_box(new List<TextBox> {txt_loaiphat, txt_giatien }, false);
            txt_loaiphat.Focus();
            option = Option.Insert;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case Option.Nodata:

                    break;

                case Option.Insert:
                    var check_ten = Utils.err_null_data(txt_loaiphat);
                    if (check_ten != null)
                    {
                        MessageBox.Show(check_ten);
                        break;
                    }
                    if (txt_loaiphat!=null && txt_giatien!=null)
                    {
                        int parsedValue;
                        if (!int.TryParse(txt_giatien.Text, out parsedValue))
                        {
                            MessageBox.Show(Constants.not_numberic);
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Constants.empty_data);
                        break;
                    }
                    get_info();
                    //check if existing data
                    var check = true;
                    var data = dtgv.Rows;
                    foreach (DataGridViewRow item in data)
                    {
                        if (int.Parse(item.Cells[0].Value.ToString()) == phat.maphat)
                        {
                            check = false;
                        }
                    }
                    if (!check)
                    {
                        Utils.err_duplicate_data();
                        break;
                    }
                    var temp = phat_ctrl.insert_mucphat(phat);
                    switch (temp.errcode)
                    {
                        case ErrorCode.NaN:
                            break;
                        case ErrorCode.sucess:
                            MessageBox.Show(Constants.success_insert);
                            load_data();
                            Utils.erase_text_box(new List<TextBox> { txt_maphat, txt_loaiphat, txt_giatien });
                            Utils.readOnly_text_box(new List<TextBox> { txt_maphat, txt_loaiphat, txt_giatien }, true);
                            break;
                        case ErrorCode.fail:
                            break;
                        default:
                            break;
                    }
                    break;

                case Option.Edit:
                    if (txt_loaiphat != null && txt_giatien != null)
                    {
                        int parsedValue;
                        if (!int.TryParse(txt_giatien.Text, out parsedValue))
                        {
                            MessageBox.Show(Constants.not_numberic);
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Constants.empty_data);
                        break;
                    }
                    get_info();
                    //check if existing data
                    var check1 = true;
                    var data1 = dtgv.Rows;
                    foreach (DataGridViewRow item in data1)
                    {
                        if (int.Parse(item.Cells[0].Value.ToString()) == phat.maphat)
                        {
                            check1 = false;
                        }
                    }
                    if (check1)
                    {
                        Utils.err_no_duplicate_data();
                        break;
                    }
                    var temp1 = phat_ctrl.edit_phat(phat);
                    switch (temp1.errcode)
                    {
                        case ErrorCode.NaN:
                            break;
                        case ErrorCode.sucess:
                            MessageBox.Show(Constants.success_edit);
                            load_data();
                            Utils.erase_text_box(new List<TextBox> { txt_maphat, txt_loaiphat, txt_giatien });
                            Utils.readOnly_text_box(new List<TextBox> { txt_maphat, txt_loaiphat, txt_giatien }, true);
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            option = Option.Edit;
            Utils.readOnly_text_box(new List<TextBox> { txt_loaiphat, txt_giatien }, false);
        }

        private void get_info()
        {
            if (txt_maphat.Text != null && txt_maphat.Text != "")
            {
                phat.maphat = int.Parse(txt_maphat.Text);
            }
            else phat.maphat = 0;
            phat.loaiphat = txt_loaiphat.Text;
            phat.giatien = int.Parse(txt_giatien.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
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
                        var temp = phat_ctrl.delete_phat(int.Parse(item.Cells[0].Value.ToString()));
                        switch (temp.errcode)
                        {
                            case ErrorCode.NaN:
                                break;
                            case ErrorCode.sucess:
                                Utils.erase_text_box(new List<TextBox> { txt_maphat, txt_loaiphat, txt_giatien });
                                Utils.readOnly_text_box(new List<TextBox> { txt_maphat, txt_loaiphat, txt_giatien }, true);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var temp = phat_ctrl.search_phat(textBox1.Text);
            switch (temp.errcode)
            {
                case ErrorCode.NaN:
                    dtgv.DataSource = temp.data;
                    break;
                case ErrorCode.sucess:
                    dtgv.DataSource = temp.data;
                    Utils.chang_title_datagridViewCell(dtgv, new List<string> { "Mã mức phạt", "Tên mức phạt", "Số tiền" });

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
