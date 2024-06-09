using QLDP_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDP_02.Controllers
{
    public class HomeController : Controller
    {
        private DB_QLDPEntities db = new DB_QLDPEntities();
        public ActionResult Index()
        {
            DM_DP_LoaiSanPham dM_DP_LoaiSanPham = new DM_DP_LoaiSanPham();
            dM_DP_LoaiSanPham.IPNhap = "127.0.0.1";
            dM_DP_LoaiSanPham.IPXoa = "";
            dM_DP_LoaiSanPham.MayNhap = "";
            dM_DP_LoaiSanPham.MaySua = "";
            dM_DP_LoaiSanPham.MayXoa = "";
            dM_DP_LoaiSanPham.NgayNhap = DateTime.Now;
            dM_DP_LoaiSanPham.NgayTao = DateTime.Now;
            dM_DP_LoaiSanPham.NgaySua = DateTime.Now;
            dM_DP_LoaiSanPham.NgayXoa = DateTime.Now;
            dM_DP_LoaiSanPham.IsDel = false;
            dM_DP_LoaiSanPham.IsCoSize = false;
            dM_DP_LoaiSanPham.LoaiSanPham = 6;
            dM_DP_LoaiSanPham.MaLoaiSanPham = "06";
            dM_DP_LoaiSanPham.TenLoaiSanPham = "Nón";
            dM_DP_LoaiSanPham.TenLoaiSanPham_EN = "Hat";
            dM_DP_LoaiSanPham.TenLoaiSanPham_JP = "帽子";

            db.DM_DP_LoaiSanPham.Add(dM_DP_LoaiSanPham);
            db.SaveChanges();


            return View();
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

        
    }
}