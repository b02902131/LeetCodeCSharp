using System;

namespace solutions
{
    public abstract class LCProblem4Solution : LCVerboseSolutionTwoInput<int[], int[], double>
    {
        public abstract double FindMedianSortedArrays(int[] nums1, int[] nums2);

        public override double Solve(int[] nums1, int[] nums2)
        {
            return FindMedianSortedArrays(nums1, nums2);
        }
    }

    public class LCProblem4Solution0 : LCProblem4Solution
    {
        public override double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;

            int ptr1 = 0;
            int ptr2 = 0;
            int count = 0;

            int midPos = (n + m) / 2;

            int a, b, v1 = 0, v2 = 0;
            while (count <= midPos)
            {
                count++;
                v1 = v2;

                if (ptr1 >= m)
                {
                    v2 = nums2[ptr2];
                    ptr2++;
                    continue;
                }
                else if (ptr2 >= n)
                {
                    v2 = nums1[ptr1];
                    ptr1++;
                    continue;
                }

                a = nums1[ptr1];
                b = nums2[ptr2];

                if (a < b)
                {
                    v2 = a;
                    ptr1++;
                }
                else
                {
                    v2 = b;
                    ptr2++;
                }
            }

            // DebugWriteLine($"v = {v2}");
            // DebugWriteLine($"w = {v1}");

            if ((n + m) % 2 == 0)
            {
                // total length is even
                return ((double)(v2 + v1) / 2);
            }
            else
            {
                // total length is odd
                return (double)v2;
            }
        }
    }
}