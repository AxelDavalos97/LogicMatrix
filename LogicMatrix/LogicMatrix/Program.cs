using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var isAValidNumber = true;
            List<Matrix> lstMatrix = new List<Matrix>();
            do
            {
                Console.Write("Insert the number of test cases: \n");
                var testCasesNumberString = Console.ReadLine();

                //If the number of test cases is not parseable, return the code to the beggining of the process.
                isAValidNumber  = ClsUtils.IsAValidNumber(testCasesNumberString).Item1;

                var testCasesNumber = ClsUtils.IsAValidNumber(testCasesNumberString).Item2;
                if (testCasesNumber != -1)
                {
                    lstMatrix = new List<Matrix>();
                    for (int i = 0; i < testCasesNumber; i++)
                    {

                        Console.Write("Insert how many rows do you want: \n");
                        var numberRowsString = Console.ReadLine();
                        var tupleRows = ClsUtils.IsAValidNumber(numberRowsString);
                        //If the number of rows is not parseable, return the code to the beggining of the process.
                        //Item1 contains a boolean value if is a valid number or not.
                        if (!tupleRows.Item1)
                        {
                            isAValidNumber = false;
                            lstMatrix.Clear();
                            break;
                        }

                        Console.Write("Insert how many columns do you want: \n");
                        var numberColumnsString = Console.ReadLine();
                        var tupleColumns = ClsUtils.IsAValidNumber(numberColumnsString);
                        //If the number of columns is not parseable, return the code to the beggining of the process.
                        //Item1 contains a boolean value if is a valid number or not.
                        if (!tupleColumns.Item1)
                        {
                            isAValidNumber = false;
                            lstMatrix.Clear();
                            break;
                        }
                        //Item2 contains a int value of how many rows or column are specified.
                        var matrix = new Matrix(tupleRows.Item2, tupleColumns.Item2);
                        lstMatrix.Add(matrix);

                    }
                }
                else
                    isAValidNumber = false;


            } while (!isAValidNumber);

            ClsCoreMatrix.WalkInMatrices(lstMatrix);
            Console.ReadKey();
        }
    }
}

