using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            double a, b, c;
            PixelGrid pixelGrid = pixelGridUserControl.PixelCells;
            int width = pixelGrid.Width;
            int height = pixelGrid.Height;

            Regression.CalculateLineEquation(pixelGrid, 0, 0, width, height, out a, out b, out c);

            eqnATextBox.Text = a.ToString("f5");
            eqnBTextBox.Text = b.ToString("f5");
            eqnCTextBox.Text = c.ToString("f5");
        }
    }
}
