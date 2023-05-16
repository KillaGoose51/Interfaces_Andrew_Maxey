using System;

namespace Interfaces_Andrew_Maxey
{
    class Program
    {
        static void Main(string[] args)
        { // makes a new game object that puts the esrb, genre, title
            Game myGame = new Game("E", "FPS", "ZombCube");
            Console.WriteLine(myGame.Describe());
            // my game objects calls PlayGame method
            myGame.PlayGame();
            // makes a new movie object that puts the esrb, genre, title
            Movie myMovie = new Movie("PG", "Adventure/Comedy", "Sonic the Hedgehog 2");
            // Prints Describe which is a method which return Esrb,Genre,Title, Line 27 Movie.cs
            Console.WriteLine(myMovie.Describe());
            // my movie objects calls PlayMovie method
            myMovie.PlayMovie();
        }
    }
}
