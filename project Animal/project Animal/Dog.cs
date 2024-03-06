using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Animal
{
    class Dog:Animal,Land
    {
        //params
        private int NumberOfLegs;

        //constractor
        public Dog(bool mammals, bool carnivorous, Mood mood) : base(mammals, carnivorous, mood)
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
            if (mood == Mood.MOOD_HAPPY)
            {
                Console.WriteLine("wagging their tails");
            }
            else
            {
                Console.WriteLine("whooping");
            }
            
        }
        public int GetNumberOfLegs()
        {
            return NumberOfLegs;
        }
    }
}
