using System;

namespace Movie
{
    public class MovieStore{
        private MovieStock moviestore = MovieStock.GetMovieStock();

        public MovieStore(){
            //moviestore = MovieStock.GetMovieStock();
        }
        public void FindMovie(){
            System.Console.WriteLine("Search: ");
            string key = Console.ReadLine();
            foreach(Movie m in moviestore){
            if((m.Title).Contains(key)){
            m.ShowMovie();
        }
    }
    
}
}
}