using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora
{
    public static class Calculadora
    {
        public static int suma(int a, int b)
        {
            int resultado = a + b;
            return resultado;
        }
        public static int resta(int a, int b)
        {
            int resultado = a - b;
            return resultado;
        }
        public static int multiplicacion(int a, int b)
        {
            int resultado = a * b;
            return resultado;
        }
        public static double division(int a, int b)
        {
            double resultado;
            if(b == 0)
            {
                if (a >= 0)
                {
                    resultado = double.PositiveInfinity;
                }
                else
                {
                    resultado = double.NegativeInfinity;
                }
            }
            else
            {
                resultado = a / b;
            }
            
            return resultado;
        }
        public static double raiz(double a)
        {
            double resultado = Math.Sqrt(a);
            return resultado;
        }
        public static double operacion(int a)
        {
            return 0;
        }
    }
}
