using OOPLR4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR4Tests
{
    [TestClass]
    public class DataProcessorTests
    {
        [TestMethod]
        public void DataProcessing_Test1()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            List<IFilm> assert = DataProcessor<IFilm>.CreateTop(testFilmsAndSerials);
            Assert.IsTrue(assert.Count() == 0);
        }
        [TestMethod]
        public void DataProcessing_Test2()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 3, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 4, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            List<IFilm> expect = new List<IFilm>();

            expect.Add(new Film("Hobbit", 4, 2));
            expect.Add(new Film("Matrix", 3, 1));

            List<IFilm> assert = DataProcessor<IFilm>.CreateTop(testFilmsAndSerials);

            Assert.AreEqual(expect[0].Name, assert[0].Name);
            Assert.AreEqual(expect[0].Mark, assert[0].Mark);
            Assert.AreEqual(expect[0].Style, assert[0].Style);

            Assert.AreEqual(expect[1].Name, assert[1].Name);
            Assert.AreEqual(expect[1].Mark, assert[1].Mark);
            Assert.AreEqual(expect[1].Style, assert[1].Style);
        }
        [TestMethod]
        public void DataProcessing_Test3()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 3, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 4, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 3, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 4, 1, 372));

            List<IFilm> expect = new List<IFilm>();

            expect.Add(new Serial("Futurama", 4, 1, 372));
            expect.Add(new Film("Hobbit", 4, 2));
            expect.Add(new Film("Москва слезам не верит", 3, 3));

            List<IFilm> assert = DataProcessor<IFilm>.CreateTop(testFilmsAndSerials);

            Assert.AreEqual(expect[0].Name, assert[0].Name);
            Assert.AreEqual(expect[0].Mark, assert[0].Mark);
            Assert.AreEqual(expect[0].Style, assert[0].Style);

            Assert.AreEqual(expect[1].Name, assert[1].Name);
            Assert.AreEqual(expect[1].Mark, assert[1].Mark);
            Assert.AreEqual(expect[1].Style, assert[1].Style);

            Assert.AreEqual(expect[2].Name, assert[2].Name);
            Assert.AreEqual(expect[2].Mark, assert[2].Mark);
            Assert.AreEqual(expect[2].Style, assert[2].Style);
        }
        [TestMethod]
        public void Search_Test1()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            List<IFilm> assert = DataProcessor<IFilm>.Search(testFilmsAndSerials, 15);

            Assert.IsTrue(assert.Count() == 0);
        }
        [TestMethod]
        public void Search_Test2()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            List<IFilm> expect = new List<IFilm>();

            expect.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));

            List<IFilm> assert = DataProcessor<IFilm>.Search(testFilmsAndSerials, 12);

            Assert.AreEqual(expect[0].Name, assert[0].Name);
            Assert.AreEqual(expect[0].Mark, assert[0].Mark);
            Assert.AreEqual(expect[0].Style, assert[0].Style);
        }
        [TestMethod]
        public void Search_Test3()
        {
            List<IFilm> testFilmsAndSerials = new List<IFilm>();

            testFilmsAndSerials.Add(new Film("Matrix", 5, 1));
            testFilmsAndSerials.Add(new Film("Hobbit", 10, 2));
            testFilmsAndSerials.Add(new Film("Москва слезам не верит", 8, 3));
            testFilmsAndSerials.Add(new Serial("Cyberpunk: edgerunner", 12, 1, 10));
            testFilmsAndSerials.Add(new Serial("Futurama", 10, 1, 372));

            List<IFilm> expect = new List<IFilm>();

            expect.Add(new Film("Hobbit", 10, 2));

            List<IFilm> assert = DataProcessor<IFilm>.Search(testFilmsAndSerials, 10);

            Assert.AreEqual(expect[0].Name, assert[0].Name);
            Assert.AreEqual(expect[0].Mark, assert[0].Mark);
            Assert.AreEqual(expect[0].Style, assert[0].Style);
        }
    }
}