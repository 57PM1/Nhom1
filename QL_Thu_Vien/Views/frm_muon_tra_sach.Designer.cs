namespace DoAnCNPM.Views
{
    partial class frm_muon_tra_sach
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
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.cbx_option_search = new System.Windows.Forms.ComboBox();
            this.btn_in = new System.Windows.Forms.Button();
            this.dtgv_sachmuon = new System.Windows.Forms.DataGridView();
            this.chbox_xacnhantra = new System.Windows.Forms.CheckBox();
            this.dtpk_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.dtpk_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cbx_docgia = new System.Windows.Forms.ComboBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.txt_sotienphat = new System.Windows.Forms.TextBox();
            this.txt_soPM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.lbl_sotienphat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sachmuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(755, 106);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(219, 25);
            this.txt_timkiem.TabIndex = 52;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // cbx_option_search
            // 
            this.cbx_option_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_option_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_option_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_option_search.FormattingEnabled = true;
            this.cbx_option_search.Items.AddRange(new object[] {
            "Mã khoa",
            "Tên khoa",
            "Địa chỉ",
            "Điện thoại"});
            this.cbx_option_search.Location = new System.Drawing.Point(639, 105);
            this.cbx_option_search.Name = "cbx_option_search";
            this.cbx_option_search.Size = new System.Drawing.Size(110, 25);
            this.cbx_option_search.TabIndex = 53;
            // 
            // btn_in
            // 
            this.btn_in.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Location = new System.Drawing.Point(48, 241);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(68, 48);
            this.btn_in.TabIndex = 47;
            this.btn_in.Text = "IN";
            this.btn_in.UseVisualStyleBackColor = false;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // dtgv_sachmuon
            // 
            this.dtgv_sachmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_sachmuon.Location = new System.Drawing.Point(138, 207);
            this.dtgv_sachmuon.Name = "dtgv_sachmuon";
            this.dtgv_sachmuon.Size = new System.Drawing.Size(362, 147);
            this.dtgv_sachmuon.TabIndex = 48;
            this.dtgv_sachmuon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_sachmuon_CellEndEdit);
            this.dtgv_sachmuon.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgv_sachmuon_EditingControlShowing);
            // 
            // chbox_xacnhantra
            // 
            this.chbox_xacnhantra.AutoSize = true;
            this.chbox_xacnhantra.Location = new System.Drawing.Point(100, 134);
            this.chbox_xacnhantra.Name = "chbox_xacnhantra";
            this.chbox_xacnhantra.Size = new System.Drawing.Size(104, 21);
            this.chbox_xacnhantra.TabIndex = 14;
            this.chbox_xacnhantra.Text = "Xác nhận trả";
            this.chbox_xacnhantra.UseVisualStyleBackColor = true;
            // 
            // dtpk_ngaymuon
            // 
            this.dtpk_ngaymuon.CustomFormat = "dd/MM/yyyy";
            this.dtpk_ngaymuon.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpk_ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_ngaymuon.Location = new System.Drawing.Point(344, 51);
            this.dtpk_ngaymuon.Name = "dtpk_ngaymuon";
            this.dtpk_ngaymuon.Size = new System.Drawing.Size(158, 25);
            this.dtpk_ngaymuon.TabIndex = 13;
            this.dtpk_ngaymuon.Value = new System.DateTime(2016, 5, 30, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(541, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Tìm kiếm theo";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 42);
            this.label1.TabIndex = 47;
            this.label1.Text = "QUẢN LÝ MƯỢN /TRẢ SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(541, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Danh sách phiếu mượn";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToOrderColumns = true;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.GridColor = System.Drawing.SystemColors.Control;
            this.dtgv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgv.Location = new System.Drawing.Point(540, 167);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(712, 417);
            this.dtgv.TabIndex = 51;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // dtpk_ngaytra
            // 
            this.dtpk_ngaytra.CustomFormat = "dd/MM/yyyy";
            this.dtpk_ngaytra.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpk_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_ngaytra.Location = new System.Drawing.Point(344, 91);
            this.dtpk_ngaytra.Name = "dtpk_ngaytra";
            this.dtpk_ngaytra.Size = new System.Drawing.Size(158, 25);
            this.dtpk_ngaytra.TabIndex = 3;
            this.dtpk_ngaytra.Value = new System.DateTime(2016, 6, 7, 0, 0, 0, 0);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghichu.Location = new System.Drawing.Point(344, 131);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(158, 57);
            this.txt_ghichu.TabIndex = 4;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Moccasin;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Location = new System.Drawing.Point(183, 422);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 42);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(25, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số PM";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btn_in);
            this.groupBox1.Controls.Add(this.dtgv_sachmuon);
            this.groupBox1.Controls.Add(this.chbox_xacnhantra);
            this.groupBox1.Controls.Add(this.dtpk_ngaymuon);
            this.groupBox1.Controls.Add(this.dtpk_ngaytra);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.cbx_docgia);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.txt_sotienphat);
            this.groupBox1.Controls.Add(this.txt_ghichu);
            this.groupBox1.Controls.Add(this.txt_soPM);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.lbl_sotienphat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 489);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu mượn";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Moccasin;
            this.btn_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Location = new System.Drawing.Point(425, 422);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 42);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbx_docgia
            // 
            this.cbx_docgia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_docgia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_docgia.FormattingEnabled = true;
            this.cbx_docgia.Location = new System.Drawing.Point(100, 91);
            this.cbx_docgia.Name = "cbx_docgia";
            this.cbx_docgia.Size = new System.Drawing.Size(158, 25);
            this.cbx_docgia.TabIndex = 1;
            this.cbx_docgia.Leave += new System.EventHandler(this.cbx_docgia_Leave);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.Moccasin;
            this.btn_huy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_huy.Location = new System.Drawing.Point(342, 422);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 42);
            this.btn_huy.TabIndex = 11;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // txt_sotienphat
            // 
            this.txt_sotienphat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotienphat.Location = new System.Drawing.Point(367, 373);
            this.txt_sotienphat.Multiline = true;
            this.txt_sotienphat.Name = "txt_sotienphat";
            this.txt_sotienphat.ReadOnly = true;
            this.txt_sotienphat.Size = new System.Drawing.Size(133, 26);
            this.txt_sotienphat.TabIndex = 4;
            this.txt_sotienphat.Visible = false;
            // 
            // txt_soPM
            // 
            this.txt_soPM.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soPM.Location = new System.Drawing.Point(100, 51);
            this.txt_soPM.Name = "txt_soPM";
            this.txt_soPM.ReadOnly = true;
            this.txt_soPM.Size = new System.Drawing.Size(158, 25);
            this.txt_soPM.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(268, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày trả";
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.Moccasin;
            this.btn_luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_luu.Location = new System.Drawing.Point(262, 422);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 42);
            this.btn_luu.TabIndex = 7;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Moccasin;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sua.Location = new System.Drawing.Point(98, 422);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 42);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(267, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ngày mượn";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(25, 94);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Độc giả";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Moccasin;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.Location = new System.Drawing.Point(17, 422);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 42);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lbl_sotienphat
            // 
            this.lbl_sotienphat.AutoSize = true;
            this.lbl_sotienphat.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sotienphat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_sotienphat.Location = new System.Drawing.Point(266, 379);
            this.lbl_sotienphat.Name = "lbl_sotienphat";
            this.lbl_sotienphat.Size = new System.Drawing.Size(95, 20);
            this.lbl_sotienphat.TabIndex = 2;
            this.lbl_sotienphat.Text = "Số tiền phạt";
            this.lbl_sotienphat.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(267, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi chú";
            // 
            // frm_muon_tra_sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 596);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.cbx_option_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_muon_tra_sach";
            this.Text = "frm_muon_tra_sach";
            this.Load += new System.EventHandler(this.frm_capnhat_docgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sachmuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.ComboBox cbx_option_search;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.DataGridView dtgv_sachmuon;
        private System.Windows.Forms.CheckBox chbox_xacnhantra;
        private System.Windows.Forms.DateTimePicker dtpk_ngaymuon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DateTimePicker dtpk_ngaytra;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cbx_docgia;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.TextBox txt_sotienphat;
        private System.Windows.Forms.TextBox txt_soPM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lbl_sotienphat;
        private System.Windows.Forms.Label label3;
    }
}