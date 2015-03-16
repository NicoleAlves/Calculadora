using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculador
    {
        public double FatorialIterativa(double n)
        {
            double result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
        //recursiva - chama ela mesma
        public double FibonacciRecursiva(double num)
        {
            if (num == 1)
                return 0;
            else if (num == 2)
                return 1;
            else
                return FibonacciRecursiva(num - 1) + FibonacciRecursiva(num - 2);
        }

        public double FibonacciIterativa(double num)
        {

            double a = 0;
            double b = 1;
            double c = 1;

            for (double i = 1; i < num; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            return a;
        }


        public double FatorialRecursiva(double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return n * FatorialRecursiva(n - 1);
        }
        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Subtracao(double b1, double b2)
        {
            return b1 - b2;
        }
        public double Multiplicacao(double d1, double d2)
        {
            return d1 * d2;
        }
        public double Divisao(double f1, double f2)
        {
            return f1 / f2;
        }

        public double Potencia(double g1, double g2)
        {
            
            return Math.Pow(g2,g1);
        }

        public double Raiz(double s1, double s2)
        {
            return Math.Pow(s1, 1 / s2);
        }

        public double Porcentagem(double s1, double s2)
        {
            return (s1/100) * s2;
        }

        public double Resto(double s1, double s2)
        {
            return s1 % s2;
        }

        public double Sen(double s1)
        {
            return Math.Sin(s1* (Math.PI/ 180)); 
        }

        public double Cos(double s1)
        {
            return Math.Cos(s1 * (Math.PI / 180));
        }

        public double Tg(double s1)
        {
            return Math.Tan(s1 * (Math.PI / 180));
        }
    }
}
