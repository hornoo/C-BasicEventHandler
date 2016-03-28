using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPracticeCode
{
    public class EventArgsWithInt: EventArgs
    {
        public int InputInteger { get; set; }

        public EventArgsWithInt(int inputInteger)
        {
            InputInteger = inputInteger;
        }
    }
}
