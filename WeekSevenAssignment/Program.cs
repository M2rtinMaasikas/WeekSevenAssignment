using System;

namespace WeekSevenAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("sisesta kasutajatunnus");
                string userName = Console.ReadLine();
                Console.WriteLine("sisesta parool");
                string userPassword = Console.ReadLine();
                if(userName =="admin" && userPassword == "1234")
                {
                    Console.WriteLine("tere tulemast");
                    break; 
                }
               else
                {
                    i = i + 1;
                        Console.WriteLine($"Proovi uuesti. {3-i} katset on jäänud.");
                }
            } Console.WriteLine("kena päeva");



        }
    }
}
