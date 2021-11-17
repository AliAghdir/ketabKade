using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KetabKade.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int pic { get; set; }
        public int price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
