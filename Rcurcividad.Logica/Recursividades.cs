using System;
using System.Collections.Generic;
using System.Text;

namespace Rcurcividad.Logica
{
    public  class Recursividades
    {

        public int CalcularFactorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }

            return num * CalcularFactorial(num - 1);

        }
    }
}
