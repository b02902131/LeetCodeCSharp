namespace problems
{
    public interface ILCProblemV2
    {
        void PrepareTester();
        void AddTestCase();
        void RegisterSolutions();
        void SetSolution(int solutionIndex);
        void RunTest();
    }
}