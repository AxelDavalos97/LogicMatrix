using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicMatrix
{
    public class Matrix
    {
        public Matrix(int _rows, int _columns) {
            this.Rows = _rows;
            this.Columns = _columns;
        }
        public int Columns { get; set; }
        public int Rows { get; set; }
    }
}
