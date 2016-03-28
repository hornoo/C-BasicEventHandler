using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPracticeCode
{
    public class Subject
    {
        // Alternative to using EventHandler<T>
        //public delegate void NumberEventHandler(object sender, EventArgsWithInt e);

        public event EventHandler<EventArgsWithInt> NumberEvent;    // NumberEventHandler is the delegate type bound to NumberEvent

        public void OnNumberEvent()
        {
            EventArgsWithInt e = new EventArgsWithInt(42);
            NumberEvent(this, e);
        }

    }
}
