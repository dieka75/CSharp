using System;

namespace Condicional
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("que edad tenes?");

            int edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("tenes carnet de conducir");

            string carnet = ReadLine();

            if (edad < 18 || carnet != "si")
            {
                System.Console.WriteLine("No puedes conducir");
            }
            else
            {
                System.Console.WriteLine("Puedes conducir");
            }
        }
    }

    class Program : NewBaseType;
    
}