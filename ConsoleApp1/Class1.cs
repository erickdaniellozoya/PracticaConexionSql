using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public int potencia(int num1, int num2)
        {
            int multi = 1;
            for (int i = 0; i < num2; i++)
            {
                multi *= num1;
            }

            return multi;

        }

        public int factorial(int num1)
        {
            int multiplicacion = 1;
            for (int i = num1; i >= 1; i--)
            {
                multiplicacion *= i;

                if (i == 1)
                {
                    Console.Write(i.ToString() + "=");
                }
                else
                {
                    Console.Write(i.ToString() + " x ");
                }

            }
            return multiplicacion;
        }
    }
}
