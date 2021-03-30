using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subscriber Leo = new Subscriber("Leo");
            Creator Big_Hot_Men = new Creator();
            Big_Hot_Men.Subscribe(Leo);
        }
    }
}
