using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeClient.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            List<ServiceReference1.Employee> list = obj.GetEmpDetails();
            return View(list);
        }

    }
}
