using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrthogonalLinearRegression
{
    public class Regression
    {
        /// <summary>
        /// Calculate the line equation of the form Ax + By = C
        /// </summary>
        /// <param name="grid">Pixel Array to get the points from</param>
        /// <param name="x">Starting x coordinate</param>
        /// <param name="y">Starting y coordinate</param>
        /// <param name="width">Number of pixels across (x)</param>
        /// <param name="y1">Number of pixels down (y)</param>
        /// <param name="a">x coefficeint</param>
        /// <param name="b">y coefficient</param>
        /// <param name="c">Intercept</param>
        public static void CalculateLineEquationOld(IPixelGrid grid, int x, int y, int width, int height,
                                                 out double a, out double b, out double c)
        {
            a = 0.0;
            b = 0.0;
            c = 0.0;

            int n = 0, sX = 0, sY = 0, sXX = 0, sXY = 0, sYY = 0;

            for (int iy = y; iy < y + height; iy++)
            {
                for (int ix = x; ix < x + width; ix++)
                {
                    if (grid.GetPixel(ix, iy))
                    {
                        n++;
                        sX += ix;
                        sY += iy;
                        sXX += ix * ix;
                        sXY += ix * iy;
                        sYY += iy * iy;
                    }
                }
            }

            double p = n * sXX - sX * sX;
            double q = 2 * (sX * sY - n * sXY);
            double r = n * sYY - sY * sY;
            bool isVertical = q == 0 && r > p;
            bool isHorizontal = q == 0 && !isVertical;
            double slope = double.NaN;
            double intercept = double.NaN;

            if (isVertical)
            {
                slope = double.PositiveInfinity;
                intercept = (double)sX / n;
            }
            if (isHorizontal)
            {
                slope = 0.0;
                intercept = (double)sY / n;
            }
            else
            {
                slope = (p - r - Math.Sqrt((p - r) * (p - r) + q * q)) / q;
                intercept = ((double)sY - slope * sX) / n;
            }

            if (isVertical)
            {
                a = 0.0;
                b = 1.0;
                c = intercept + y;
            }
            else
            {
                a = -slope;
                b = 1.0;
                c = y - height / 2 + intercept - (double)(x - width / 2) * slope;
            }
        }

        /// <summary>
        /// Calculate the line equation of the form Ax + By = C
        /// </summary>
        /// <param name="grid">Pixel Array to get the points from</param>
        /// <param name="x">Starting x coordinate</param>
        /// <param name="y">Starting y coordinate</param>
        /// <param name="width">Number of pixels across (x)</param>
        /// <param name="y1">Number of pixels down (y)</param>
        /// <param name="a">x coefficeint</param>
        /// <param name="b">y coefficient</param>
        /// <param name="c">Intercept</param>
        public static void CalculateLineEquation(IPixelGrid grid, int x, int y, int width, int height,
                                                 out double a, out double b, out double c)
        {
            a = 0.0;
            b = 0.0;
            c = 0.0;

            int n = 0, sX = 0, sY = 0;
            double mX, mY, sXX = 0.0, sXY = 0.0, sYY = 0.0;

            for (int iy = y; iy < y + height; iy++)
            {
                for (int ix = x; ix < x + width; ix++)
                {
                    if (grid.GetPixel(ix, iy))
                    {
                        n++;
                        sX += ix;
                        sY += iy;
                    }
                }
            }

            mX = (double)sX / n;
            mY = (double)sY / n;

            for (int iy = y; iy < y + height; iy++)
            {
                for (int ix = x; ix < x + width; ix++)
                {
                    if (grid.GetPixel(ix, iy))
                    {
                        sXX += ((double)ix - mX) * ((double)ix - mX);
                        sXY += ((double)ix - mX) * ((double)iy - mY);
                        sYY += ((double)iy - mY) * ((double)iy - mY);
                    }
                }
            }

            bool isVertical = sXY == 0 && sXX < sYY;
            bool isHorizontal = sXY == 0 && sXX > sYY;
            bool isIndeterminate = sXY == 0 && sXX == sYY;
            double slope = double.NaN;
            double intercept = double.NaN;

            if (isVertical)
            {
                a = 0.0;
                b = 1.0;
                c = mX;
            }
            else if (isHorizontal)
            {
                a = 0.0;
                b = 1.0;
                c = mY;
            }
            else
            {
                slope = (sYY - sXX + Math.Sqrt((sYY-sXX)*(sYY-sXX)+4.0*sXY*sXY))/(2.0*sXY);
                intercept = mY - slope * mX;
                double normFactor = (intercept >= 0.0 ? -1.0 : 1.0) * Math.Sqrt(slope * slope + 1.0);
                a = -slope / normFactor;
                b = 1.0 / normFactor;
                c = intercept / normFactor;
            }
        }
    }
}
