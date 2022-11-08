using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCalculadora
{
    internal class Calculadora
    {
        private double num1;
        private double num2;

        public double GetNum1(){return num1;}

        public void SetNum1(double value){num1 = value;}

        public double GetNum2(){return num2;}

        public void SetNum2(double value){num2 = value;}

        public double Somar()
        {
            return num1 + num2;
        }
        public double Subtrair()
        {
            return num1 - num2;
        }

        public double Multiplicar()
        {
            return num1 * num2;
        }

        public double Dividir()
        {
            return num1 / num2;
        }
    }
}
