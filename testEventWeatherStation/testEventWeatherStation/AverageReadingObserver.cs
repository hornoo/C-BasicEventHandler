using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEventWeatherStation
{
    public class AverageReadingObserver
    {

        ListBox display;
         int runCount;
         double computedAverageTemp;
         double computedAverageHumid;
        public AverageReadingObserver(Subject subject, ListBox Display)
        {

            EventHandler<EventArgsWeatherInput> AverageReading = new EventHandler<EventArgsWeatherInput>(DisplayAveragereading);
            subject.SensorEvent += AverageReading;

            computedAverageHumid = 0;
            computedAverageTemp = 0;
            runCount = 0;
            display = Display;

        }
        private void DisplayAveragereading(object sender, EventArgsWeatherInput e)
        {


            if (runCount == 0)
            {
                runCount++;
                computedAverageTemp = e.Temp;
                computedAverageHumid = e.Humid;
                display.Items.Add("Temp " + e.Temp.ToString());
                display.Items.Add("Humid " + e.Humid.ToString());
            }
            else
            {
                runCount++;

                computedAverageHumid = AverageData(runCount, e.Humid, computedAverageHumid);
                computedAverageTemp = AverageData(runCount, e.Temp, computedAverageTemp);

                display.Items.Add("Temp " + computedAverageTemp.ToString("F2"));
                display.Items.Add("Humid " + computedAverageHumid.ToString("F2"));


            }
            
        }


        public double AverageData(int dataruns, int newData, double runningTotal)
        {
            double returnValue = 0;

            returnValue = ((runningTotal * (dataruns - 1)) + newData) / dataruns;

            return returnValue;
        }
    }
}
