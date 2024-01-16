using hrazkouska;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lol
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Jmenopozitivni()
        {          
            Class1 test1 = new Class1();
            string jmeno = "CATMAN";
            Assert.IsTrue(test1.Prvavda(jmeno));
        }

        [TestMethod]
        public void Negativny()
        {
            Class1 test1 = new Class1();
            string jmeno = "CATMANHHHHHHHHHHHHHHHHHHHHH";
            Assert.IsFalse(test1.Prvavda(jmeno));
        }

        [TestMethod]

        public void Testpozice()
        {
            Class1 test2 = new Class1();
            int[] souradnice = { 2, 5 };
            int[] okcekavane = { 2+3, 5+3 };
            int speed = 3;
            Assert.AreEqual(souradnice ,test2.Positionchange(souradnice, speed));
        }

        [TestMethod]

        public void Xptest()
        {
            Class1 test3 = new Class1();
            int[] xp = { 1, 2 };
            int[] okcekavane = { 2, 2 };
            Assert.AreEqual(okcekavane, test3.Xp(xp, 100));
        }
    }
}
