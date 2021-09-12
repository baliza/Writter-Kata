using Deharo.Writter.Services;
using Deharo.Writter.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Deharo.Writter.Tests
{
    class CloudWriterTests
    {
        [Test]
        public void Test_CloudWriter_isNotSame_to_Writer()
        {
            var localContainer = new WriterContainer(false);
            var cloudContainer = new WriterContainer(true);

            Assert.AreNotEqual(localContainer.Factory.CreateWritter(EFormatTypes.JSON).ToString(),
                cloudContainer.Factory.CreateWritter(EFormatTypes.JSON).ToString());
        }
    }
}
