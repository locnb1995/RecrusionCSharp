using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCSharp
{
    class Permutation
    {
        private static List<int> result = new List<int> { };

        public static void init(List<int> input)
        {
            for (int i = 0; i <= input.Count; i++)
            {
                result.Add(0);
            }
            getPermutation(input , 1);
        }

        private static void getPermutation(List<int> input , int index)
        {
            for(int i = 0; i< input.Count; i++)
            { 
                if (checkExistInResult(input[i], index))
                {
                    continue;
                }
                result[index] = input[i];
                if(index == input.Count)
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
                    getPermutation(input, index + 1);
                }
            }
        }

        private static bool checkExistInResult(int value , int index)
        {
            for(int i = 1; i < index; i++)
            {
                if(result[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
