using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEventWeatherStation
{
   public class CurrentReadingObserver
    {
       ListBox display;

        public CurrentReadingObserver(Subject subject, ListBox Display)
       {
           EventHandler<EventArgsWeatherInput> CurrentReading = new EventHandler<EventArgsWeatherInput>(DisplayCurrentRading);
           subject.SensorEvent += CurrentReading;

           display = Display;
       }

       public void DisplayCurrentRading(object sender, EventArgsWeatherInput e)
        {
            display.Items.Add("temp " + e.Temp.ToString());
            display.Items.Add("Humid " + e.Humid.ToString());
        }

    }
}
