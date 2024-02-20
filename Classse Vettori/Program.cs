using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classse_Vettori
{
    internal class Program
    {
        class Vector
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Vector(double x, double y)
            {
                X = x;
                Y = y;
            }
            public override string ToString()
            {
                return string.Format(X+";"+Y);
            }
            public static Vector Parse(string stringa)
            {
                string[] stringa1=stringa.Split(',');
                return new Vector(double.Parse(stringa1[0]), double.Parse(stringa1[1]));
            }
            public static double Modulo(Vector f) 
            {
             return Math.Sqrt(f.X*f.X + f.Y*f.Y);
            }
            public static Vector operator +(Vector v)
            {
                return v;
            }

            public static Vector operator -(Vector v)
            {
                return new Vector(-v.X, -v.Y);
            }
            public static Vector operator +(Vector v1, Vector v2) 
            {
            return new Vector(v1.X+v2.X, v1.Y+v2.Y);
            }
            public static Vector operator -(Vector v1, Vector v2)
            {
                return new Vector(v1.X - v2.X, v1.Y - v2.Y);
            }
            public static Vector operator *(Vector v1, Vector v2)
            {
                return new Vector(v1.X * v2.X, v1.Y * v2.Y);
            }
            public static Vector operator /(Vector v1, Vector v2)
            {
                return new Vector(v1.X / v2.X, v1.Y / v2.Y);

            }
            public static Vector operator *(Vector v1, double s)
            {
                return new Vector(v1.X * s, v1.Y * s);
            }
            public static Vector operator *(double s, Vector v2)
            {
                return new Vector(s * v2.X, s * v2.Y);
            }


        }

        static void Main(string[] args)
        {
        }
    }
}
