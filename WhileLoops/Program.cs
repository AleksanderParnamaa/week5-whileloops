using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {


            /*  while (true)
              {
                  Console.WriteLine("Sisesta Pin kood");
                  int userPIN = Convert.ToInt32(Console.ReadLine());
                  if (userPIN == 1234)
                  {
                      Console.WriteLine("Tere Tulemast!");
                      break;
                  }
                  else

                  {
                      Console.WriteLine("Vale PIN, proovi uuesti");

                  }
              }
                  Console.WriteLine("Kena Päeva"); */
            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("Sisesta Pin kood");
                int userPIN = Convert.ToInt32(Console.ReadLine());
                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere Tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN, {3 - i} katset on jäänud");
                }
            }
            Console.WriteLine
            }
        }
    }

