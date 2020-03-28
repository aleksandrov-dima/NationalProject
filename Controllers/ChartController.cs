using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationalProject.Models;

namespace NationalProject.Controllers
{
    public class ChartController : Controller
    {
        public ActionResult ParetoChart()
        {
            return View();
        }
        public ActionResult Overview()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<object> GetComplaintsData()
        {
            var dataSource = new List<object>();
            var sortedParetoData = SampleData.ParetoChartData.OrderBy(i => i.year);
            //var totalCount = sortedParetoData.Sum(i => i.count);

            foreach (var item in sortedParetoData)
            {
                dataSource.Add(new
                {
                    item.year,
                    item.budjet,
                    item.factAge,
                    item.planDate,
                    item.events
                });
            }

            return dataSource;
        }
    }
}