using System;
using System.Linq;

namespace CodingChallenges.Tasks
{
    public class Task001
    {
        /*
         * Source: https://app.codility.com/programmers/challenges/
         * 
           This is a demo task.

            Write a function:

            class Solution { public int solution(int[] A); }
            
            that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
            
            For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
            
            Given A = [1, 2, 3], the function should return 4.
            
            Given A = [−1, −3], the function should return 1.
            
            Write an efficient algorithm for the following assumptions:
            
            N is an integer within the range [1..100,000];
            each element of array A is an integer within the range [−1,000,000..1,000,000].

        */

        public static int Solution(int[] array)
        {

            var sortedArray = array.OrderBy(x => x).ToArray();

            var largestNumber = sortedArray.Max();
            var smallestNumber = sortedArray.Min();
            int result = 1;
            bool found = false;


            if(largestNumber <= 0)
                return result = 1;

            for (int i = 1; i < largestNumber; i++)
            {
                if (!sortedArray.Contains(i))
                {
                    result = i;
                    found = true;
                    break;

                }
            }

            if (found == false)
            {
                result = largestNumber + 1;
            }

            return result;
        }
    }
}
