using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Welcome to GC Blockbuster");
            Blockbuster bb = new Blockbuster();

            bool bContinue = true;
            while (bContinue)
            {
                Movie movieOpt = bb.Checkout();

                Console.WriteLine("\nDo you want to watch the movie? y/n");
                if (Console.ReadLine().ToLower()[0] == 'y')
                {
                    Console.WriteLine("Do you want to watch the whole movie? y/n");
                    if (Console.ReadLine().ToLower()[0] == 'y')
                    {
                        movieOpt.PlayWholeMovie();
                    }
                    else
                    {
                        if (movieOpt.GetType() == typeof(DVD))
                        {
                            Console.WriteLine();
                            movieOpt.Play();
                        }
                        else
                        {
                            VHS vhsObj = (VHS)movieOpt;
                            vhsObj.Play();
                        }
                    }
                }

                Console.WriteLine("Do you want to watch another movie? y/n");
                if(Console.ReadLine().ToLower()[0] != 'y')
                {
                    bContinue = false;
                    Console.WriteLine("Bye");
                }          
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
