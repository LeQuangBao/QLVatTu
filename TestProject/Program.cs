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
                var loai = from l in context.Loai
                           select l;
                foreach(Loai l in loai) {
                    Console.WriteLine(l.MaLoai.ToString());
                }
            }
        }
    }
}
