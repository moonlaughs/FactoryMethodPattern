using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animals");
            Factory factory = Factory.GetFactory();
            IAnimal animal1 = factory.GetAnimal("wolf");
            animal1.Eat();
            IAnimal animal2 = factory.GetAnimal("lion");
            animal2.Eat();
            IAnimal nullAnimal = factory.GetAnimal("donut");
            nullAnimal.Eat(); //will do nothing

        }
    }
}
