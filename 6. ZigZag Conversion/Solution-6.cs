using System;

namespace solutions
{
    public abstract class LCProblem6Solution : LCVerboseSolutionTwoInput<string, int, string>
    {
        public abstract string Convert(string s, int numRows);

        public override string Solve(string s, int numRows)
        {
            return Convert(s, numRows);
        }
    }

    public class LCProblem6Solution0 : LCProblem6Solution
    {
        public override string Convert(string s, int numRows)
        {
            if (numRows == 1) { return s; }
            if (numRows > s.Length) { return s; }

            /* 1. get columns num       */
            int numCols = CalculateColumns(s, numRows);
            if (numCols == 0) { return ""; }

            /* 2. get a matrix with 0s  */
            char[,] matrix = new char[numRows, numCols];
            bool[,] flag = new bool[numRows, numCols];
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    flag[i, j] = false;
                }
            }

            /* 3. fill the numbers      */
            int x = 0, y = 0;
            bool isDown = true;
            for (int i = 0; i < s.Length; i++)
            {
                matrix[x, y] = s[i];
                flag[x, y] = true;

                if (isDown && x == numRows - 1)
                {
                    isDown = false;
                }
                else if (!isDown && x == 0)
                {
                    isDown = true;
                }

                if (isDown)
                {
                    x++;
                }
                else
                {
                    x--;
                    y++;
                }
            }
            /* 4. collect the numbers   */
            char[] charArray = new char[s.Length];
            int ptr = 0;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (flag[i, j])
                    {
                        charArray[ptr++] = matrix[i, j];
                    }
                }
            }
            return new String(charArray);
        }

        int CalculateColumns(string s, int numRows)
        {
            int strLen = s.Length;
            if (strLen == 0) { return 0; }

            int patternNum = numRows * 2 - 2;
            int colPerPattern = numRows - 1;
            return ((strLen - 1) / patternNum + 1) * colPerPattern;
        }
    }
}