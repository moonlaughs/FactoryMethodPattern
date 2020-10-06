using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace FactoryMethodPattern
{
    public class Factory
    {
        public static Factory factory = new Factory();

        public static Factory GetFactory() { return factory; }

        private Factory()
        {

        }

        public IAnimal GetAnimal(string animal)
        {
            if(animal == "wolf")
            {
                return new Wolf();
            }
            if(animal == "lion")
            {
                return new Lion();
            }
            else
            {
                return new NullObject();
            }
        }
    }
}
