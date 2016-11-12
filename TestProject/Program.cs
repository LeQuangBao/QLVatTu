using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace TestProject {
    class Program {
        static void Main(string[] args) {
            using (var context = new Context()) {
                //select without condition
                var loai = from l in context.Loai
                           select l;

                //select with condition and inner join
                var thietBi = from tb in context.ThietBi
                              join l in context.Loai on tb.MaLoai equals l.MaLoai
                              where l.MaLoai == 0
                              select tb;

                //select pivot table
                var phieuGiaoNhan = from pgn in context.PhieuGiaoNhan
                                    where pgn.MaLoaiGiaoNhan == "1"
                                    select pgn;

                List<ThietBi> thietBi1 = new List<ThietBi>();
                foreach (PhieuGiaoNhan pgn in phieuGiaoNhan) {
                    thietBi1.AddRange(pgn.ThietBi.ToList());
                }

                // select elements from List
                //var sg = thietBi1.Where(tb => tb.MaThietBi == 8);


                // pure query (not recommended)
                var thietBi2 = context.ThietBi.SqlQuery("SELECT * FROM ThietBi").ToList();

                //foreach (ThietBi tb in thietBi1) {
                //    Console.WriteLine(tb.MaThietBi.ToString());
                //}

                // INSERT
                //var thietBi3 = new ThietBi();
                //thietBi3.MaThietBi = 36;
                //thietBi3.MaLoai = 0;
                //thietBi3.NgayDuaVaoSuDung = DateTime.Parse("29/10/2016");
                //thietBi3.TinhTrang = 1;
                //context.ThietBi.Add(thietBi3);
                //context.SaveChanges();

                // UPDATE
                //var thietBi4 = from tb in context.ThietBi
                //               where tb.MaThietBi == 36
                //               select tb;
                //foreach(ThietBi tb in thietBi4) {
                //    tb.MaLoai = 2;
                //}
                //context.SaveChanges();

                // DELETE
                //var thietBi5 = from tb in context.ThietBi
                //               where tb.MaThietBi == 36
                //               select tb;
                //foreach(ThietBi tb in thietBi5) {
                //    context.ThietBi.Remove(tb);
                //}
                //context.SaveChanges();
            }
        }
    }
}
