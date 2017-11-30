using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class MatrixUtils<T>
    {
        public enum OrderType
        {
            Asc,
            Desc
        }

        public T[,] Matrix { get; set; }

            public MatrixUtils(T[,] matrix)
            {
                this.Matrix = matrix;
            }

        public bool IsOrderedSequenceExists(OrderType orderType)
        {
            
            int row = 0;
            int column = 0;

            int rowsCount = Matrix.GetLength(0);
            int columnsCount = Matrix.GetLength(1);

            T currentElement = this.Matrix[rowsCount - 1, 0];
            T prevElement = this.Matrix[rowsCount - 1, 0];

            for (int i = 0; i < columnsCount; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = rowsCount - 1; j >= 1; j--)
                    {
                        currentElement = Matrix[j - 1,i];
                        if (!DetectAndCompareNewValue(orderType, Matrix[ j, i], ref prevElement, ref currentElement))
                            return false;

                    }
                }
                else
                {
                    for (int j = 0; j < rowsCount - 1; j++)
                    {
                        currentElement = Matrix[j + 1,i ];
                        if (!DetectAndCompareNewValue(orderType, Matrix[j,i], ref prevElement, ref currentElement))
                            return false;

                    }
                }
            }
            return true;
        }


        private bool DetectAndCompareNewValue(OrderType orderType, T value, ref T prevValue, ref T currentValue)
        {
            prevValue = currentValue;
            currentValue = value;

            if (orderType == OrderType.Asc && Comparer<T>.Default.Compare(currentValue, prevValue) > 0)
                return false;

            if (orderType == OrderType.Desc && Comparer<T>.Default.Compare(currentValue, prevValue) < 0)
                return false;

            return true;
        }

       

       
    }
}
 