using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsPracticeCode
{
    class Observer3
    {
        public Observer3(Subject mySubject)
        {
            EventHandler<EventArgsWithInt> del = new EventHandler<EventArgsWithInt>(InverseNumber);
            mySubject.NumberEvent += del;
        }

        public void InverseNumber(object sender, EventArgsWithInt e)
        {
            int n = e.InputInteger;
            int displayNumber = n*-1;
            MessageBox.Show(displayNumber.ToString());
        }
    }
}
