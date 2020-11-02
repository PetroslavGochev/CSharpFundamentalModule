using System;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            while (nums.Length != 1)
            {
                int[] newArr = new int[nums.Length - 1];
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = nums[i] + nums[i + 1];
                }
                nums = newArr;
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
