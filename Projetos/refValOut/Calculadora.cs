using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refValOut
{
    internal class Calculadora
    {
        public static void Triplo(int x, out int resultado)
        {
            //x = x * 3;
            resultado = x * 3;
        }
    }
}
