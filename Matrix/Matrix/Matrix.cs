using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public delegate void MatrixChangedEventHandler(object sender, EventArgs args); 

    public class Matrix<T>
    {
        private T[,] array;

        public Matrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Matrix dimensions must be above zero");
            }

            array = new T[size, size];
            Size = size;
        }

        public event MatrixChangedEventHandler MatrixChangedEvent;

        public int Size { get; }

        public virtual T this[int i, int j]
        {
            get => array[i, j];
            set
            {
                array[i, j] = value;
                MatrixChangedEvent(this, new EventArgs());
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Size != b.Size)
            {
                throw new InvalidOperationException("Matrixes must be of the same size");
            }

            Matrix<T> result = new Matrix<T>(a.Size);
            for (int i = 0; i < a.Size; ++i)
            {
                for (int j = 0; j < a.Size; ++i)
                {
                    result[i, j] = (dynamic)a[i, j] + (dynamic)b[i, j];
                }
            }

            return result;
        }
    }
}
