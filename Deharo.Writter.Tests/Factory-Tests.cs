using Deharo.Writter.Services;
using Deharo.Writter.Models;
using NUnit.Framework;
using System;


namespace Deharo.Writter.Tests
{
    class Factory_Tests
    {
        [Test]
        public void Test_Factory_Dictionary_Created()
        {
            Container container = new Container();
            var factory = container.Factory.ToString();
            Assert.AreEqual("",factory.ToString());
        }
    }
}
