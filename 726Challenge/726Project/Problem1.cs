using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _726Project
{
    public static class Problem1
    {
        public static void SumSubArray(List<int> arr, int val)
        {
            bool endFlag = false;
            for (int i = 0; i < arr.Count; i++)
            {
                if (endFlag) break;
                List<int> currentValues = new List<int>();
                int currentSum = arr[i];
                currentValues.Add(arr[i]);
                for (int j = (i+1); j < arr.Count; j++)
                {
                    if (endFlag) break;
                    currentSum += arr[j];
                    currentValues.Add(arr[j]);
                    if(currentSum == val)
                    {
                        List<string> strings = new List<string>();
                        foreach (int l in currentValues) strings.Add(l.ToString());
                        Console.WriteLine("Sum found between " + i.ToString() + " and " + j.ToString());
                        Console.WriteLine("Elements are " + string.Join(',', strings));
                        endFlag = true;
                    }
                }
            }
        }
    }
}
