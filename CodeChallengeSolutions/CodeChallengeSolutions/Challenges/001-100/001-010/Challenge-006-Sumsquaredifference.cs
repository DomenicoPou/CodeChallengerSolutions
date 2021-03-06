using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
	public static class Sumsquaredifference 
	{
		/// <summary>
		/// Title: Sum square difference
		/// Description: 
		///		
		///		<p>The sum of the squares of the first ten natural numbers is,</p>
		///		$$1^2 + 2^2 + ... + 10^2 = 385$$
		///		<p>The square of the sum of the first ten natural numbers is,</p>
		///		$$(1 + 2 + ... + 10)^2 = 55^2 = 3025$$
		///		<p>Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is $3025 - 385 = 2640$.</p>
		///		<p>Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			List<int> numberList = GetNumbers(1, 20);
			int sumOfSquares = numberList.Aggregate((a, b) => a + (int)Math.Pow(b, 2));
			int squareOfSums = (int)Math.Pow(numberList.Sum(), 2);
			string difference = (squareOfSums - sumOfSquares).ToString();
			return difference;
		}

		/// <summary>
		/// Returns the list of number between min - max
		/// </summary>
		/// <param name="min">The minimum number within the list</param>
		/// <param name="max">The Maximum number within the list</param>
		/// <returns>The list of numbers between min - max</returns>
        private static List<int> GetNumbers(int min, int max)
        {
			// Simply create the numbers between the minimum and maximum given
			List<int> results = new List<int>();
			for (int index = min; index <= max; index++)
            {
				results.Add(index);
            }
			return results;
        }
    }
}
