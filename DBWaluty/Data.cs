using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWaluty
{
    internal class Data
    {
        public int studentId { get; set; }
        public string studentName { get; set; }

        public override string ToString()
        {
            return studentId + ": " + studentName;
        }
    }
}
