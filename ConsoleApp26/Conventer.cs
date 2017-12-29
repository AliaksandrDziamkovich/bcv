using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        public string ConverterTo2 (int number10)
        {
            List<int> x = new List<int>();
            int number;
            while(number10>0)
            {
                number = number10 % 2;
                number10 = number10/2;
                x.Add(number);
            }
            x.Reverse();
            return string.Join("", x);
        }
    }
}
