using System;

namespace tester
{
    public class LCTesterHelper
    {
        public static string ParseTestData<T>(T data)
        {
            if (typeof(T) == typeof(int[]))
            {
                return IntArray2String(data as int[]);
            }
            else if (typeof(T) == typeof(string))
            {
                return data as string;
            }
            else if (typeof(T) == typeof(double))
            {
                return String.Format("{0:F2}", data);
            }
            return typeof(T).ToString();
        }

        public static string IntArray2String(int[] data)
        {
            string s = "[";

            for (var i = 0; i < data.Length; i++)
            {
                int a = data[i];
                s += a.ToString();

                if (i != data.Length - 1)
                {
                    s += ", ";
                }
            }
            s += "]";
            return s;
        }
    }
}