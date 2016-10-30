using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DF_Model;

namespace TestProject {
    class Program {
        static void Main(string[] args) {
            using (var context = new QuanLyVatTuContext()) {
                //select without condition
                var loai = from l in context.Loai
                           select l;
                
                foreach(Loai l in loai) {
                    Console.WriteLine(l.MaLoai.ToString());
                }

                //select with condition
                var thietBi = from tb in context.ThietBi
                              where tb.MaLoai == 0
                              select tb;

                // pure query (not recommended)
                var thietBi2 = context.ThietBi.SqlQuery("SELECT * FROM ThietBi").ToList();
                foreach(ThietBi tb in thietBi) {
                    Console.WriteLine(tb.NgayDuaVaoSuDung.ToString());
                }
            }
        }
    }
}
