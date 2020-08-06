using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    abstract class Movie
    {      
        #region Property
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }
        #endregion

        #region Constructor
        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }
        #endregion

        #region Methods
        public virtual void PrintInfo()
        {
            Console.WriteLine(Title);
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"RunTime: {RunTime} minutes");
        }

        public void PrintScenes()
        {
            for (int i=0; i<Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i + 1}: {Scenes[i]}");
            }
        }

        public abstract void Play();

        public abstract void PlayWholeMovie();
        #endregion
    }
}
