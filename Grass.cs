using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyZooSimulator
{
    class Grass : Plant,IWeatherAffectable
    {
        public Grass()
        {
            Id = "";
            Name = "";
            Weight = 10.0;
            Length = 10.0;
            Health = 100;
            Age = 1;
        }

        public void AffectTo(WeatherType weather)
        {
            switch(weather)
            {
                case WeatherType.Rain:
                    weight *= 1.05;
                    break;
                case WeatherType.Hot:
                    health *= 0.8;
                    break;
                case WeatherType.Cold:
                    health *= 0.9;
                    break;
            }
        }

        public override void Breed(Environment enviroment)
        {
            if(age > 0 && enviroment.Weather == WeatherType.Rain)
            {
                enviroment.Spawn<Grass>(1);
                Console.WriteLine("Grass Spawn 1");
            }
        }
    }
}
