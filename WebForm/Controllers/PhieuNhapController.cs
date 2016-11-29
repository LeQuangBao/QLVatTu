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
    public class PhieuNhapController : Controller {
        private Context db = new Context();

        // GET: PhieuNhap
        public ActionResult Index() {
            var phieuNhap = db.PhieuNhap.Include(p => p.NhaCungCap);
            return View(phieuNhap.ToList());
        }

        // GET: PhieuNhap/Details/5
        public ActionResult Details(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuNhap phieuNhap = db.PhieuNhap.Find(id);
            List<List<string>> chiTietLoai = new List<List<string>>();
            foreach(ThietBi tb in phieuNhap.ThietBi) {
                Loai loai = (from l in db.Loai
                            where l.MaLoai == tb.MaLoai
                            select l).FirstOrDefault();
                chiTietLoai.Add((new string[] { tb.MaThietBi.ToString(), loai.TenLoai, loai.DonGia.ToString(), loai.ThongSoKyThuat, loai.NamSanXuat }).ToList());
            }
            ViewBag.ChiTietLoai = chiTietLoai;
            if(phieuNhap == null) {
                return HttpNotFound();
            }
            return View(phieuNhap);
        }

        // GET: PhieuNhap/Create
        public ActionResult Create() {
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap, "MaNhaCungCap", "TenNhaCungCap");
            return View();
        }

        // POST: PhieuNhap/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhieuNhap,MaNhaCungCap,NgayNhap")] PhieuNhap phieuNhap) {
            if(ModelState.IsValid) {
                db.PhieuNhap.Add(phieuNhap);
                db.SaveChanges();
                return RedirectToAction("CreateDetail");
            }

            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap, "MaNhaCungCap", "TenNhaCungCap", phieuNhap.MaNhaCungCap);
            return View(phieuNhap);
        }

        public ActionResult CreateDetail(int? id) {
            PhieuNhap phieuNhap = db.PhieuNhap.Find(id);
            ViewBag.phieuNhap = phieuNhap;
            List<Loai> listLoai = (from l in db.Loai select l).ToList();
            return View(phieuNhap);
        }

        public ActionResult CreateDetailHandler(int[] maLoai, int[] soLuong) {
            Model.Database.InsertListThietBi(maLoai, soLuong);
            return RedirectToAction("Index");
        }

        // GET: PhieuNhap/Edit/5
        public ActionResult Edit(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuNhap phieuNhap = db.PhieuNhap.Find(id);
            if(phieuNhap == null) {
                return HttpNotFound();
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap, "MaNhaCungCap", "TenNhaCungCap", phieuNhap.MaNhaCungCap);
            return View(phieuNhap);
        }

        // POST: PhieuNhap/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhieuNhap,MaNhaCungCap,NgayNhap")] PhieuNhap phieuNhap) {
            if(ModelState.IsValid) {
                db.Entry(phieuNhap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap, "MaNhaCungCap", "TenNhaCungCap", phieuNhap.MaNhaCungCap);
            return View(phieuNhap);
        }

        // GET: PhieuNhap/Delete/5
        public ActionResult Delete(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuNhap phieuNhap = db.PhieuNhap.Find(id);
            if(phieuNhap == null) {
                return HttpNotFound();
            }
            return View(phieuNhap);
        }

        // POST: PhieuNhap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            PhieuNhap phieuNhap = db.PhieuNhap.Find(id);
            db.PhieuNhap.Remove(phieuNhap);
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
