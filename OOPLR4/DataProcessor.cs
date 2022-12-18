using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR4
{
    public class DataProcessor<T>
    {
        public static List<T> CreateTop(List<IFilm> list)
        {
            var filtredList = list
                    .Where(x => x.Mark >= 3)
                    .Where(x => x.Mark < 5)
                    .OrderBy(x => x.Mark)
                    .Reverse()
                    .Take(3);
            List<T> top = new List<T>();
            foreach (T item in filtredList)
                top.Add(item);
            return top;
        }
        public static List<T> Search(List<IFilm> list, int request)
        {
            if (request < 1)
            {
                throw new MarkException("!!! Ошибка, число должно быть положительным !!!");
            }
            var foundObjects = list.Where(x => x.Mark == request);
            List<T> result = new List<T>();
            foreach (T item in foundObjects)
                result.Add(item);
            return result;
        }

    }
}
