using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        public List<int> ConverterTo2 (int number10)
        {
            List<int> x = new List<int>();
            int number2, number;
            for (int i = 0; i < 100000; i++)
            {
                if (number10 < 1)
                {
                    break;
                }
                number2 = number10 % 2;
                number = number10 / 2;
                number10 = number;

                x.Add(i);
                x[i] = number2;
            }
            return x;
        }

        public List<int> ReverseNumber (List<int> ConverterTo2)
        {
           ConverterTo2.Reverse();
            return ConverterTo2;
        }

        public string NumberToString ( List<int> ReverseNumber)
        {
            string value = String.Concat<int>(ReverseNumber);
            return value;
        }

    }
}
