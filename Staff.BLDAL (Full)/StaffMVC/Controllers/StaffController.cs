using Staff.BLDAL.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaffMVC.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
       
        public ActionResult Index()
        {
            List<Staff.BLDAL.DTO.Staff> model = StaffBLL.Staff_SelectList();

            return View(model);
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            return View(new Staff.BLDAL.DTO.Staff());
        }

        // POST: Staff/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Staff.BLDAL.DTO.Staff model)
        {
            if (ModelState.IsValid)
            {
                if (StaffBLL.Staff_Insert(model))
                {
                    return RedirectToAction("Index");
                }
                else
                {

                    return View(model);
                }
            }

            return View(model);

        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Staff/Edit/5
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

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Staff/Delete/5
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
