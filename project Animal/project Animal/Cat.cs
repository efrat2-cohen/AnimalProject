using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Animal
{
    class Cat:Animal,Land
    {
        //params
        private int NumberOfLegs;

        //constractor
        public Cat(bool mammals, bool carnivorous, Mood mood) : base(mammals, carnivorous, mood)
        {
            NumberOfLegs = 4;
        }

        //functions
        public override void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public override void SayHello(Mood mood)
        {
            if(mood == Mood.MOOD_HAPPY)
            {
                Console.WriteLine("purr, purr");
            }
            else
            {
                Console.WriteLine("hiss");
            }
        }
        public int GetNumberOfLegs()
        {
            return NumberOfLegs;
        }
    }
}
