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
            this.tenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongSoKyThuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maThietBiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDuaVaoSuDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thietBiDataSet = new WinForm.ThietBiDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongSoKyThuatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSanXuatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyVatTuDataSet = new WinForm.QuanLyVatTuDataSet();
            this.btn_XoaLoai = new System.Windows.Forms.Button();
            this.btn_SuaLoai = new System.Windows.Forms.Button();
            this.btn_ThemLoai = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_ThongKe_ChonLoai = new System.Windows.Forms.ComboBox();
            this.dtp_ThongKe = new System.Windows.Forms.DateTimePicker();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.dgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.clnMaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLoaiThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThongSoKyThuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNamSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTableAdapter = new WinForm.ThietBiDataSetTableAdapters.LoaiTableAdapter();
            this.loaiTableAdapter1 = new WinForm.QuanLyVatTuDataSetTableAdapters.LoaiTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thietBiDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyVatTuDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(680, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 386);
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
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loaiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 380);
            this.dataGridView1.TabIndex = 0;
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
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_ThemLoai);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý loại";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.dgv_Loai);
            this.groupBox1.Controls.Add(this.btn_XoaLoai);
            this.groupBox1.Controls.Add(this.btn_SuaLoai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 352);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Năm sản xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại";
            // 
            // lb_MaLoai
            // 
            this.lb_MaLoai.AutoSize = true;
            this.lb_MaLoai.Location = new System.Drawing.Point(119, 0);
            this.lb_MaLoai.Name = "lb_MaLoai";
            this.lb_MaLoai.Size = new System.Drawing.Size(16, 13);
            this.lb_MaLoai.TabIndex = 4;
            this.lb_MaLoai.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn vị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 88);
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
            this.dgv_Loai.AutoGenerateColumns = false;
            this.dgv_Loai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Loai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiDataGridViewTextBoxColumn,
            this.tenLoaiDataGridViewTextBoxColumn1,
            this.donGiaDataGridViewTextBoxColumn1,
            this.donViDataGridViewTextBoxColumn1,
            this.thongSoKyThuatDataGridViewTextBoxColumn1,
            this.namSanXuatDataGridViewTextBoxColumn1});
            this.dgv_Loai.DataSource = this.loaiBindingSource1;
            this.dgv_Loai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Loai.Location = new System.Drawing.Point(3, 161);
            this.dgv_Loai.Name = "dgv_Loai";
            this.dgv_Loai.Size = new System.Drawing.Size(660, 188);
            this.dgv_Loai.TabIndex = 3;
            this.dgv_Loai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Loai_CellContentClick);
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            // 
            // tenLoaiDataGridViewTextBoxColumn1
            // 
            this.tenLoaiDataGridViewTextBoxColumn1.DataPropertyName = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn1.HeaderText = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn1.Name = "tenLoaiDataGridViewTextBoxColumn1";
            // 
            // donGiaDataGridViewTextBoxColumn1
            // 
            this.donGiaDataGridViewTextBoxColumn1.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn1.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn1.Name = "donGiaDataGridViewTextBoxColumn1";
            // 
            // donViDataGridViewTextBoxColumn1
            // 
            this.donViDataGridViewTextBoxColumn1.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn1.HeaderText = "DonVi";
            this.donViDataGridViewTextBoxColumn1.Name = "donViDataGridViewTextBoxColumn1";
            // 
            // thongSoKyThuatDataGridViewTextBoxColumn1
            // 
            this.thongSoKyThuatDataGridViewTextBoxColumn1.DataPropertyName = "ThongSoKyThuat";
            this.thongSoKyThuatDataGridViewTextBoxColumn1.HeaderText = "ThongSoKyThuat";
            this.thongSoKyThuatDataGridViewTextBoxColumn1.Name = "thongSoKyThuatDataGridViewTextBoxColumn1";
            // 
            // namSanXuatDataGridViewTextBoxColumn1
            // 
            this.namSanXuatDataGridViewTextBoxColumn1.DataPropertyName = "NamSanXuat";
            this.namSanXuatDataGridViewTextBoxColumn1.HeaderText = "NamSanXuat";
            this.namSanXuatDataGridViewTextBoxColumn1.Name = "namSanXuatDataGridViewTextBoxColumn1";
            // 
            // loaiBindingSource1
            // 
            this.loaiBindingSource1.DataMember = "Loai";
            this.loaiBindingSource1.DataSource = this.quanLyVatTuDataSet;
            // 
            // quanLyVatTuDataSet
            // 
            this.quanLyVatTuDataSet.DataSetName = "QuanLyVatTuDataSet";
            this.quanLyVatTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tabPage3.Size = new System.Drawing.Size(672, 386);
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
            this.tableLayoutPanel2.Controls.Add(this.dgv_ThongKe, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_ThongKe, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05263F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.94736F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(666, 380);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cb_ThongKe_ChonLoai
            // 
            this.cb_ThongKe_ChonLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ThongKe_ChonLoai.FormattingEnabled = true;
            this.cb_ThongKe_ChonLoai.Location = new System.Drawing.Point(3, 10);
            this.cb_ThongKe_ChonLoai.Name = "cb_ThongKe_ChonLoai";
            this.cb_ThongKe_ChonLoai.Size = new System.Drawing.Size(216, 21);
            this.cb_ThongKe_ChonLoai.TabIndex = 1;
            // 
            // dtp_ThongKe
            // 
            this.dtp_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_ThongKe.Location = new System.Drawing.Point(225, 11);
            this.dtp_ThongKe.Name = "dtp_ThongKe";
            this.dtp_ThongKe.Size = new System.Drawing.Size(216, 20);
            this.dtp_ThongKe.TabIndex = 2;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThongKe.Location = new System.Drawing.Point(447, 9);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(216, 23);
            this.btn_ThongKe.TabIndex = 4;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
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
            this.clnNamSanXuat});
            this.tableLayoutPanel2.SetColumnSpan(this.dgv_ThongKe, 3);
            this.dgv_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThongKe.Location = new System.Drawing.Point(3, 45);
            this.dgv_ThongKe.Name = "dgv_ThongKe";
            this.dgv_ThongKe.Size = new System.Drawing.Size(660, 332);
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
            // loaiTableAdapter
            // 
            this.loaiTableAdapter.ClearBeforeFill = true;
            // 
            // loaiTableAdapter1
            // 
            this.loaiTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 412);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thietBiDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyVatTuDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.BindingSource loaiBindingSource1;
        private QuanLyVatTuDataSetTableAdapters.LoaiTableAdapter loaiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thongSoKyThuatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSanXuatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cb_ThongKe_ChonLoai;
        private System.Windows.Forms.DateTimePicker dtp_ThongKe;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.DataGridView dgv_ThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLoaiThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThongSoKyThuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNamSanXuat;
    }
}

