using NUnit.Framework;
namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test, Author("NunitTest"), Category("Nunit")]
        public void TestMethod()
        {
            System.Threading.Thread.Sleep(5000);
            Assert.Pass("Your first passing test");
        }

        [Test, Author("NunitTest"), Category("Nunit")]
        public void TestMethod2()
        {
            System.Threading.Thread.Sleep(5000);
            Assert.Pass("Your first passing test");
        }
        
        // [Test, Author("NunitTest"), Category("Nunit")]
        // public void TestMethod5()
        // {
            // System.Threading.Thread.Sleep(5000);
            // Assert.Pass("Your first passing test");
        // }
        
        // [Test, Author("NunitTest"), Category("Nunit")]
        // public void TestMethod6()
        // {
            // System.Threading.Thread.Sleep(5000);
            // Assert.Pass("Your first passing test");
        // }

        [Test, Ignore("No reason"), Author("NunitTest")]
        public void TestMethod3()
        {
            System.Threading.Thread.Sleep(5000);
            Assert.Pass("Your first passing test");
        }

        [Test, Author("NunitTest"), Platform("x86")]
        public void TestMethod4()
        {
            System.Threading.Thread.Sleep(5000);
            Assert.Pass("Your first passing test");
        }
        
        // [Test, Author("NunitTest"), Platform("x86")]
        // public void TestMethod7()
        // {
            // System.Threading.Thread.Sleep(5000);
            // Assert.Pass("Your first passing test");
        // }
    }
}
