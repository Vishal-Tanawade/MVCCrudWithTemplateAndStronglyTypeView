using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrudWithTemplateAndStronglyTypeView.Controllers
{
    public class EmployeeManagementPortalController : Controller
    {
        // GET: EmployeeManagementPortal
        public ActionResult Index()
        {
            return View();
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
