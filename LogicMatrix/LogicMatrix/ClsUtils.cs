using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicMatrix
{
    public static class ClsUtils
    {
        public static Tuple<bool, int> IsAValidNumber(string numberInString)
        {
            int number;
            bool success = Int32.TryParse(numberInString, out number);
            if (success)
            {
                return new Tuple<bool, int>(true, number);
            }
            else
            {
                return new Tuple<bool, int>(false, -1);
            }

        }
    }
}

