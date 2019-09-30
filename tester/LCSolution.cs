using System;

namespace solutions
{
    public interface ILCSolution<T1, T2>
    {
        T2 Solve(T1 input);
    }

    public interface ILCSolutionV2<T1, T2>
    {
        T2 Solve(T1 input);
        void SetVerbose(bool verbose);
        void DebugWriteLine(string msg);
    }

    public abstract class LCVerboseSolution<T1, T2> : ILCSolutionV2<T1, T2>
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

        public abstract T2 Solve(T1 input);
    }

    public abstract class LCPxxxSolution : LCVerboseSolution<string, string>
    {
        public abstract string LeetCodeFunctionName(string input);

        public override string Solve(string x)
        {
            return LeetCodeFunctionName(x);
        }
    }

    public class LCP8xxxSolution0 : LCPxxxSolution
    {
        public override string LeetCodeFunctionName(string input)
        {
            return "example";
        }
    }
}