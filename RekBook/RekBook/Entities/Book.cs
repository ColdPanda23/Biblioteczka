using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekBook.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string?  ISBN { get; set; }
        public DateTime? YearOfPublication { get; set; }
        public string? Description { get; set; }
        public byte[]? QrCode { get; set; }

        public Publisher Publisher { get; set; }
        public Category Category { get; set; }
        public Shelf Shelf { get; set; }
        public virtual ICollection<Author> Authors{ get; set; }

    }
}
