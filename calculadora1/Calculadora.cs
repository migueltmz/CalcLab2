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
        {   //Implementación de la raiz cuadrada siguiendo el Algoritmo babilonico
            double b = a;
            if (a < 0)
            {
                b = double.NaN;
            }
            else
            {
                double delta = 0.000001;
                double precision = 10;
                while (precision > delta)
                {
                    b = (a / b + b) / 2;
                    precision = Math.Abs(b - (a / b));
                }
            }
            return b;
        }
    }
}
