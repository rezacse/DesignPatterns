using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrototypeWithoutBuiltIn;

namespace Prototype.Tests
{
    [TestClass]
    public class PrototypeTest
    {
        [TestMethod]
        public void Prototype()
        {
            const string webUrl = "http://www.google.com";
            var reader = new BuiltInWebPageReader(webUrl);
            reader.PrintPageInfo();

            var cloneReader = reader.Clone() as BuiltInWebPageReader;

            Assert.AreEqual(cloneReader.Title, reader.Title);
            Assert.AreEqual(cloneReader.Header, reader.Header);
            Assert.AreEqual(cloneReader.Body, reader.Body);
            Assert.AreNotSame(reader, cloneReader);
        }

        [TestMethod]
        public void PrototypeWithoutBuiltIn()
        {
            const string webUrl = "http://www.google.com";
            var reader = new WebPageReader(webUrl);
            reader.PrintPageInfo();

            var cloneReader = reader.Clone();

            //Assert.Equals(cloneReader.Title, reader.Title);
            //Assert.Equals(cloneReader.Header, reader.Header);
            //Assert.Equals(cloneReader.Body, reader.Body);
            Assert.AreNotSame(reader, cloneReader);
        }
    }
}
