using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model;

namespace WebForm.Controllers
{
    public class PhieuGiaoNhanController : Controller
    {
        private Context db = new Context();

        // GET: PhieuGiaoNhan
        public ActionResult Index()
        {
            var phieuGiaoNhan = db.PhieuGiaoNhan.Include(p => p.DonVi);
            return View(phieuGiaoNhan.ToList());
        }

        // GET: PhieuGiaoNhan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuGiaoNhan phieuGiaoNhan = db.PhieuGiaoNhan.Find(id);
            List<List<string>> chiTietLoai = new List<List<string>>();
            List<ChiTietPhieuGiaoNhan> listChiTietPhieuGiaoNhan = phieuGiaoNhan.ChiTietPhieuGiaoNhan.ToList();
            foreach(ChiTietPhieuGiaoNhan ct in listChiTietPhieuGiaoNhan) {
                ThietBi tb = ct.ThietBi;
                Loai loai = (from l in db.Loai
                             where l.MaLoai == tb.MaLoai
                             select l).FirstOrDefault();
                TinhTrang tt = (from t in db.TinhTrang
                               where t.MaTinhTrang == ct.TinhTrang
                               select t).FirstOrDefault();
                chiTietLoai.Add((new string[] { tb.MaThietBi.ToString(), loai.TenLoai, loai.DonGia.ToString(), loai.ThongSoKyThuat, loai.NamSanXuat, tt.TenTinhTrang }).ToList());
            }
            ViewBag.ChiTietLoai = chiTietLoai;
            if (phieuGiaoNhan == null)
            {
                return HttpNotFound();
            }
            return View(phieuGiaoNhan);
        }

        // GET: PhieuGiaoNhan/Create
        public ActionResult Create()
        {
            ViewBag.MaDonVi = new SelectList(db.DonVi, "MaDonVi", "TenDonVi");
            return View();
        }

        // POST: PhieuGiaoNhan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhieuGiaoNhan,MaDonVi,NgayGiaoNhan")] PhieuGiaoNhan phieuGiaoNhan)
        {
            if (ModelState.IsValid)
            {
                db.PhieuGiaoNhan.Add(phieuGiaoNhan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDonVi = new SelectList(db.DonVi, "MaDonVi", "TenDonVi", phieuGiaoNhan.MaDonVi);
            return View(phieuGiaoNhan);
        }

        // GET: PhieuGiaoNhan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuGiaoNhan phieuGiaoNhan = db.PhieuGiaoNhan.Find(id);
            if (phieuGiaoNhan == null)
            {
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
        public ActionResult Edit([Bind(Include = "MaPhieuGiaoNhan,MaDonVi,NgayGiaoNhan")] PhieuGiaoNhan phieuGiaoNhan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuGiaoNhan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDonVi = new SelectList(db.DonVi, "MaDonVi", "TenDonVi", phieuGiaoNhan.MaDonVi);
            return View(phieuGiaoNhan);
        }

        // GET: PhieuGiaoNhan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuGiaoNhan phieuGiaoNhan = db.PhieuGiaoNhan.Find(id);
            if (phieuGiaoNhan == null)
            {
                return HttpNotFound();
            }
            return View(phieuGiaoNhan);
        }

        // POST: PhieuGiaoNhan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhieuGiaoNhan phieuGiaoNhan = db.PhieuGiaoNhan.Find(id);
            db.PhieuGiaoNhan.Remove(phieuGiaoNhan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
