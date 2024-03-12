using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4CSharp
{
    class VectorUshort
    {
        protected ushort[] ArrayUShort;
        protected uint num;
        protected uint codeError;
        static uint num_vs;
        public VectorUshort()
        {
            ArrayUShort = new ushort[1];
            num = 1;
            num_vs++;
        }

        public VectorUshort(uint size)
        {
            ArrayUShort = new ushort[size];
            num = size;
            num_vs++;
        }

        public VectorUshort(uint size, ushort initValue)
        {
            ArrayUShort = new ushort[size];
            num = size;
            num_vs++;
            for (int i = 0; i < size; i++)
            {
                ArrayUShort[i] = initValue;
            }
        }

        ~VectorUshort()
        {
            Console.WriteLine("VectorUshort object is destroyed.");
        }
        public void Input()
        {
            Console.WriteLine("Enter elements of the vector:");
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Element {i + 1}: ");
                ArrayUShort[i] = ushort.Parse(Console.ReadLine());
            }
        }

        public void Display()
        {
            Console.WriteLine("Vector elements:");
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{ArrayUShort[i]} ");
            }
            Console.WriteLine();
        }

        public void SetValues(ushort value)
        {
            for (int i = 0; i < num; i++)
            {
                ArrayUShort[i] = value;
            }
        }

        public static uint CountVectors()
        {
            return num_vs;
        }
        public uint Size
        {
            get { return num; }
        }

        public uint CodeError
        {
            get { return codeError; }
            set { codeError = value; }
        }

    }
}