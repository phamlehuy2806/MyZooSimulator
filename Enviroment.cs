using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooSimulator
{
    public class Environment
    {
        protected WeatherType weather;
        protected int days;
        protected List<Specis> ecosystem;

        public WeatherType Weather { get; set; }
        public int Days { get; set; }
        public List<Specis> Ecosystem { get; set; } = new List<Specis>();

        public void NextDay()
        {
            Days++;
            ChangeWeather();
        }
        public List<Specis> Select<T>() where T : Specis
        {
            return null;
        }
        public void Eliminate(double threshold) { }
        public void ChangeWeather()
        {
            Random random = new Random();
            Weather = (WeatherType)Enum.GetValues(typeof(WeatherType)).GetValue(random.Next(0, 3));
        }
        public void Hunt() { }
        public void Feed() { }
        public void Spawn<T>(int quantity) where T : Specis, new()
        {
            IEnumerable<T> collection = Ecosystem.OfType<T>();
            Console.WriteLine(collection.Count());
          
            for (int i = 0; i < collection.Count(); i++)
            {
                for (int j = 0; j < quantity; j++)
                {
                    Ecosystem.Add(new T()); 
                }
            }

        }
        
    }


}
