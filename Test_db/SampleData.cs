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
        }
    }
}
