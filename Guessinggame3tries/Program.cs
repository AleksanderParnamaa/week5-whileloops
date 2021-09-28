using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool run = true;


            while (run == true) 
            {

                Random rndnr = new Random();
                int rnd;
                rnd = rndnr.Next(1, 10);
                int guess;
                int trys;
                trys = 0;
                guess = 0;



                Console.WriteLine("Kas sa oskad numbri ära arvata 1-10?");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(rnd);

                while (guess != rnd)
                {


                    if (trys > 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Sul on ainult 3 proovi sa kukkusid läbi\n");
                        run = false;
                        Console.WriteLine("Kas sa tahad uuesti mängida? vajuta R + Enter et uuesti mängida");
                        string rerun = Console.ReadLine().ToUpper();
                        if (rerun == "R")
                        {
                            run = true;
                            trys = 0;
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            run = false;
                            break;

                        }


                    }





                    if (guess > rnd)
                    {
                        Console.WriteLine("Mu number on madalam kui" + guess + "\n paku uuesti >>");
                        guess = Convert.ToInt32(Console.ReadLine());

                    }

                    if (guess < rnd)
                    {
                        Console.WriteLine("Mu number on kõrgem kui" + guess + "\n paku uuesti >>");
                        guess = Convert.ToInt32(Console.ReadLine());

                    }

                    if (guess == rnd)
                    {

                        Console.Write("sa pakkusid õigesti, mu number on" + rnd + "ja sa vajasid " + trys + "katset");
                        run = false;
                        Console.WriteLine("kas soovid uuesti mängida? vajuta R + Enter et uuesti mängida!");
                        string rerun = Console.ReadLine().ToUpper();

                        if (rerun == "R")
                        {
                            run = true;
                            trys = 0;
                            Console.Clear();
                        }

                        else
                        {
                            run = false;
                            break;
                        }
                    }


                    trys++;
                }




            }
            Console.Clear();
            Console.WriteLine("tänan mängimast!");
            Console.ReadLine();
        }
    }
}