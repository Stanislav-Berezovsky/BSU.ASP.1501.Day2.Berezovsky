using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class HexProvider:IFormatProvider,ICustomFormatter
    {
        private static readonly char[] arrayHexNumber = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            return null;
        }


        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (format.ToUpperInvariant() != "H")
                throw new FormatException(String.Format("The {0} format string is not supported.", format));

            
            if (arg == null || !(arg is int))
                throw new ArgumentException();
            
            int number = Convert.ToInt32(arg);
            bool isPositiv=true;
            if (number < 0)
            {
                isPositiv = false;
                number = number * (-1);
            }
            StringBuilder hexNumber = new StringBuilder();
            int part = 0;
            while (number > 0)
            {
                part = number % 16;
                number = number / 16;
                hexNumber.Append(arrayHexNumber[part]);
            }
            if (isPositiv)
                return  new string(hexNumber.ToString().Reverse().ToArray());
            return "-" + new string(hexNumber.ToString().Reverse().ToArray()); 
        }
    }
}
