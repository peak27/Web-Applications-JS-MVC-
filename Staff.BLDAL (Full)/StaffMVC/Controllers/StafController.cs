using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StaffMVC.Models;
using Staff.BLDAL.DTO;

namespace StaffMVC.Controllers
{
    public class StafController : Controller
    {
        // GET: Staf
        public ActionResult Index()
        {
            using (DBModel db = new DBModel()){
                return View(db.Staffs.ToList());
            }
            
        }

        // GET: Staf/Details/5
        public ActionResult Details(int id)
        {
            using (DBModel db = new DBModel())
            {
                return View(db.Staffs.Where(x => x.StaffID == id).FirstOrDefault());

            }
            
        }

        // GET: Staf/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staf/Create
        [HttpPost]
        public ActionResult Create(StaffMVC.Models.Staff staff)
        {
            try
            {
                // TODO: Add insert logic here
                using (DBModel db = new DBModel())
                {
                    db.Staffs.Add(staff);
                    db.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staf/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModel db = new DBModel())
            {
                return View(db.Staffs.Where(x => x.StaffID == id).FirstOrDefault());

            }
        }

        // POST: Staf/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StaffMVC.Models.Staff staff)
        {
            try
            {
                // TODO: Add update logic here
                using (DBModel db = new DBModel())
                {
                    db.Entry(staff).State = System.Data.EntityState.Modified;
                    db.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staf/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModel db = new DBModel())
            {
                return View(db.Staffs.Where(x => x.StaffID == id).FirstOrDefault());

            }
        }

        // POST: Staf/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, StaffMVC.Models.Staff staff)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModel db = new DBModel())
                {
                    staff = db.Staffs.Where(x => x.StaffID == id).FirstOrDefault();
                    db.Staffs.Remove(staff);
                    db.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
