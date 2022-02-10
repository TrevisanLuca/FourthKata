using FourthKata;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;

namespace TDDFourthKata
{
    [TestFixture]
    public class Tests
    {
        ICitySearcher _sut;
        [SetUp]
        public void Setup()
        {
            //var mock = new Mock<ICitySearcher>();
            //mock.Setup(x => x.CitySearch("a")).Returns(new List<string>());            
            //mock.Setup(x => x.CitySearch("Sk")).Returns(new List<string>() { "Skopje" });            
            //mock.Setup(x => x.CitySearch("Va")).Returns(new List<string>() { "Valencia", "Vancouver" });            
            //mock.Setup(x => x.CitySearch("ams")).Returns(new List<string>() { "Amsterdam" });            
            //mock.Setup(x => x.CitySearch("ape")).Returns(new List<string>() { "Budapest" });            
            //mock.Setup(x => x.CitySearch("*")).Returns(CitiesList.CityList);            
            //_sut = mock.Object;
            _sut = new CitySearcher();
        }

        [TestCase("nna", ExpectedResult = new string[]{"Vienna"})]
        [TestCase(".", ExpectedResult = new string[] { })]
        [TestCase("W YOR", ExpectedResult = new string[] { "New York City" })]
        [TestCase(" Istanbul ", ExpectedResult = new string[] { })]
        [TestCase("HongKong", ExpectedResult = new string[] { })]
        [TestCase("gk", ExpectedResult = new string[] { "Bangkok" })]
        public List<string> TestCitySearch(string input) => _sut.CitySearch(input);

        [Test]
        public void TestOnlyOneLetter()
        {
            var actual = _sut.CitySearch("a");
            Assert.AreEqual(new List<string>(), actual);
        }
        [Test]
        public void TestTwoLettersOrMore()
        {
            var actual = _sut.CitySearch("Sk");
            Assert.AreEqual(new List<string>() { "Skopje" }, actual);
        }
        [Test]
        public void TestTwoLettersOrMore2()
        {
            var actual = _sut.CitySearch("Va");
            Assert.AreEqual(new List<string>() { "Valencia", "Vancouver" }, actual);
        }
        [Test]
        public void TestCaseInsensitive()
        {
            var actual = _sut.CitySearch("ams");
            Assert.AreEqual(new List<string>() { "Amsterdam" }, actual);
        }
        [Test]
        public void TestSearchInside()
        {
            var actual = _sut.CitySearch("ape");
            Assert.AreEqual(new List<string>() { "Budapest" }, actual);
        }
        [Test]
        public void TestSearchAll()
        {
            var actual = _sut.CitySearch("*");
            Assert.AreEqual(CitiesList.CityList, actual);
        }
    }
}