﻿namespace DoAnCNPM.Views
{
    partial class frm_capnhat_sach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sotrang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpk_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbx_linhvuc = new System.Windows.Forms.ComboBox();
            this.cbx_nxb = new System.Windows.Forms.ComboBox();
            this.txt_slht = new System.Windows.Forms.TextBox();
            this.txt_slbd = new System.Windows.Forms.TextBox();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_option_search = new System.Windows.Forms.ComboBox();
            this.lst_tacgia_rs = new System.Windows.Forms.ListView();
            this.matg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tentg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_tacgias = new System.Windows.Forms.ComboBox();
            this.btn_them_tacgia = new System.Windows.Forms.Button();
            this.btn_xoa_tacgia = new System.Windows.Forms.Button();
            this.btn_them_slbd = new System.Windows.Forms.Button();
            this.btn_them_slht = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.GridColor = System.Drawing.SystemColors.Control;
            this.dtgv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgv.Location = new System.Drawing.Point(543, 12);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(725, 401);
            this.dtgv.TabIndex = 36;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // txt_masach
            // 
            this.txt_masach.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masach.Location = new System.Drawing.Point(91, 36);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.ReadOnly = true;
            this.txt_masach.Size = new System.Drawing.Size(158, 25);
            this.txt_masach.TabIndex = 10;
            this.txt_masach.TextChanged += new System.EventHandler(this.txt_masach_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(273, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Lĩnh vực";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(16, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(273, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày nhập";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(754, 431);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(219, 25);
            this.txt_timkiem.TabIndex = 32;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(541, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tìm kiếm theo";
            // 
            // txt_sotrang
            // 
            this.txt_sotrang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotrang.Location = new System.Drawing.Point(348, 76);
            this.txt_sotrang.Multiline = true;
            this.txt_sotrang.Name = "txt_sotrang";
            this.txt_sotrang.Size = new System.Drawing.Size(158, 25);
            this.txt_sotrang.TabIndex = 5;
            this.txt_sotrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sotrang_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_them_slht);
            this.groupBox1.Controls.Add(this.btn_them_slbd);
            this.groupBox1.Controls.Add(this.dtpk_ngaynhap);
            this.groupBox1.Controls.Add(this.cbx_linhvuc);
            this.groupBox1.Controls.Add(this.cbx_nxb);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_slht);
            this.groupBox1.Controls.Add(this.txt_slbd);
            this.groupBox1.Controls.Add(this.txt_sotrang);
            this.groupBox1.Controls.Add(this.txt_masach);
            this.groupBox1.Controls.Add(this.txt_tensach);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 309);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sách";
            // 
            // dtpk_ngaynhap
            // 
            this.dtpk_ngaynhap.CustomFormat = "dd/MM/yyyy";
            this.dtpk_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_ngaynhap.Location = new System.Drawing.Point(348, 154);
            this.dtpk_ngaynhap.Name = "dtpk_ngaynhap";
            this.dtpk_ngaynhap.Size = new System.Drawing.Size(158, 25);
            this.dtpk_ngaynhap.TabIndex = 13;
            this.dtpk_ngaynhap.Value = new System.DateTime(2015, 11, 20, 17, 0, 0, 0);
            // 
            // cbx_linhvuc
            // 
            this.cbx_linhvuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_linhvuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_linhvuc.FormattingEnabled = true;
            this.cbx_linhvuc.Location = new System.Drawing.Point(348, 40);
            this.cbx_linhvuc.Name = "cbx_linhvuc";
            this.cbx_linhvuc.Size = new System.Drawing.Size(158, 25);
            this.cbx_linhvuc.TabIndex = 4;
            this.cbx_linhvuc.Leave += new System.EventHandler(this.cbx_linhvuc_Leave);
            // 
            // cbx_nxb
            // 
            this.cbx_nxb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_nxb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_nxb.FormattingEnabled = true;
            this.cbx_nxb.Location = new System.Drawing.Point(91, 155);
            this.cbx_nxb.Name = "cbx_nxb";
            this.cbx_nxb.Size = new System.Drawing.Size(158, 25);
            this.cbx_nxb.TabIndex = 3;
            this.cbx_nxb.Leave += new System.EventHandler(this.cbx_nxb_Leave);
            // 
            // txt_slht
            // 
            this.txt_slht.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slht.Location = new System.Drawing.Point(91, 111);
            this.txt_slht.Multiline = true;
            this.txt_slht.Name = "txt_slht";
            this.txt_slht.Size = new System.Drawing.Size(115, 25);
            this.txt_slht.TabIndex = 6;
            this.txt_slht.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sotrang_KeyPress);
            // 
            // txt_slbd
            // 
            this.txt_slbd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slbd.Location = new System.Drawing.Point(348, 111);
            this.txt_slbd.Multiline = true;
            this.txt_slbd.Name = "txt_slbd";
            this.txt_slbd.Size = new System.Drawing.Size(115, 25);
            this.txt_slbd.TabIndex = 6;
            this.txt_slbd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sotrang_KeyPress);
            // 
            // txt_tensach
            // 
            this.txt_tensach.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensach.Location = new System.Drawing.Point(91, 76);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(158, 25);
            this.txt_tensach.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "SL hiện tại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(273, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "SL ban đầu";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(16, 79);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(273, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số trang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà XB";
            // 
            // cbx_option_search
            // 
            this.cbx_option_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_option_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_option_search.FormattingEnabled = true;
            this.cbx_option_search.Items.AddRange(new object[] {
            "Mã khoa",
            "Tên khoa",
            "Địa chỉ",
            "Điện thoại"});
            this.cbx_option_search.Location = new System.Drawing.Point(639, 431);
            this.cbx_option_search.Name = "cbx_option_search";
            this.cbx_option_search.Size = new System.Drawing.Size(110, 25);
            this.cbx_option_search.TabIndex = 33;
            this.cbx_option_search.SelectedIndexChanged += new System.EventHandler(this.cbx_option_search_SelectedIndexChanged);
            // 
            // lst_tacgia_rs
            // 
            this.lst_tacgia_rs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.matg,
            this.tentg});
            this.lst_tacgia_rs.FullRowSelect = true;
            this.lst_tacgia_rs.Location = new System.Drawing.Point(101, 12);
            this.lst_tacgia_rs.Name = "lst_tacgia_rs";
            this.lst_tacgia_rs.Size = new System.Drawing.Size(158, 113);
            this.lst_tacgia_rs.TabIndex = 37;
            this.lst_tacgia_rs.UseCompatibleStateImageBehavior = false;
            this.lst_tacgia_rs.View = System.Windows.Forms.View.Details;
            // 
            // matg
            // 
            this.matg.Text = "Mã tác giả";
            this.matg.Width = 64;
            // 
            // tentg
            // 
            this.tentg.Text = "Tên tác giả";
            this.tentg.Width = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(26, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tác giả";
            // 
            // cbx_tacgias
            // 
            this.cbx_tacgias.FormattingEnabled = true;
            this.cbx_tacgias.Location = new System.Drawing.Point(358, 12);
            this.cbx_tacgias.Name = "cbx_tacgias";
            this.cbx_tacgias.Size = new System.Drawing.Size(158, 21);
            this.cbx_tacgias.TabIndex = 38;
            // 
            // btn_them_tacgia
            // 
            this.btn_them_tacgia.Location = new System.Drawing.Point(286, 10);
            this.btn_them_tacgia.Name = "btn_them_tacgia";
            this.btn_them_tacgia.Size = new System.Drawing.Size(43, 23);
            this.btn_them_tacgia.TabIndex = 39;
            this.btn_them_tacgia.Text = "Thêm tác giả";
            this.btn_them_tacgia.UseVisualStyleBackColor = true;
            this.btn_them_tacgia.Click += new System.EventHandler(this.btn_them_tacgia_Click);
            // 
            // btn_xoa_tacgia
            // 
            this.btn_xoa_tacgia.Location = new System.Drawing.Point(286, 39);
            this.btn_xoa_tacgia.Name = "btn_xoa_tacgia";
            this.btn_xoa_tacgia.Size = new System.Drawing.Size(43, 23);
            this.btn_xoa_tacgia.TabIndex = 39;
            this.btn_xoa_tacgia.Text = "Xóa";
            this.btn_xoa_tacgia.UseVisualStyleBackColor = true;
            this.btn_xoa_tacgia.Click += new System.EventHandler(this.btn_xoa_tacgia_Click);
            // 
            // btn_them_slbd
            // 
            this.btn_them_slbd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_slbd.Location = new System.Drawing.Point(469, 108);
            this.btn_them_slbd.Name = "btn_them_slbd";
            this.btn_them_slbd.Size = new System.Drawing.Size(37, 32);
            this.btn_them_slbd.TabIndex = 14;
            this.btn_them_slbd.Text = "+";
            this.btn_them_slbd.UseVisualStyleBackColor = true;
            this.btn_them_slbd.Click += new System.EventHandler(this.btn_add_soluong_bandau_Click);
            // 
            // btn_them_slht
            // 
            this.btn_them_slht.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_slht.Location = new System.Drawing.Point(212, 108);
            this.btn_them_slht.Name = "btn_them_slht";
            this.btn_them_slht.Size = new System.Drawing.Size(37, 32);
            this.btn_them_slht.TabIndex = 14;
            this.btn_them_slht.Text = "+";
            this.btn_them_slht.UseVisualStyleBackColor = true;
            this.btn_them_slht.Click += new System.EventHandler(this.btn_add_soluong_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Red;
            this.btn_thoat.BackgroundImage = global::DoAnCNPM.Properties.Resources.Thoat;
            this.btn_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Location = new System.Drawing.Point(431, 207);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 59);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_huy.BackgroundImage = global::DoAnCNPM.Properties.Resources.Huy;
            this.btn_huy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_huy.Location = new System.Drawing.Point(351, 207);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 59);
            this.btn_huy.TabIndex = 11;
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_xoa.BackgroundImage = global::DoAnCNPM.Properties.Resources.Xoa;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Location = new System.Drawing.Point(182, 207);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 59);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_luu.BackgroundImage = global::DoAnCNPM.Properties.Resources.Luu;
            this.btn_luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_luu.Location = new System.Drawing.Point(268, 207);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 59);
            this.btn_luu.TabIndex = 7;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sua.BackgroundImage = global::DoAnCNPM.Properties.Resources.sua;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sua.Location = new System.Drawing.Point(99, 207);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 59);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_them.BackgroundImage = global::DoAnCNPM.Properties.Resources.Them;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.Location = new System.Drawing.Point(16, 207);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 59);
            this.btn_them.TabIndex = 8;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // frm_capnhat_sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 490);
            this.Controls.Add(this.btn_xoa_tacgia);
            this.Controls.Add(this.btn_them_tacgia);
            this.Controls.Add(this.cbx_tacgias);
            this.Controls.Add(this.lst_tacgia_rs);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbx_option_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_capnhat_sach";
            this.Text = "frm_capnhat_sach";
            this.Load += new System.EventHandler(this.frm_capnhat_sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_sotrang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_option_search;
        private System.Windows.Forms.TextBox txt_slbd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_linhvuc;
        private System.Windows.Forms.ComboBox cbx_nxb;
        private System.Windows.Forms.DateTimePicker dtpk_ngaynhap;
        private System.Windows.Forms.TextBox txt_slht;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lst_tacgia_rs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader matg;
        private System.Windows.Forms.ColumnHeader tentg;
        private System.Windows.Forms.ComboBox cbx_tacgias;
        private System.Windows.Forms.Button btn_them_tacgia;
        private System.Windows.Forms.Button btn_xoa_tacgia;
        private System.Windows.Forms.Button btn_them_slht;
        private System.Windows.Forms.Button btn_them_slbd;
    }
}