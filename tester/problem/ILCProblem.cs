namespace problems
{
    public interface ILCProblem
    {
        void PrepareTester();
        void AddTestCase();
        void SetSolution(int solutionIndex);
        void RunTest();
    }
}