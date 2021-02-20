using System;
using System.Collections.Generic;

namespace TrainingCSharp
{
    class BinaryNumber
    {
        private static List<int> result = new List<int> { };

        public static void init(int size)
        {
            for(int i = 0; i <= size; i++)
            {
                result.Add(0);
            }
            getBinaryNumber(size, 1);
        }

        private static void getBinaryNumber(int size, int index)
        {
            for (int i = 0; i <= 1; i++)
            {
                result[index] = i;
                if (index == size)
                {
                    string output = "";
                    for (int j = 1 ; j < result.Count; j++)
                    {
                        output += result[j];
                    }
                    Console.WriteLine(output);
                }
                else
                {
                    getBinaryNumber(size, index + 1);
                }
            }
        }
    }
}
