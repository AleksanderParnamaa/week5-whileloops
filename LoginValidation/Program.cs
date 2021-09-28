using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
                while(i < 3)
            {
                Console.WriteLine("sisestage kasutajatunnus:");
                string UserName = Console.ReadLine();
                Console.WriteLine("sisesta parool: ");
                string Password = Console.ReadLine();
                if (UserName != "admin" && Password != "admin1234")
            {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti. { 3 - i} katset on jäänud");
                }
                else
                {
                    Console.WriteLine("Tere tulemast");

                }
            }
        }
    }
}
