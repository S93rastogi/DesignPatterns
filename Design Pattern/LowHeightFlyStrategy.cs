using System;

namespace Design_Pattern
{
    internal class LowHeightFlyStrategy : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("This duck flies at height below 50m");
        }
    }
}