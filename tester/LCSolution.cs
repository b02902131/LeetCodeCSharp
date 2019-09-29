namespace solutions
{
    public interface ILCSolution<T1, T2>
    {
        T2 Solve(T1 input);
    }
}