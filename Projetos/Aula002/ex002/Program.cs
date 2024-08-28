using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O tipo Byte vai de " + byte.MinValue + " até " + byte.MaxValue);
            Console.WriteLine("O tipo sByte vai de " + sbyte.MinValue + " até " + sbyte.MaxValue);
            Console.WriteLine("O tipo short vai de " + short.MinValue + " até " + short.MaxValue);
            Console.WriteLine("O tipo int vai de " + int.MinValue + " até " + int.MaxValue);
            Console.WriteLine("O tipo uint vai de " + uint.MinValue + " até " + uint.MaxValue );
            Console.WriteLine("O tipo long vai de " + long.MinValue + " até " + long.MaxValue);
            Console.WriteLine("O tipo ulong vai de " + ulong.MinValue + " até " + ulong.MaxValue);
            Console.WriteLine("O tipo float vai de " + float.MinValue + " até " + float.MaxValue);
            Console.WriteLine("O tipo double vai de " + double.MinValue + " até " + double.MaxValue);
            Console.WriteLine("O tipo decimal vai de " + decimal.MinValue + " até " + decimal.MaxValue);
            Console.WriteLine("O tipo bool vai de " + bool.TrueString + " até " + bool.FalseString);
            Console.ReadKey();
        }
    }
}
