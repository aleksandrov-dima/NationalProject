using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NationalProject.Controllers
{
    public class CommonController : Controller
    {
        public ActionResult ActionAndListsOverview()
        {
            return View();
        }
    }
}