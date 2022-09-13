using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Calculadora
    {
        double resultado;
        public void Somar (double x, double y)
        {
            resultado = x + y;
            Console.WriteLine($"{x} + {y} = {resultado.ToString("0.00")}");
        }

          public void Subtrair (double x, double y)
        {
            resultado = x - y;
            Console.WriteLine($"{x} - {y} = {resultado.ToString("0.00")}");
        }

          public void Dividir (double x, double y)
        {
            resultado = x / y;
            Console.WriteLine($"{x} / {y} = {resultado.ToString("0.00")}");
        }

          public void Multiplicar (double x, double y)
        {
            resultado = x * y;
            Console.WriteLine($"{x} * {y} = {resultado.ToString("0.00")}");
        }

        public void Potencia (double x, double y)
        {
          double resultado = Math.Pow(x, y); //Utilizado para calcular potência
          Console.WriteLine($"Potencia: \n {x}^{y} = {resultado}");
        }
    }
}