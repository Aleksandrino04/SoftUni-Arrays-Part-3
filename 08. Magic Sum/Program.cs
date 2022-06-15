using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == magicNumber)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                    }
                }
            }
        }
    }
}
