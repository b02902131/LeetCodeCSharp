using System.Collections.Generic;

namespace tester
{
    public interface ILCProblem
    {
        void PrepareTester();
        void AddTestCase();
        void SetSolution(int solutionIndex);
        void RunTest();
    }

    public class TestProblem : ILCProblem
    {
        public void PrepareTester() { }
        public void AddTestCase() { }
        public void SetSolution(int solutionIndex) { }
        public void RunTest() { }
    }
}