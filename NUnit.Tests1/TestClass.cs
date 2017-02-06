using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            int numerator = 20;
            int denominator = 5;
            int expected = 4;

            int result = TestingNunit.Class1.Divide(numerator, denominator);

            Assert.AreEqual(expected,result);
        
            Assert.Pass("Your first passing test");
            
       
        }
    }
}
