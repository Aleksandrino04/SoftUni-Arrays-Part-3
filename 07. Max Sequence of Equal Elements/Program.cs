using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            int bestNumber = numbers[0];
            int currentSequence = 1;
            int bestSequence = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNumber = numbers[i];
                int nextNumber = numbers[i+1];
                if (currentNumber == nextNumber)
                {

                    currentSequence++;
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        bestNumber = currentNumber;
                    }
                }
                else
                {
                    currentSequence = 1;
                }
            }
            for (int i = 0; i < bestSequence; i++)
            {
                Console.Write(bestNumber + " ");
            }



        }
    }
}
