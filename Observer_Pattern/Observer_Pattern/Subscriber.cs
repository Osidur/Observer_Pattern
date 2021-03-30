using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    class Subscriber
    {
        public string SubscriberName;
        public Subscriber(string name)
        {
            SubscriberName = name;
        }
    }
}
