using System;

namespace MandelbrotSet
{
    public class Cplx
    {
        private double re;
        private double im;

        public Cplx() : this(0, 0)
        {
        }

        public Cplx(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public static Cplx operator +(Cplx a, Cplx b)
        {
            Cplx t = new Cplx
            {
                re = a.re + b.re,
                im = a.im + b.im
            };
            return t;
        }

        public static Cplx operator -(Cplx a, Cplx b)
        {
            Cplx t = new Cplx
            {
                re = a.re - b.re,
                im = a.im - b.im
            };
            return t;
        }

        public static Cplx operator *(Cplx a, Cplx b)
        {
            Cplx t = new Cplx
            {
                re = a.re * b.re - a.im * b.im,
                im = a.im * b.re + a.re * b.im
            };
            return t;
        }

        public static Cplx operator /(Cplx a, Cplx b)
        {
            Cplx c = b.Conjugate();
            Cplx up = a * c;
            Cplx down = b * c;
            Cplx t = new Cplx
            {
                re = up.re / down.re,
                im = up.im / down.re
            };
            return t;
        }

        public Cplx Conjugate()
        {
            Cplx tmp = new Cplx
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
