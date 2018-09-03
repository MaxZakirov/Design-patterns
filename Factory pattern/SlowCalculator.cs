using System;
using Shared.Loaders;

namespace Factory_pattern
{
    public abstract class SlowCalculator
    {
        private ILoader loader;

        public SlowCalculator()
        {
            loader = CreateLoader();
        }

        public int Sum(int a, int b)
        {
            int res = a + b;
            using (loader)
            {
                loader.Load(0);
            }
            Console.WriteLine(res);
            return res;
        }

        protected abstract ILoader CreateLoader();
    }
}
