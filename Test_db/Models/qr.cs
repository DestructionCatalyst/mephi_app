using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_db.Models
{
    public class qr
    {
        public int key { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public byte[] top_img { get; set; }
    }
}
