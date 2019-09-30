using System;

namespace solutions
{
    public interface ILCVerboseSolutionTwoInput<T1, T2, T3>
    {
        T2 Solve(T1 input, T2 output2);
        void SetVerbose(bool verbose);
        void DebugWriteLine(string msg);
    }

    public abstract class LCVerboseSolutionTwoInput<T1, T2, T3> : ILCVerboseSolutionTwoInput<T1, T2, T3>
    {

        bool m_Verbose;

        public void SetVerbose(bool verbose)
        {
            m_Verbose = verbose;
        }

        public void DebugWriteLine(string msg)
        {
            if (!m_Verbose) { return; }

            Console.WriteLine(msg);
        }

        public abstract T2 Solve(T1 input, T2 output);
    }

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