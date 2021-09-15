using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WritterJavi.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IFormatable formater = GetFormater();
            var Writter = new Writter(IFormatable formater);
        }
    }
}
