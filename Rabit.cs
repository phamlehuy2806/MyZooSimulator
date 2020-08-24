using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyZooSimulator
{
    class Rabit : Animal
    {

        public void Hunt(Environment environment)
        {
            List<Specis> food = environment.Select<Grass>();
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i].Health != 0)
                {
                    food[i].Health = 0;
                    return;
                }
            }
            food[0].Health = 0;
            health *= 0.5;
        }
        public Rabit()
        {
            breedingPeriod = 5;
        }
        public override void Breed(Environment environment)
        {
            if (age % breedingPeriod == 0)
            {
                environment.Spawn<Rabit>(1);
                Console.WriteLine("Rabit Spawn 1");
            }
        }

    }
}
