using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Regression;

namespace RegressionTest
{
    public class MockPixelGrid : IPixelGrid
    {
        private bool[,] pixelData;

        public int Width
        {
            get { return pixelData.GetLength(1); }
        }

        public int Height
        {
            get { return pixelData.GetLength(0); }
        }

        public bool GetPixel(int x, int y)
        {
            return pixelData[y, x];
        }

        /// <summary>
        /// Constructor that takes a list of points
        /// </summary>
        /// <param name="size">Size of grid to be created</param>
        /// <param name="newPixelData">List of points</param>
        /// <remarks>
        /// List of points should be multiple of 2 in length.
        /// List of points is of the form x0,y0,x1,y1,y2 etc.
        /// </remarks>
        public MockPixelGrid(int size, short[] newPixelData)
        {
            pixelData = new bool[size, size];

            for (int i = 0; i < newPixelData.Length; i += 2)
            {
                pixelData[newPixelData[i + 1], newPixelData[i]] = true;
            }
            
        }
    }
}
