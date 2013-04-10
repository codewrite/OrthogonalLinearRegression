using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RegressionTest
{
    public class TestHelper
    {
        public static void AssertABC(float a, float b, float c, float exA, float exB, float exC)
        {
            if (!MathHelper.AreEqual(a, exA) || !MathHelper.AreEqual(b, exB) || !MathHelper.AreEqual(c, exC))
            {
                string str1 = MathHelper.CoeffecientsToString("Expected ", exA, exB, exC);
                string str2 =  MathHelper.CoeffecientsToString("Actual ", a, b, c);
                Assert.Fail(str1 + "\n" + str2);
            }
        }
    }
}
