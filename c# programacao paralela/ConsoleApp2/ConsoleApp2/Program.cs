using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program   //projeto sem parametro com retorno
    {
        static void Main(string[] args)
        {
            float multiplica;
            multiplica = calc_multiplicacao();
            Console.WriteLine("\nResultado da multiplicação = " + Math.Round(multiplica, 2));
        }

        private static float calc_multiplicacao()
        {
            float valor1, valor2, resultado;
            string ler;

            Console.Write("digite o primeiro numero: ");
            ler = Console.ReadLine();
            valor1 = float.Parse(ler);
            Console.Write("digite o segundo numero: ");
            ler = Console.ReadLine();
            valor2 = float.Parse(ler);
            resultado = valor1 * valor2;
            return(resultado);
            
        }
    }
}
