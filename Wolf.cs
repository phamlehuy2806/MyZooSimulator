using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooSimulator
{
    public class Wolf : Animal, IWeatherAffectable
    {
        public void AffectTo(WeatherType weather)
        {
            if (weather == WeatherType.Cold)
            {
                health *= 0.98;
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
                    health += 5;
                    weight *= 1.02;
                    return;
                }
            }
            health *= 0.5;
        }

        public Wolf()
        {
            breedingPeriod = 10;
        }
        public override void Breed(Environment environment)
        {
            if (age % breedingPeriod == 0)
            {
                environment.Spawn<Wolf>(2);
                Console.WriteLine("Wolf Spawn 2");
            }
        }
    }
}
