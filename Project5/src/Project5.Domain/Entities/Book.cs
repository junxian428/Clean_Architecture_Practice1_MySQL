using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.Domain.Entities
{
    public class Book
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public string Author { get; init; }
        public int Year { get; init; }
    }
}
