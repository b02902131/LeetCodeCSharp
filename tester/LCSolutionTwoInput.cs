using System;

namespace solutions
{
    public abstract class LCProblem_Solution : LCVerboseSolutionTwoInput<string, string, string>
    {
        public abstract string LeetCodeFunctionName(string input1, string input2);

        public override string Solve(string x, string y)
        {
            return LeetCodeFunctionName(x, y);
        }
    }

    public class LCProblem_SolutionXXX : LCProblem_Solution
    {
        public override string LeetCodeFunctionName(string input1, string input2)
        {
            return "example";
        }
    }
}