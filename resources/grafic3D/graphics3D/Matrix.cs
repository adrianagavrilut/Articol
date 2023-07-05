using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Matrix
    {
        public Matrix() { }
        public Matrix(int n, int m) { values = new float[n, m]; }
        public Matrix(int n, int m, float defaultValue)
        {
            values = new float[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    values[i, j] = defaultValue;
        }
        public float[,] values;
        public static Matrix Empty;
        public int n { get { return values.GetLength(0); } set { n = value; } }
        public int m { get { return values.GetLength(1); } set { m = value; } }
        public Matrix Multiply(Matrix toMultiply)
        {
            if (this.m != toMultiply.n)
                return Empty;
            else
            {
                Matrix toR = new Matrix(this.n, toMultiply.m);
                for (int i = 0; i < this.n; i++)
                    for (int j = 0; j < toMultiply.m; j++)
                    {
                        toR.values[i, j] = 0;
                        for (int k = 0; k < this.m; k++)
                            toR.values[i, j] += this.values[i, k] * toMultiply.values[k, j];
                    }
                return toR;
            }
        }
        public Matrix Add(Matrix toAdd)
        {
            if (this.n != toAdd.n || this.m != toAdd.m)
                return Empty;
            else
            {
                Matrix toR = new Matrix(this.n, this.m);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        toR.values[i, j] = this.values[i, j] + toAdd.values[i, j];
                return toR;
            }
        }
        public Matrix Substract(Matrix toSubstract)
        {
            if (this.n != toSubstract.n || this.m != toSubstract.m)
                return Empty;
            else
            {
                Matrix toR = new Matrix(this.n, this.m);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        toR.values[i, j] = this.values[i, j] - toSubstract.values[i, j];
                return toR;
            }
        }
        public List<string> toString()
        {
            List<string> toR = new List<string>();
            string buffer;
            for (int i = 0; i < n; i++)
            {
                buffer = "";
                for (int j = 0; j < m; j++)
                    buffer += values[i, j] + " ";
                toR.Add(buffer);
            }
            return toR;
        }
    }
}
