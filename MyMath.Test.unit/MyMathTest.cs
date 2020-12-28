using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

//using UnitTestAnotherDemo;

namespace MyMath.Test.unit
{
    [TestFixture]
    public class MyMathTest
    {
        [Test]
        public void Add()
        {
            var math = new UnitTestAnotherDemo.MyMath();
            var result = math.Add(20, 5);
            Assert.AreEqual(25, result);
        }

        public void Add1()
        {
            var math = new UnitTestAnotherDemo.MyMath();
            var result = math.Add1(64, 36);
            Assert.That(result, Is.EqualTo(100));
        }
    }
}
