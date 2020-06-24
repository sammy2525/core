using NUnit.Framework;

namespace AWSLambda1.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var f = new Function();
            var res = f.FunctionHandler("JKIUJKIUJ", null);
            Assert.Pass();
        }
    }
}