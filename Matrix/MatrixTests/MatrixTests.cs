using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day13.Tests
{
    public static class MatrixTests
    {
        public static Matrix<int>[][] ArrayInt;

        static MatrixTests()
        {
            var random = new Random();
            ArrayInt = new Matrix<int>[2][];
            ArrayInt[0] = new Matrix<int>[3];
            ArrayInt[0][0] = new Matrix<int>(4);
            ArrayInt[0][1] = new Matrix<int>(4);
            ArrayInt[0][2] = new Matrix<int>(4);
            for (int i = 0; i < ArrayInt[0][0].Size; ++i)
            {
                for (int j = 0; j < ArrayInt[0][0].Size; ++j)
                {
                    ArrayInt[0][1][i, j] = random.Next(-100, 100);
                    ArrayInt[0][2][i, j] = random.Next(-100, 100);
                    ArrayInt[0][0][i, j] = ArrayInt[0][2][i, j] + ArrayInt[0][1][i, j];
                }
            }
            ArrayInt[1] = new Matrix<int>[3];
            ArrayInt[1][0] = new Matrix<int>(6);
            ArrayInt[1][1] = new Matrix<int>(6);
            ArrayInt[1][2] = new Matrix<int>(6);
            for (int i = 0; i < ArrayInt[1][0].Size; ++i)
            {
                for (int j = 0; j < ArrayInt[1][0].Size; ++j)
                {
                    ArrayInt[1][1][i, j] = random.Next(-100, 100);
                    ArrayInt[1][2][i, j] = random.Next(-100, 100);
                    ArrayInt[1][0][i, j] = ArrayInt[1][2][i, j] + ArrayInt[1][1][i, j];
                }
            }
        }

        [Test, TestCaseSource("ArrayInt")]
        public static void MatrixIntTest(Matrix<int> result, Matrix<int> a, Matrix<int> b)
        {
            Assert.AreEqual(result, a + b);
        }
    }
}
