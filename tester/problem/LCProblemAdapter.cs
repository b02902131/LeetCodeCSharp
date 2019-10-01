namespace problems
{
    public class LCProblemV1V2Adapter : ILCProblemV2
    {
        ILCProblem m_Problem;
        public LCProblemV1V2Adapter(ILCProblem problem)
        {
            m_Problem = problem;
        }

        public void PrepareTester()
        {
            m_Problem.PrepareTester();
        }
        public void AddTestCase()
        {
            m_Problem.AddTestCase();
        }
        public virtual void RegisterSolutions()
        {

        }
        public void SetSolution(int solutionIndex)
        {
            m_Problem.SetSolution(solutionIndex);
        }
        public void RunTest()
        {
            m_Problem.RunTest();
        }
    }
}