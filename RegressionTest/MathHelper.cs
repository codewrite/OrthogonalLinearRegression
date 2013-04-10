using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegressionTest
{
    public class MathHelper
    {
        private const float FLOAT_TOLERANCE = 1e-7f;

        public const float SQRT2 = 1.41421356f;
        public const float SQRT2DIV2 = 0.707106781f;

        public static bool AreEqual(float number1, float number2)
        {
            return Math.Abs(number1 - number2) <=
                 FLOAT_TOLERANCE * Math.Max(1.0f, Math.Max(Math.Abs(number1), Math.Abs(number2)));
        }

        public static void NormalizeCoefficientsWithRespectToA(ref float a, ref float b, ref float c)
        {
            if (a < 0.0f)
            {
                a *= -1.0f;
                b *= -1.0f;
                c *= -1.0f;
            }
        }

        public static string CoeffecientsToString(string prefix, float a, float b, float c)
        {
            return String.Format("{0} a: {1:G9}, b: {2:G9}, c:{3:G9}", prefix, a, b, c);
        }
    }
}
