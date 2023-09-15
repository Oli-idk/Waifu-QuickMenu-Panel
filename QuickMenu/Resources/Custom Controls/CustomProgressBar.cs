using System.Drawing;
using System.Windows.Forms;

namespace QuickMenu.Resources.Custom_Controls
{
    internal class CustomProgressBar : ProgressBar
    {
        public CustomProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
            DoubleBuffered = true;
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            const int inset = 2;

            using Image offscreenImage = new Bitmap(Width, Height);
            using Graphics offscreen = Graphics.FromImage(offscreenImage);
            Rectangle rect = new(0, 0, Width, Height);

            using (SolidBrush backBrush = new(BackColor))
            {
                e.Graphics.FillRectangle(backBrush, rect);
            }

            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);

            rect.Inflate(new Size(-inset, -inset));
            rect.Width = (int)(rect.Width * ((double)Value / Maximum));
            if (rect.Width == 0) rect.Width = 1;

            SolidBrush brush = new(ForeColor);
            offscreen.FillRectangle(brush, inset, inset, rect.Width, rect.Height);

            e.Graphics.DrawImage(offscreenImage, 0, 0);
        }
    }
}
