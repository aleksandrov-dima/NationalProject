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
    [Produces("application/json")]
    [Route("api/ActionsOverview")]
    public class ActionsOverviewController : Controller
    {
        [HttpGet]
        public object Get(DataSourceLoadOptions options)
        {
            return DataSourceLoader.Load(SampleData.ProjectEntitys, options);
        }
    }
}