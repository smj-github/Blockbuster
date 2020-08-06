using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class VHS : Movie
    {
        #region Properties
        public int CurrentTime { get; set; }
        #endregion

        #region Constructors
        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes):base(Title,Category,RunTime,Scenes)
        {

        }
        #endregion

        #region Methods
        public override void Play()
        {
            Console.WriteLine($"You are watching the VHS moive scene {Scenes[CurrentTime]}");
            CurrentTime++;
            if(CurrentTime == Scenes.Count)
            {
                Rewind();
            }
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }

        public override void PlayWholeMovie()
        {
            foreach (string s in Scenes)
            {
                Console.WriteLine($"Now Playing {s}");
            }
        }
        #endregion
    }
}
