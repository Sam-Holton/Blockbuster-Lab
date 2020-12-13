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

        public List<string> Scenes { get; set; }

        public virtual void PrintInfo()
        {

        }

        public void PrintScenes()
        {

        }

        public abstract void Play();
    }

    public class VHS : Movie
    {
        public double CurrentTime { get; set; }

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public void Rewind()
        {

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
