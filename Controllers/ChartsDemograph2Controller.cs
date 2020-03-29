using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationalProject.Models;

namespace NationalProject.Controllers
{
    public class ChartsDemograph2Controller : Controller
    {
        public ActionResult ParetoChart()
        {
            return View();
        }
        public ActionResult Overview()
        {
            return View();
        }

        public IActionResult OnGetPartial() => new PartialViewResult
                    {
                        ViewName = "_ChartsDemograph2",
                        ViewData = ViewData,
                    };

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
                    item.budjetPlan,
                    item.budjetFact,
                    item.factAge,
                    item.planAge,
                    item.events
                });
            }

            return dataSource;
        }
    }
}