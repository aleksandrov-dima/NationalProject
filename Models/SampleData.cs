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


        public static readonly IEnumerable<ParetoChartData> ParetoChartData = new[] {
            new ParetoChartData()
            {
                year = "2012",
                budjetFact = null,
                factAge = 61.5,
                events = "<p><a href=\"#\" target=\"_blank\">Майские указы</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">Майские указы 2</a></p>"+
                         "<p><a href=\"#\" target=\"_blank\">Июнские указы </a></p>"
            },
            new ParetoChartData()
            {
                year = "2013",
                budjetFact = null,
                factAge = 61.8,
                events = "<p><a href=\"#\" target=\"_blank\">Майские указы</a></p>"
            },
            new ParetoChartData()
            {
                year = "2014",
                budjetFact = null,
                factAge = 62

            },
            new ParetoChartData()
            {
                year = "2015",
                budjetFact = null,
                factAge = 62.4
            },
            new ParetoChartData()
            {
                year = "2016",
                budjetFact = 8,
                budjetPlan =  10,
                factAge = 63,
                events = "<ul><li><a href=\"#\">Событие 1</a></li>"+
                         "<li><a href=\"#\">Событие 2</a></li></ul>"
            },
            new ParetoChartData()
            {
                year = "2017",
                budjetFact = 9,
                budjetPlan =  11,
                factAge = 63.2,
                events = "<ul><li><a href=\"#\">Событие 1</a></li>"+
                         "<li><a href=\"#\">Событие 2</a></li></ul>"
            },
            new ParetoChartData()
            {
                year = "2018",
                budjetPlan =  12,
                budjetFact = 9,
                factAge = 63.6,
                events = "<ul><li><a href=\"#\">Событие 1</a></li>"+
                         "<li><a href=\"#\">Событие 2</a></li></ul>"
            },
            new ParetoChartData()
            {
                year = "2019",
                budjetPlan = 76.71,
                budjetFact = 32,
                factAge = 64.2,
                events = "<ul><li><a href=\"http://minec.cap.ru/news/2019/04/11/priglashaem-organizacii-chuvashskoj-respubliki-pri\">Форум InnoMed</a></li>"+
                         "<li><a href=\"http://minec.cap.ru/news/2019/04/13/problemi-razvitiya-malogo-i-srednego-biznesa-obsuz\">Круглый стол с мылым бизнесом</a></li></ul>"
            },
            new ParetoChartData()
            {
                year = "2020",
                budjetPlan = 74.33,
                factAge = null,
                planAge = 65,
                events = "<ul><li><a href=\"#\">Событие 1</a></li>"+
                         "<li><a href=\"#\">Событие 2</a></li></ul>"
            },
            new ParetoChartData()
            {
                year = "2021",
                budjetPlan = 42.96,
                factAge = null,
                planAge = 65.5
            },
            new ParetoChartData()
            {
                year = "2022",
                budjetPlan = 31.5,
                factAge = null,
                planAge = 66
            },
            new ParetoChartData()
            {
                year = "2023",
                budjetPlan = 31.5,
                factAge = null,
                planAge = 66.5
            },
            new ParetoChartData()
            {
                year = "2024",
                budjetPlan = 31.48,
                factAge = null,
                planAge = 67
            },
            new ParetoChartData()
            {
                year = "2025",
                factAge = null,
                planAge = 67.3
            },
            new ParetoChartData()
            {
                year = "2026",
                factAge = null,
                planAge = 67.5
            },
            new ParetoChartData()
            {
                year = "2027",
                factAge = null,
                planAge = 67.9
            },
            new ParetoChartData()
            {
                year = "2028",
                factAge = null,
                planAge = 68.1
            },
            new ParetoChartData()
            {
                year = "2029",
                factAge = null,
                planAge = 68.2
            },
            new ParetoChartData()
            {
                year = "2030",
                factAge = null,
                planAge = 68.4
            }
        };

    }
}
