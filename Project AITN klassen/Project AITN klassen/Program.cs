using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AITN_klassen
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] klasnamen = new string[3];
            klasnamen[0] = "5AI&T";
            klasnamen[1] = "5IT&N";
            klasnamen[2] = "6IT&N";

            foreach (string item in klasnamen)
            {
                Console.WriteLine(item);
            }

            string[] klasnamenBis = { "5AIT", "5ITN", "6ITN" };
            foreach (string item in klasnamenBis)
            {
                Console.WriteLine(item);
            }

            //klas toevoegen

            Console.WriteLine("Gelieve nog een klas toe te voegen: ");
            klasnamenBis[3] = Console.ReadLine();

            Console.WriteLine("Geupdatete lijst: ");
            foreach (string klasnaam in klasnamenBis) 
            {
                Console.WriteLine(klasnaam);
            }

            Console.ReadKey();





        }
    }
}
