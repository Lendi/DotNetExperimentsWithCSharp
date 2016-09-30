using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayRoll.BusinessLayer;
using PayRoll.DataLayer;


namespace PayRoll.MVCUI.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        EmployeeBAL obj = new EmployeeBAL();

        public ActionResult Index()
        {
            List<Employee> list = obj.GetEmpDetails();
            return View(list);
        }

        public ActionResult Create() {//this method executed by default
            return View();
        }

        [HttpPost]//the action method with httppost gets executed on clicking the button
        public ActionResult Create(Employee e1) {//to add data to backend table, this form is executed
            obj.AddEmployee(e1);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int eid) {
            Employee e = obj.GetEmpById(eid);
            return View(e);
        }

        public ActionResult Delete(int eid) {
            obj.DeleteEmployee(eid);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int eid) {
            Employee e = obj.GetEmpById(eid);
            return View(e);
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            obj.UpdateEmployee(e.Eid, e);
                return RedirectToAction("Index");
        }

    }
}
