using System;

namespace Design_Pattern
{
    internal class DisplayRealStrategy:IDisplayStrategy
    {
        public void Display()
        {
            Console.WriteLine("This is a real Duck!!");
        }
    }
}
