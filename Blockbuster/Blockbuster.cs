using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class Blockbuster
    {
        List<Movie> Movies = new List<Movie>
        {
        new DVD("Saving Private Ryan", Genre.Drama, 170, new List<string> { "SPR1", "SPR2", "SPR3" }),
        new DVD("Olympus Has Fallen", Genre.Action, 120, new List<string> { "OHF1", "OHF2", "OHF3" }),
        new DVD("Daddy Day Care", Genre.Comedy, 92, new List<string> { "DDC1", "DDC2", "DDC3" }),
        new VHS("GO, Diego, Go", Genre.Comedy, 60, new List<string> { "GDG1", "GDG2", "GDG3" }),
        new VHS("Blue Bloods", Genre.Drama, 60, new List<string> { "BB1", "BB2", "BB3" }),
        new VHS("Drake and Josh", Genre.Comedy, 30, new List<string> { "DAJ1", "DAJ2", "DAJ3" })
        };

        #region Constructors
        public Blockbuster() {}
        #endregion

        #region Methods
        
        public void PrintMovies()
        {
            Console.WriteLine("Please select a movie from the list: ");
            for (int i=0; i< Movies.Count; i++)
            {
                Console.WriteLine($"{i+1}) {Movies[i].Title}");
            }
            Console.WriteLine();
        }

        public Movie Checkout()
        {
            PrintMovies();
            Console.WriteLine("Please select a movie number you want to watch:");
            int opt;
            string userOpt = Console.ReadLine();
            while(!ValidateUserOption(userOpt, out opt))
            {
                Console.WriteLine("Please enter a valid movie number");
                userOpt = Console.ReadLine();
            }
            Movies[opt - 1].PrintInfo();
            return Movies[opt - 1];
        }

        public bool ValidateUserOption(string userOption, out int number)
        {
            if (int.TryParse(userOption, out number))
            {
                if ((number > 0) && (number <= Movies.Count))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }
        #endregion 
    }
}
