using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEventWeatherStation
{
    public partial class Form1 : Form
    {
        Subject sensorSubject;
        CurrentReadingObserver currentreading;
        AverageReadingObserver aveReading;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     

            int temp = 0;
            int humid = 0;
            try
            {
                temp = Int32.Parse(tbtemp.Text.ToString().Trim());
                humid = Int32.Parse(tbhumid.Text.ToString().Trim());
            }
            catch (FormatException error)
            {

                MessageBox.Show(error.ToString());

            }
            sensorSubject.OnsenserEvent(temp, humid);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sensorSubject = new Subject();

            currentreading = new CurrentReadingObserver(sensorSubject, lbreading);
            aveReading = new AverageReadingObserver(sensorSubject, lbaverage);
            
        }
    }
}
