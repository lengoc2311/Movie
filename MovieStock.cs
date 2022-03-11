using System;
using System.Collections.Generic;


namespace Movie
{
    public class MovieStock{
        private List<Movie> movies;

        private static MovieStock moviestock;

        private MovieStock() {
            movies = new List<Movie>();
        }
        public static MovieStock GetMovieStock() {
            if (moviestock == null)
            {
                moviestock = new MovieStock();
            }
            return moviestock;
        }
        
        private string ChooseCategory(){
            string[] categories = {"Action", "Comedy", "Cartoon", "Horror","Romance"};
            bool correct = false;
            int choice = 0;
            while(!correct){
            System.Console.WriteLine("Choose category: " );
            for(int i =0; i < categories.Length; i++){
               System.Console.WriteLine(i +". "+categories[i]);
            }
            choice = Convert.ToInt32(Console.ReadLine());
            if(choice >= 0 && choice < categories.Length ){
                correct = true;
               }else { 
                  System.Console.WriteLine("invalid");
               }
            }
            return categories[choice];
        }
        public void AddMovie(){
            Movie m = new Movie();
            string title,category;
            bool invalid = true;
            while (invalid)
            {    
                try
                {
                   System.Console.WriteLine("Enter title:");
                    title = Console.ReadLine();
                    m.Title = title;
                    category = ChooseCategory();
                    m.Category = category;
                    movies.Add(m);
                    invalid = false;
                }
                catch(Exception)
                {
                    System.Console.WriteLine("Error:Please enter movie title!");
                }
            }
            System.Console.WriteLine("Add success");

        }
        public void FindMovie(){
            System.Console.WriteLine("Search: ");
            string key = Console.ReadLine();
            foreach(Movie m in movies){
            if((m.Title).Contains(key)){
            m.ShowMovie();
         }
      }
        }


        public void DeleteMovie(){
            System.Console.WriteLine("Movie id: ");
            int id = Convert.ToInt32(Console.ReadLine());
             bool found = false;
         foreach(Movie m in movies)
         {
            if(m.Id == id){
               movies.Remove(m);
               found = true;
               System.Console.WriteLine("Delete success");
               break;
            }
         }
         if(!found) System.Console.WriteLine("ID not found");
        }
        public void ShowAllMovies(){
         foreach (Movie m in movies){
            m.ShowMovie();
         }
      }

    }
    
}