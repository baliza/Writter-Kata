using Deharo.Writter.Services;
using Deharo.Writter.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Deharo.Writter.Tests
{
    class Factory_Tests
    {
        Container container;
        [SetUp]
        public void Setup()
        {
            container = new Container();
        }

        [Test]
        public void Test_Factory_Dictionary_Created()
        {   
            var factory = container.Factory.ToString();
            var expected = "{JSON=JsonFormatter,TXT=TxtFormatter,XML=XmlFormatter,YML=YmlFormatter}";
            Assert.AreEqual(expected, factory.ToString());
        }

        [Test]
        public void Test_Factory_Created_Same_to_Conventional()
        {
            var factory = container.Factory.ToString();
            Factory factoryConventional = new Factory(new Dictionary<Models.EFormatTypes, Interfaces.IWriterFormatter> {
            {EFormatTypes.JSON, new JsonFormatter() },
            {EFormatTypes.TXT, new TxtFormatter() },
            {EFormatTypes.XML, new XmlFormatter() },
            {EFormatTypes.YML, new YmlFormatter() }
            });
            Assert.AreEqual(factoryConventional.ToString(), factory.ToString());
        }
    }
}
