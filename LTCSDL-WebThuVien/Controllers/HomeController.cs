using LTCSDL_WebThuVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTCSDL_WebThuVien.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new dbWebThuVienContext();
            var sach = db.Sach.ToList();
            ViewData["sach"] = sach;
            return View(sach);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LoaiSanPham()
        {
            var db = new dbWebThuVienContext();
            var loaiSach = db.LoaiSach.ToList();
            ViewData["loaisach"] = loaiSach;
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}