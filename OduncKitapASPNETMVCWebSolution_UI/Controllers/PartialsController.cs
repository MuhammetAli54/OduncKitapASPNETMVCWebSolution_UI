using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OduncKitapASPNETMVCWebSolution_BLL.Managers;
using OduncKitapASPNETMVCWebSolution_UI.Controllers;

namespace OduncKitapASPNETMVCWebSolution_UI.Controllers
{
    public class PartialsController : Controller
    {
        //Global alan
        KitapManager myKitapManager = new KitapManager();
        //Tüm partial'ları tek bir yerden yönetmek amacıyla partialsController oluşturduk.
        public PartialViewResult MenuPartialResult()
        {
            int toplamKitapSayisi = myKitapManager.TumAktifKitaplariGetir().Count();
            TempData["ToplamKitapSayisi"] = toplamKitapSayisi;

            return PartialView("_PartialMenu");
        }
    }
}