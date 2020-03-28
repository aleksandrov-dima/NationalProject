using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalProject.Models {
    public static class SampleData {        

        public static List<ProjectEntity> ProjectEntitys = new List<ProjectEntity>() {
            new ProjectEntity {
                ID = 1,
                ProjectName = "Здравоохранение",
                LitleDescription = "Образ жизни. Здравоохранение и медицина",
                Images = new[] {
                    new ProjectEntityImage { FileName = "zdrav_icon.png" },
                    new ProjectEntityImage { FileName = "zdrav_programs.png" },
                    new ProjectEntityImage { FileName = "zdrav_programs.png", widthRatio = 2, heightRatio = 2 },
                    new ProjectEntityImage { FileName = "zdrav_tasks.png", widthRatio = 2, heightRatio = 2 }
                },
                Program = "Программа Здравоохранения 1"
            },
            new ProjectEntity {
                ID = 2,
                ProjectName = "Здравоохранение",
                LitleDescription = "Образ жизни. Здравоохранение и медицина",
                Images = new[] {
                    new ProjectEntityImage { FileName = "zdrav_icon.png" },
                    new ProjectEntityImage { FileName = "zdrav_programs.png" },
                    new ProjectEntityImage { FileName = "zdrav_programs.png", widthRatio = 2, heightRatio = 2 },
                    new ProjectEntityImage { FileName = "zdrav_tasks.png", widthRatio = 2, heightRatio = 2 }
                },
                Program = "Программа Здравоохранения 2"
            },
            new ProjectEntity {
                ID = 3,
                ProjectName = "Здравоохранение",
                LitleDescription = "Образ жизни. Здравоохранение и медицина",
                Images = new[] {
                    new ProjectEntityImage { FileName = "zdrav_icon.png" },
                    new ProjectEntityImage { FileName = "zdrav_programs.png" },
                    new ProjectEntityImage { FileName = "zdrav_programs.png", widthRatio = 2, heightRatio = 2 },
                    new ProjectEntityImage { FileName = "zdrav_tasks.png", widthRatio = 2, heightRatio = 2 }
                },
                Program = "Программа Здравоохранения 3"
            },
            new ProjectEntity {
                ID = 4,
                ProjectName = "Демография",
                LitleDescription = "Краткое описание",
                Images = new[] {
                    new ProjectEntityImage { FileName = "demograf_icon.png" },
                    new ProjectEntityImage { FileName = "demograf_programs.png", widthRatio = 2, heightRatio = 2 },
                    new ProjectEntityImage { FileName = "demograf_tasks.png", widthRatio = 2, heightRatio = 2 }
                },
                Program = "Содействие занятости женщин"
            },
            new ProjectEntity {
                ID = 5,
                ProjectName = "Демография",
                LitleDescription = "Краткое описание",
                Images = new[] {
                    new ProjectEntityImage { FileName = "demograf_icon.png" },
                    new ProjectEntityImage { FileName = "demograf_programs.png", widthRatio = 2, heightRatio = 2 },
                    new ProjectEntityImage { FileName = "demograf_tasks.png", widthRatio = 2, heightRatio = 2 }
                },
                Program = "Спорт норма жизни"
            },
            new ProjectEntity {
                ID = 6,
                ProjectName = "Демография",
                LitleDescription = "Краткое описание",
                Images = new[] {
                    new ProjectEntityImage { FileName = "demograf_icon.png" },
                    new ProjectEntityImage { FileName = "demograf_programs.png", widthRatio = 2, heightRatio = 2 },
                    new ProjectEntityImage { FileName = "demograf_tasks.png", widthRatio = 2, heightRatio = 2 }
                },
                Program = "Старшее поколение"
            },
            new ProjectEntity {
                ID = 7,
                ProjectName = "Демография",
                LitleDescription = "Краткое описание",
                Images = new[] {
                    new ProjectEntityImage { FileName = "demograf_icon.png" },
                    new ProjectEntityImage { FileName = "demograf_programs.png", widthRatio = 2, heightRatio = 2 },
                    new ProjectEntityImage { FileName = "demograf_tasks.png", widthRatio = 2, heightRatio = 2 }
                },
                Program = "Укрепление общественного здоровья"
            }
        };
        //70,3	70,8	70,62	71,35	71,52	72,73	73,5	74,2
        public static readonly IEnumerable<ParetoChartData> ParetoChartData = new[] {
            new ParetoChartData()
            {
                year = "2012",
                budjet = null,
                factAge = 70.3,
                planDate = null,
                events = "<p><a href=\"#\" target=\"_blank\">Майские указы</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">Майские указы 2</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">Июнские указы </a></p>"
            },
            new ParetoChartData()
            {
                year = "2013",
                budjet = null,
                factAge = 70.8,
                planDate = null,
                events = "<p><a href=\"#\" target=\"_blank\">Майские указы</a></p>"
            },
            new ParetoChartData()
            {
                year = "2014",
                budjet = null,
                factAge = 70.62,
                planDate = null,

            },
            new ParetoChartData()
            {
                year = "2015",
                budjet = null,
                factAge = 71.35,
                planDate = null
            },
            new ParetoChartData()
            {
                year = "2016",
                budjet = 10,
                factAge = 71.52,
                planDate = null,
                events = "<p><a href=\"#\" target=\"_blank\">События 1</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">События 2</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">События 3 </a></p>"
            },
            new ParetoChartData()
            {
                year = "2017",
                budjet = 11,
                factAge = 72.73,
                planDate = 68,
                events = "<p><a href=\"#\" target=\"_blank\">События 1</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">События 2</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">События 3 </a></p>"
            },
            new ParetoChartData()
            {
                year = "2018",
                budjet = 12,
                factAge = 73.5,
                planDate = 70,
                events = "<p><a href=\"#\" target=\"_blank\">События 1</a></p>"
            },
            new ParetoChartData()
            {
                year = "2019",
                budjet = 20.71,
                factAge = 74.2,
                planDate = 72,
                events = "<p><a href=\"#\" target=\"_blank\">События 1</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">События 2</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">События 3 </a></p>"
            },
            new ParetoChartData()
            {
                year = "2020",
                budjet = 25.33,
                factAge = null,
                planDate = 73.83,
                events = "<p><a href=\"#\" target=\"_blank\">События 1</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">События 2</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">События 3 </a></p>"
            },
            new ParetoChartData()
            {
                year = "2021",
                budjet = 26.96,
                factAge = null,
                planDate = 74.25
            },
            new ParetoChartData()
            {
                year = "2022",
                budjet = 31.48,
                factAge = null,
                planDate = 74.65
            },
            new ParetoChartData()
            {
                year = "2023",
                budjet = 31.48,
                factAge = null,
                planDate = 75.04
            },
            new ParetoChartData()
            {
                year = "2024",
                budjet = 31.48,
                factAge = null,
                planDate = 75.42
            },
            new ParetoChartData()
            {
                year = "2025",
                budjet = null,
                factAge = null,
                planDate = 75.79 							
            },
            new ParetoChartData()
            {
                year = "2026",
                budjet = null,
                factAge = null,
                planDate = 76.15
            }
        };

    }
}
