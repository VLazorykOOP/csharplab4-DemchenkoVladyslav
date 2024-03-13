using Lab3CSharp;
using Lab4CSharp;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Romb r = new(1, Math.Sqrt(2), 1);
        Console.WriteLine(r.ToString());
        r++;
        Console.WriteLine((string)r);
        r--;
        r = r * 2;
        if (r)
        {
            Console.WriteLine("Квадрат");
        }
        else
        {
            Console.WriteLine("Не квадрат");
        }

        VectorUshort v1 = new(3, 1);
        VectorUshort v2 = new(3, 5);
        Console.WriteLine(VectorUshort.CountVectors());
        v1.Display();
        v2.Display();
        (v1 + v2).Display();
        (v1 - v2).Display();
        (v1 * v2).Display();
        (v1 / v2).Display();
        (v2 % v1).Display();
        (v1 + 2).Display();
        (v1 - 2).Display();
        (v1 * 2).Display();
        (v1 / 2).Display();
        (v2 % 2).Display();
        Console.WriteLine(v1 > v2);
        Console.WriteLine(v2 >= v1);
        (v1 >> 2).Display();
        (v1 << 2).Display();
        (v2 & v1).Display();
        (v2 | v1).Display();
        (v2 ^ v1).Display();

        MatrixUshort m1 = new(3, 3, 2);
        MatrixUshort m2 = new(3, 3, 10);
        Console.WriteLine(MatrixUshort.CountMatrixs());
        m1.Display();
        m2.Display();
        (m1 + m2).Display();
        (m1 - m2).Display();
        (m1 * m2).Display();
        (m1 / m2).Display();
        (m2 % m1).Display();
        (m1 + 2).Display();
        (m1 - 2).Display();
        (m1 * 2).Display();
        (m1 / 2).Display();
        (m2 % 2).Display();
        Console.WriteLine(m1 > m2);
        Console.WriteLine(m2 >= m1);
        (m1 >> 2).Display();
        (m1 << 2).Display();
        (m2 & m1).Display();
        (m2 | m1).Display();
        (m2 ^ m1).Display();
    }
}
