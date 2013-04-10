using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrthogonalLinearRegression
{
    /// <summary>
    /// Control that allows us to simulate a 2D array of pixels.
    /// The user can toggle the pixels on or off by clicking on them.
    /// </summary>
    public partial class PixelGridUserControl : UserControl
    {
        const int NUM_PIXELS = 10;
        const float MIN_XY = -0.5f;
        const float MAX_XY = (float)NUM_PIXELS - 0.5f;

        private PixelGrid pixelCells = new PixelGrid(NUM_PIXELS, NUM_PIXELS);
        private PointF startPoint;
        private PointF endPoint;
        private bool lineValid = false;

        /// <summary>
        /// The array of pixels as a 2D array.
        /// </summary>
        public PixelGrid PixelCells { get { return pixelCells; } }

        public PixelGridUserControl()
        {
            CreateGrid();
            InitializeComponent();
        }

        public void DrawLine(float a, float b, float c)
        {
            GetCrossingPoints(a, b, c, out startPoint, out endPoint);
            lineValid = true;
            Invalidate();
        }

        public void MakeLineInvalid()
        {
            lineValid = false;
            Invalidate();
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

            if (lineValid)
            {
                Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
                pe.Graphics.DrawLine(blackPen, GetScreenPoint(startPoint), GetScreenPoint(endPoint));
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            ResizeGrid();
            base.OnSizeChanged(e);
        }

        private Point GetScreenPoint(PointF gridPoint)
        {
            int width = Size.Width / NUM_PIXELS;
            int height = Size.Height / NUM_PIXELS;

            Point scrPoint = new Point((int)((gridPoint.X + 0.5) * width),
                                       (int)((gridPoint.Y + 0.5) * height));
            return scrPoint;
        }

        /// <summary>
        /// Calulate two points at the boundary of the grid that represent the line.
        /// </summary>
        /// <param name="a">x coefficent of line</param>
        /// <param name="b">y coefficient of line</param>
        /// <param name="c">intercept</param>
        /// <param name="startPoint">Boundary point on line</param>
        /// <param name="endPoint">Opposite boundary point on line</param>
        /// <remarks>
        /// Since we are using the centre of pixels, the edges of the displayed grid
        /// will be actually be half a pixel above or below the pixel grid. So the
        /// top left hand corner will be at (-0.5,-0.5) and the bottom right corner
        /// will be at (NUM_PIXELS+0.5,NUM_PIXELS+0.5).
        /// Typical start and end points would be something like (-0.5, 1.24) and (10.5, 3.71)
        /// which would be a line going from the left hand side to the right hand side.
        /// </remarks>
        private void GetCrossingPoints(float a, float b, float c, out PointF startPoint, out PointF endPoint)
        {
            PointF? p1 = null;
            PointF? p2 = null;
            PointF? p3 = null;
            PointF? p4 = null;

            float x0cross = b != 0.0f ? (c - a * MIN_XY) / b : -1.0f;
            if (x0cross >= MIN_XY && x0cross <= MAX_XY)
                p1 = new PointF(MIN_XY, x0cross);
            float x1cross = b != 0.0f ? (c - a * MAX_XY) / b : -1.0f;
            if (x1cross >= MIN_XY && x1cross <= MAX_XY)
                p2 = new PointF(MAX_XY, x1cross);
            float y0cross = a != 0.0f ? (c - b * MIN_XY) / a : -1.0f;
            if (y0cross >= MIN_XY && y0cross <= MAX_XY)
                p3 = new PointF(y0cross, MIN_XY);
            float y1cross = a != 0.0f ? (c - b * MAX_XY) / a : -1.0f;
            if (y1cross >= MIN_XY && y1cross <= MAX_XY)
                p4 = new PointF(y1cross, MAX_XY);

            if (p1 != null && p2 != null)
            {
                startPoint = (PointF)p1;
                endPoint = (PointF)p2;
            }
            else if (p3 != null && p4 != null)
            {
                startPoint = (PointF)p3;
                endPoint = (PointF)p4;
            }
            else if (p1 != null)
            {
                startPoint = (PointF)p1;
                endPoint = p3 != null ? (PointF)p3 : (PointF)p4;
            }
            else //if (p2 != null)
            {
                startPoint = (PointF)p2;
                endPoint = p3 != null ? (PointF)p3 : (PointF)p4;
            }
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

        /// <summary>
        /// Toggle a pixel on or off
        /// </summary>
        /// <param name="sender">control that was clicked</param>
        /// <param name="e">click details</param>
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
