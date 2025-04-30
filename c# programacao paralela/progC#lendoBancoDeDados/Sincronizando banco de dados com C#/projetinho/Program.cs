using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace projetinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            DateTime hora_ini;
            DateTime hora_fim;
            hora_ini = DateTime.Now;
            MySqlConnection con_cadfunc = new MySqlConnection();
            con_cadfunc = new MySqlConnection("server=localhost;database=progpar;uid=root;pwd=mysqlec2019*");
            con_cadfunc.Open();
            MySqlCommand cad_command = new MySqlCommand();
            cad_command.Connection = con_cadfunc;
            cad_command.CommandText = ("SELECT * from cadfunc");
            MySqlDataReader cad_read = cad_command.ExecuteReader();
            while (cad_read.Read())
            {
                int re_cad = cad_read.GetInt32(0);
                string bruto = cad_read.GetString(1);
                string inss = cad_read.GetString(2);
                string liq = cad_read.GetString(3);
                Console.WriteLine("\n RE do funcionario    : " + re_cad);
                Console.WriteLine(" RE do funcionario    : " + bruto);
                Console.WriteLine(" RE do funcionario    : " +inss);
                Console.WriteLine(" RE do funcionario    : " + liq);
                contador++;
            }
            con_cadfunc.Close();
            hora_fim = DateTime.Now;
            var tempo_total = hora_fim - hora_ini;
            Console.WriteLine("\n Total de registros lidos  : " + contador);
            Console.WriteLine("\n Tempo Total               : " + tempo_total);


        }
    }
}
