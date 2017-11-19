using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class DiagonalMatrix<T> : Matrix<T>
    {
        public DiagonalMatrix(int size) : base(size)
        {
        }

        public override T this[int i, int j]
        {
            get => base[i, j];
            set
            {
                if (i == j)
                {
                    base[i, j] = value;
                }
            }
        }
    }
}
