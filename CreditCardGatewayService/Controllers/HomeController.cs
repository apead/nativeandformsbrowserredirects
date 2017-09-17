using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreditCardGatewayService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CardSuccess()
        {
            return View();
        }

        public ActionResult CardProcess(string operation)
        {
            ViewBag.Message = "Your application description page.";

            if (operation == "sucessprocess")
                return RedirectToAction("CardSuccess", "Home");

            return RedirectToAction("CardDeclined", "Home");
        }

        public ActionResult CardDeclined()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}