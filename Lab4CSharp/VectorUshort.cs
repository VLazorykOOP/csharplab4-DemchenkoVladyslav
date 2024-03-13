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
            num_vs--;
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
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < num)
                {
                    codeError = 0;
                    return ArrayUShort[index];
                }
                else
                {
                    codeError = 1;
                    return 0;
                }
            }
            set
            {
                if (index >= 0 && index < num)
                {
                    codeError = 0;
                    ArrayUShort[index] = (ushort)value;
                }
                else
                {
                    codeError = 1;
                }
            }
        }
        public static VectorUshort operator ++(VectorUshort vector)
        {
            for (int i = 0; i < vector.num; i++)
            {
                vector.ArrayUShort[i]++;
            }
            return vector;
        }

        public static VectorUshort operator --(VectorUshort vector)
        {
            for (int i = 0; i < vector.num; i++)
            {
                vector.ArrayUShort[i]--;
            }
            return vector;
        }
        public static bool operator true(VectorUshort vector)
        {
            if (vector.num == 0)
                return false;
            for (int i = 0; i < vector.num; i++)
            {
                if (vector[i] != 0) return true;
            }
            return false;
        }

        public static bool operator false(VectorUshort vector)
        {
            if (vector.num == 0)
                return true;
            for (int i = 0; i < vector.num; i++)
            {
                if (vector[i] != 0) return false;
            }
            return true;
        }
        public static VectorUshort operator !(VectorUshort vector)
        {
            for (int i = 0; i < vector.num; i++)
            {
                vector.ArrayUShort[i] = (ushort)(vector.ArrayUShort[i] == 0 ? 1 : 0);
            }
            return vector;
        }

        public static VectorUshort operator ~(VectorUshort vector)
        {
            for (int i = 0; i < vector.num; i++)
            {
                vector.ArrayUShort[i] = (ushort)~vector.ArrayUShort[i];
            }
            return vector;
        }

        public static VectorUshort operator +(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num != v2.num)
            {
                v1.codeError = 1;
                return v1;
            }

            VectorUshort result = new VectorUshort(v1.num);
            for (int i = 0; i < v1.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(v1.ArrayUShort[i] + v2.ArrayUShort[i]);
            }
            return result;
        }
        public static VectorUshort operator +(VectorUshort vector, ushort scalar)
        {
            VectorUshort result = new VectorUshort(vector.num);
            for (int i = 0; i < vector.num; i++)
            {
                result.ArrayUShort[i] += scalar;
            }
            return result;
        }
        public static VectorUshort operator -(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num != v2.num)
            {
                v1.codeError = 1;
                return v1;
            }

            VectorUshort result = new VectorUshort(v1.num);
            for (int i = 0; i < v1.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(v1.ArrayUShort[i] - v2.ArrayUShort[i]);
            }
            return result;
        }

        public static VectorUshort operator -(VectorUshort vector, ushort scalar)
        {
            VectorUshort result = new VectorUshort(vector.num);
            for (int i = 0; i < vector.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(vector.ArrayUShort[i] - scalar);
            }
            return result;
        }

        public static VectorUshort operator *(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num != v2.num)
            {
                v1.codeError = 1;
                return v1;
            }

            VectorUshort result = new VectorUshort(v1.num);
            for (int i = 0; i < v1.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(v1.ArrayUShort[i] * v2.ArrayUShort[i]);
            }
            return result;
        }

        public static VectorUshort operator *(VectorUshort vector, ushort scalar)
        {
            VectorUshort result = new VectorUshort(vector.num);
            for (int i = 0; i < vector.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(vector.ArrayUShort[i] * scalar);
            }
            return result;
        }

        public static VectorUshort operator /(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num != v2.num)
            {
                v1.codeError = 1;
                return v1;
            }

            VectorUshort result = new VectorUshort(v1.num);
            for (int i = 0; i < v1.num; i++)
            {
                if (v2.ArrayUShort[i] != 0)
                    result.ArrayUShort[i] = (ushort)(v1.ArrayUShort[i] / v2.ArrayUShort[i]);
            }
            return result;
        }

        public static VectorUshort operator /(VectorUshort vector, ushort scalar)
        {
            if (scalar == 0)
            {
                vector.codeError = 1;
                return vector;
            }

            VectorUshort result = new VectorUshort(vector.num);
            for (int i = 0; i < vector.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(vector.ArrayUShort[i] / scalar);
            }
            return result;
        }
        public static VectorUshort operator %(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num != v2.num)
            {
                v1.codeError = 1;
                return v1;
            }

            VectorUshort result = new VectorUshort(v1.num);
            for (int i = 0; i < v1.num; i++)
            {
                if (v2.ArrayUShort[i] != 0)
                    result.ArrayUShort[i] = (ushort)(v1.ArrayUShort[i] % v2.ArrayUShort[i]);
            }
            return result;
        }

        public static VectorUshort operator %(VectorUshort vector, ushort scalar)
        {
            if (scalar == 0)
            {
                vector.codeError = 1;
                return vector;
            }

            VectorUshort result = new VectorUshort(vector.num);
            for (int i = 0; i < vector.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(vector.ArrayUShort[i] % scalar);
            }
            return result;
        }

        public static VectorUshort operator |(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num != v2.num)
            {
                v1.codeError = 1;
                return v1;
            }

            VectorUshort result = new VectorUshort(v1.num);
            for (int i = 0; i < v1.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(v1.ArrayUShort[i] | v2.ArrayUShort[i]);
            }
            return result;
        }

        public static VectorUshort operator |(VectorUshort vector, ushort scalar)
        {
            VectorUshort result = new VectorUshort(vector.num);
            for (int i = 0; i < vector.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(vector.ArrayUShort[i] | scalar);
            }
            return result;
        }

        public static VectorUshort operator ^(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num != v2.num)
            {
                v1.codeError = 1;
                return v1;
            }

            VectorUshort result = new VectorUshort(v1.num);
            for (int i = 0; i < v1.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(v1.ArrayUShort[i] ^ v2.ArrayUShort[i]);
            }
            return result;
        }

        public static VectorUshort operator ^(VectorUshort vector, ushort scalar)
        {
            VectorUshort result = new VectorUshort(vector.num);
            for (int i = 0; i < vector.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(vector.ArrayUShort[i] ^ scalar);
            }
            return result;
        }

        public static VectorUshort operator &(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num != v2.num)
            {
                v1.codeError = 1;
                return v1;
            }

            VectorUshort result = new VectorUshort(v1.num);
            for (int i = 0; i < v1.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(v1.ArrayUShort[i] & v2.ArrayUShort[i]);
            }
            return result;
        }

        public static VectorUshort operator &(VectorUshort vector, ushort scalar)
        {
            VectorUshort result = new VectorUshort(vector.num);
            for (int i = 0; i < vector.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(vector.ArrayUShort[i] & scalar);
            }
            return result;
        }

        public static VectorUshort operator >>(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num != v2.num)
            {
                v1.codeError = 1;
                return v1;
            }

            VectorUshort result = new VectorUshort(v1.num);
            for (int i = 0; i < v1.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(v1.ArrayUShort[i] >> v2.ArrayUShort[i]);
            }
            return result;
        }

        public static VectorUshort operator >>(VectorUshort vector, ushort scalar)
        {
            VectorUshort result = new VectorUshort(vector.num);
            for (int i = 0; i < vector.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(vector.ArrayUShort[i] >> scalar);
            }
            return result;
        }

        public static VectorUshort operator <<(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num != v2.num)
            {
                v1.codeError = 1;
                return v1;
            }

            VectorUshort result = new VectorUshort(v1.num);
            for (int i = 0; i < v1.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(v1.ArrayUShort[i] << v2.ArrayUShort[i]);
            }
            return result;
        }

        public static VectorUshort operator << (VectorUshort vector, ushort scalar)
        {
            VectorUshort result = new VectorUshort(vector.num);
            for (int i = 0; i < vector.num; i++)
            {
                result.ArrayUShort[i] = (ushort)(vector.ArrayUShort[i] << scalar);
            }
            return result;
        }
        public static bool operator ==(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num != v2.num)
            {
                return false;
            }

            for (int i = 0; i < v1.num; i++)
            {
                if (v1.ArrayUShort[i] != v2.ArrayUShort[i])
                    return false;
            }
            return true;
        }

        public static bool operator !=(VectorUshort v1, VectorUshort v2)
        {
            return !(v1 == v2);
        }
        public static bool operator >(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num > v2.num)
            {
                return true;
            }

            for (int i = 0; i < v1.num; i++)
            {
                if (v1.ArrayUShort[i] <= v2.ArrayUShort[i])
                    return false;
            }
            return true;
        }

        public static bool operator >=(VectorUshort v1, VectorUshort v2)
        {
            if (v1.num > v2.num)
            {
                return true;
            }
            if (v1.num < v2.num)
            {
                return false;
            }

            for (int i = 0; i < v1.num; i++)
            {
                if (v1.ArrayUShort[i] < v2.ArrayUShort[i])
                    return false;
            }
            return true;
        }

        public static bool operator <(VectorUshort v1, VectorUshort v2)
        {
            return !(v1 >= v2);
        }

        public static bool operator <=(VectorUshort v1, VectorUshort v2)
        {
            return !(v1 > v2);
        }
    }
}