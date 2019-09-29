using System;
using tester;

namespace solutions
{
    public abstract class LCP8Solution : LCVerboseSolution<string, int>
    {
        public abstract int MyAtoi(string str);

        public override int Solve(string x)
        {
            return MyAtoi(x);
        }
    }

    public class LCP8Solution0 : LCP8Solution
    {
        public bool isNumber(char c)
        {
            if (c.CompareTo('9') > 0 || c.CompareTo('0') < 0) { return false; }
            return true;
        }

        public int char2int(char c)
        {
            if (!isNumber(c)) { return -1; }
            return (int)c - (int)'0';
        }

        int INT_MAX = 2147483647;
        int INT_MIN = -2147483648;
        int[] maxAnsInt = new int[10] { 2, 1, 4, 7, 4, 8, 3, 6, 4, 7 };
        public override int MyAtoi(string str)
        {
            bool isNegative = false;

            string s = str;
            int a = 0;
            int startPos, endPos, ptr;

            // trim the str
            startPos = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                var c = s[i];

                if (c != ' ') { break; }

                startPos += 1;
            }

            s = s.Substring(startPos);

            if (s.Length == 0) { return 0; }

            ptr = 0;
            var sign = s[ptr];
            while (sign == '-' || sign == '+')
            {
                ptr += 1;

                if (ptr >= 2) { return 0; }

                if (sign == '-') { isNegative = !isNegative; }

                if (ptr >= s.Length) { break; }

                sign = s[ptr];
            }

            s = s.Substring(ptr);

            // trim the str with 0
            startPos = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                var c = s[i];

                if (c != '0') { break; }

                startPos += 1;
            }

            s = s.Substring(startPos);

            endPos = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];

                if (!isNumber(c))
                {
                    endPos = i;
                    break;
                }

                endPos += 1;
            }


            if (endPos == 0) { return 0; }

            s = s.Substring(0, endPos);


            if (s.Length == 0) { return 0; }

            if (s.Length > 10)
            {
                return isNegative ? INT_MIN : INT_MAX;
            }

            a += char2int(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                int b = char2int(s[i]);

                if (i == 9)
                {
                    if (a > INT_MAX / 10)
                    {
                        return isNegative ? INT_MIN : INT_MAX;
                    }
                    else if (a == INT_MAX / 10)
                    {
                        if (isNegative)
                        {
                            if (b >= maxAnsInt[9] + 1) { return INT_MIN; }
                        }
                        else
                        {
                            if (b >= maxAnsInt[9]) { return INT_MAX; }
                        }
                    }
                }

                a *= 10;
                a += b;
            }

            return isNegative ? -a : a;
        }
    }
}