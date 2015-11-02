using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task2
{
    public class Customer:IFormattable
    {
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }


        public Customer(string name, string ContactPhone, decimal revenue)
        {
            this.Name = name;
            this.ContactPhone = ContactPhone;
            this.Revenue = revenue;
        }


        public override string ToString()
        {
            return this.ToString("NCR", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }


        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                format = "NCV";
            if (formatProvider == null)
                formatProvider = CultureInfo.CurrentCulture;
            string outPutString ="";
            switch (format)
            {
                case "NCR":
                    outPutString = string.Format("{0} {1} {2}",Name.ToString(formatProvider),ContactPhone.ToString(formatProvider),Revenue.ToString(formatProvider));
                    break;
                case "NC":
                    outPutString = string.Format("{0} {1}", Name.ToString(formatProvider), ContactPhone.ToString(formatProvider));
                    break;
                case "NR":
                    outPutString = string.Format("{0} {1}", Name.ToString(formatProvider), Revenue.ToString(formatProvider));
                    break;
                case "CR":
                    outPutString = string.Format("{0} {1}", ContactPhone.ToString(formatProvider), Revenue.ToString(formatProvider));
                    break;
                case "N":
                    outPutString = string.Format("{0}", Name.ToString(formatProvider));
                    break;
                case "C":
                    outPutString = string.Format("{0}", ContactPhone.ToString(formatProvider));
                    break;
                case "R":
                    outPutString = string.Format("{0}", Revenue.ToString(formatProvider));
                    break;
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }
            return outPutString;

        }

    }


}
