using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace imaykana.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult AccountView(string Id)
        {

            var accountmodel = new Amaykana.Models.ListaUsuarios();
            accountmodel.Usuarios();

            ViewBag.Message = "Your application description page.";
            ViewBag.Total = accountmodel.Total();
            ViewBag.Id = Id;

            return View(accountmodel);
        }

        public ActionResult SelectSocialProject()
        {
            return View();
        }

        public ActionResult BarScan(string parameter)
        {

            if (parameter == "p")
            {
                ViewBag.Id = parameter;
            }

            return View();
        }
    }
}