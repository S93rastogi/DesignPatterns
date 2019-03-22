using System;

namespace Design_Pattern
{
    internal class HighHeightFlyStrategy : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("This is the bird that flies above 50m ");
        }
    }
}