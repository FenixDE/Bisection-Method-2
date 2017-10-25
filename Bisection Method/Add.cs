using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Method
{
    class Add
    {
       //check if string is number
        public static bool isNumeric(object Expression)
        {
            decimal dm;
            bool tparse = Decimal.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out dm);
            return tparse;
        }
    }
}