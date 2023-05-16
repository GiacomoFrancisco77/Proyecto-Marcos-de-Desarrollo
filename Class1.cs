using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Class1
    {
        public double Suma(double num1, double num2)
        {
            double suma;
            suma = num1 + num2;
            return suma;
        }
        public double Resta(double num1,double num2)
        {
            double resta;
            resta = num1 - num2;
            return resta;
        }
        public double Multiplicacion(double num1,double num2)
        {
            double mult;
            mult = num1 * num2;
            return mult;
        }
        public double Division(double num1,double num2)
        {
            double division;
            division = num1 / num2;
            return division;
        }
    }
}
