using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class DVD : Movie
    {
        #region Constructors
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }
        #endregion
        #region Methods
        public override void Play()
        {
            bool bWatchAnotherScene = true;
            while (bWatchAnotherScene)
            {
                Console.WriteLine($"Which scene of the DVD {Title} would you like to watch?");
                PrintScenes();
                Console.WriteLine($"Select 1 - {Scenes.Count}: ");
                int sel;
                string input = Console.ReadLine();
                while (!int.TryParse(input, out sel))
                {
                    Console.WriteLine("Please enter a valid scene number");
                    input = Console.ReadLine();
                }
                Console.WriteLine($"Now showing : {Scenes[sel - 1]}\n");

                Console.WriteLine("Watch another scene? y/n");
                if(Console.ReadLine().ToLower()[0] != 'y')
                {
                    bWatchAnotherScene = false;
                }
                Console.Clear();
            }
        }

        public override void PlayWholeMovie()
        {
            foreach(string s in Scenes)
            {
                Console.WriteLine($"Now Playing {s}");
            }
        }
        #endregion
    }
}
