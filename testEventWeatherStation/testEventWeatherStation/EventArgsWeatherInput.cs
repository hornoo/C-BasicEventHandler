using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEventWeatherStation
{
    public class EventArgsWeatherInput : EventArgs
    {
        public int Temp { get; set; }
        public int Humid{get; set;}


        public EventArgsWeatherInput(int temp, int humid)
        {
            Temp = temp;
            Humid = humid;
        }
    }
}
