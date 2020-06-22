using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Place
    {
        public int Id { get; set; }
        public int Stand { get; set; }
        public int Shelf { get; set; }
        public int Number { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
