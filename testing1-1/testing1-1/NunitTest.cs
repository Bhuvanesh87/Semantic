using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace testing1_1
{
    [TestFixture]
    class NunitTest
    {
        [TestCase]
        public void Add()
        {
            Class1 math = new Class1();
            Assert.AreEqual(31, math.Add(20, 11));
        }

        [TestCase]
        public void Sub()
        {
            Class1 math1 = new Class1();
            Assert.AreEqual(20, math1.Sub(30, 10));
        }






    }
}
