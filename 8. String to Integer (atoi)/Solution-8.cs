using System;
using tester;

namespace solutions
{
    public abstract class LCP8Solution : ILCSolution<string, int>
    {
        public abstract int MyAtoi(string str);

        public int Solve(string x)
        {
            return MyAtoi(x);
        }
    }

    public class LCP8Solution0 : LCP8Solution
    {
        int[] maxAnsInt = new int[10] { 2, 1, 4, 7, 4, 8, 3, 6, 4, 7 };
        public override int MyAtoi(string str)
        {
            return 0;
        }
    }
}