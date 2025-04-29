using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            string le;
            Console.WriteLine("\nEscolha uma funcao ");
            Console.WriteLine("\n1- calcula area do quadrado");
            Console.WriteLine("\n1- calcula area do triangulo");
            le = Console.ReadLine();
            opc = int.Parse(le);

            if (opc == 1)
                calc_area();
            else if (opc == 2)
                calc_tria();
            else
                Console.WriteLine("Valor incorreto tente com 1 e 2");




        }
    
        private static void calc_area()
        {
            float area, lado;
            string ler;
            Console.WriteLine("informe o lado do quadrado = ");
            ler = Console.ReadLine();
            lado = float.Parse(ler);
            area = lado * lado;
            Console.WriteLine("\nAreá do quadrado = " + Math.Round(area, 1));
        }

        private static void calc_tria()
        {
            float area, alt_t, base_t;
            string ler;
            Console.WriteLine("\ninforme a base do triangulo: ");
            ler = Console.ReadLine();
            base_t = float.Parse(ler);
            Console.WriteLine("\nInforme a altura do quadrado: ");
            ler = Console.ReadLine();
            alt_t = float.Parse(ler);
            area = (base_t * alt_t) / 2;
            Console.WriteLine("\n\nA area do triangulo é: " + Math.Round(area, 2));
        }


    }
}


