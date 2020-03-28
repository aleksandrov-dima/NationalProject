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

        

       
    }
}
