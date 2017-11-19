using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class SymmetricMatrix<T> : Matrix<T>
    {
        public SymmetricMatrix(int size) : base(size)
        {
        }

        public override T this[int i, int j]
        {
            get => base[i, j];
            set
            {
                base[i, j] = value;
                if (i != j)
                {
                    base[j, i] = value;
                }
            }
        }
    }
}
