using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekBook.Entities
{
    public class Borrow
    {
        public int Id { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }


        public Employee Employee { get; set; }
        public Book Book { get; set; }
       
 


    }
}
