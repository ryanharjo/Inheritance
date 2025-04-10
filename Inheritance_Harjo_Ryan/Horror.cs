using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Harjo_Ryan
{
    // The Horror class inherits from the Game base class
    class Horror : Game
    {
        // Constructor for the Horror class
        // Takes ESRB rating and title as parameters and passes them to the base class constructor
        public Horror(string esrbparam, string titleparam) : base(esrbparam, titleparam)
        {
            Title = titleparam; // Assign the title parameter to the Title property
            ESRB = esrbparam; // Assign the ESRB parameter to the ESRB property
        }

        // Override the Describe method from the base class
        public override string Describe()
        {
            // Return a string describing the horror game with its title and ESRB rating
            return $"{Title} is a horror game rated {ESRB}";
        }
    }
}
