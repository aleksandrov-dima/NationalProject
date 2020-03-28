using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalProject.Models
{
    public class ProjectEntity
    {
        public int ID { get; set; }
       
        public string ProjectName { get; set; }
        public string State { get; set; }
        public string Website { get; set; }
        public decimal Budget { get; set; }
        public string LitleDescription { get; set; }
        public IEnumerable<ProjectEntityImage> Images { get; set; }
        public string Program { get; set; }
    }

    public class ProjectEntityImage
    {
        public string FileName { get; set; }
        public int widthRatio { get; set; }
        public int heightRatio { get; set; }
    }

    public class ProjectEntityPrograms
    {
        public int ID { get; set; }
        public string ProgramName { get; set; }
        public string LitleDescription { get; set; }
    }
}
