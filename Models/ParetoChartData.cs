using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalProject.Models
{
    public class ParetoChartData
    {
        public String year { get; set; }
        public double? budjetFact { get; set; }
        public double? budjetPlan { get; set; }
        public double? factAge { get; set; }
        public double? planAge { get; set; }
        public string events { get; set; }
    }

    public class ParetoChartDataProgramDemography
    {
        public String year { get; set; }
        public double? budjetFact { get; set; }
        public double? budjetPlan { get; set; }
        public double? factPeaplePercent { get; set; }
        public double? planPeaplePercent { get; set; }
        public string events { get; set; }
    }
}
