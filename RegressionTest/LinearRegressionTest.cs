﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Regression;

namespace RegressionTest
{
    public class LinearRegressionTest
    {
        /// <summary>
        /// Make sure that square arrangements of pixels return NaN for a, b and c
        /// </summary>
        /// <param name="size">Size of pixel grid</param>
        /// <param name="points">points where pixels are set</param>
        [TestCase(2, new short[] { 0, 0, 1, 0, 0, 1, 1, 1 })]
        [TestCase(4, new short[] { 1, 1, 2, 1, 1, 2, 2, 2 })]
        [TestCase(3, new short[] { 0, 0, 0, 2, 2, 0, 2, 2 })]
        [TestCase(10, new short[] { 5, 5, 6, 5, 7, 5, 5, 6, 7, 6, 5, 7, 6, 7, 7, 7 })]
        public void IndeterminateTest(int size, short[] points)
        {
            MockPixelGrid pixelGrid = new MockPixelGrid(size, points);
            float a, b, c;
            LinearRegression.CalculateLineEquation(pixelGrid, 0, 0, pixelGrid.Width, pixelGrid.Height,
                                                   out a, out b, out c);
            Assert.IsTrue(float.IsNaN(a), MathHelper.CoeffecientsToString("Expected NaN for a, b and c, but got ", a, b, c));
            Assert.IsTrue(float.IsNaN(b), MathHelper.CoeffecientsToString("Expected NaN for a, b and c, but got ", a, b, c));
            Assert.IsTrue(float.IsNaN(c), MathHelper.CoeffecientsToString("Expected NaN for a, b and c, but got ", a, b, c));
        }

        [TestCase(2, new short[] { 0, 0, 1, 1 }, 0.0f)]
        [TestCase(5, new short[] { 1, 0, 2, 1, 3, 2 }, MathHelper.SQRT2DIV2)]
        [TestCase(10, new short[] { 3, 1, 4, 2, 7, 5, 8, 6 }, MathHelper.SQRT2)]
        public void DiagonalLineTest(int size, short[] points, float expectedC)
        {
            MockPixelGrid pixelGrid = new MockPixelGrid(size, points);
            float a, b, c;
            LinearRegression.CalculateLineEquation(pixelGrid, 0, 0, pixelGrid.Width, pixelGrid.Height,
                                                   out a, out b, out c);

            MathHelper.NormalizeCoefficientsWithRespectToA(ref a, ref b, ref c);
            TestHelper.AssertABC(a, b, c, MathHelper.SQRT2DIV2, -MathHelper.SQRT2DIV2, expectedC);
        }

        [TestCase(2, new short[] { 0, 0, 0, 1 }, 0.0f)]
        [TestCase(5, new short[] { 2, 0, 2, 1, 2, 2 }, 2.0f)]
        [TestCase(8, new short[] { 4, 1, 4, 2, 4, 5, 4, 6 }, 4.0f)]
        public void VerticalLineTest(int size, short[] points, float expectedC)
        {
            MockPixelGrid pixelGrid = new MockPixelGrid(size, points);
            float a, b, c;
            LinearRegression.CalculateLineEquation(pixelGrid, 0, 0, pixelGrid.Width, pixelGrid.Height,
                                                   out a, out b, out c);

            MathHelper.NormalizeCoefficientsWithRespectToA(ref a, ref b, ref c);
            TestHelper.AssertABC(a, b, c, 1.0f, 0.0f, expectedC);
        }

        [TestCase(2, new short[] { 0, 0, 1, 0 }, 0.0f)]
        [TestCase(4, new short[] { 0, 3, 1, 3, 2, 3 }, 3.0f)]
        [TestCase(8, new short[] { 0, 7, 4, 7, 5, 7, 6, 7 }, 7.0f)]
        [TestCase(9, new short[] { 0, 3, 1, 3, 2, 4, 3, 4, 4, 4, 5, 4, 6, 3, 7, 3 }, 3.5f)]
        public void HorizonalLineTest(int size, short[] points, float expectedC)
        {
            MockPixelGrid pixelGrid = new MockPixelGrid(size, points);
            float a, b, c;
            LinearRegression.CalculateLineEquation(pixelGrid, 0, 0, pixelGrid.Width, pixelGrid.Height,
                                                   out a, out b, out c);

            MathHelper.NormalizeCoefficientsWithRespectToA(ref a, ref b, ref c);
            TestHelper.AssertABC(a, b, c, 0.0f, 1.0f, expectedC);
        }
    }
}
