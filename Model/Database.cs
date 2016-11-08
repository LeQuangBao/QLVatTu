using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Database {
        public static List<Loai> selectLoai() {
            using (var context = new Context()) {
                return (from l in context.Loai
                        select l).ToList<Loai>();
            }
        }

        public static int SelectLastLoai() {
            using (var context = new Context()) {
                var loai = from l in context.Loai
                           select l;
                int n = 0;
                foreach(Loai l in loai) {
                    n = l.MaLoai;
                }
                return n;
            }
        }

        public static void InsertLoai(Loai loai) {
            using (var context = new Context()) {
                var l = new Loai();
                l.MaLoai = Int32.Parse(context.Loai.OrderByDescending(t => t.MaLoai).Select(t => t.MaLoai).First().ToString()) + 1;
                //l.MaLoai = SelectLastLoai();
                l.TenLoai = loai.TenLoai;
                l.DonGia = loai.DonGia;
                l.DonVi = loai.DonVi;
                l.ThongSoKyThuat = loai.ThongSoKyThuat;
                l.NamSanXuat = loai.NamSanXuat;
                context.Loai.Add(l);
                context.SaveChanges();
            }
        }

        public static void UpdateLoai(Loai loai) {
            using (var context = new Context()) {
                var listLoai = from l in context.Loai
                               where l.MaLoai == loai.MaLoai
                               select l;
                foreach (Loai l in listLoai) {
                    l.TenLoai = loai.TenLoai;
                    l.DonGia = loai.DonGia;
                    l.DonVi = loai.DonVi;
                    l.ThongSoKyThuat = loai.ThongSoKyThuat;
                    l.NamSanXuat = loai.NamSanXuat;
                }
                context.SaveChanges();
            }
        }

        public static void DeleteLoai(int maLoai) {
            using (var context = new Context()) {
                var listLoai = from l in context.Loai
                               where l.MaLoai == maLoai
                               select l;
                foreach (Loai tb in listLoai) {
                    context.Loai.Remove(tb);
                }
                context.SaveChanges();
            }
        }
    }
}