using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal();
        }

        static void Principal()
        {
            double prc_fab, val_ipi, val_distr, prc_final;
           
            Console.Write("Informe o preço de fabrica:  ");
            prc_fab = double.Parse(Console.ReadLine());
           
            val_ipi = Calc_ipi(prc_fab);
            val_distr = Calc_distr(prc_fab);
            prc_final = prc_fab + val_distr + val_ipi;

            Console.WriteLine("\n\nO preco de fabricação é:           " + Math.Round(prc_fab, 2));
            Console.WriteLine("O valor do ipi é:                  " + Math.Round(val_ipi, 2));
            Console.WriteLine("O valor do distribuidor é:         " + Math.Round(val_distr, 2));
            Console.WriteLine("\nO valor final é:                 " + Math.Round(prc_final, 2));

            Console.WriteLine("\n\n\nFIM DO PROGRAMA!");
        }


        private static double Calc_ipi(double prc_fab)
        {
            double cal_ipi;

            if (prc_fab <= 200000)
            {
                cal_ipi = prc_fab * 0.00;
            }

            else if (prc_fab <= 400000)
            {
                cal_ipi = prc_fab * 0.15;
            }

            else
            {
                cal_ipi = prc_fab * 0.20;
            }

            return cal_ipi;
        }

        private static double Calc_distr(double prc_fab)
        {
            double cal_dis;

            if (prc_fab <= 150000)
            {
                cal_dis = prc_fab * 0.03;
            }

            else if (prc_fab <= 350000)
            {
                cal_dis = prc_fab * 0.08;
            }

            else
            {
                cal_dis = prc_fab * 0.12;
            }

            return cal_dis;
        }
    }
}
