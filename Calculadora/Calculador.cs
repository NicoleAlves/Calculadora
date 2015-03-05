using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculador
    {

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
            double resultPot = g1;
            for (double i = 1; i < g2; i++)
            {

                resultPot *= g1;

            }
            return resultPot;
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
            return Math.Sin(s1);
        }

        public double Cos(double s1)
        {
            return Math.Cos(s1);
        }

        public double Tg(double s1)
        {
            return Math.Tan(s1);
        }
    }
}
