using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> nums = new List<float>();

        float n = 0;

        do {
            Console.WriteLine("What number would you like to add to the list?");

            n = float.Parse(Console.ReadLine());
            nums.Add(n);
        } while (n != 0);

        nums.RemoveAt(nums.Count - 1);

        float total = 0;
        float maxNum = 0;

        for (int i = 0; i < nums.Count; i ++) {
            total += nums[i];

            if (maxNum < nums[i]) {
                maxNum = nums[i];
            }
        }

        float avg = total / nums.Count;

        Console.WriteLine($"The sum of the numbers is {total}");
        Console.WriteLine($"Their mean average is {avg}");
        Console.WriteLine($"The biggest number in the list is {maxNum}");

    }
}