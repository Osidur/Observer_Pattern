using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    class Creator
    {
        private List<Subscriber> subscriber_list = new List<Subscriber>();

        public void Subscribe(Subscriber subscriber)
        {
            subscriber_list.Add(subscriber);
        }
        public void Unsubscribe(Subscriber subscriber)
        {
            subscriber_list.Remove(subscriber);
        }
    }
}
