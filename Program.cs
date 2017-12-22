using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Converter converter = new Converter();

            List<int> converterTo2 = converter.ConverterTo2(number);
            List<int> reverse = converter.ReverseNumber(converterTo2);
            string numberToString = converter.NumberToString(reverse);

            Console.WriteLine(numberToString);
            Console.ReadKey();
        }
    }
}
