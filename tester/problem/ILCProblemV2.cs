namespace problems
{
    public interface ILCProblemV2 : ILCProblem
    {
        void PrepareTester();
        void AddTestCase();
        void RegisterSolutions();
        void SetSolution(int solutionIndex);
        void RunTest();
    }
}