﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WinForm {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'quanLyVatTuDataSet.Loai' table. You can move, or remove it, as needed.
            this.loaiTableAdapter1.Fill(this.quanLyVatTuDataSet.Loai);
            // TODO: This line of code loads data into the 'thietBiDataSet.Loai' table. You can move, or remove it, as needed.
            this.loaiTableAdapter.Fill(this.thietBiDataSet.Loai);
            
            //Manual
            List<Loai> listLoai = Database.selectLoai();
            foreach (Loai l in listLoai) {
                cb_ThongKe_ChonLoai.Items.Add(l.TenLoai);
            }

            ////Testing ground
            //List<ThietBi> list = new List<ThietBi>();
            //DateTime dateTime = new DateTime(2016,11,14);
            ////list = Database.ThongKeTheoTinhTrang(Database.CON_DUNG_DUOC, 2, dateTime);
            //return;
        }

        private void btn_SuaLoai_Click(object sender, EventArgs e) {
            Database.UpdateLoai(new Loai(Int32.Parse(lb_MaLoai.Text), tb_TenLoai.Text, Int32.Parse(tb_DonGia.Text), Int32.Parse(tb_DonVi.Text), tb_ThongSoKyThuat.Text, tb_NamSanXuat.Text));
        }

        private void btn_XoaLoai_Click(object sender, EventArgs e) {
            Database.DeleteLoai(Int32.Parse(lb_MaLoai.Text));
        }

        private void btn_ThemLoai_Click(object sender, EventArgs e) {
            SubForm_ThemLoai subFrom = new SubForm_ThemLoai();
            subFrom.Show();
        }

        private void dgv_Loai_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int row = dgv_Loai.CurrentCell.RowIndex;
            lb_MaLoai.Text = dgv_Loai.Rows[row].Cells[0].Value.ToString();
            tb_TenLoai.Text = dgv_Loai.Rows[row].Cells[1].Value.ToString();
            tb_DonGia.Text = dgv_Loai.Rows[row].Cells[2].Value.ToString();
            tb_DonVi.Text = dgv_Loai.Rows[row].Cells[3].Value.ToString();
            tb_ThongSoKyThuat.Text = dgv_Loai.Rows[row].Cells[4].Value.ToString();
            tb_NamSanXuat.Text = dgv_Loai.Rows[row].Cells[5].Value.ToString();
            return;
        }

        private void btn_ThongKe_Click(object sender, EventArgs e) {

        }
    }
}