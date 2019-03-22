namespace Design_Pattern
{
    internal static class DuckClient
    {
       public static void Main()
        {
            var flyStrategy = new HighHeightFlyStrategy();
            var displayStrategy = new DisplayRealStrategy();
            var duck = new Duck(flyStrategy:flyStrategy,displayStrategy:displayStrategy);
            duck.Fly();
            duck.Display();
        }
    }
}
