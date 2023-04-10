using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string carnet="no";

            Console.WriteLine("que edad tenes?");

            int edad = Int32.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                System.Console.WriteLine("tenes carnet de conducir?");

                carnet = Console.ReadLine();
                
            }
            
            if (edad>=18 && carnet == "si")
            {
                System.Console.WriteLine("Puedes conducir");
            }
            else
            {
                System.Console.WriteLine("No puedes conducir");
            }
        }
    }
}