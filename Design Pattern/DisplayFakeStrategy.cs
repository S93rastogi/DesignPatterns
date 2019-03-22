using System;

namespace Design_Pattern
{
    internal class DisplayFakeStrategy:IDisplayStrategy
    {
        public void Display()
        {
            Console.WriteLine("This is fake Toy Duck !!");
        }
    }
}
