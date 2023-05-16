using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Andrew_Maxey
{
    class Movie : IGenre
    {
        // automatic properties 
        public string Esrb { get; set; }

        public string Genre { get; set; } //

        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }
        // Method thats calls the title that you input
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSssssssssshhhhhhhhhh!");
        }
        // making a new method called Describe
        public string Describe()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}";
        }
    }
}
