using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regression
{
    public class LinearRegression
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
        public static void CalculateLineEquation(IPixelGrid grid, int x, int y, int width, int height,
                                                 out float a, out float b, out float c)
        {
            a = 0.0f;
            b = 0.0f;
            c = 0.0f;

            int n = 0, sX = 0, sY = 0;
            double mX, mY, sXX = 0.0, sXY = 0.0, sYY = 0.0;

            //Calculate sums of X and Y
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

            //Calculate X and Y means (sample means)
            mX = (double)sX / n;
            mY = (double)sY / n;

            //Calculate sum of X squared, sum of Y squared and sum of X * Y
            //(components of the scatter matrix)
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
                a = 1.0f;
                b = 0.0f;
                c = (float)mX;
            }
            else if (isHorizontal)
            {
                a = 0.0f;
                b = 1.0f;
                c = (float)mY;
            }
            else if (isIndeterminate)
            {
                a = float.NaN;
                b = float.NaN;
                c = float.NaN;
            }
            else
            {
                slope = (sYY - sXX + Math.Sqrt((sYY - sXX) * (sYY - sXX) + 4.0 * sXY * sXY)) / (2.0 * sXY);
                intercept = mY - slope * mX;
                double normFactor = (intercept >= 0.0 ? 1.0 : -1.0) * Math.Sqrt(slope * slope + 1.0);
                a = (float)(-slope / normFactor);
                b = (float)(1.0 / normFactor);
                c = (float)(intercept / normFactor);
            }
        }
    }
}
