using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int depart = 0;
            int arrive = 0;
            int pas = 0;
            double conversion=0;


            Console.WriteLine("Bienvenue dans l'outil de conversion celsius/farenheit");
            Console.WriteLine("Entre le points de départ");
            depart=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre le points de arrivé");
            arrive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre le nombre de pas");
            pas = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("CELSIUS                 FARENHEIT");

            for (int n = depart; n < arrive; n+=pas)
            {
                conversion = 9.0/5 * n + 32;



            Console.WriteLine(n + "                 " + conversion);
            }
            Console.ReadLine();





        }
    }
}
