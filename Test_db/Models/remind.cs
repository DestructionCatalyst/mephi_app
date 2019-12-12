using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_db.Models
{
    public class remind
    {
        public int ID { get; set; }
        public string name { get; set; }
        
        public string from { get; set; }
        public string to { get; set; }
        public string place { get; set; }
        public string text { get; set; }
        
        public int IDPlace { get; set; }
    }
}
