using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    class Romb
    {
        protected double a;
        protected double d1;
        private int color;

        public Romb(double side, double diagonal, int color)
        {
            a = side;
            d1 = a * 2 > d1 ? diagonal : a * 2 - 1;
            this.color = color;
        }
        ~Romb()
        {
            Console.WriteLine("Видалено ромб");
        }
        public void DisplayLengths()
        {
            Console.WriteLine($"Сторона ромба: {a}, Діагональ ромба: {d1}");
        }

        public double CalculatePerimeter()
        {
            return 4 * a;
        }

        public double CalculateArea()
        {
            return 0.5 * a * d1;
        }

        public bool IsSquare()
        {
            return Math.Abs(2 * a * a - d1 * d1) < 0.01;
        }

        public double Side
        {
            get { return a; }
            set { a = value; }
        }

        public double Diagonal
        {
            get { return d1; }
            set { d1 = value; }
        }

        public int Color
        {
            get { return color; }
        }

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return a;
                    case 1:
                        return d1;
                    case 2:
                        return color;
                    default:
                        throw new IndexOutOfRangeException("Invalid index. Use 0 for 'a', 1 for 'd1', and 2 for 'color'.");
                }
            }
        }

        public static Romb operator ++(Romb romb)
        {
            romb.a++;
            romb.d1++;
            return romb;
        }

        public static Romb operator --(Romb romb)
        {
            romb.a--;
            romb.d1--;
            return romb;
        }

        public static bool operator true(Romb romb)
        {
            return romb.IsSquare();
        }

        public static bool operator false(Romb romb)
        {
            return !romb.IsSquare();
        }

        public static Romb operator *(Romb romb, int scalar)
        {
            romb.a *= scalar;
            romb.d1 *= scalar;
            return romb;
        }

        public static explicit operator string(Romb romb)
        {
            return $"{romb.a} {romb.d1} {romb.color}";
        }
        public override string ToString()
        {
            return $"{this.a} {this.d1} {this.color}";
        }

        public static explicit operator Romb(string str)
        {
            string[] v = str.Split(" ");
            return new Romb(double.Parse(v[0]), double.Parse(v[1]), int.Parse(v[2]));
        }
    }
}
