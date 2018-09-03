namespace Factory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SlowCalculator calc1 = new GreenStarCalculator();
            calc1.Sum(2,5);
            SlowCalculator calc2 = new RedDotCalulator();
            calc2.Sum(3, 7);
        }
    }
}
