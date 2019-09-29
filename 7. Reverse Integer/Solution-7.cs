using System;
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
        int[] maxAnsInt = new int[10] { 2, 1, 4, 7, 4, 8, 3, 6, 4, 7 };
        public override int Reverse(int x)
        {
            bool isNegative = false;

            string s = x.ToString();
            string r = "";

            if (s[0] == '-')
            {
                isNegative = true;
                s = s.Substring(1);
            }

            for (int i = 0; i < s.Length; i++)
            {
                r = r.Insert(r.Length, s.Substring(s.Length - 1 - i, 1));
            }

            if (s.Length >= 10)
            {
                for (int i = 0; i < r.Length; i++)
                {
                    int t = maxAnsInt[i];
                    int a = int.Parse(r.Substring(i, 1));

                    if (a > t) { return 0; }
                    if (a < t) { break; }
                }
            }

            var n = int.Parse(r);

            return isNegative ? -n : n;
        }
    }
}