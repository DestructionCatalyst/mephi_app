using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_db.Models
{
    public class Way
    {
        public int ID { get; set; }
        public int IDStart { get; set; }
        public int IDEnd { get; set; }
        public double len { get; set; }
    }
}
