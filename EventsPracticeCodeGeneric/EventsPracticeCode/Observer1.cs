using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsPracticeCode
{
    class Observer1
    {
        public Observer1(Subject mySubject)
        {
            EventHandler<EventArgsWithInt> del = new EventHandler<EventArgsWithInt>(DivideByTwo);
            mySubject.NumberEvent += del;
        }
        public void DivideByTwo(object sender, EventArgsWithInt e)
        {
            int n = e.InputInteger;
            double displayValue = n / 2.0;
            MessageBox.Show(displayValue.ToString());
        }
    }
}
