using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201List.Models
{
    public class Student
    {
        private static int _counter = 0;
        public int Id { get;private set; }
        public string Name { get; set; }
        public double Grade { get; set; }
        public Student()
        {
            Id = ++_counter;
        }
    }
}
