using OOPLR4;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace OOPLR4Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void FindMiddleMark_Test1()
        {
            List<IFilm> testFilmsAndSerials= new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            double expect = 9;

            double assert = Program.FindMiddleMark(testFilmsAndSerials);

            Assert.AreEqual(expect, assert);
        }
        [TestMethod]
        public void FindMiddleMark_Test2()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 1, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 1, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 2, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 1, 1, 10));

            double expect = 1.25;

            double assert = Program.FindMiddleMark(testFilmsAndSerials);

            Assert.AreEqual(expect, assert);
        }
        [TestMethod]
        public void FindMinMark_Test1()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            double expect = 5;

            double assert = Program.FindMinMark(testFilmsAndSerials);

            Assert.AreEqual(expect, assert);
        }
        [TestMethod]
        public void FindMinMark_Test2()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 100, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 1, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 0, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 0, 1, 372));

            double expect = 0;

            double assert = Program.FindMinMark(testFilmsAndSerials);

            Assert.AreEqual(expect, assert);
        }
        [TestMethod]
        public void FindMaxMark_Test1()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            double expect = 12;

            double assert = Program.FindMaxMark(testFilmsAndSerials);

            Assert.AreEqual(expect, assert);
        }
        [TestMethod]
        public void FindMaxMark_Test2()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 100, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", -110, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 110, 1, 372));

            double expect = 110;

            double assert = Program.FindMaxMark(testFilmsAndSerials);

            Assert.AreEqual(expect, assert);
        }
        [TestMethod]
        public void SortStyles_Test() 
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            int[] expect = new int[1000];

            for (int i = 0; i < 1000; i++)
                expect[i] = 0;

            expect[1] = 3;
            expect[2] = 1;
            expect[3] = 1;

            int[] assert = Program.SortStyles(testFilmsAndSerials);
            for (int i = 0; i < 1000; i++)
                Assert.AreEqual(expect[i], assert[i]);
        }
        [TestMethod]
        public void FindMiddleMarkStyle_Test1()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            double expect = 9;

            double assert = Program.FindMiddleMarkStyle(testFilmsAndSerials, 1);
            Assert.AreEqual(expect, assert);
        }
        [TestMethod]
        public void FindMiddleMarkStyle_Test2()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            double expect = 10;

            double assert = Program.FindMiddleMarkStyle(testFilmsAndSerials, 2);
            Assert.AreEqual(expect, assert);
        }
        [TestMethod]
        public void FindMiddleMarkStyle_Test3()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            double expect = 8;

            double assert = Program.FindMiddleMarkStyle(testFilmsAndSerials, 3);
            Assert.AreEqual(expect, assert);
        }
        [TestMethod]
        public void CountViews_Test1()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            double expect = 3;

            double assert = Program.CountViews(testFilmsAndSerials, 1);
            Assert.AreEqual(expect, assert);
        }
        [TestMethod]
        public void CountViews_Test2()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            double expect = 1;

            double assert = Program.CountViews(testFilmsAndSerials, 2);
            Assert.AreEqual(expect, assert);
        }
        [TestMethod]
        public void CountViews_Test3()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            double expect = 1;

            double assert = Program.CountViews(testFilmsAndSerials, 3);
            Assert.AreEqual(expect, assert);
        }
    }
}