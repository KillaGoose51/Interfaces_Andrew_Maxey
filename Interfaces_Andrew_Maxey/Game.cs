using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Andrew_Maxey
{
    class Game : IGenre
    { // automatic properties
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }


        public Game(string esrbParam, string genreParam, string titleParam)
        {
            //Assigning Esrb, Genre, Title to what you input.
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }
        // making a new method called PlayGame
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }
        // making a new method called Describe
        public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";
        }
    }
}
