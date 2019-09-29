namespace tester
{
    public interface ILCTester
    {
        void SetProblem();
        void SetSolution();
        void RunTest();
    }

    public class MyClass
    {
        public string ReturnMessage()
        {
            return "Happy coding!";
        }
    }
}