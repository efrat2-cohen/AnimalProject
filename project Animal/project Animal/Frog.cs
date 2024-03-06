using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Animal
{
    class Frog:Animal,Land,Water
    {
        //params
        private int NumberOfLegs;

        //constractor
        public Frog(bool mammals, bool carnivorous, Mood mood) : base(mammals, carnivorous, mood)
        {
            NumberOfLegs = 4;
        }

        //functions
        public override void SayHello(Mood mood)
        {
            if(mood == Mood.MOOD_HAPPY)
            {
                Console.WriteLine("quack quack quack");
            }
            else
            {
                Console.WriteLine("plop into the water");
            }
        }

        public bool HasGills()
        {
            return true;
        }

        public bool HasLaysEggs()
        {
            return true;
        }
        public int GetNumberOfLegs()
        {
            return NumberOfLegs;
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello");
        }

    }
}
