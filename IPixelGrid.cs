﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrthogonalLinearRegression
{
    /// <summary>
    /// A pixel grid is a 2D array of pixels. It starts at x = 0, y = 0,
    /// and ends at x = Width-1, y = Height-1. Pixels are either on or off.
    /// </summary>
    public interface IPixelGrid
    {
        int Width { get; }
        int Height { get; }

        bool GetPixel(int x, int y);

    }
}
