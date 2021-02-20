using System;
using System.Collections.Generic;

namespace TrainingCSharp
{
    class SubArray
    {
        private static List<int> result = new List<int> { };

        public static void init(List<int> parentArray , int subSize)
        {
            for (int i = 0; i <= subSize; i++)
            {
                result.Add(0);
            }
            getListSubArray(parentArray, subSize, -1, 1);
        }
        private static void getListSubArray(List<int> parentArray, int subSize , int preIndex , int index)
        {
            for(int i = index - 1; i < parentArray.Count - subSize + index; i++)
            {
                if(preIndex >= i)
                {
                    continue;
                }
                result[index] = parentArray[i];
                if (index == subSize)
                {
                    string output = "";
                    for (int j = 1; j < result.Count; j++)
                    { 
                        output += result[j];
                    }
                    Console.WriteLine(output);
                }
                else
                {
                    getListSubArray(parentArray, subSize, i, index + 1);
                }
            }
        }
    }
}
