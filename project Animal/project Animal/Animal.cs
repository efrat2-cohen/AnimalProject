using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Animal
{
    //enum
    public enum Mood
    {
        MOOD_HAPPY, MOOD_SCARE
    }
    public abstract class Animal
    {
        //params
        private bool Mammals;
        private bool Carnivorous;
        private Mood Mood;
        
        //constractor
        public Animal(bool mammals, bool carnivorous, Mood mood)
        {
            Mammals = mammals;
            Carnivorous = carnivorous;
            Mood = mood;
        }

        //functions
        public abstract void SayHello();
        public abstract void SayHello(Mood mood);
        public bool IsMammals()
        {
            return this.Mammals;
        }
        public void SetMammals(bool isMammals)
        {
            this.Mammals = isMammals;
        }
        public bool IsCarnivorous()
        {
            return this.Carnivorous;
        }
        public void SetCarnivorous(bool isCarnivorous)
        {
            this.Carnivorous = isCarnivorous;
        }
    }
}
