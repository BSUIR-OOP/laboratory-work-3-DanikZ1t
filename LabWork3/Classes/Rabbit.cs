using System;

namespace laba3.Classes
{
    [Serializable]
    public class Rabbit : Pet
    {
        public override void AnimalEat()
        {
            Console.WriteLine($"Rabbit eats grass");
        }
    }
}