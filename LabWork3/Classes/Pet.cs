using System;

namespace laba3.Classes
{
    [Serializable]
    public abstract class Pet
    {
        public string Name {get; set;}
        public int Age { get; set; }
        public string Color { get; set; }

        public void AnimalColor()
        {
            Console.WriteLine($"{Name} is a {Color}");
        }

        public void AnimalAge()
        {
            if(Age == 1)
            {
                Console.WriteLine($"{Name} is a {Age} year old");
            }
            else
            {
                Console.WriteLine($"{Name} is a {Age} years old");
            }
        }

        public abstract void AnimalEat();
    }
}