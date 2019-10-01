using System;

namespace solutions
{
    public abstract class LCProblem6Solution : LCVerboseSolutionTwoInput<string, int, string>
    {
        public abstract string Convert(string s, int numRows);

        public override string Solve(string s, int numRows)
        {
            return Convert(s, numRows);
        }
    }

    public class LCProblem6Solution0 : LCProblem6Solution
    {
        public override string Convert(string s, int numRows)
        {
            return "example";
        }
    }
}