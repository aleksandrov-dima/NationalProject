using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using NationalProject.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace NationalProject.Controllers {

    public class OrdersController : Controller {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(SampleData.Orders, loadOptions);
        }

    }
}