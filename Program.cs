using System;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieStock m = MovieStock.GetMovieStock();
            m.AddMovie();
            m.ShowAllMovies();
        }
    }
}
