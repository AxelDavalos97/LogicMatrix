using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicMatrix
{
    public static class ClsCoreMatrix
    {
        public static void WalkInMatrices(List<Matrix> matrices)
        {
            //We get the final direction from the number of rows and columns of the matrix
            foreach (var matrix in matrices)
            {
                GetFinalDirection(matrix.Rows, matrix.Columns);
            }
        }

        static void GetFinalDirection(int rows, int columns)
        {
            //If the rows are more than columns is because the final direction it could be Up or down.
            if (rows > columns)
            {
                //If columns is a pair number the final direction is UP
                if (columns % 2 == 0)
                    Console.Write("U\n");
                //If columns is not a pair number the final direction is DOWN
                else
                    Console.Write("D\n");

            }
            //If the columnos are more than rows or there are equal is because the final direction it could be right or or left.
            else
            {
                //If rows is a pair number the final direction is LEFT
                if (rows % 2 == 0)
                    Console.Write("L\n");
                //If rows is not a pair number the final direction is RIGHT
                else
                    Console.Write("R\n");
            }


        }


    }
}
