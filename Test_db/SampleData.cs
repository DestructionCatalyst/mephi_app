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
                        t = "27.08.2019,10:30",
                        IDPlace = 1
                    },
                    new news
                    {
                        name = "Инструкция по применению: ЛаПлаз",
                        place = "Aктовый зал",
                        institution = 2,
                        t = "28.08.2019,10:30",
                        IDPlace = 1
                    },
                new news
                    {
                        name = "Кубок МИФИ по программированию",
                        place = "Корпус В",
                        institution = 0,
                        t = "27.09.2019,16:30",
                        IDPlace = 2
                    },
                    new news
                    {
                        name = "Ярмарка вакансий",
                        place = "Актовый зал",
                        institution = 0,
                        t = "14.11.2019,10:15",
                        IDPlace = 1
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
                        from = "01.09.2019",
                        to = "27.09.2019",
                        IDPlace = 1
                    },
                    new remind
                    {
                        name = "Получить книги в библиотеке",
                        place = "Абонемент учебной литературы (Г-053)",
                        from = "20.08.2019",
                        to = "01.09.2019",
                        IDPlace = 3
                    },
                    new remind
                    {
                        name = "Встать на воинский учёт",
                        place = "Военно-мобилизационное управление, военкомат по месту проживания",
                        from = "01.09.2019",
                        to = "30.09.2019",
                        IDPlace = 3
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
                        text = "Учебный отдел Института интеллектуальных кибернетических систем. Открыт с 8:30 до 17:50.",
                        IDPlace = 1
                    },
                    new qr
                    {
                        name = "А-100",
                        text = "Лекционная аудитория, оборудована микрофоном и проекторами.",
                        IDPlace = 1
                    },
                     new qr
                     {
                         name = "В-204б",
                         text = "Компьютерная лаборатория.",
                         IDPlace = 2
                     }
                );
                context.SaveChanges();
            }
            if (!context.institutions.Any())
            {
                Console.WriteLine("Institutions!");
                context.institutions.AddRange(

                    new institution
                    {
                       // ID = 1,
                        name = "ИЯФиТ",
                        IDDec = 1
                        
                    },
                    new institution
                    {
                       // ID = 2,
                        name = "ЛаПлаз",
                        IDDec = 2
                        
                    },
                     new institution
                     {
                       //  ID= 5,
                         name = "ИИКС",
                         IDDec = 3
                         
                     }
                ); ;
                context.SaveChanges();
            }
            if (!context.dots.Any())
            {
                Console.WriteLine("Dots!");
                context.dots.AddRange(

                    new dot
                    {
                        //ID = 1,
                        x = 1,
                        y = 1

                    },
                    new dot
                    {
                        //ID = 2,
                        x = 2,
                        y = 2

                    },
                     new dot
                     {
                        // ID = 3,
                         x = 3,
                         y = 3

                     }
                ); ;
                context.SaveChanges();
            }
            if (!context.ways.Any())
            {
                Console.WriteLine("Ways!");
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
                Console.WriteLine("Groups!");
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
