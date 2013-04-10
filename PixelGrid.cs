using System;
using Regression;

namespace OrthogonalLinearRegression
{
    public class PixelGrid : IPixelGrid
    {
        private readonly PixelCell[,] pixelCells;

        public int Width { get { return pixelCells.GetLength(1); } }
        public int Height { get { return pixelCells.GetLength(0); } }

        public PixelGrid(int width, int height)
        {
            pixelCells = new PixelCell[height, width];
        }

        public PixelCell GetCell(int x, int y)
        {
            return pixelCells[y, x];
        }

        public void SetCell(int x, int y, PixelCell cell)
        {
            pixelCells[y, x] = cell;
        }

        public bool GetPixel(int x, int y)
        {
            return pixelCells[y, x].IsSet;
        }
    }
}
