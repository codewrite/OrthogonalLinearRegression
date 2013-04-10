using System;
using System.Windows.Forms;
using Regression;

namespace OrthogonalLinearRegression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mainPanel_Resize(object sender, EventArgs e)
        {
            Control panel = (Control)sender;

            int width = panel.Size.Width;
            int height = panel.Size.Height;

            int sqSize = Math.Min(width, height);

            pixelGridUserControl.Width = sqSize;
            pixelGridUserControl.Height = sqSize;
        }

        private void drawLineButton_Click(object sender, EventArgs e)
        {
            float a, b, c;
            PixelGrid pixelGrid = pixelGridUserControl.PixelCells;
            int width = pixelGrid.Width;
            int height = pixelGrid.Height;

            LinearRegression.CalculateLineEquation(pixelGrid, 0, 0, width, height,
                                                   out a, out b, out c);

            eqnATextBox.Text = a.ToString("G7");
            eqnBTextBox.Text = b.ToString("G7");
            eqnCTextBox.Text = c.ToString("G7");

            if (!float.IsNaN(a) && !float.IsNaN(b) && !float.IsNaN(c))
                pixelGridUserControl.DrawLine(a, b, c);
            else
                pixelGridUserControl.MakeLineInvalid();

        }
    }
}
