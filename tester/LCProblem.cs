using System.Collections.Generic;

namespace tester
{
    public interface ILCProblem
    {
        List<ILCTestCase> TestCases { get; }
    }
}