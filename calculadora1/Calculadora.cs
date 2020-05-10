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
        public static double raiz(double x)
        {   //Implementación de la raiz cuadrada siguiendo el algoritmo de Bakhshali
            double b;
            //comprobar si a es 0
            if (x == 0)
            {
                b = 0;
            }
            else
            {
                if (x < 0)
                {
                    b = double.NaN;
                }
                else
                {
                    //Buscar el cuadrado perfecto más cercano
                    int n = 1;
                    while (n*n<x)
                    {
                        n++;
                    }
                    n--;
                    //calcular
                    b = (Math.Pow(n, 4) + x * 6 * Math.Pow(n, 2) + Math.Pow(x,2)) / (4 * Math.Pow(n,3) + 4 * n * x);
                }
            }
            return b;
        }
    }
}
