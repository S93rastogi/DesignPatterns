namespace Design_Pattern
{
    public class Duck
    {
        private IDisplayStrategy DisplayStrategy { get; set; }
        private IFlyStrategy FlyStrategy { get; set; }

        public Duck(IDisplayStrategy displayStrategy,IFlyStrategy flyStrategy)
        {
            DisplayStrategy = displayStrategy;
            FlyStrategy = flyStrategy;
        }

        public void Display()
        {
            DisplayStrategy.Display();
        }

        public void Fly()
        {
            FlyStrategy.Fly();
        }
    }
}
