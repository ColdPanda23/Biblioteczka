using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekBook.Entities
{
    public class Shelf
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Floor { get; set; }
        public string Building { get; set; }
        public byte[]? QrCode { get; set; }
        
    }
}
