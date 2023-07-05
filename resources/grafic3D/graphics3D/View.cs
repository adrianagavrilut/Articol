using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public abstract class View
    {
        protected Point3D cameraPosition;
        protected Point3D cameraRotation;
        protected Point3D canvas;
        public View()
        {
            cameraPosition = new Point3D();
            cameraRotation = new Point3D();
            canvas = new Point3D();
        }
        public void setCameraPosition(Point3D toSet)
        {
            cameraPosition = new Point3D(toSet);
        }
        public void setCameraRotation(float angleX, float angleY, float angleZ)
        {
            cameraRotation.X = angleX;
            cameraRotation.Y = angleY;
            cameraRotation.Z = angleZ;
        }
        public void setCanvas(float X, float Y, float Z)
        {
            canvas.X = X;
            canvas.Y = Y;
            canvas.Z = Z;
        }
        public abstract void render() ;
        public abstract void Draw(myGraphics where, Color inkColor);
    }
    public class PointsCollection : View 
    {
        List<Point3D> points;
        List<Point2D> pointsToDraw;
        public void Add(Point3D toAdd)
        {
            points.Add(toAdd);
        }
        
        public PointsCollection() 
        {
            points = new List<Point3D>();
            pointsToDraw = new List<Point2D>();
        }

        public override void render()
        {
            foreach (Point3D point in points)
                pointsToDraw.Add(point.transform(cameraPosition, cameraRotation, canvas));
        }

        public override void Draw(myGraphics where, Color inkColor)
        {
            render();
            foreach (Point2D p in pointsToDraw)
                where.grp.DrawEllipse(Pens.Black, p.X - 2, p.Y - 2, 5, 5);
        }
    }
    public class Function : View 
    {
        float isx = -10;
        float iex = 10;
        float isy = -10;
        float iey = 10;
        int afinity = 160;

        public float f (float x, float y)
        {
            return (float)Math.Log((x*x) + (y*y));
        }

        Point2D[,] toDraw;
        
        public Function()
        {
            toDraw = new Point2D [afinity + 3 , afinity  + 3];
        }
        int lines = 0;
        int columns = 0;
            
        public override void render()
        {
            lines = 0;
            columns = 0;
            float dx = (iex - isx) / afinity;
            float dy = (iey - isy) / afinity;
            for (float x = isx; x <= iex; x += dx) lines++;
            for (float y = isy; y <= iey; y += dy) columns ++;
                    toDraw = new Point2D[lines, columns];
            int c = 0;
            int l = 0;
            for (float x = isx; x <= iex; x += dx)
                for (float y = isy; y <= iey; y += dy)
                {
                    
                    toDraw[l, c] = new Point3D(x, y, f(x, y)).transform(cameraPosition, cameraRotation, canvas);
                    c++;
                    if (c == columns)
                    {
                        l++;
                        c = 0;
                    }
                }
        }
        public override void Draw(myGraphics where, Color inkColor)
        {
            render();
            Pen T = new Pen(inkColor);
            for (int i = 0; i < lines - 1; i++)
                for (int j = 0; j < columns - 1; j++)
                {
                    where.grp.DrawLine(T, toDraw[i, j].X, toDraw[i, j].Y, toDraw[i + 1, j].X, toDraw[i + 1, j].Y);
                    where.grp.DrawLine(T, toDraw[i, j].X, toDraw[i, j].Y, toDraw[i , j + 1].X, toDraw[i , j + 1].Y);
                }
            for (int i = 0; i < lines- 1; i++)
                where.grp.DrawLine(T, toDraw[i, columns - 1].X, toDraw[i, columns - 1].Y, toDraw[i + 1, columns - 1].X, toDraw[i + 1, columns - 1].Y);
            for (int i = 0; i < columns - 1; i++)
                where.grp.DrawLine(T, toDraw[lines - 1, i].X, toDraw[lines - 1, i].Y, toDraw[lines-1,i + 1].X, toDraw[lines-1,i + 1].Y);
        }
    }
    public class ChaoticMap : View 
    {
        double a = 10.0;
        double b = 28.0;
        double c = 8.0 / 3.0;
        double t = 0.01;

        int iteration = 50000;

        List <Point2D> toDraw;
        List<Point3D> points;
        
        public override void render()
        {
            toDraw = new List<Point2D>();
            points = new List<Point3D>();
            toDraw.Clear();

            double x = 0.1;
            double y = 1;
            double z = 1;
          
                        for (int i = 1; i < iteration; i++)
                        {
                            double xt = x + t * a * (y - x);
                            double yt = y + t * (x * (b - z) - y);
                            double zt = z + t * (x * y - c * z);
                            points.Add(new Point3D((float)xt, (float)yt, (float)zt));
                            toDraw.Add(new Point3D((float)xt, (float)yt, (float)zt).transform(cameraPosition, cameraRotation, canvas));                  
                            x = xt;
                            y = yt;
                            z = zt;
                        }
        }

        public override void Draw(myGraphics where, Color inkColor)
        {
            render();
            Pen T = new Pen(inkColor);
            for (int i = 0; i < toDraw.Count - 1; i++)
                where.grp.DrawLine(new Pen(where.getRNDColor ()), toDraw[i].X, toDraw[i].Y, toDraw[i + 1].X, toDraw[i + 1].Y);
        }
    }

}
