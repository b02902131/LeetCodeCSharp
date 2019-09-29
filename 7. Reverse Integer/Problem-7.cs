using tester;

namespace problems
{
    public class LCProblem7 : ILCProblem
    {
        List<ILCTestCase> m_TestCases = new List<ILCTestCase>
        {
            new LCTestCase("123", "321"),
            new LCTestCase("-123", "-321"),
            new LCTestCase("120", "21"),
        };

        public LCProblem7() { }
    }
}