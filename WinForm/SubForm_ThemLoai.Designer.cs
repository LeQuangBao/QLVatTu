namespace WinForm {
    partial class SubForm_ThemLoai {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ThongSoKyThuat = new System.Windows.Forms.TextBox();
            this.tb_DonVi = new System.Windows.Forms.TextBox();
            this.tb_TenLoai = new System.Windows.Forms.TextBox();
            this.tb_DonGia = new System.Windows.Forms.TextBox();
            this.tb_NamSanXuat = new System.Windows.Forms.TextBox();
            this.btn_ThemLoai = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.16704F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.83296F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_ThongSoKyThuat, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_DonVi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_TenLoai, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_DonGia, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_NamSanXuat, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 138);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Năm sản xuất";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn vị";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thông số kỹ thuật";
            // 
            // tb_ThongSoKyThuat
            // 
            this.tb_ThongSoKyThuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ThongSoKyThuat.Location = new System.Drawing.Point(119, 84);
            this.tb_ThongSoKyThuat.Name = "tb_ThongSoKyThuat";
            this.tb_ThongSoKyThuat.Size = new System.Drawing.Size(340, 20);
            this.tb_ThongSoKyThuat.TabIndex = 1;
            // 
            // tb_DonVi
            // 
            this.tb_DonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DonVi.Location = new System.Drawing.Point(119, 57);
            this.tb_DonVi.Name = "tb_DonVi";
            this.tb_DonVi.Size = new System.Drawing.Size(340, 20);
            this.tb_DonVi.TabIndex = 1;
            // 
            // tb_TenLoai
            // 
            this.tb_TenLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TenLoai.Location = new System.Drawing.Point(119, 3);
            this.tb_TenLoai.Name = "tb_TenLoai";
            this.tb_TenLoai.Size = new System.Drawing.Size(340, 20);
            this.tb_TenLoai.TabIndex = 1;
            // 
            // tb_DonGia
            // 
            this.tb_DonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DonGia.Location = new System.Drawing.Point(119, 30);
            this.tb_DonGia.Name = "tb_DonGia";
            this.tb_DonGia.Size = new System.Drawing.Size(340, 20);
            this.tb_DonGia.TabIndex = 1;
            // 
            // tb_NamSanXuat
            // 
            this.tb_NamSanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NamSanXuat.Location = new System.Drawing.Point(119, 113);
            this.tb_NamSanXuat.Name = "tb_NamSanXuat";
            this.tb_NamSanXuat.Size = new System.Drawing.Size(340, 20);
            this.tb_NamSanXuat.TabIndex = 1;
            // 
            // btn_ThemLoai
            // 
            this.btn_ThemLoai.Location = new System.Drawing.Point(131, 169);
            this.btn_ThemLoai.Name = "btn_ThemLoai";
            this.btn_ThemLoai.Size = new System.Drawing.Size(231, 26);
            this.btn_ThemLoai.TabIndex = 7;
            this.btn_ThemLoai.Text = "Thêm loại";
            this.btn_ThemLoai.UseVisualStyleBackColor = true;
            this.btn_ThemLoai.Click += new System.EventHandler(this.btn_ThemLoai_Click);
            // 
            // SubForm_ThemLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 216);
            this.Controls.Add(this.btn_ThemLoai);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SubForm_ThemLoai";
            this.Text = "SubForm_ThemLoai";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ThongSoKyThuat;
        private System.Windows.Forms.TextBox tb_DonVi;
        private System.Windows.Forms.TextBox tb_TenLoai;
        private System.Windows.Forms.TextBox tb_DonGia;
        private System.Windows.Forms.TextBox tb_NamSanXuat;
        private System.Windows.Forms.Button btn_ThemLoai;
    }
}