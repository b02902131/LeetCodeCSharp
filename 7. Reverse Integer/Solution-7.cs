using tester;

namespace solutions
{
    public abstract class LCP7Solution : ILCSolution<string, string>
    {
        public abstract int Reverse(int x);

        public string Solve(string x)
        {
            return Reverse(int.Parse(x)).ToString();
        }
    }

    public class LCP7Solution0 : LCP7Solution
    {
        public override int Reverse(int x)
        {
            return 0;
        }
    }
}