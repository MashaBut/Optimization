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

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.getX() == b.getX() && a.getY() == b.getY())
            {
                return substract(a, b);
            } else
            {
                throw new Exception("Matrix sizes are not equals");
            }
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
            if (getY() == 1)
            {
                return elements[0, 0];
            }
            if (getY() == 2)
            {
                return elements[0, 0] * elements[1, 1] - elements[0, 1] * elements[1, 0];
            }
            double result = 0;
            for (var y = 0; y < getY(); y++)
            {
                result += (y % 2 == 1 ? 1 : -1) * elements[1, y] *
                    this.createMatrixWithoutColumn(y).
                    createMatrixWithoutRow(1).calculateDeterminant();
            }
            return result;
        }
        public object Clone()
        {
            return new Matrix(elements.Clone() as double[,]);
        }
        public Matrix getInverseMatrix()
        {
            Matrix result = (Matrix)Clone();
            double det = calculateDeterminant();
            processFunctionOverData((int x, int y) =>
            {
                result.set(x, y, ((x + y) % 2 == 1 ? -1 : 1) * сalculateMinor(x,y) / det);
            });
            return result.transponate();
        }

        public double сalculateMinor(int x, int y)
        {
            return createMatrixWithoutColumn(x)
                .createMatrixWithoutRow(y)
                .calculateDeterminant();
        }

        public Matrix transponate()
        {
            Matrix result = (Matrix)Clone();
            processFunctionOverData((x, y) =>
            {
                result.set(y, x, elements[x, y]);
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
            var result = new Matrix(getX() - 1, getY());
            result.processFunctionOverData((x, y) =>
                result.set(x, y, x < column ? elements[x, y] : elements[x + 1, y]));
            return result;
        }
        private Matrix createMatrixWithoutRow(int row)
        {
            if (row < 0 || row >= getY())
            {
                throw new ArgumentException("invalid row index");
            }
            var result = new Matrix(getX(), getY() - 1);
            result.processFunctionOverData((x, y) =>
                result.set(x, y, y < row ? elements[x, y] : elements[x, y + 1]));
            return result;
        }
        private void processFunctionOverData(Action<int, int> func)
        {
            for (var i = 0; i < getY(); i++)
            {
                for (var j = 0; j < getX(); j++)
                {
                    func(j, i);
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
        private static Matrix substract(Matrix a, Matrix b)
        {
            Matrix result = (Matrix)a.Clone();
            result.processFunctionOverData((x,y) => {
                a.set(x, y, a.get(x, y) - b.get(x, y));
            });
            return result;
        }
        #endregion
    }
}
