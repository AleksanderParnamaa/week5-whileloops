using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("tere tulemast!");

            
            var numberToGuess = new Random().Next(10);

            var guess = -1;

          
            while (guess != numberToGuess)
            {              
                Console.WriteLine("paku mis numbrist ma mõtlen 1-10");              
                var input = Console.ReadLine();                                   
            
                if (int.TryParse(input, out guess))
                {                  
                    if (guess == numberToGuess)
                    {                  
                        Console.WriteLine($"õige, ma mõtlesin numbrist {numberToGuess}");

                        break;
                    }                    
                    else
                    {
                     
                        Console.WriteLine($"peaaegu, see number millest ma mõtlen on { (guess > numberToGuess ? "väiksem" : "suurem") }");
                    }
                }          
                else
                {                    
                    guess = -1;              
                    Console.WriteLine($"Number peab olema positiivne.");
                }
            }           
            Console.WriteLine("Tänan mängimast");

            Console.ReadLine();
        }
    }
}