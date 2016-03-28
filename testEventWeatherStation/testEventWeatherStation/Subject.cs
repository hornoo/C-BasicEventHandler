using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEventWeatherStation
{
    public class Subject
    {

        public event EventHandler<EventArgsWeatherInput> SensorEvent;

        public void OnsenserEvent(int Temp, int Humid)
        {
            EventArgsWeatherInput e = new EventArgsWeatherInput(Temp, Humid);
            SensorEvent(this, e);
        }
    }
}
