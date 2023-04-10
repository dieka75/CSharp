using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("que edad tenes?");

            int edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("tenes carnet de conducir");

            string carnet = Console.ReadLine();
            
            if (edad>=18 && carnet=="si")
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