using System;
using System.Collections.Generic;

namespace Blockbuster_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Blockbuster
    {
        public List<Movie> MovieList()
        {
            List<Movie> movies = new List<Movie>
            {
                new VHS
                {
                    Title = "The Fifth Element",
                    RunTime = 127,
                    Category = Genre.Action,
                    Scenes =
                    {
                        "LeeLou gets blown Up",
                        "LeeLou gets reconstructed",
                        "LeeLou blows up bad planet",
                        "LeeLou hooks up below her station"
                    }
                },
                new VHS
                {
                    Title = "The Wizard of Oz",
                    RunTime = 112,
                    Category = Genre.Drama,
                    Scenes =
                    {
                        "Dorothy goes to Oz",
                        "Dorothy meets some odd folks",
                        "Dorothy kills a woman",
                        "Dorothy absconds back to Earth"
                    }
                },
                new VHS
                {
                    Title = "Star Wars - A New Hope",
                    RunTime = 125,
                    Category = Genre.Action,
                    Scenes =
                    {
                        "Vader tries to kill Leia",
                        "Luke discovers he's not just a farmer's kid",
                        "Luke levels up with Yoda",
                        "Luke blows up Vader's toy"
                    }
                }, 
                new DVD
                {
                    Title = "Inception",
                    RunTime = 162,
                    Category = Genre.Drama,
                    Scenes =
                    {
                        "Cobb and crew hacks somebodies brain",
                        "Cobb goes deeper into the brain",
                        "Cobb goes deeper into the brain... again",
                        "Cobb goes super deep and comes back... maybe"
                    }
                },
                new DVD
                {
                    Title = "Alita, Battle Angel",
                    RunTime = 122,
                    Category = Genre.Drama,
                    Scenes =
                    {
                        "Doc finds cyborg core in dump",
                        "Doc rebuilds Alita with spare parts",
                        "Alita trades up for better body",
                        "Alita joins ultraviolent racing for chance to kill someone who doesn't race"
                    }
                },
                new DVD
                {
                    Title = "Ender's Game",
                    RunTime = 114,
                    Category = Genre.Drama,
                    Scenes =
                    {
                        "Ender gets recruited",
                        "Ender leads teams to wins",
                        "Ender forms an elite team for a different game",
                        "Ender unknowingly commits genocide"
                    }
                }
            };





            return movies;
        }

        public void PrintMovies()
        {

        }

        public void CheckOut()
        {

        }
    }

    public abstract class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public Genre Category { get; set; }
        public List<string> Scenes { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine(Title);
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {RunTime}");
        }

        public void PrintScenes()
        {
            int x = 1; // Assumption: General public starts at one even though indexes start at zero

            foreach(var scene in Scenes)
            {
                Console.WriteLine($"{x}: {scene}");
            }
        }

        public abstract void Play();        
    }

    public class VHS : Movie
    {
        public double CurrentTime;

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }

    public class DVD : Movie
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
    }

    public enum Genre
    {
        Drama = 0,
        Comedy = 1,
        Horror = 2,
        Romance = 3,
        Action = 4
    }
}
