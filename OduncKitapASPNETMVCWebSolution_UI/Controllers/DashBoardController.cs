using OduncKitapASPNETMVCWebSolution_BLL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OduncKitapASPNETMVCWebSolution_UI.Controllers
{
    public class DashBoardController : Controller
    {
        //Global alan
        KitapManager myKitapManager = new KitapManager();
        // GET: DashBoard
        public ActionResult Index()
        {
            ViewBag.BugunEklenenKitapSayisi = myKitapManager.TumAktifKitaplariGetir().Where(x => x.KayitTarihi > DateTime.Now.AddDays(-1) && x.KayitTarihi < DateTime.Now.AddDays(1)).Count();

            return View();
        }
    }
}