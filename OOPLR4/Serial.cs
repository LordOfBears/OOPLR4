using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR4
{
    public class Serial : ISerial
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public int Style { get; set; }
        public int NumberParts { get; set; }
        public Serial(string name, int mark, int style, int numberParts)
        {
            Name = name;
            Mark = mark;
            Style = style;
            NumberParts = numberParts;
        }
        public void PrintInfo()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-> Название сериала " + this.Name);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-> Оценка сериала   " + this.Mark);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-> Жанр сериала     " + this.Style);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-> Количество серий " + this.NumberParts);
            Console.WriteLine();
        }
    }
}
