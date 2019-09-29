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
}