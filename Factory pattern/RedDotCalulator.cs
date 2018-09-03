using Shared.Loaders;

namespace Factory_pattern
{
    public class RedDotCalulator : SlowCalculator
    {
        protected override ILoader CreateLoader()
        {
            return new RedDotLoader(100);
        }
    }
}
