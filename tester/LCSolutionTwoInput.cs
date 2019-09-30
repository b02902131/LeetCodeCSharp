using System;

namespace solutions
{
    public abstract class LCPxxxSolutionTwoInput : LCVerboseSolutionTwoInput<string, string, string>
    {
        public abstract string LeetCodeFunctionName(string input1, string input2);

        public override string Solve(string x, string y)
        {
            return LeetCodeFunctionName(x, y);
        }
    }

    public class LCP8xxxTwoInputSolution0 : LCPxxxSolutionTwoInput
    {
        public override string LeetCodeFunctionName(string input1, string input2)
        {
            return "example";
        }
    }
}