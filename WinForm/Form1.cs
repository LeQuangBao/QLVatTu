using System;
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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'thietBiDataSet.Loai' table. You can move, or remove it, as needed.
            this.loaiTableAdapter.Fill(this.thietBiDataSet.Loai);

        }

        private void btn_SuaLoai_Click(object sender, EventArgs e) {
            
            Database.UpdateLoai(new Loai(Int32.Parse(lb_MaLoai.Text), tb_TenLoai.Text, Int32.Parse(tb_DonGia.Text), Int32.Parse(tb_DonVi.Text), tb_ThongSoKyThuat.Text, tb_NamSanXuat.Text));

        }

        private void btn_XoaLoai_Click(object sender, EventArgs e) {
            Database.DeleteLoai(Int32.Parse(lb_MaLoai.Text));
        }


    }
}
