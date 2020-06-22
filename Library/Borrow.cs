using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Borrow
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public Reader Reader { get; set; }
        public int ReaderId { get; set; }
    }
}
