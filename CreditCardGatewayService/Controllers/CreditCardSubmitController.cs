using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreditCardGatewayService.Controllers
{
    public class CreditCardSubmitController : Controller
    {
        // GET: CreditCardSubmit
        public ActionResult Index()
        {
            return View();
        }

        // GET: CreditCardSubmit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CreditCardSubmit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreditCardSubmit/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CreditCardSubmit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CreditCardSubmit/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CreditCardSubmit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CreditCardSubmit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
