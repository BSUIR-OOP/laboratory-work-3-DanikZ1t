using System;

namespace laba3.Classes
{
    [Serializable]
    public class Bird : Pet
    {
        public override void AnimalEat()
        {
            Console.WriteLine($"A bird eats insects");
        }
    }
}