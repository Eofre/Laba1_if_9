using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void NumTest()
        {
            var a = 100;
            var b = 5;
            var c = 900000;
            var message = Logic.Num(a, b, c);
            Assert.AreEqual("Произведение двух наименьших чисел равно 500", message);
        }
    }
}