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
           try
           {
                int number = int.Parse(Console.ReadLine());
                Converter converter = new Converter();
                string converter2 = converter.ConverterTo2(number);
                Console.WriteLine(converter2);
            }
           catch(FormatException)
            {
                Console.WriteLine("введен неверный формат");
            }

            Console.ReadKey();
        }
    }
}
