using MVCCrudWithTemplateAndStronglyTypeView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrudWithTemplateAndStronglyTypeView.Controllers
{
   
    public class EmployeeManagementPortalController : Controller
    {

        public static List<ClsEmployee> Employees = new List<ClsEmployee>()
        {
             new ClsEmployee { EmpID = 1, FirstName = "Aaron", LastName = "Hawkins", Password = "arron@123", CellNumber = "(660) 663-4518", Email = "aron.hawkins@aol.com" },
             new ClsEmployee { EmpID = 2, FirstName = "Hedy", LastName = "Greene", Password = "hedy@123", CellNumber = "(608) 265-2215", Email = "hedy.greene@aol.com" },
             new ClsEmployee { EmpID = 3, FirstName = "Melvin", LastName = "Porter", Password = "melvin@123", CellNumber = "(959) 119-8364", Email = "melvin.porter@aol.com" }

        };

        // GET: EmployeeManagementPortal
        public ActionResult Index()
        {
            return View(Employees.ToList());
        }

        // GET: EmployeeManagementPortal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeManagementPortal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeManagementPortal/Create
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

        // GET: EmployeeManagementPortal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeManagementPortal/Edit/5
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

        // GET: EmployeeManagementPortal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeManagementPortal/Delete/5
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
