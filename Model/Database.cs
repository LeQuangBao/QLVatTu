using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Database {

        public const int CON_DUNG_DUOC = 0;
        public const int DANG_DUNG = 1;
        public const int DA_HU = 2;
        public const int DA_THANH_LY = 3;

        public const int LAPTOP = 0;
        public const int DAN_PIANO = 1;
        public const int ONG_NGHIEM = 2;
        public const int MAY_CHIEU_SHAFT = 3;
        public const int DEN_LED = 4;

        public static void InsertListThietBi(int maPhieuNhap, int[] maLoai, int[] soLuong) {
            using(Context context = new Context()) {
                int maLoaiLength = maLoai.Length;
                int increase = 1;
                for(int i = 0; i < maLoaiLength; i++) {
                    PhieuNhap phieuNhap = (from p in context.PhieuNhap
                                           where p.MaPhieuNhap == maPhieuNhap
                                           select p).FirstOrDefault();
                    for(int j = 0; j < soLuong[i]; j++) {
                        //ThietBi t = InsertThietBi(maLoai[i]);

                        ThietBi thietBi = new ThietBi();
                        thietBi.MaThietBi = SelectLastMaThietBi() + increase++;
                        thietBi.MaLoai = maLoai[i];
                        thietBi.NgayDuaVaoSuDung = null;
                        thietBi.TinhTrang = 0;

                        phieuNhap.ThietBi.Add(thietBi);

                    }
                    context.SaveChanges();
                }   
            }
        }

        public static ThietBi InsertThietBi(int maLoai) {
            using(Context context = new Context()) {
                ThietBi thietBi = new ThietBi();
                thietBi.MaThietBi = SelectLastMaThietBi() + 1;
                thietBi.MaLoai = maLoai;
                thietBi.NgayDuaVaoSuDung = null;
                thietBi.TinhTrang = 0;
                context.ThietBi.Add(thietBi);
                context.SaveChanges();
                return thietBi;
            }
        }

        public static int SelectLastMaThietBi() {
            using(Context context = new Context()) {
                return (from t in context.ThietBi
                        orderby t.MaThietBi descending
                        select t).FirstOrDefault().MaThietBi;
            }
        }
        public static Loai SelectLoaiByTenLoai(string tenLoai) {
            using(Context context = new Context()) {
                return (from l in context.Loai
                        where l.TenLoai == tenLoai
                        select l).First();
            }
        }

        public static int GetMaLoai(string tenLoai) {
            using(Context context = new Context()) {
                return (from l in context.Loai
                        where l.TenLoai == tenLoai
                        select l).First().MaLoai;
            }
        }

        public static List<ThietBi> ThongKeTheoLoai(string tenLoai, string date) {
            using(Context context = new Context()) {
                List<ThietBi> result = new List<ThietBi>();
                int maLoai = GetMaLoai(tenLoai);
                DateTime time = Convert.ToDateTime(date);
                List<ThietBi> listThietBi = (from l in context.ThietBi
                                             where l.MaLoai == maLoai
                                             select l).ToList();
                foreach(ThietBi tb in listThietBi) {
                    ThietBi temp = new ThietBi();
                    temp.MaThietBi = tb.MaThietBi;
                    temp.NgayDuaVaoSuDung = tb.NgayDuaVaoSuDung;
                    temp.MaLoai = maLoai;
                    ChiTietPhieuGiaoNhan ct = (from l in context.ChiTietPhieuGiaoNhan
                                               join c in context.PhieuGiaoNhan on l.MaPhieuGiaoNhan equals c.MaPhieuGiaoNhan
                                               where c.NgayGiaoNhan <= time
                                               where l.MaThietBi == tb.MaThietBi
                                               orderby c.NgayGiaoNhan descending
                                               select l).FirstOrDefault();
                    if(ct == null) {
                        temp.TinhTrang = 0;
                    } else {
                        temp.TinhTrang = ct.TinhTrang ?? default(int);
                    }
                    result.Add(temp);
                }
                return result;
            }
        }
        //public static List<ThietBi> ThongKeTheoLoai(string tenLoai, string date) {
        //    using(Context context = new Context()) {
        //        int maLoai = getMaLoai(tenLoai);
        //        DateTime time = Convert.ToDateTime(date);
        //        List<ThietBi> result = new List<ThietBi>();
        //        List<ThietBi> listThietBi = (from l in context.ThietBi
        //                                     where l.MaLoai == maLoai
        //                                     select l).ToList();
        //        //string query = "SELECT TOP 1 PhieuGiaoNhan.MaPhieuGiaoNhan, MaLoaiGiaoNhan, MaDonVi, NgayGiaoNhan FROM PhieuGiaoNhan, ChiTietPhieuGiaoNhan WHERE ChiTietPhieuGiaoNhan.MaPhieuGiaoNhan = PhieuGiaoNhan.MaPhieuGiaoNhan AND NgayGiaoNhan < '2016-06-15' AND MaThietBi = 0 ORDER BY NgayGiaoNhan DESC";

        //        //var listPhieuGiaoNhan = from p in context.PhieuGiaoNhan
        //        //                        select p;

        //        //PhieuGiaoNhan phieuGiaoNhan = context.PhieuGiaoNhan.SqlQuery(query).ToList().First();
        //        foreach(ThietBi thietBi in listThietBi) {
        //            ThietBi rs = new ThietBi();
        //            rs.MaThietBi = thietBi.MaThietBi;
        //            rs.NgayDuaVaoSuDung = thietBi.NgayDuaVaoSuDung;
        //            List<PhieuGiaoNhan> listPhieuGiaoNhan = (from pgn in context.PhieuGiaoNhan
        //                                                     where pgn.NgayGiaoNhan <= time
        //                                                     orderby pgn.NgayGiaoNhan descending
        //                                                     select pgn).ToList();
        //            PhieuGiaoNhan p = new PhieuGiaoNhan();
        //            foreach(PhieuGiaoNhan pgn in listPhieuGiaoNhan) {
        //                List<ThietBi> list = pgn.ThietBi.ToList();
        //                bool isFound = false;
        //                foreach(ThietBi tb in list) {
        //                    if(tb.MaThietBi == thietBi.MaThietBi) {
        //                        isFound = true;
        //                        p = pgn;
        //                    }
        //                }
        //                if(isFound) {
        //                    break;
        //                }
        //            }
        //            // 1 còn hoạt động -> đang dùng
        //            // 2 đang dùng -> còn hoạt động
        //            // 3 đang dùng -> đã hư
        //            // 4 đã hư -> còn hoạt động
        //            // 5 đã hư -> thanh lý
        //            switch(p.MaLoaiGiaoNhan) {
        //                case "1":
        //                    rs.TinhTrang = DANG_DUNG;
        //                    break;
        //                case "2":
        //                    rs.TinhTrang = CON_DUNG_DUOC;
        //                    break;
        //                case "3":
        //                    rs.TinhTrang = DA_HU;
        //                    break;
        //                case "4":
        //                    rs.TinhTrang = CON_DUNG_DUOC;
        //                    break;
        //                case "5":
        //                    rs.TinhTrang = DA_THANH_LY;
        //                    break;
        //                default:
        //                    break;
        //            }
        //            result.Add(rs);
        //        }
        //        return result;
        //    }
        //}

        //public static List<ThietBi> ThongKeTheoTinhTrang2(int tinhTrang, int loai, DateTime time) {
        //    using(Context context = new Context()) {
        //        List<ThietBi> result = new List<ThietBi>();
        //        List<int> listMaThietBi = new List<int>();
        //        // sub list
        //        // 0 phiếu nhập
        //        // 1 còn hoạt động -> đang dùng
        //        // 2 đang dùng -> còn hoạt động
        //        // 3 đang dùng -> đã hư
        //        // 4 đã hư -> còn hoạt động
        //        // 5 đã hư -> thanh lý
        //        List<int> list0 = selectThietBiTheoPhieuNhap(loai, time);
        //        List<int> list1 = selectThietBiTheoPhieuGiaoNhan(1, loai, time);
        //        List<int> list2 = selectThietBiTheoPhieuGiaoNhan(2, loai, time);
        //        List<int> list3 = selectThietBiTheoPhieuGiaoNhan(3, loai, time);
        //        List<int> list4 = selectThietBiTheoPhieuGiaoNhan(4, loai, time);
        //        List<int> list5 = selectThietBiTheoPhieuGiaoNhan(5, loai, time);
        //        if(tinhTrang == CON_DUNG_DUOC) {
        //            listMaThietBi.AddRange(list0);
        //            listMaThietBi = UtilityArray.UniqueMerge(listMaThietBi, list2);
        //            listMaThietBi = UtilityArray.UniqueMerge(listMaThietBi, list4);
        //            listMaThietBi = UtilityArray.RemoveIntersect(listMaThietBi, list1);
        //        } else if(tinhTrang == DANG_DUNG) {
        //            listMaThietBi.AddRange(list1);
        //            List<int> t = UtilityArray.UniqueMerge(list2, list3);
        //            listMaThietBi = UtilityArray.RemoveIntersect(listMaThietBi, t);
        //        } else if(tinhTrang == DA_HU) {
        //            listMaThietBi.AddRange(list3);
        //            List<int> t = UtilityArray.UniqueMerge(list4, list5);
        //            listMaThietBi = UtilityArray.RemoveIntersect(listMaThietBi, t);
        //        } else if(tinhTrang == DA_THANH_LY) {
        //            listMaThietBi.AddRange(list5);
        //        }
        //        var listThietBi = from tb in context.ThietBi
        //                          join m in listMaThietBi on tb.MaThietBi equals m
        //                          select tb;
        //        foreach(ThietBi tb in listThietBi) {
        //            result.Add(tb);
        //        }
        //        return result;
        //    }
        //}

        //public static List<int> selectThietBiTheoPhieuGiaoNhan(int loaign, int loaiThietBi, DateTime time) {
        //    using(var context = new Context()) {
        //        var phieuGiaoNhan = from pgn in context.PhieuGiaoNhan
        //                            where pgn.MaLoaiGiaoNhan == loaign.ToString()
        //                            && pgn.NgayGiaoNhan < time
        //                            select pgn;
        //        List<ThietBi> listThietBi = new List<ThietBi>();
        //        foreach(PhieuGiaoNhan pgn in phieuGiaoNhan) {
        //            listThietBi.AddRange(pgn.ThietBi.ToList());
        //        }
        //        List<int> listMaThietBi = new List<int>();
        //        foreach(ThietBi tb in listThietBi) {
        //            if(tb.MaLoai == loaiThietBi) {
        //                listMaThietBi.Add(tb.MaThietBi);
        //            }
        //        }
        //        return listMaThietBi;
        //    }
        //}
        //public static List<int> selectThietBiTheoPhieuNhap(int loaiThietBi, DateTime time) {
        //    using(var context = new Context()) {
        //        var phieuNhap = from pn in context.PhieuNhap
        //                        where pn.NgayNhap < time
        //                        select pn;
        //        List<ThietBi> listThietBi = new List<ThietBi>();
        //        foreach(PhieuNhap pn in phieuNhap) {
        //            listThietBi.AddRange(pn.ThietBi.ToList());
        //        }
        //        List<int> listMaThietBi = new List<int>();
        //        foreach(ThietBi tb in listThietBi) {
        //            if(tb.MaLoai == loaiThietBi) {
        //                listMaThietBi.Add(tb.MaThietBi);
        //            }
        //        }
        //        return listMaThietBi;
        //    }
        //}


        public static List<TinhTrang> SelectTinhTrang() {
            using(var context = new Context()) {
                return (from t in context.TinhTrang select t).ToList();
            }
        }

        public static List<DonVi> SelectDonVi() {
            using(var context = new Context()) {
                return (from t in context.DonVi select t).ToList();
            }
        }

        /// <summary>
        /// Select all "loai" in database
        /// </summary>
        /// <returns></returns>
        public static List<Loai> SelectLoai() {
            using(var context = new Context()) {
                return (from l in context.Loai
                        select l).ToList<Loai>();
            }
        }

        public static int SelectLastLoai() {
            using(var context = new Context()) {
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
            using(var context = new Context()) {
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
            using(var context = new Context()) {
                var listLoai = from l in context.Loai
                               where l.MaLoai == loai.MaLoai
                               select l;
                foreach(Loai l in listLoai) {
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
            using(var context = new Context()) {
                var listLoai = from l in context.Loai
                               where l.MaLoai == maLoai
                               select l;
                foreach(Loai tb in listLoai) {
                    context.Loai.Remove(tb);
                }
                context.SaveChanges();
            }
        }
    }
}