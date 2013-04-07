using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrthogonalLinearRegression
{
    public partial class PixelGridUserControl : UserControl
    {
        const int NUM_PIXELS = 11;

        private PixelGrid pixelCells = new PixelGrid(NUM_PIXELS, NUM_PIXELS);

        public PixelGrid PixelCells { get { return pixelCells; } }

        public PixelGridUserControl()
        {
            CreateGrid();
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.Clear(Color.White);

            for (int x = 0; x < NUM_PIXELS; x++)
            {
                for (int y = 0; y < NUM_PIXELS; y++)
                {
                    pixelCells.GetCell(x, y).Draw(pe.Graphics);
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            ResizeGrid();
            base.OnSizeChanged(e);
        }

        private void CreateGrid()
        {
            int width = Size.Width / NUM_PIXELS;
            int height = Size.Height / NUM_PIXELS;

            for (int x = 0; x < NUM_PIXELS; x++)
            {
                for (int y = 0; y < NUM_PIXELS; y++)
                {
                    int left = x * width;
                    int top = y * height;
                    pixelCells.SetCell(x, y, new PixelCell(left, top, width, height));
                }
            }
        }

        private void ResizeGrid()
        {
            int width = Size.Width / NUM_PIXELS;
            int height = Size.Height / NUM_PIXELS;

            for (int x = 0; x < NUM_PIXELS; x++)
            {
                for (int y = 0; y < NUM_PIXELS; y++)
                {
                    pixelCells.GetCell(x, y).Resize(width, height);
                    pixelCells.GetCell(x, y).Reposition(x * width, y * height);
                }
            }
            Invalidate();
        }

        private void PixelGridUserControl_MouseClick(object sender, MouseEventArgs e)
        {
            int width = Size.Width / NUM_PIXELS;
            int height = Size.Height / NUM_PIXELS;

            int x = e.Location.X / width;
            int y = e.Location.Y / height;

            if (x >= NUM_PIXELS || y >= NUM_PIXELS)
                return;

            pixelCells.GetCell(x, y).ToggleCell();
            pixelCells.GetCell(x, y).InvalidateParent(this);
        }

    }
}
