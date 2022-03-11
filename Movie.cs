using System;

namespace Movie
{
    public class Movie
    {
        private string title;
        private string category;
        private int download;
        private int view;
        private int id;

        private static int setid=0;
        public Movie (string title, string category){
            Title = title;
            Category = category;
            download = 0;
            view = 0;
            setid++;
            this.id = setid;
        }
        public Movie(){
            Title="Unknown";
            Category="Unclassified";
            download = 0;
            view = 0;
            setid++;
            this.id = setid;
        }

        public string Title{
            get { return title; }
            set
            {
                if (value == "")
                {
                    throw new Exception("enter title");
                }
                else
                {
                    title = value;
                }
            }
        }
        public string Category{
            get{ return category; }
            set{
                
          category = value;
                
            }
        }
        public int Download{
            get{return download; }
        }
        public int View{
            get{return view; }
        }
        public int Id { 
         get {return id;}
        }

        public void ShowMovie(){
            System.Console.WriteLine(Id + ". " +Title + " - Category:"+ Category);
            System.Console.WriteLine("Views:" + View);
            System.Console.WriteLine("Downloads:" + Download);
        }

    }
}