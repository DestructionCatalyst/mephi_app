using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_db.Models
{
    public class news
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int institution { get; set; }
        public DateTime t { get; set; }
        public string place { get; set; }
        public string text { get; set; }
        public byte [] top_img { get; set; }

        
    }
}
