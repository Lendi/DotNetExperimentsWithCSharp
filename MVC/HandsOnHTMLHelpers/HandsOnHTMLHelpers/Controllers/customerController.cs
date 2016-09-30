using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HandsOnHTMLHelpers.Models;

namespace HandsOnHTMLHelpers.Controllers
{
    public class customerController : Controller
    {
        //
        // GET: /customer/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult create() {
            return View();
        }

        public ActionResult show(customer obj) {
            return View(obj);
        }

    }
}
