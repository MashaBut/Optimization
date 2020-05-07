using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Methods_Lab3.Entities
{
    class Matrix : ICloneable
    {
        private double[,] elements;

        #region Constructors
        public Matrix(double[,] elements)
        {
            this.elements = elements;
        }
        private Matrix(int x, int y)
        {
            this.elements = new double[x, y];
        }
        #endregion

        #region Accessors
        public int getX()
        {
            return elements.GetLength(0);
        }
        public int getY()
        {
            return elements.GetLength(1);
        }
        public double get(int x, int y)
        {
            if (elements.GetLength(0) > x && elements.GetLength(1) > y)
            {
                return elements[x, y];
            }
            else
            {
                throw new Exception(String.Format("element with indexes x={0}, y={1} doesn't exist", x, y));
            }
        }
        public void set(int x, int y, double value)
        {
            if (elements.GetLength(0) > x && elements.GetLength(1) > y)
            {
                elements[x, y] = value;
            }
            else
            {
                throw new Exception(String.Format("element with indexes x={0}, y={1} doesn't exist", x, y));
            }

        }
        public bool isSquare { get => getX() == getY(); }
        #endregion

        #region Operators
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.getX() == b.getY())
                return multi(a, b);
            else
                throw new Exception(String.Format("matrix are not acceptable a.x = {0}; b.y = {1}", a.getX(), b.getY()));
        }
        #endregion

        #region Public
        public double calculateDeterminant()
        {
            if (!this.isSquare)
            {
                throw new InvalidOperationException(
                    "determinant can be calculated only for square matrix");
            }
            if (getY() == 2)
            {
                return elements[0, 0] * elements[1, 1] - elements[0, 1] * elements[1, 0];
            }
            double result = 0;
            for (var j = 0; j < getY(); j++)
            {
                result += (j % 2 == 1 ? 1 : -1) * elements[1, j] *
                    this.createMatrixWithoutColumn(j).
                    createMatrixWithoutRow(1).calculateDeterminant();
            }
            return result;
        }
        public object Clone()
        {
            return new Matrix(elements);
        }
        public Matrix getInverseMatrix()
        {
            Matrix result = (Matrix)Clone();
            double det = calculateDeterminant();
            processFunctionOverData((int i, int j) =>
            {
                result.set(i, j, result.get(i, j) / det);
            });
            return result;
        }
        #endregion

        #region Private
        private Matrix createMatrixWithoutColumn(int column)
        {
            if (column < 0 || column >= getX())
            {
                throw new ArgumentException("invalid column index");
            }
            var result = new Matrix(getY(), getX() - 1);
            result.processFunctionOverData((i, j) =>
                result.set(i, j, j < column ? elements[i, j] : elements[i, j + 1]));
            return result;
        }
        private Matrix createMatrixWithoutRow(int row)
        {
            if (row < 0 || row >= getY())
            {
                throw new ArgumentException("invalid row index");
            }
            var result = new Matrix(getY() - 1, getX());
            result.processFunctionOverData((i, j) =>
                result.set(i, j, i < row ? elements[i, j] : elements[i + 1, j]));
            return result;
        }
        private void processFunctionOverData(Action<int, int> func)
        {
            for (var i = 0; i < getY(); i++)
            {
                for (var j = 0; j < getX(); j++)
                {
                    func(i, j);
                }
            }
        }
        private static Matrix multi(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(b.getX(), a.getY());
            for (int i = 0; i < a.getY(); i++)
            {
                for (int ii = 0; ii < b.getX(); ii++)
                {
                    double sum = 0;
                    for (int iii = 0; iii < a.getX(); iii++)
                    {
                        sum += a.get(iii, i) * b.get(ii, iii);
                    }
                    result.set(ii, i, sum);
                }
            }
            return result;
        }
        #endregion
    }
}
