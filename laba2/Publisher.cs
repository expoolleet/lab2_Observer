using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class Publisher : IPub
    {
        public bool IsBroadcasting { get ; set; }

        delegate void WeatherUpdate(float temp, float humidity, float press);

        event WeatherUpdate NotifyEvent;

        private Random random = new Random();

        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        public void AddSub(ISub sub)
        {
            NotifyEvent += sub.Update;
        }

        public void RemoveSub(ISub sub)
        {
            NotifyEvent -= sub.Update;
        }

        public async void Notify()
        {
            while (IsBroadcasting)
            {
                Temperature = random.Next(-15, 31);
                Humidity = random.Next(30, 101);
                Pressure = random.Next(70, 110);

                NotifyEvent?.Invoke(Temperature, Humidity, Pressure);

                await Task.Delay(2000);
            } 
        }
    }
}
