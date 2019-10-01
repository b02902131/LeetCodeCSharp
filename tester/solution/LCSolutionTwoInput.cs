using System;

namespace solutions
{
    public abstract class LCProblemSolutionTwoInput : LCVerboseSolutionTwoInput<int, int, int>
    {
        public abstract int LeetCodeFunctionName(int input1, int input2);

        public override int Solve(int x, int y)
        {
            return LeetCodeFunctionName(x, y);
        }
    }

    public class LCProblemSolutionTwoInput0 : LCProblemSolutionTwoInput
    {
        public override int LeetCodeFunctionName(int input1, int input2)
        {
            return 0;
        }
    }
}