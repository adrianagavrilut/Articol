using System;
using System.Drawing;

namespace MandelbrotSet
{
    public class Fractal
    {
        public bool colorful;
        public bool blackWhite;
        public bool twoD;
        public bool threeD;
        public const double limit = 1e10;
        public int maxIterations;

        internal void Draw()
        {
            if (twoD && blackWhite)
                DrawTwoDBW();
            else if(twoD && colorful)
                DrawTwoDColor();
            else if (threeD && colorful)
                DrawThreeDColor();
            else if (threeD && blackWhite)
                DrawThreeDBW();
        }

        private void DrawTwoDBW()
        {
            for (int x = 0; x < Engine.display.Width; x++)
            {
                for (int y = 0; y < Engine.display.Height; y++)
                {
                    double re = -2.0 + (3.0 * x / Engine.display.Width);
                    double im = 2.0 - (4.0 * y / Engine.display.Height);
                    Cplx2D c = new Cplx2D(re, im);

                    Cplx2D z = new Cplx2D(0, 0);
                    int iterations = 0;
                    while (z.Norm() < limit && iterations < maxIterations)
                    {
                        z = z * z + c;
                        iterations++;
                    }

                    Color color = (z.Norm() < limit) ? Color.Black : Color.White;
                    Engine.bmp.SetPixel(x, y, color);
                }
            }
            Engine.Refresh();
        }

        private void DrawTwoDColor()
        {
            //MethodOneRGB();
            //MethodTwoRGB();
            MethodThreeHSL();
        }

        private void MethodOneRGB()
        {
            for (int x = 0; x < Engine.display.Width; x++)
            {
                for (int y = 0; y < Engine.display.Height; y++)
                {
                    double re = -1.5 + (2.0 * x / Engine.display.Width);
                    double im = 1.0 - (2.0 * y / Engine.display.Height);
                    Cplx2D c = new Cplx2D(re, im);

                    Cplx2D z = new Cplx2D(0, 0);
                    int iterations = 0;
                    while (z.Norm() < limit && iterations < maxIterations)
                    {
                        z = z * z + c;
                        iterations++;
                    }

                    Color color = Color.Black;
                    if (iterations == maxIterations || z.Norm() >= limit)
                    {
                        int colorValue = (int)((double)iterations / (double)maxIterations * 255.0);
                        color = Color.FromArgb(colorValue, colorValue, colorValue);
                    }
                    Engine.bmp.SetPixel(x, y, color);
                }
            }
            Engine.Refresh();
        }

        private void MethodTwoRGB()
        {
            for (int x = 0; x < Engine.display.Width; x++)
            {
                for (int y = 0; y < Engine.display.Height; y++)
                {
                    double re = -2.0 + (3.0 * x / Engine.display.Width);
                    double im = 2.0 - (4.0 * y / Engine.display.Height);
                    Cplx2D c = new Cplx2D(re, im);

                    Cplx2D z = new Cplx2D(0, 0);
                    int iterations = 0;
                    while (z.Norm() < limit && iterations < maxIterations)
                    {
                        z = z * z + c;
                        iterations++;
                    }

                    int r = (int)((iterations % 16) * 16);
                    int g = (int)((iterations % 32) * 8);
                    int b = (int)((iterations % 64) * 4);

                    Color color = (iterations >= maxIterations) ? Color.Black : Color.FromArgb(r, g, b);
                    Engine.bmp.SetPixel(x, y, color);
                }
            }
            Engine.Refresh();
        }

        private void MethodThreeHSL()
        {
            for (int x = 0; x < Engine.display.Width; x++)
            {
                for (int y = 0; y < Engine.display.Height; y++)
                {
                    double re = -2.0 + (3.0 * x / Engine.display.Width);
                    double im = 2.0 - (4.0 * y / Engine.display.Height);
                    Cplx2D c = new Cplx2D(re, im);

                    Cplx2D z = new Cplx2D(0, 0);
                    int iterations = 0;
                    while (z.Norm() < limit && iterations < maxIterations)
                    {
                        z = z * z + c;
                        iterations++;
                    }

                    Color color;
                    if (iterations == maxIterations)
                    {
                        color = Color.Black;
                    }
                    else
                    {
                        // Use HSL color space to create a gradient based on the number of iterations
                        double hue = 360 * iterations / (double)maxIterations;
                        double saturation = 1.0;
                        double lightness = 0.5;
                        color = FromHsl(hue, saturation, lightness);
                    }

                    Engine.bmp.SetPixel(x, y, color);
                }
            }
            Engine.Refresh();
        }

        private Color FromHsl(double hue, double saturation, double lightness) //https://en.wikipedia.org/wiki/HSL_and_HSV#From_HSL
        {
            double chroma = (1 - Math.Abs(2 * lightness - 1)) * saturation;
            double hPrime = hue / 60.0;
            double x = chroma * (1 - Math.Abs(hPrime % 2 - 1));
            double r1, g1, b1;

            if (hPrime >= 0 && hPrime <= 1)
            {
                r1 = chroma;
                g1 = x;
                b1 = 0;
            }
            else if (hPrime > 1 && hPrime <= 2)
            {
                r1 = x;
                g1 = chroma;
                b1 = 0;
            }
            else if (hPrime > 2 && hPrime <= 3)
            {
                r1 = 0;
                g1 = chroma;
                b1 = x;
            }
            else if (hPrime > 3 && hPrime <= 4)
            {
                r1 = 0;
                g1 = x;
                b1 = chroma;
            }
            else if (hPrime > 4 && hPrime <= 5)
            {
                r1 = x;
                g1 = 0;
                b1 = chroma;
            }
            else
            {
                r1 = chroma;
                g1 = 0;
                b1 = x;
            }

            double m = lightness - 0.5 * chroma;
            int r = (int)((r1 + m) * 255);
            int g = (int)((g1 + m) * 255);
            int b = (int)((b1 + m) * 255);

            return Color.FromArgb(r, g, b);
        }

        private void DrawThreeDBW()
        {
            throw new NotImplementedException();
        }

        private void DrawThreeDColor()
        {
            throw new NotImplementedException();
        }
    }
}
