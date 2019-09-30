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
}