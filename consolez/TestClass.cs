using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace consolez
{
    class TestClass
    {
        [Test]
        public void does_one_plus_one_equal_two()
        {
            Assert.AreEqual(1+1,2);
        }
    }
}
