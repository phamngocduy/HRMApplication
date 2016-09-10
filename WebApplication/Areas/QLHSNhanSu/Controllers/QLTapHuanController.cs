using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRM.QLTTNhanSu.Controllers
{
    public class QLTapHuanController : Controller
    {
        //
        // GET: /QLTapHuan/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /QLTapHuan/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /QLTapHuan/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /QLTapHuan/Create

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

        //
        // GET: /QLTapHuan/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /QLTapHuan/Edit/5

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

        //
        // GET: /QLTapHuan/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /QLTapHuan/Delete/5

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
