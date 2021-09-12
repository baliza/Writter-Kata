using Deharo.Writter.Services;
using Deharo.Writter.Models;
using NUnit.Framework;

namespace Deharo.Writter.Tests
{
    public class Tests
    {
        Container container;
        [SetUp]
        public void Setup()
        {
            container = new Container();
        }

        [Test]
        public void Test_Container_Creating_JSON()
        {
            var actual = container.Factory.CreateWritter(EFormatTypes.JSON);
            Assert.AreEqual("json - Example in JSON", actual.ToString());
        }

        [Test]
        public void Test_Container_Creating_Monkey()
        {
            var actual = container.Factory.CreateWritter(EFormatTypes.TXT);
            Assert.AreNotEqual("json - Example in JSON", actual.ToString());
        }

        /*[Test]
        public void Test_Writer_Return_CorrectStructure()
        {
            var actual = container.Factory.CreateWritter(EFormatTypes.XML).WriteBody();
        }*/
    }
}