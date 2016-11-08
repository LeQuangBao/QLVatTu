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
    public partial class SubForm_ThemLoai : Form {
        public SubForm_ThemLoai() {
            InitializeComponent();
        }

        private void btn_ThemLoai_Click(object sender, EventArgs e) {
            Database.InsertLoai(new Loai(0, tb_TenLoai.Text, Int32.Parse(tb_DonGia.Text), Int32.Parse(tb_DonVi.Text), tb_ThongSoKyThuat.Text, tb_NamSanXuat.Text));
        }
    }
}
