using System;

namespace laba3.Classes
{
    [Serializable]
    public class Cat : Pet
    {
        public override void AnimalEat()
        {
            Console.WriteLine($"A cat eats meat");
        }
    }
}