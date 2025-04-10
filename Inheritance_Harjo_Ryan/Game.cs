using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Harjo_Ryan
{
    // Abstract base class representing a general game
    abstract class Game
    {
        // Property to hold the ESRB rating of the game
        public string ESRB { get; set; }

        // Property to hold the title of the game
        public string Title { get; set; }

        // Constructor to initialize the title and ESRB rating
        public Game(string ESRB, string title)
        {
            Title = title;
            ESRB = ESRB;// Make sure parameter name doesn't conflict with property name

        }

        // Method to simulate starting the game
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!"); 
        }

        // Abstract method that must be implemented by derived classes
        public abstract string Describe();
    }






}
