using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR4
{
    public class Film : IFilm
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public int Style { get; set; }
        public Film(string name, int mark, int style)
        {
            Name = name;
            Mark = mark;
            Style = style;
        }
        public void PrintInfo()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-> Название фильма " + this.Name);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-> Оценка фильма   " + this.Mark);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-> Жанр фильма     " + this.Style);
            Console.WriteLine();
        }
    }
}
