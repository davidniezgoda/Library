using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishmentYear { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}
