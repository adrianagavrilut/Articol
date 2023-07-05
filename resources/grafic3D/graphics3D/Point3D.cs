using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Point2D 
    {
        public float X, Y;
        public Point2D() 
        { }
        public Point2D(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

    }

    public class Point3D
    {
        public float X,Y,Z;
        public Point3D() 
        { }
        public Point3D(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public Point3D(Point3D toCopy)
        {
            this.X = toCopy.X;
            this.Y = toCopy.Y;
            this.Z = toCopy.Z;
        }

        public Point2D transform(Point3D C, Point3D Q, Point3D E)
        {
            float x = this.X - C.X;
            float y = this.Y - C.Y;
            float z = this.Z - C.Z;

            float cx = (float)Math.Cos(Q.X);
            float cy = (float)Math.Cos(Q.Y);
            float cz = (float)Math.Cos(Q.Z);

            float sx = (float)Math.Sin(Q.X);
            float sy = (float)Math.Sin(Q.Y);
            float sz = (float)Math.Sin(Q.Z);

            Point3D d = new Point3D();

            d.X = cy * (sz * y + cz * x) - sy * z;
            d.Y = sx * (cy * z + sy * (sz * y + cz * x)) + cx * (cz * y - sz * x);
            d.Z = cx * (cy * z + sy * (sz * y + cz * x)) - sx * (cz * y - sz * x);

            Point2D b = new Point2D();

            b.X = (E.Z * d.X) / d.Z + E.X;
            b.Y = (E.Z * d.Y) / d.Z + E.Y;
            return b;
        }
    }



    public class transformation 
    {
        transformation(float angleX, float angleY, float angleZ)
        {
            Matrix Qx = new Matrix(3, 3);
            Qx.values[0, 0] = 1;
            Qx.values[0, 1] = 0;
            Qx.values[0, 2] = 0;
            Qx.values[1, 0] = 0;
            Qx.values[1, 1] = (float)Math.Cos(angleX);
            Qx.values[1, 2] = (float)Math.Sin(angleX);
            Qx.values[2, 0] = 0;
            Qx.values[2, 1] = -(float)Math.Sin(angleX);
            Qx.values[2, 2] = (float)Math.Cos(angleX);

            Matrix Qy = new Matrix(3, 3);
            Qy.values[0, 0] = (float)Math.Cos(angleY);
            Qy.values[0, 1] = 0;
            Qy.values[0, 2] = -(float)Math.Sin(angleY);
            Qy.values[1, 0] = 0;
            Qy.values[1, 1] = 1;
            Qy.values[1, 2] = 0;
            Qy.values[2, 0] = (float)Math.Sin(angleY);
            Qy.values[2, 1] = 0;
            Qy.values[2, 2] = (float)Math.Cos(angleY);

            Matrix Qz = new Matrix(3, 3);
            Qz.values[0, 0] = (float)Math.Cos(angleZ);
            Qz.values[0, 1] = (float)Math.Sin(angleZ);
            Qz.values[0, 2] = 0;
            Qz.values[1, 0] = -(float)Math.Sin(angleZ);
            Qz.values[1, 1] = (float)Math.Cos(angleZ);
            Qz.values[1, 2] = 0;
            Qz.values[2, 0] = 0;
            Qz.values[2, 1] = 0;
            Qz.values[2, 2] = 1;
        }
    }
}
