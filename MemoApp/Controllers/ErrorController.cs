using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemoApp.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        [Route("Error/Index/{id}")]
        public ActionResult Index()
        {
            return View();
        }
    }
}