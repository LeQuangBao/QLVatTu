namespace WinForm {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_MaLoai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ThongSoKyThuat = new System.Windows.Forms.TextBox();
            this.tb_DonVi = new System.Windows.Forms.TextBox();
            this.tb_TenLoai = new System.Windows.Forms.TextBox();
            this.tb_DonGia = new System.Windows.Forms.TextBox();
            this.tb_NamSanXuat = new System.Windows.Forms.TextBox();
            this.dgv_Loai = new System.Windows.Forms.DataGridView();
            this.cln_MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_NamSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_ThongSoKyThuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_XoaLoai = new System.Windows.Forms.Button();
            this.btn_SuaLoai = new System.Windows.Forms.Button();
            this.btn_ThemLoai = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_ThongKe_ChonLoai = new System.Windows.Forms.ComboBox();
            this.dtp_ThongKe = new System.Windows.Forms.DateTimePicker();
            this.dgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.clnMaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLoaiThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThongSoKyThuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNamSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNgayDuaVaoSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_SoLuongThanhLy = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_SoLuongDaHu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_SoLuongDangDung = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_SoLuongConDungDuoc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loaiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyVatTuDataSet = new WinForm.QuanLyVatTuDataSet();
            this.loaiTableAdapter1 = new WinForm.QuanLyVatTuDataSetTableAdapters.LoaiTableAdapter();
            this.tenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongSoKyThuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maThietBiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDuaVaoSuDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thietBiDataSet = new WinForm.ThietBiDataSet();
            this.loaiTableAdapter = new WinForm.ThietBiDataSetTableAdapters.LoaiTableAdapter();
            this.TenTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyVatTuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thietBiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê nhanh";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenLoaiDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn,
            this.thongSoKyThuatDataGridViewTextBoxColumn,
            this.namSanXuatDataGridViewTextBoxColumn,
            this.maThietBiDataGridViewTextBoxColumn,
            this.ngayDuaVaoSuDungDataGridViewTextBoxColumn,
            this.TenTinhTrang});
            this.dataGridView1.DataSource = this.loaiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_ThemLoai);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý loại";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.dgv_Loai);
            this.groupBox1.Controls.Add(this.btn_XoaLoai);
            this.groupBox1.Controls.Add(this.btn_SuaLoai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 407);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(495, 107);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(75, 23);
            this.btn_LamMoi.TabIndex = 6;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.16704F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.83296F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_MaLoai, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_ThongSoKyThuat, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_DonVi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_TenLoai, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_DonGia, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_NamSanXuat, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 138);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Năm sản xuất";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại";
            // 
            // lb_MaLoai
            // 
            this.lb_MaLoai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_MaLoai.AutoSize = true;
            this.lb_MaLoai.Location = new System.Drawing.Point(119, 4);
            this.lb_MaLoai.Name = "lb_MaLoai";
            this.lb_MaLoai.Size = new System.Drawing.Size(16, 13);
            this.lb_MaLoai.TabIndex = 4;
            this.lb_MaLoai.Text = "---";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn vị";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thông số kỹ thuật";
            // 
            // tb_ThongSoKyThuat
            // 
            this.tb_ThongSoKyThuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ThongSoKyThuat.Location = new System.Drawing.Point(119, 91);
            this.tb_ThongSoKyThuat.Name = "tb_ThongSoKyThuat";
            this.tb_ThongSoKyThuat.Size = new System.Drawing.Size(340, 20);
            this.tb_ThongSoKyThuat.TabIndex = 1;
            // 
            // tb_DonVi
            // 
            this.tb_DonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DonVi.Location = new System.Drawing.Point(119, 69);
            this.tb_DonVi.Name = "tb_DonVi";
            this.tb_DonVi.Size = new System.Drawing.Size(340, 20);
            this.tb_DonVi.TabIndex = 1;
            // 
            // tb_TenLoai
            // 
            this.tb_TenLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TenLoai.Location = new System.Drawing.Point(119, 25);
            this.tb_TenLoai.Name = "tb_TenLoai";
            this.tb_TenLoai.Size = new System.Drawing.Size(340, 20);
            this.tb_TenLoai.TabIndex = 1;
            // 
            // tb_DonGia
            // 
            this.tb_DonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DonGia.Location = new System.Drawing.Point(119, 47);
            this.tb_DonGia.Name = "tb_DonGia";
            this.tb_DonGia.Size = new System.Drawing.Size(340, 20);
            this.tb_DonGia.TabIndex = 1;
            // 
            // tb_NamSanXuat
            // 
            this.tb_NamSanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NamSanXuat.Location = new System.Drawing.Point(119, 114);
            this.tb_NamSanXuat.Name = "tb_NamSanXuat";
            this.tb_NamSanXuat.Size = new System.Drawing.Size(340, 20);
            this.tb_NamSanXuat.TabIndex = 1;
            // 
            // dgv_Loai
            // 
            this.dgv_Loai.AllowUserToAddRows = false;
            this.dgv_Loai.AllowUserToDeleteRows = false;
            this.dgv_Loai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Loai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_MaLoai,
            this.cln_TenLoai,
            this.TenDonViTinh,
            this.cln_DonGia,
            this.cln_NamSanXuat,
            this.cln_ThongSoKyThuat});
            this.dgv_Loai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Loai.Location = new System.Drawing.Point(3, 163);
            this.dgv_Loai.Name = "dgv_Loai";
            this.dgv_Loai.ReadOnly = true;
            this.dgv_Loai.Size = new System.Drawing.Size(884, 241);
            this.dgv_Loai.TabIndex = 3;
            this.dgv_Loai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Loai_CellContentClick);
            // 
            // cln_MaLoai
            // 
            this.cln_MaLoai.HeaderText = "Mã Loại";
            this.cln_MaLoai.Name = "cln_MaLoai";
            this.cln_MaLoai.ReadOnly = true;
            // 
            // cln_TenLoai
            // 
            this.cln_TenLoai.HeaderText = "Tên Loại";
            this.cln_TenLoai.Name = "cln_TenLoai";
            this.cln_TenLoai.ReadOnly = true;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.DataPropertyName = "TenDonViTinh";
            this.TenDonViTinh.HeaderText = "Đơn Vị";
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.ReadOnly = true;
            // 
            // cln_DonGia
            // 
            this.cln_DonGia.HeaderText = "Đơn Giá";
            this.cln_DonGia.Name = "cln_DonGia";
            this.cln_DonGia.ReadOnly = true;
            // 
            // cln_NamSanXuat
            // 
            this.cln_NamSanXuat.HeaderText = "Năm Sản Xuất";
            this.cln_NamSanXuat.Name = "cln_NamSanXuat";
            this.cln_NamSanXuat.ReadOnly = true;
            // 
            // cln_ThongSoKyThuat
            // 
            this.cln_ThongSoKyThuat.HeaderText = "Thông số kỹ thuật";
            this.cln_ThongSoKyThuat.Name = "cln_ThongSoKyThuat";
            this.cln_ThongSoKyThuat.ReadOnly = true;
            // 
            // btn_XoaLoai
            // 
            this.btn_XoaLoai.Location = new System.Drawing.Point(495, 62);
            this.btn_XoaLoai.Name = "btn_XoaLoai";
            this.btn_XoaLoai.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaLoai.TabIndex = 2;
            this.btn_XoaLoai.Text = "Xóa";
            this.btn_XoaLoai.UseVisualStyleBackColor = true;
            this.btn_XoaLoai.Click += new System.EventHandler(this.btn_XoaLoai_Click);
            // 
            // btn_SuaLoai
            // 
            this.btn_SuaLoai.Location = new System.Drawing.Point(495, 19);
            this.btn_SuaLoai.Name = "btn_SuaLoai";
            this.btn_SuaLoai.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaLoai.TabIndex = 2;
            this.btn_SuaLoai.Text = "Sửa loại";
            this.btn_SuaLoai.UseVisualStyleBackColor = true;
            this.btn_SuaLoai.Click += new System.EventHandler(this.btn_SuaLoai_Click);
            // 
            // btn_ThemLoai
            // 
            this.btn_ThemLoai.Location = new System.Drawing.Point(6, 6);
            this.btn_ThemLoai.Name = "btn_ThemLoai";
            this.btn_ThemLoai.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemLoai.TabIndex = 2;
            this.btn_ThemLoai.Text = "Thêm loại";
            this.btn_ThemLoai.UseVisualStyleBackColor = true;
            this.btn_ThemLoai.Click += new System.EventHandler(this.btn_ThemLoai_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(896, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê chi tiết";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.cb_ThongKe_ChonLoai, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtp_ThongKe, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgv_ThongKe, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_ThongKe, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05263F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.94736F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(890, 434);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cb_ThongKe_ChonLoai
            // 
            this.cb_ThongKe_ChonLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ThongKe_ChonLoai.FormattingEnabled = true;
            this.cb_ThongKe_ChonLoai.Location = new System.Drawing.Point(3, 11);
            this.cb_ThongKe_ChonLoai.Name = "cb_ThongKe_ChonLoai";
            this.cb_ThongKe_ChonLoai.Size = new System.Drawing.Size(290, 21);
            this.cb_ThongKe_ChonLoai.TabIndex = 1;
            // 
            // dtp_ThongKe
            // 
            this.dtp_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_ThongKe.Location = new System.Drawing.Point(299, 11);
            this.dtp_ThongKe.Name = "dtp_ThongKe";
            this.dtp_ThongKe.Size = new System.Drawing.Size(290, 20);
            this.dtp_ThongKe.TabIndex = 2;
            // 
            // dgv_ThongKe
            // 
            this.dgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMaThietBi,
            this.clnLoaiThietBi,
            this.clnDonGia,
            this.clnDonVi,
            this.clnThongSoKyThuat,
            this.clnNamSanXuat,
            this.clnNgayDuaVaoSuDung,
            this.clnTinhTrang});
            this.tableLayoutPanel2.SetColumnSpan(this.dgv_ThongKe, 3);
            this.dgv_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThongKe.Location = new System.Drawing.Point(3, 88);
            this.dgv_ThongKe.Name = "dgv_ThongKe";
            this.dgv_ThongKe.Size = new System.Drawing.Size(884, 343);
            this.dgv_ThongKe.TabIndex = 4;
            // 
            // clnMaThietBi
            // 
            this.clnMaThietBi.HeaderText = "Mã Thiết Bị";
            this.clnMaThietBi.Name = "clnMaThietBi";
            this.clnMaThietBi.ReadOnly = true;
            // 
            // clnLoaiThietBi
            // 
            this.clnLoaiThietBi.HeaderText = "Loại";
            this.clnLoaiThietBi.Name = "clnLoaiThietBi";
            this.clnLoaiThietBi.ReadOnly = true;
            // 
            // clnDonGia
            // 
            this.clnDonGia.HeaderText = "Đơn giá";
            this.clnDonGia.Name = "clnDonGia";
            this.clnDonGia.ReadOnly = true;
            // 
            // clnDonVi
            // 
            this.clnDonVi.HeaderText = "Đơn Vị";
            this.clnDonVi.Name = "clnDonVi";
            this.clnDonVi.ReadOnly = true;
            // 
            // clnThongSoKyThuat
            // 
            this.clnThongSoKyThuat.HeaderText = "Thông Số Kỹ Thuật";
            this.clnThongSoKyThuat.Name = "clnThongSoKyThuat";
            this.clnThongSoKyThuat.ReadOnly = true;
            // 
            // clnNamSanXuat
            // 
            this.clnNamSanXuat.HeaderText = "Năm sản xuất";
            this.clnNamSanXuat.Name = "clnNamSanXuat";
            this.clnNamSanXuat.ReadOnly = true;
            // 
            // clnNgayDuaVaoSuDung
            // 
            this.clnNgayDuaVaoSuDung.HeaderText = "Ngày đưa vào sử dụng";
            this.clnNgayDuaVaoSuDung.Name = "clnNgayDuaVaoSuDung";
            // 
            // clnTinhTrang
            // 
            this.clnTinhTrang.HeaderText = "Tình Trạng";
            this.clnTinhTrang.Name = "clnTinhTrang";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThongKe.Location = new System.Drawing.Point(595, 12);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(292, 19);
            this.btn_ThongKe.TabIndex = 4;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 9;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.label15, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_SoLuongThanhLy, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_SoLuongDaHu, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_SoLuongDangDung, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_SoLuongConDungDuoc, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(884, 36);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(787, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "Thanh lý";
            // 
            // lbl_SoLuongThanhLy
            // 
            this.lbl_SoLuongThanhLy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_SoLuongThanhLy.AutoSize = true;
            this.lbl_SoLuongThanhLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SoLuongThanhLy.Location = new System.Drawing.Point(771, 10);
            this.lbl_SoLuongThanhLy.Name = "lbl_SoLuongThanhLy";
            this.lbl_SoLuongThanhLy.Size = new System.Drawing.Size(10, 15);
            this.lbl_SoLuongThanhLy.TabIndex = 7;
            this.lbl_SoLuongThanhLy.Text = " ";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(591, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Đã hư";
            // 
            // lbl_SoLuongDaHu
            // 
            this.lbl_SoLuongDaHu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_SoLuongDaHu.AutoSize = true;
            this.lbl_SoLuongDaHu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SoLuongDaHu.Location = new System.Drawing.Point(575, 10);
            this.lbl_SoLuongDaHu.Name = "lbl_SoLuongDaHu";
            this.lbl_SoLuongDaHu.Size = new System.Drawing.Size(10, 15);
            this.lbl_SoLuongDaHu.TabIndex = 5;
            this.lbl_SoLuongDaHu.Text = " ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(395, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Đang dùng";
            // 
            // lbl_SoLuongDangDung
            // 
            this.lbl_SoLuongDangDung.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_SoLuongDangDung.AutoSize = true;
            this.lbl_SoLuongDangDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SoLuongDangDung.Location = new System.Drawing.Point(379, 10);
            this.lbl_SoLuongDangDung.Name = "lbl_SoLuongDangDung";
            this.lbl_SoLuongDangDung.Size = new System.Drawing.Size(10, 15);
            this.lbl_SoLuongDangDung.TabIndex = 3;
            this.lbl_SoLuongDangDung.Text = " ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(199, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Còn dùng được";
            // 
            // lbl_SoLuongConDungDuoc
            // 
            this.lbl_SoLuongConDungDuoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_SoLuongConDungDuoc.AutoSize = true;
            this.lbl_SoLuongConDungDuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SoLuongConDungDuoc.Location = new System.Drawing.Point(183, 10);
            this.lbl_SoLuongConDungDuoc.Name = "lbl_SoLuongConDungDuoc";
            this.lbl_SoLuongConDungDuoc.Size = new System.Drawing.Size(10, 15);
            this.lbl_SoLuongConDungDuoc.TabIndex = 1;
            this.lbl_SoLuongConDungDuoc.Text = " ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(36, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng:";
            // 
            // loaiBindingSource2
            // 
            this.loaiBindingSource2.DataMember = "Loai";
            this.loaiBindingSource2.DataSource = this.quanLyVatTuDataSet;
            // 
            // quanLyVatTuDataSet
            // 
            this.quanLyVatTuDataSet.DataSetName = "QuanLyVatTuDataSet";
            this.quanLyVatTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiTableAdapter1
            // 
            this.loaiTableAdapter1.ClearBeforeFill = true;
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            this.tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.HeaderText = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "DonVi";
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            // 
            // thongSoKyThuatDataGridViewTextBoxColumn
            // 
            this.thongSoKyThuatDataGridViewTextBoxColumn.DataPropertyName = "ThongSoKyThuat";
            this.thongSoKyThuatDataGridViewTextBoxColumn.HeaderText = "ThongSoKyThuat";
            this.thongSoKyThuatDataGridViewTextBoxColumn.Name = "thongSoKyThuatDataGridViewTextBoxColumn";
            // 
            // namSanXuatDataGridViewTextBoxColumn
            // 
            this.namSanXuatDataGridViewTextBoxColumn.DataPropertyName = "NamSanXuat";
            this.namSanXuatDataGridViewTextBoxColumn.HeaderText = "NamSanXuat";
            this.namSanXuatDataGridViewTextBoxColumn.Name = "namSanXuatDataGridViewTextBoxColumn";
            // 
            // maThietBiDataGridViewTextBoxColumn
            // 
            this.maThietBiDataGridViewTextBoxColumn.DataPropertyName = "MaThietBi";
            this.maThietBiDataGridViewTextBoxColumn.HeaderText = "MaThietBi";
            this.maThietBiDataGridViewTextBoxColumn.Name = "maThietBiDataGridViewTextBoxColumn";
            // 
            // ngayDuaVaoSuDungDataGridViewTextBoxColumn
            // 
            this.ngayDuaVaoSuDungDataGridViewTextBoxColumn.DataPropertyName = "NgayDuaVaoSuDung";
            this.ngayDuaVaoSuDungDataGridViewTextBoxColumn.HeaderText = "NgayDuaVaoSuDung";
            this.ngayDuaVaoSuDungDataGridViewTextBoxColumn.Name = "ngayDuaVaoSuDungDataGridViewTextBoxColumn";
            // 
            // loaiBindingSource
            // 
            this.loaiBindingSource.DataMember = "Loai";
            this.loaiBindingSource.DataSource = this.thietBiDataSet;
            // 
            // thietBiDataSet
            // 
            this.thietBiDataSet.DataSetName = "ThietBiDataSet";
            this.thietBiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiTableAdapter
            // 
            this.loaiTableAdapter.ClearBeforeFill = true;
            // 
            // TenTinhTrang
            // 
            this.TenTinhTrang.DataPropertyName = "TenTinhTrang";
            this.TenTinhTrang.HeaderText = "Tình Trạng";
            this.TenTinhTrang.Name = "TenTinhTrang";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 466);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyVatTuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thietBiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ThietBiDataSet thietBiDataSet;
        private System.Windows.Forms.BindingSource loaiBindingSource;
        private ThietBiDataSetTableAdapters.LoaiTableAdapter loaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thongSoKyThuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThietBiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDuaVaoSuDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_ThongSoKyThuat;
        private System.Windows.Forms.TextBox tb_DonVi;
        private System.Windows.Forms.TextBox tb_TenLoai;
        private System.Windows.Forms.TextBox tb_DonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThemLoai;
        private System.Windows.Forms.Button btn_XoaLoai;
        private System.Windows.Forms.Button btn_SuaLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Loai;
        private System.Windows.Forms.Label lb_MaLoai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_NamSanXuat;
        private QuanLyVatTuDataSet quanLyVatTuDataSet;
        private QuanLyVatTuDataSetTableAdapters.LoaiTableAdapter loaiTableAdapter1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cb_ThongKe_ChonLoai;
        private System.Windows.Forms.DateTimePicker dtp_ThongKe;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.BindingSource loaiBindingSource2;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_NamSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_ThongSoKyThuat;
        private System.Windows.Forms.DataGridView dgv_ThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLoaiThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThongSoKyThuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNamSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNgayDuaVaoSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTinhTrang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_SoLuongThanhLy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_SoLuongDaHu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_SoLuongDangDung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_SoLuongConDungDuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTinhTrang;
    }
}

