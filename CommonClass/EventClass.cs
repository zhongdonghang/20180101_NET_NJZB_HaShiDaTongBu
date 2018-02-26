using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonClass
{
    public class EventClass
    {
        public delegate void EventHandleSync(double count);

        public delegate void EventHandleSyncMessage(string message);

    }
}
