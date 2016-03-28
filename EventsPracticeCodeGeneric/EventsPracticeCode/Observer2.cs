using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsPracticeCode
{
    class Observer2
    {
        public Observer2(Subject mySubject)
        {
            EventHandler<EventArgsWithInt> del = new EventHandler<EventArgsWithInt>(SquareNumber);
            mySubject.NumberEvent += del;
        }

        public void SquareNumber(object sender, EventArgsWithInt e)
        {
            int n = e.InputInteger;
            int displayNumber = n * n;
            MessageBox.Show(displayNumber.ToString());
        }
    }
}
