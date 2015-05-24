using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppearanceCount;

namespace UnitTestCountAppearance
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            if (AppearanceCount.CountAppearance(new int[] {1, 2, 3, 3}, 3) != 2)
            {
               //drug pyt.
            }
                
        }
    }
}
