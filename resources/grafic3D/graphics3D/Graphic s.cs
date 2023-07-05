using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class myGraphics
    {

        public Graphics grp;
        public Bitmap bmp;
        public int rezx, rezy;
        public Color backColor = Color.Aquamarine;
        public PictureBox display;

        public void InitGraph(PictureBox T)
        {
            display = T;
            rezx = T.Width;
            rezy = T.Height;

            bmp = new Bitmap(rezx, rezy);
            grp = Graphics.FromImage(bmp);
            ClearGraph();
            RefreshGraph();
        }
        public void ClearGraph()
        {
            grp.Clear(backColor);
        }
        public void RefreshGraph()
        {
            display.Image = bmp;
        }
        public void drawPoint(PointF toDraw, Color fill, int Size)
        {
            grp.FillEllipse(new SolidBrush(fill), toDraw.X - Size, toDraw.Y - Size, 2 * Size + 1, 2 * Size + 1);
            grp.DrawEllipse(new Pen(Color.Black), toDraw.X - Size, toDraw.Y - Size, 2 * Size + 1, 2 * Size + 1);
        }
        static Random rnd = new Random();
        public Color getRNDColor()
        {
            return Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
    }
}
