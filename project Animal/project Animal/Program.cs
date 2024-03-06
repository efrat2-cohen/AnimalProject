using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of animal
            Animal[] animal = new Animal[3];
            animal[0] = new Dog(true, true, Mood.MOOD_HAPPY);
            animal[1] = new Cat(true, true, Mood.MOOD_HAPPY);
            animal[2] = new Frog(false, false, Mood.MOOD_HAPPY);

            //print the result of the functions
            for (int i = 0; i < animal.Length; i++)
            {
                animal[i].SayHello();
                animal[i].SayHello(Mood.MOOD_SCARE);
                if(animal[i] is Dog)
                {
                    Dog dog = (Dog)animal[i];
                    Console.WriteLine("to the dog" + dog.GetNumberOfLegs() + "legs");
                }
                if(animal[i] is Cat)
                {
                    Cat cat = (Cat)animal[i];
                    Console.WriteLine("to the cat" + cat.GetNumberOfLegs() + "legs");
                }
                if(animal[i] is Frog)
                {
                    Frog frog = (Frog)animal[i];
                    Console.WriteLine("to the frog" + frog.GetNumberOfLegs() + "legs");
                    Console.WriteLine(frog.HasGills());
                    Console.WriteLine(frog.HasLaysEggs());
                }
            }
            Console.ReadLine();
        }
    }
}
