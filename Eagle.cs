using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooSimulator
{
    public class Eagle : Animal, IFly
    {
        private int fly = 0;
        public void Fly()
        {
            fly += 1;
            if (fly % 5 == 0)
            {
                health *= 0.8;
            }
        }

        public void Hunt(Environment environment)
        {
            List<Specis> food = environment.Select<Rabit>();
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i].Health != 0)
                {
                    food[i].Health = 0;
                    length *= 1.02;
                    weight *= 1.02;
                    return;
                }
            }
            health *= 0.5;
        }

        public Eagle()
        {
            breedingPeriod = 10;
        }
        public override void Breed(Environment environment)
        {
            if (age % breedingPeriod == 0)
            {
                environment.Spawn<Eagle>(2);
                Console.WriteLine("Spawn Eagle 2");
            }
        }

    }
}
