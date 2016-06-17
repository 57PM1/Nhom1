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
    public partial class frm_baocao_tienphat : Form
    {

        public partial class Item
        {
            public int Value { get; set; }
            public String Text { get; set; }
        }

        public frm_baocao_tienphat()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        Controllers.baocao_tienphat_ctrl tienphat_ctrl = new Controllers.baocao_tienphat_ctrl();

        public void load_data(int option, int input)
        {
            if (option == 1)
            {
                dataGridView1.DataSource= tienphat_ctrl.select_all_tienphat_month(input, int.Parse(cbx_year.Text));
                Utils.chang_title_datagridViewCell(dataGridView1, new List<string> { "Mã phiếu", "Độc giả", "Ngày mượn", "Ngày trả", "Ghi chú", "Số tiền phạt" });
            }
            else if(option == 2)
            {
                dataGridView1.DataSource = tienphat_ctrl.select_all_tienphat_year(input);
                Utils.chang_title_datagridViewCell(dataGridView1, new List<string> { "Mã phiếu", "Độc giả", "Ngày mượn", "Ngày trả", "Ghi chú", "Số tiền phạt" });
            }
            tongtien();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_option.Text)
            {
                case "Theo tháng":
                    cbx_month.Enabled = true;
                    cbx_month.Items.Clear();
                    for (int i = 1; i < 13; i++)
                    {
                        cbx_month.Items.Add(i);
                    }
                    cbx_month.SelectedValue = DateTime.Now.Month;
                    break;
                case "Theo năm":
                    cbx_year.Items.Clear();
                    for (int i = 0; i < 20; i++)
                    {
                        cbx_year.Items.Add(2000+i);
                    }
                    cbx_year.SelectedValue = DateTime.Now.Year;
                    cbx_month.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void frm_baocao_tienphat_Load(object sender, EventArgs e)
        {

            cbx_option.Items.Add("Theo tháng");
            cbx_option.Items.Add("Theo năm");
            cbx_option.SelectedText = "Theo tháng";
            cbx_month.Items.Clear();
            for (int i = 1; i < 13; i++)
            {
                cbx_month.Items.Add(i);
            }
            cbx_month.SelectedText = DateTime.Now.Month.ToString();
            cbx_year.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                cbx_year.Items.Add(2000 + i);
            }
            cbx_year.SelectedText = DateTime.Now.Year.ToString();
            load_data(1, DateTime.Now.Month);
        }

        private void cbx_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_option.Text)
            {
                case "Theo tháng":
                    load_data(1, int.Parse(cbx_month.Text));
                    break;
                case "Theo năm":
                    load_data(2, int.Parse(cbx_month.Text));
                    break;
                default:
                    break;
            }
        }

        private void cbx_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_option.Text)
            {
                case "Theo tháng":
                    load_data(1, int.Parse(cbx_month.Text));
                    break;
                case "Theo năm":
                    load_data(2, int.Parse(cbx_month.Text));
                    break;
                default:
                    break;
            }
        }

        private void tongtien()
        {
            int sum=0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum = sum + int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            txt_sum.Text = sum.ToString();
        }
    }
}
