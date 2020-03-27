using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using NationalProject.Models;

namespace NationalProject.Controllers
{
    public class AccordionController : Controller
    {
        public ActionResult Overview()
        {
            return View();
        }

        [HttpGet]
        public object GetData(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.ProjectEntitys, loadOptions);
        }
    }
}