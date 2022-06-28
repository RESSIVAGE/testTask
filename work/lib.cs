using System;

namespace work
{
    public interface Shape
    {
        public double calcS();
        public string type { get;  }
    }

    public class circle : Shape
    {
        public float rad = 0;
        public double calcS()
        {
            return Math.Pow(rad, 2) * Math.PI;
        }

        public circle(float r)
        {
            this.rad = r;
        }
        public string type
        {
            get { return "circle"; }
        }
    }
    public class triangle : Shape
    {
        public float a = 0;
        public float b = 0;
        public float c = 0;
        public float p = 0;
        public double calcS()
        {
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //формула герона
        }

        public bool check90()
        {
            if (
                a * a == b * b + c * c |
                b * b == a * a + c * c |
                c * c == b * b + a * a
            )
            {
                return true;
            }

            return false;
        }
        public triangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.p = (a + b + c) / 2;
        }
        public string type
        {
            get { return "triangle"; }
        }
    }
}