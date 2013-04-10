using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrthogonalLinearRegression
{
    /// <summary>
    /// A cell in a PixelGrid
    /// </summary>
    public class PixelCell
    {
        private bool _isSet = false;

        public int Top { get; private set; }
        public int Left { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public bool IsSet { get { return _isSet; } }

        public PixelCell(int left, int top, int width, int height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }

        public void ToggleCell()
        {
            _isSet = !_isSet;
        }

        public void Resize(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Reposition(int left, int top)
        {
            Left = left;
            Top = top;
        }

        public void Draw(Graphics g)
        {
            Pen blackPen = new Pen(Color.FromArgb(255,160,160,160), 1);
            SolidBrush pixelBrush = new SolidBrush(_isSet ?
                                                   Color.FromArgb(255,220,220,220) :
                                                   Color.White);
            g.DrawRectangle(blackPen, Left, Top, Width, Height);
            g.FillRectangle(pixelBrush, new Rectangle(Left+1, Top+1, Width-1, Height-1));
            pixelBrush.Dispose();
            blackPen.Dispose();
        }

        public void InvalidateParent(UserControl parent)
        {
            parent.Invalidate(new Rectangle(Left, Top, Width, Height));
        }
    }
}
