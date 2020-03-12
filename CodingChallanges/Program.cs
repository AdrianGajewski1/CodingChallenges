using System;
using CodingChallenges.Tasks;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3 };

            var solution = Task001.Solution(array);

            Console.WriteLine(solution);
            Console.ReadLine();
        }
    }
}
