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
            var sortedParetoData = SampleData.ParetoChartDataProgramDemography.OrderBy(i => i.year);

            foreach (var item in sortedParetoData)
            {
                dataSource.Add(new
                {
                    item.year,
                    item.budjetPlan,
                    item.budjetFact,
                    item.factPeaplePercent,
                    item.planPeaplePercent,
                    item.events
                });
            }

            return dataSource;
        }
    }
}