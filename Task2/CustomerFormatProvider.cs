using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class CustomerFormatProvider:IFormatProvider,ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            return null;
        }

    
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg==null)
 	            throw new ArgumentNullException();
            var c = arg as Customer;         
            try
            {
                return c.ToString(format,null);
            }
            catch (FormatException e)
            {
                return new string(c.Name.Reverse().ToArray());
            }
        }
    }
}
