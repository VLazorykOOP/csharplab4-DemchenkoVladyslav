using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4CSharp
{
    public class MatrixUshort
    {
        protected ushort[,] ShortIntArray;
        protected int n, m;
        protected int codeError;
        protected static int num_m;

        public MatrixUshort()
        {
            n = m = 1;
            ShortIntArray = new ushort[n, m];
            codeError = 0;
            num_m++;
        }

        public MatrixUshort(int rows, int cols)
        {
            n = rows;
            m = cols;
            ShortIntArray = new ushort[n, m];
            codeError = 0;
            num_m++;
        }

        public MatrixUshort(int rows, int cols, ushort initialValue)
        {
            n = rows;
            m = cols;
            ShortIntArray = new ushort[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ShortIntArray[i, j] = initialValue;
                }

            }
            codeError = 0;
            num_m++;
        }

        ~MatrixUshort()
        {
            Console.WriteLine("Matrix destroyed");
        }
        public void Input()
        {
            Console.WriteLine("Enter elements of the matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Element {i + 1}: ");
                    ShortIntArray[i, j] = ushort.Parse(Console.ReadLine());
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Vector elements:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{ShortIntArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void SetValues(ushort value)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ShortIntArray[i, j] = value;
                }
            }
        }

        public static int CountVectors()
        {
            return num_m;
        }
        public int Rows
        {
            get { return n; }
        }
        public int Columns
        {
            get { return m; }
        }
        public int CodeError
        {
            get { return codeError; }
            set { codeError = value; }
        }
        public int this[int index1, int index2]
        {
            get
            {
                if (index1 >= 0 && index1 < n && index2 >= 0 && index2 < m)
                {
                    codeError = 0;
                    return ShortIntArray[index1, index2];
                }
                else
                {
                    codeError = 1;
                    return 0;
                }
            }
            set
            {
                if (index1 >= 0 && index1 < n && index2 >= 0 && index2 < m)
                {
                    codeError = 0;
                    ShortIntArray[index1, index2] = (ushort)value;
                }
                else
                {
                    codeError = 1;
                }
            }
        }
        public static MatrixUshort operator ++(MatrixUshort matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    matrix.ShortIntArray[i, j]++;
                }
            }
            return matrix;
        }

        public static MatrixUshort operator --(MatrixUshort matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    matrix.ShortIntArray[i, j]--;
                }
            }
            return matrix;
        }
        public static bool operator true(MatrixUshort matrix)
        {
            if (matrix.n == 0)
                return false;
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if (matrix[i, j] != 0) return true;
                }
            }
            return false;
        }

        public static bool operator false(MatrixUshort matrix)
        {
            if (matrix.n == 0)
                return true;
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if (matrix[i, j] != 0) return false;
                }
            }
            return true;
        }
        public static MatrixUshort operator !(MatrixUshort matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    matrix.ShortIntArray[i, j] = (ushort)(matrix.ShortIntArray[i, j] == 0 ? 1 : 0);
                }
            }
            return matrix;
        }

        public static MatrixUshort operator ~(MatrixUshort matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    matrix.ShortIntArray[i, j] = (ushort)~matrix.ShortIntArray[i, j];
                }
            }
            return matrix;
        }

        public static MatrixUshort operator +(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n != m2.n)
            {
                m1.codeError = 1;
                return m1;
            }

            MatrixUshort result = new MatrixUshort(m1.n, m1.m);
            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        result.ShortIntArray[i, j] = (ushort)(m1.ShortIntArray[i, j] + m2.ShortIntArray[i, j]);
                    }
                }
            }
            return result;
        }
        public static MatrixUshort operator +(MatrixUshort matrix, ushort scalar)
        {
            MatrixUshort result = new MatrixUshort(matrix.n, matrix.m);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    result.ShortIntArray[i, j] += scalar;
                }
            }
            return result;
        }
        public static MatrixUshort operator -(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n != m2.n)
            {
                m1.codeError = 1;
                return m1;
            }

            MatrixUshort result = new MatrixUshort(m1.n, m1.m);
            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        result.ShortIntArray[i, j] = (ushort)(m1.ShortIntArray[i, j] - m2.ShortIntArray[i, j]);
                    }
                }
            }
            return result;
        }

        public static MatrixUshort operator -(MatrixUshort matrix, ushort scalar)
        {
            MatrixUshort result = new MatrixUshort(matrix.n, matrix.m);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    result.ShortIntArray[i, j] = (ushort)(matrix.ShortIntArray[i, j] - scalar);
                }
            }
            return result;
        }

        public static MatrixUshort operator *(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n != m2.n)
            {
                m1.codeError = 1;
                return m1;
            }

            MatrixUshort result = new MatrixUshort(m1.n, m1.m);
            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        result.ShortIntArray[i, j] = (ushort)(m1.ShortIntArray[i, j] * m2.ShortIntArray[i, j]);
                    }
                }
            }
            return result;
        }

        public static MatrixUshort operator *(MatrixUshort matrix, ushort scalar)
        {
            MatrixUshort result = new MatrixUshort(matrix.n, matrix.m);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    result.ShortIntArray[i, j] = (ushort)(matrix.ShortIntArray[i, j] * scalar);
                }
            }
            return result;
        }

        public static MatrixUshort operator /(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n != m2.n)
            {
                m1.codeError = 1;
                return m1;
            }

            MatrixUshort result = new MatrixUshort(m1.n, m1.m);
            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        if (m2.ShortIntArray[i, j] != 0)
                            result.ShortIntArray[i, j] = (ushort)(m1.ShortIntArray[i, j] / m2.ShortIntArray[i, j]);
                    }
                }
            }
            return result;
        }

        public static MatrixUshort operator /(MatrixUshort matrix, ushort scalar)
        {
            if (scalar == 0)
            {
                matrix.codeError = 1;
                return matrix;
            }

            MatrixUshort result = new MatrixUshort(matrix.n, matrix.m);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    result.ShortIntArray[i, j] = (ushort)(matrix.ShortIntArray[i, j] / scalar);
                }
            }
            return result;
        }
        public static MatrixUshort operator %(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n != m2.n)
            {
                m1.codeError = 1;
                return m1;
            }

            MatrixUshort result = new MatrixUshort(m1.n, m1.m);
            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        if (m2.ShortIntArray[i, j] != 0)
                            result.ShortIntArray[i, j] = (ushort)(m1.ShortIntArray[i, j] % m2.ShortIntArray[i, j]);
                    }
                }
            }
            return result;
        }

        public static MatrixUshort operator %(MatrixUshort matrix, ushort scalar)
        {
            if (scalar == 0)
            {
                matrix.codeError = 1;
                return matrix;
            }

            MatrixUshort result = new MatrixUshort(matrix.n, matrix.m);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    result.ShortIntArray[i, j] = (ushort)(matrix.ShortIntArray[i, j] % scalar);
                }
            }
            return result;
        }

        public static MatrixUshort operator |(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n != m2.n)
            {
                m1.codeError = 1;
                return m1;
            }

            MatrixUshort result = new MatrixUshort(m1.n, m1.m);
            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        result.ShortIntArray[i, j] = (ushort)(m1.ShortIntArray[i, j] | m2.ShortIntArray[i, j]);
                    }
                }
            }
            return result;
        }

        public static MatrixUshort operator |(MatrixUshort matrix, ushort scalar)
        {
            MatrixUshort result = new MatrixUshort(matrix.n, matrix.m);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    result.ShortIntArray[i, j] = (ushort)(matrix.ShortIntArray[i, j] | scalar);
                }
            }
            return result;
        }

        public static MatrixUshort operator ^(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n != m2.n)
            {
                m1.codeError = 1;
                return m1;
            }

            MatrixUshort result = new MatrixUshort(m1.n, m1.m);
            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        result.ShortIntArray[i, j] = (ushort)(m1.ShortIntArray[i, j] ^ m2.ShortIntArray[i, j]);
                    }
                }
            }
            return result;
        }

        public static MatrixUshort operator ^(MatrixUshort matrix, ushort scalar)
        {
            MatrixUshort result = new MatrixUshort(matrix.n, matrix.m);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    result.ShortIntArray[i, j] = (ushort)(matrix.ShortIntArray[i, j] ^ scalar);
                }
            }
            return result;
        }

        public static MatrixUshort operator &(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n != m2.n)
            {
                m1.codeError = 1;
                return m1;
            }

            MatrixUshort result = new MatrixUshort(m1.n, m1.m);
            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        result.ShortIntArray[i, j] = (ushort)(m1.ShortIntArray[i, j] & m2.ShortIntArray[i, j]);
                    }
                }
            }
            return result;
        }

        public static MatrixUshort operator &(MatrixUshort matrix, ushort scalar)
        {
            MatrixUshort result = new MatrixUshort(matrix.n, matrix.m);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    result.ShortIntArray[i, j] = (ushort)(matrix.ShortIntArray[i, j] & scalar);
                }
            }
            return result;
        }

        public static MatrixUshort operator >>(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n != m2.n)
            {
                m1.codeError = 1;
                return m1;
            }

            MatrixUshort result = new MatrixUshort(m1.n, m1.m);
            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        result.ShortIntArray[i, j] = (ushort)(m1.ShortIntArray[i, j] >> m2.ShortIntArray[i, j]);
                    }
                }
            }
            return result;
        }

        public static MatrixUshort operator >>(MatrixUshort matrix, ushort scalar)
        {
            MatrixUshort result = new MatrixUshort(matrix.n, matrix.m);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    result.ShortIntArray[i, j] = (ushort)(matrix.ShortIntArray[i, j] >> scalar);
                }
            }
            return result;
        }

        public static MatrixUshort operator <<(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n != m2.n)
            {
                m1.codeError = 1;
                return m1;
            }

            MatrixUshort result = new MatrixUshort(m1.n, m1.m);
            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        result.ShortIntArray[i, j] = (ushort)(m1.ShortIntArray[i, j] << m2.ShortIntArray[i, j]);
                    }
                }
            }
            return result;
        }

        public static MatrixUshort operator <<(MatrixUshort matrix, ushort scalar)
        {
            MatrixUshort result = new MatrixUshort(matrix.n, matrix.m);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    result.ShortIntArray[i, j] = (ushort)(matrix.ShortIntArray[i, j] << scalar);
                }
            }
            return result;
        }
        public static bool operator ==(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n != m2.n)
            {
                return false;
            }

            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        if (m1.ShortIntArray[i, j] != m2.ShortIntArray[i, j])
                            return false;
                    }
                }
            }
            return true;
        }

        public static bool operator !=(MatrixUshort m1, MatrixUshort m2)
        {
            return !(m1 == m2);
        }
        public static bool operator >(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n > m2.n)
            {
                return true;
            }

            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        if (m1.ShortIntArray[i, j] <= m2.ShortIntArray[i, j])
                            return false;
                    }
                }
            }
            return true;
        }

        public static bool operator >=(MatrixUshort m1, MatrixUshort m2)
        {
            if (m1.n > m2.n)
            {
                return true;
            }
            if (m1.n < m2.n)
            {
                return false;
            }

            for (int i = 0; i < m1.n; i++)
            {
                for (int j = 0; j < m1.m; j++)
                {
                    {
                        if (m1.ShortIntArray[i, j] < m2.ShortIntArray[i, j])
                            return false;
                    }
                }
            }
            return true;
        }

        public static bool operator <(MatrixUshort m1, MatrixUshort m2)
        {
            return !(m1 >= m2);
        }

        public static bool operator <=(MatrixUshort m1, MatrixUshort m2)
        {
            return !(m1 > m2);
        }
    }
}
