using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR4
{
    public class Book : IArt
    {
        public string Name { get; set; }
        public Book(string name)
        {
            Name = name;
        }
        public void PrintInfo()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-> Название книги " + this.Name);
            Console.WriteLine();
        }
    }
}
