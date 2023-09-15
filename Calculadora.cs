using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntentodeEjerciciosClases
{
    internal class Calculadora
    {
       
        
        public double Sumar(double numero1, double numero2)
        {
            double resultado= numero1+ numero2;
            return resultado;
        }
        public double Restar(double numero1, double numero2)
        {
            double resultado = numero1 - numero2;
            return resultado;
        }
        public double Multiplicar(double numero1, double numero2)
        {
            double resultado = numero1 * numero2;
            return resultado;
        }
        public double Dividir(double numero1, double numero2)
        {
            double resultado = numero1 / numero2;
            return resultado;
        }
    }
}
