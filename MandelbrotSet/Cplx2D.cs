using System;

namespace MandelbrotSet
{
    public class Cplx2D
    {
        private double re;
        private double im;

        public Cplx2D() : this(0, 0)
        {
        }

        public Cplx2D(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public static Cplx2D operator +(Cplx2D a, Cplx2D b)
        {
            Cplx2D t = new Cplx2D
            {
                re = a.re + b.re,
                im = a.im + b.im
            };
            return t;
        }

        public static Cplx2D operator -(Cplx2D a, Cplx2D b)
        {
            Cplx2D t = new Cplx2D
            {
                re = a.re - b.re,
                im = a.im - b.im
            };
            return t;
        }

        public static Cplx2D operator *(Cplx2D a, Cplx2D b)
        {
            Cplx2D t = new Cplx2D
            {
                re = a.re * b.re - a.im * b.im,
                im = a.im * b.re + a.re * b.im
            };
            return t;
        }

        public static Cplx2D operator /(Cplx2D a, Cplx2D b)
        {
            Cplx2D c = b.Conjugate();
            Cplx2D up = a * c;
            Cplx2D down = b * c;
            Cplx2D t = new Cplx2D
            {
                re = up.re / down.re,
                im = up.im / down.re
            };
            return t;
        }

        public Cplx2D Conjugate()
        {
            Cplx2D tmp = new Cplx2D
            {
                re = re,
                im = -1 * im
            };
            return tmp;
        }

        public double Norm()
        {
            return Math.Sqrt(re * re + im * im);
        }

        public string View()
        {
            if (im > 0)
                return re.ToString("0.00") + " " + "+ i" + im.ToString("0.00");
            else
                return re.ToString("0.00") + " " + "- i" + (-1 * im).ToString("0.00");
        }

    }
}

