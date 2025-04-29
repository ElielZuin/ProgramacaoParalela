using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime hora_fim;
            DateTime hora_ini;
            hora_ini = DateTime.Now;

            var t1 = new Thread(() => Funcao_a());  //define a thread 1 e associa ao metodo Funcao_a
            var t2 = new Thread(() => Funcao_b());
            t1.Start();     //chaama a thread 1 e inicia ela
            t2.Start();     //chama a thread 2
            t1.Join();      //semaforo da thread 1
            t2.Join();      //semaforo da thread

            hora_fim = DateTime.Now;

            var hora_total = hora_fim - hora_ini;
            Console.WriteLine("\nTempo Total: " + hora_total);
            Console.WriteLine("\n\n\nFim do programa");
        }

        private static void Funcao_a()
        {
            long ind;
            long cont_a = 0;
            long tam = 6;

            for (ind = 0; ind < tam; ind++)
            {           
            Console.WriteLine("AAAAAAA");
            cont_a++;
            }
            Console.WriteLine("\nTOTAL DA FUNCAO A = " + cont_a);
        }

        private static void Funcao_b()
        {
            long ind;
            long cont_b = 0;
            long tam = 6;

            for (ind = 0; ind < tam; ind++)
            {
                Console.WriteLine("BBBBBBB");
                cont_b++;
            }
           Console.WriteLine("\nTOTAL DA FUNCAO B = " + cont_b);
        }
        
        
    }
}
