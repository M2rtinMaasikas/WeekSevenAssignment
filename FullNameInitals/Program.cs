using System;

namespace FullNameInitals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string Lastname = Console.ReadLine();
            Console.WriteLine($"Tere, {FirstName[0]}. {Lastname[0]}");
        }
    }
}
