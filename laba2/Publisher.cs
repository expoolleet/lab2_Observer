using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class Publisher : IPub
    {
        List<ISub> subs = new List<ISub>();

        delegate void WeatherUpdate(float temp, float humidity, float press);

        event WeatherUpdate NotifyEvent;

        private Random random;

        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        public void AddSub(ISub sub)
        {
            subs.Add(sub);
            NotifyEvent += sub.Update;
        }

        public void RemoveSub(ISub sub)
        {
            subs.Remove(sub);
            NotifyEvent -= sub.Update;
        }

        private void Notify()
        {
            Temperature = random.Next(-15, 31);
            Humidity = random.Next(30, 101);
            Pressure = random.Next(70, 110);

            NotifyEvent?.Invoke(Temperature, Humidity, Pressure);
        }
    }
}
