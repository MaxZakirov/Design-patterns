using Shared.Loaders;

namespace Factory_pattern
{
    public class GreenStarCalculator : SlowCalculator
    {
        protected override ILoader CreateLoader()
        {
            return new GreenStarLoader(500);
        }
    }
}
