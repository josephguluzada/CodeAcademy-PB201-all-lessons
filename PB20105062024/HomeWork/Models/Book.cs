using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Book
    {
        private static int _counter = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public string Code { get; set; }

        public Book(string name)
        {
            Id = ++_counter;
            Code = Helper.CreateBookCode(name, Id);
        }


    }
}
