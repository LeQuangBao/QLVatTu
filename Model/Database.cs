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

        public static void InsertLoai(Loai loai) {
            using (var context = new Context()) {
                var l = new Loai();
                l.MaLoai = loai.MaLoai;
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
