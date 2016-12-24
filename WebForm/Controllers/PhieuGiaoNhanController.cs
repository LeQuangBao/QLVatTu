using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model;

namespace WebForm.Controllers {
    public class PhieuGiaoNhanController : Controller {
        private Context db = new Context();

        // GET: PhieuGiaoNhan
        public ActionResult Index() {
            var phieuGiaoNhan = db.PhieuGiaoNhan.Include(p => p.DonVi);
            return View(phieuGiaoNhan.ToList());
        }

        // GET: PhieuGiaoNhan/Details/5
        public ActionResult Details(int? id) {
            if(id == null) {
                id = 0;
            }
            PhieuGiaoNhan phieuGiaoNhan = db.PhieuGiaoNhan.Find(id);
            List<List<string>> chiTietLoai = new List<List<string>>();
            List<ChiTietPhieuGiaoNhan> listChiTietPhieuGiaoNhan = Model.Database.SelectChiTietPhieuGiaoNhan(id ?? default(int));
            foreach(ChiTietPhieuGiaoNhan ct in listChiTietPhieuGiaoNhan) {
                ThietBi tb = Model.Database.SelectThietBiByMa(ct.MaThietBi);
                Loai loai = (from l in db.Loai
                             where l.MaLoai == tb.MaLoai
                             select l).FirstOrDefault();
                TinhTrang tt = (from t in db.TinhTrang
                                where t.MaTinhTrang == ct.TinhTrang
                                select t).FirstOrDefault();
                chiTietLoai.Add((new string[] { tb.MaThietBi.ToString(), loai.TenLoai, loai.DonGia.ToString(), loai.ThongSoKyThuat, loai.NamSanXuat, tt.TenTinhTrang }).ToList());
            }
            ViewBag.ChiTietLoai = chiTietLoai;
            if(phieuGiaoNhan == null) {
                return HttpNotFound();
            }
            return View(phieuGiaoNhan);
        }

        // GET: PhieuGiaoNhan/Create
        public ActionResult Create() {
            ViewBag.MaDonVi = new SelectList(db.DonVi, "MaDonVi", "TenDonVi");
            return View();
        }

        // POST: PhieuGiaoNhan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhieuGiaoNhan,MaDonVi,NgayGiaoNhan")] PhieuGiaoNhan phieuGiaoNhan) {
            if(true) {
                PhieuGiaoNhan p = phieuGiaoNhan;
                p.MaPhieuGiaoNhan = Model.Database.SelectLastMaPhieuGiaoNhan() + 1;
                db.PhieuGiaoNhan.Add(phieuGiaoNhan);
                db.SaveChanges();
                return RedirectToAction("CreateDetail/" + p.MaPhieuGiaoNhan);
            }

            ViewBag.MaDonVi = new SelectList(db.DonVi, "MaDonVi", "TenDonVi", phieuGiaoNhan.MaDonVi);
            return View(phieuGiaoNhan);
        }

        public ActionResult CreateDetail(int id) {
            PhieuGiaoNhan pgn = Model.Database.SelectPhieuGiaoNhanByMa(id);
            DonVi donVi = Model.Database.SelectDonViByMa(pgn.MaDonVi);
            ViewBag.tenDonVi = donVi.TenDonVi;
            return View(pgn);
        }

        public ActionResult CreateDetailHandler(int maPhieuGiaoNhan, int[] maThietBi, int[] tinhTrang) {
            Model.Database.InsertChiTietPhieuGiaoNhan(maPhieuGiaoNhan, maThietBi, tinhTrang);
            return RedirectToAction("Details/" + maPhieuGiaoNhan);
        }

        public JsonResult SelectLoai() {
            List<Loai> list = Model.Database.SelectLoai();
            List<Loai> listLoai = new List<Loai>();
            foreach (Loai l in list) {
                listLoai.Add(new Loai { MaLoai = l.MaLoai, TenLoai = l.TenLoai });
            }

            return Json(listLoai, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SelectThietBi(int id) {
            List<ThietBi> list = Model.Database.SelectThietBiByLoai(id);
            List<ThietBi> listThietBi = new List<ThietBi>();
            foreach(ThietBi tb in list) {
                listThietBi.Add(new ThietBi { MaThietBi = tb.MaThietBi, TinhTrang = tb.TinhTrang });
            }
            return Json(listThietBi, JsonRequestBehavior.AllowGet);
        }

        // GET: PhieuGiaoNhan/Edit/5
        public ActionResult Edit(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuGiaoNhan phieuGiaoNhan = db.PhieuGiaoNhan.Find(id);
            if(phieuGiaoNhan == null) {
                return HttpNotFound();
            }
            ViewBag.MaDonVi = new SelectList(db.DonVi, "MaDonVi", "TenDonVi", phieuGiaoNhan.MaDonVi);
            return View(phieuGiaoNhan);
        }

        // POST: PhieuGiaoNhan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhieuGiaoNhan,MaDonVi,NgayGiaoNhan")] PhieuGiaoNhan phieuGiaoNhan) {
            if(ModelState.IsValid) {
                db.Entry(phieuGiaoNhan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDonVi = new SelectList(db.DonVi, "MaDonVi", "TenDonVi", phieuGiaoNhan.MaDonVi);
            return View(phieuGiaoNhan);
        }

        // GET: PhieuGiaoNhan/Delete/5
        public ActionResult Delete(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuGiaoNhan phieuGiaoNhan = db.PhieuGiaoNhan.Find(id);
            if(phieuGiaoNhan == null) {
                return HttpNotFound();
            }
            return View(phieuGiaoNhan);
        }

        // POST: PhieuGiaoNhan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            PhieuGiaoNhan phieuGiaoNhan = db.PhieuGiaoNhan.Find(id);
            db.PhieuGiaoNhan.Remove(phieuGiaoNhan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            if(disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
