using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace OOPLR4
{
    public class Program
    {
        public static void Main()
        {
            bool gogo = true;
            List<IArt> all = new List<IArt>();

            List<IFilm> filmsAndSerials = new List<IFilm>();
            List<Book> books = new List<Book>();

            while (gogo)
            {
                Console.WriteLine("================================");
                Console.WriteLine("------- Сколько фильмов? -------");
                int countFilms = int.Parse(Console.ReadLine());
                Console.WriteLine("------- Сколько сериалов? ------");
                int countSerials = int.Parse(Console.ReadLine());
                Console.WriteLine("------- Сколько книг? ----------");
                int countBooks = int.Parse(Console.ReadLine());
                Console.WriteLine("================================");
                for (int i = 0; i < countFilms + countSerials; i++)
                {
                    if (i < countFilms)
                    {
                        Console.WriteLine("------------ Фильм " + (i + 1) + " -----------");
                        Console.WriteLine("--- Введите название фильма " + (i + 1) + " --");
                        string name = Console.ReadLine();
                        Console.WriteLine("---- Введите оценку фильма " + (i + 1) + " ---");
                        int mark = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----- Укажите жанр фильма " + (i + 1) + " ----");
                        int style = Convert.ToInt32(Console.ReadLine());
                        filmsAndSerials.Add(new Film(name, mark, style));
                    }
                    if (i == countFilms) Console.WriteLine("================================");
                    if ((i >= countFilms) && (i < countSerials + countFilms))
                    {
                        Console.WriteLine("----------- Сериал " + (i + 1 - countFilms) + " -----------");
                        Console.WriteLine("-- Введите название сериала " + (i + 1 - countFilms) + " --");
                        string name = Console.ReadLine();
                        Console.WriteLine("--- Введите оценку сериала " + (i + 1 - countFilms) + " ---");
                        int mark = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("---- Укажите жанр сериала " + (i + 1 - countFilms) + " ----");
                        int style = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-- Укажите количество серий " + (i + 1 - countFilms) + " --");
                        int numberParts = Convert.ToInt32(Console.ReadLine());
                        filmsAndSerials.Add(new Serial(name, mark, style, numberParts));
                    }
                }
                Console.WriteLine("================================");
                for (int i = 0; i < countBooks; i++)
                {
                    Console.WriteLine("------------ Книга " + (i + 1) + " -----------");
                    Console.WriteLine("-- Введите название книги " + (i + 1) + " --");
                    string name = Console.ReadLine();
                    books.Add(new Book(name));
                }
                Console.WriteLine("================================");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("================================");
                Console.WriteLine("--->>> Средняя оценка:   " + FindMiddleMark(filmsAndSerials));
                Console.WriteLine("--->>> Максимальная оценка: " + FindMaxMark(filmsAndSerials));
                Console.WriteLine("--->>> Минимальная оценка: " + FindMinMark(filmsAndSerials));
                Console.WriteLine("================================");
                Console.WriteLine();
                int[] sortedStyles = SortStyles(filmsAndSerials);
                for (int i = 0; i < sortedStyles.Count(); i++)
                {
                    if (sortedStyles[i] != 0)
                    {
                        Console.WriteLine("================================");
                        Console.WriteLine("-->> Жанр " + i + ": просмотрено " + CountViews(filmsAndSerials, i));
                        Console.WriteLine("-->> Средняя оценка: " + FindMiddleMarkStyle(filmsAndSerials, i));
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("================================");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("================================");
                Console.WriteLine("----- Информация обо всём ------");

                for (int i = 0; i < countFilms; i++)
                {
                    all.Add(filmsAndSerials[i]);
                }
                for (int i = countFilms; i < countFilms + countSerials; i++)
                {
                    all.Add(filmsAndSerials[i]);
                }
                for (int i = 0; i < countBooks; i++)
                {
                    all.Add(books[i]);
                }

                for (int i = 0; i < all.Count(); i++)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("<<<--- Объект: " + (i + 1));
                    all[i].PrintInfo();
                }
                Console.WriteLine();
                Console.WriteLine();
                
                Console.WriteLine("================================");
                Console.WriteLine("-------- Рейтинг фильмов -------");
                var top = DataProcessor<IFilm>.CreateTop(filmsAndSerials);
                foreach (var item in top)
                {
                    item.PrintInfo();
                }
                bool getAnswer = false;
                while (!getAnswer)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("---------- Что делать? ---------");
                    Console.WriteLine("-->> 1. Найти фильм/сериал");
                    Console.WriteLine("-->> 2. Перезапустить программу");
                    Console.WriteLine("-->> 3. Завершить работу");
                    int usersAnswer = int.Parse(Console.ReadLine());
                    switch (usersAnswer)
                    {
                        case 1:
                            Console.WriteLine("================================");
                            Console.WriteLine("-------- Введите оценку --------");
                            bool requestWasReded = false;
                            int request = 0;
                            while (!requestWasReded)
                            {
                                try
                                {
                                    request = int.Parse(Console.ReadLine());
                                    var result = DataProcessor<IFilm>.Search(filmsAndSerials, request);
                                    if (result.Count() < 1)
                                        Console.WriteLine("<<-- Объект не найден -->>");
                                    else
                                    {
                                        result[0].PrintInfo();
                                    }
                                    requestWasReded = true;
                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine("!!! Ошибка, введите целое число !!!");
                                }
                                catch (MarkException ex)
                                {
                                    Console.WriteLine("!!! Ошибка, оценка должна быть положительной !!!");
                                }
                            }
                            break;
                        case 2:
                            getAnswer = true;
                            Console.Clear();
                            break;
                        case 3:
                            getAnswer = true;
                            gogo = false;
                            break;
                    }
                }
            }
        }
        public static double FindMiddleMark(List<IFilm> list)
        {
            double middleMark = 0;
            for (int i = 0; i < list.Count(); i++)
                middleMark += list[i].Mark;
            middleMark /= list.Count();
            return middleMark;
        }
        public static int FindMinMark(List<IFilm> list) 
        {
            int minMark = -1;
            for (int i = 0; i < list.Count(); i++)
            {
                if (i == 0)
                    minMark = list[i].Mark;
                else
                    if (minMark > list[i].Mark)
                        minMark = list[i].Mark;
            }
            return minMark;
        }
        public static int FindMaxMark(List<IFilm> list) 
        { 
            int maxMark = -1;
            for (int i = 0; i < list.Count(); i++)
            {
                if (maxMark < list[i].Mark)
                    maxMark = list[i].Mark;
            }
            return maxMark;
        }
        public static int[] SortStyles(List<IFilm> list)
        {
            int[] sortedStyles = new int[1000];
            for (int i = 0; i < 1000; i++)
                sortedStyles[i] = 0;
            for (int i = 0; i < list.Count(); i++)
                sortedStyles[list[i].Style]++;
            return sortedStyles;
        }
        public static double FindMiddleMarkStyle(List<IFilm> list, int style) 
        {
            double middleMarkStyle = 0;
            int count = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].Style == style)
                {
                    middleMarkStyle += list[i].Mark;
                    count++;
                }
            }
            middleMarkStyle /= count;
            return middleMarkStyle;
        }
        public static int CountViews(List<IFilm> list, int style)
        {
            int count = 0;
            for (int i = 0; i < list.Count(); i++) 
                if (list[i].Style == style)
                    count++;
            return count;
        }
    }
}