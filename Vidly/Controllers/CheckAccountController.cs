using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CheckAccountController : Controller
    {
        // GET: CheckAccount
        public ActionResult Index()
        {
            return View();
        }

        // GET: CheckAccount/Details
        public ActionResult Details()
        {
            var checkingAccount = new CheckingAccount
            {
                AccountNumber = "3333",
                FirstName = "",
                LastName = "",
                Balance = 500
            };
            return View(checkingAccount);
        }

        // GET: CheckAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckAccount/Create
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

        // GET: CheckAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckAccount/Edit/5
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

        // GET: CheckAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckAccount/Delete/5
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
