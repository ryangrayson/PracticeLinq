using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Bronco", "Tacoma", "Tundra", "Scout" };


            //Query Syntax:
            var carsWithO = from car in cars
                            where car.Contains("o")
                            orderby car descending
                            select car;
            foreach(var i in carsWithO)
            {
                Console.WriteLine(i);
            }



            List<string> games = new List<string>() { "Uncharted", "Limbo", "MarioKart 8", "Horizon", "The Last of Us II" };


            //Method Syntax
            var lengthNames = games.OrderBy(game => game.Length);  //"OrderBy like a method. Return "game"
            foreach (var game in lengthNames)
            {
                Console.WriteLine(game);
            }





        }
    }
}



/*(Using Query Syntax)
 * 1. Create an array of car names---DONE
 * 2. Select all of the cars that contain a praticular letter of your choosing.---DONE
 * 3. Print out the new collection in descending order.*///---DONE

/*(Using Method Syntax)
 * 1. Create a list of video games.---DONE
 * 2. List games by the length of the game name.
 * 3. Order by length of the game name.
 * 4. Use the lambda expressoin in this exercise as well.*/
