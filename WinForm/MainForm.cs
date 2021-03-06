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
            loaiTableAdapter1.Fill(quanLyVatTuDataSet.Loai);
            // TODO: This line of code loads data into the 'thietBiDataSet.Loai' table. You can move, or remove it, as needed.
            loaiTableAdapter.Fill(thietBiDataSet.Loai);

            //Manual
            List<Loai> listLoai = Database.SelectLoai();
            foreach(Loai l in listLoai) {
                cb_ThongKe_ChonLoai.Items.Add(l.TenLoai);
            }
            cb_ThongKe_ChonLoai.SelectedIndex = 0;
            refresh();

            ////Testing ground
            //List<ThietBi> list = new List<ThietBi>();
            //DateTime dateTime = new DateTime(2016,11,14);
            ////list = Database.ThongKeTheoTinhTrang(Database.CON_DUNG_DUOC, 2, dateTime);
            //return;
        }

        private void btn_SuaLoai_Click(object sender, EventArgs e) {
            if(lb_MaLoai.Text.Equals("---")) {
                return;
            }
            int donVi = tb_DonGia.Text == "Cái" ? 0 : 1;
            Database.UpdateLoai(new Loai(int.Parse(lb_MaLoai.Text), tb_TenLoai.Text, int.Parse(tb_DonGia.Text), donVi, tb_ThongSoKyThuat.Text, tb_NamSanXuat.Text));
            refresh();
        }

        private void btn_XoaLoai_Click(object sender, EventArgs e) {
            Database.DeleteLoai(Int32.Parse(lb_MaLoai.Text));
            refresh();
        }

        private void btn_ThemLoai_Click(object sender, EventArgs e) {
            SubForm_ThemLoai subFrom = new SubForm_ThemLoai();
            subFrom.Show();
        }

        private void dgv_Loai_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int row = dgv_Loai.CurrentCell.RowIndex;
            lb_MaLoai.Text = dgv_Loai.Rows[row].Cells[0].Value.ToString();
            tb_TenLoai.Text = dgv_Loai.Rows[row].Cells[1].Value.ToString();
            tb_DonVi.Text = dgv_Loai.Rows[row].Cells[2].Value.ToString();
            tb_DonGia.Text = dgv_Loai.Rows[row].Cells[3].Value.ToString();
            tb_NamSanXuat.Text = dgv_Loai.Rows[row].Cells[4].Value.ToString();
            tb_ThongSoKyThuat.Text = dgv_Loai.Rows[row].Cells[5].Value.ToString();
            return;
        }

        private void btn_ThongKe_Click(object sender, EventArgs e) {
            List<ThietBi> listThietBi = Database.ThongKeTheoLoai(cb_ThongKe_ChonLoai.Text, dtp_ThongKe.Value.ToShortDateString());
            List<DonVi> listDonVi = Database.SelectDonVi();
            List<TinhTrang> listTinhTrang = Database.SelectTinhTrang();
            Loai loai = Database.SelectLoaiByTenLoai(cb_ThongKe_ChonLoai.Text);
            dgv_ThongKe.Rows.Clear();
            int soLuongConDungDuoc = 0;
            int soLuongDangDung = 0;
            int soLuongDaHu = 0;
            int soLuongThanhLy = 0;
            //mã thiết bị, loại, đơn giá, đơn vị, thông số kỹ thuật, năm sản xuất
            foreach(ThietBi tb in listThietBi) {
                string tinhTrang = (from l in listTinhTrang
                                    where l.MaTinhTrang == tb.TinhTrang
                                    select l.TenTinhTrang).FirstOrDefault().ToString();
                string donVi = loai.DonVi == 0 ? "Cái" : "Bộ";
                string[] row = new string[] { tb.MaThietBi.ToString(), loai.TenLoai, loai.DonGia.ToString(), donVi, loai.ThongSoKyThuat, loai.NamSanXuat, tb.NgayDuaVaoSuDung.ToString(), tinhTrang };
                dgv_ThongKe.Rows.Add(row);
                switch(tb.TinhTrang) {
                    case 0:
                        soLuongConDungDuoc++;
                        break;
                    case 1:
                        soLuongDangDung++;
                        break;
                    case 2:
                        soLuongDaHu++;
                        break;
                    case 3:
                        soLuongThanhLy++;
                        break;
                }
            }
            lbl_SoLuongConDungDuoc.Text = soLuongConDungDuoc.ToString();
            lbl_SoLuongDangDung.Text = soLuongDangDung.ToString();
            lbl_SoLuongDaHu.Text = soLuongDaHu.ToString();
            lbl_SoLuongThanhLy.Text = soLuongThanhLy.ToString();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e) {
            refresh();
        }

        private void refresh() {
            int rowCount = dgv_Loai.Rows.Count;
            for(int i = 0; i < rowCount; i++) {
                dgv_Loai.Rows.RemoveAt(0);
            }
            List<Loai> listLoai = Database.SelectLoai();
            foreach(Loai l in listLoai) {
                string donVi = l.DonVi == 0 ? "Cái" : "Bộ";
                dgv_Loai.Rows.Add(new string[] { l.MaLoai.ToString(), l.TenLoai, donVi, l.DonGia.ToString(), l.NamSanXuat, l.ThongSoKyThuat });
            }
        }
    }
}