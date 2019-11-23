using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_db.Models;

namespace Test_db
{
    public class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            //Console.WriteLine("Initialized!");
            if (!context.newss.Any())
            {
                context.newss.AddRange(
                    new news
                    {
                        name = "Инструкция по применению: ИИКС",
                        place = "Aктовый зал",
                        institution = 5,
                        t = new DateTime(2019,8,27,10,30,0)
                    },
                    new news
                    {
                        name = "Кубок МИФИ по программированию",
                        place = "Корпус В",
                        institution = 0,
                        t = new DateTime(2019, 9, 27, 16, 30, 0)
                    },
                    new news
                    {
                        name = "Ярмарка вакансий",
                        place = "Актовый зал",
                        institution = 0,
                        t = new DateTime(2019, 11, 14, 10, 15, 0)
                    }
                ) ; 
                context.SaveChanges();
            }

            if (!context.reminds.Any())
            {
                //Console.WriteLine("Reminder!");
                context.reminds.AddRange(

                    new remind
                    { 
                        name = "Подать документы на студенческий билет и зачётную книжку",
                        place = "Учебный отдел Вашего института",
                        from = new DateTime(2019, 9, 1, 0, 0, 0),
                        to = new DateTime(2019, 9, 27, 0, 0, 0)
                    },
                    new remind
                    {
                        name = "Получить книги в библиотеке",
                        place = "Абонемент учебной литературы (Г-053)",
                        from = new DateTime(2019, 8, 20, 0, 0, 0),
                        to = new DateTime(2019, 9, 1, 0, 0, 0)
                    },
                    new remind
                    {
                        name = "Встать на воинский учёт",
                        place = "Военно-мобилизационное управление, военкомат по месту проживания",
                        from = new DateTime(2019, 9, 1, 0, 0, 0),
                        to = new DateTime(2019, 9, 30, 0, 0, 0)
                    }
                );
                context.SaveChanges();
            }
            if (!context.qrs.Any())
            {
                //Console.WriteLine("Reminder!");
                context.qrs.AddRange(

                    new qr
                    {
                        name = "Г-309",
                        text = "Учебный отдел Института интеллектуальных кибернетических систем. Открыт с 8:30 до 17:50."
                    },
                    new qr
                    {
                        name = "А-100",
                        text = "Лекционная аудитория, оборудована микрофоном и проекторами."
                    },
                     new qr
                     {
                         name = "В-204б",
                         text = "Компьютерная лаборатория."
                     }
                );
                context.SaveChanges();
            }
            if (!context.institutions.Any())
            {
                //Console.WriteLine("Reminder!");
                context.institutions.AddRange(

                    new institution
                    {
                        ID = 1,
                        name = "ИЯФиТ"
                        
                    },
                    new institution
                    {
                        ID  =2,
                        name = "ЛаПлаз"
                        
                    },
                     new institution
                     {
                         ID= 5,
                         name = "ИИКС"
                         
                     }
                ); ;
                context.SaveChanges();
            }
            if (!context.dots.Any())
            {
                //Console.WriteLine("Reminder!");
                context.dots.AddRange(

                    new dot
                    {
                        ID = 1,
                        x = 1,
                        y = 1

                    },
                    new dot
                    {
                        ID = 2,
                        x = 2,
                        y = 2

                    },
                     new dot
                     {
                         ID = 3,
                         x = 3,
                         y = 3

                     }
                ); ;
                context.SaveChanges();
            }
            if (!context.ways.Any())
            {
                //Console.WriteLine("Reminder!");
                context.ways.AddRange(

                    new way
                    {
                        IDStart = 1,
                        IDEnd=2,
                        len = 1.4

                    },
                    new way
                    {
                        IDStart = 1,
                        IDEnd = 3,
                        len = 2.8

                    },
                     new way
                     {
                         IDStart = 2,
                         IDEnd = 3,
                         len = 10

                     }
                ); ;
                context.SaveChanges();
            }
            if (!context.groups.Any())
            {
                //Console.WriteLine("Reminder!");
                context.groups.AddRange(

                    new Group
                    {
                        name = "Б19-101",
                        IDInst = 1

                    },
                    new Group
                    {
                        name = "Б19-201",
                        IDInst = 2

                    },
                     new Group
                     {
                         name = "Б19-514",
                         IDInst = 5

                     }
                ); ;
                context.SaveChanges();
            }
        }
    }
}
