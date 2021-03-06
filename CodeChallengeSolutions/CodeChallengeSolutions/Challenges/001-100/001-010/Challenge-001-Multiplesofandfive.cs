using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Multiplesofandfive 
	{
		/// <summary>
		/// Title: Multiples of 3 and 5
		/// Description: 
		///		
		///		<p>If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.</p>
		///		<p>Find the sum of all the multiples of 3 or 5 below 1000.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			// Initialize the solution number
			int solution = 0;

			// Loop through the number from 1 to 999
			for (int num = 1; num < 1000; num++)
            {
				// If the number in question is a multiple of 3 or 5
				if (num % 3 == 0 || num % 5 == 0)
                {
					// Add it to the solution number
					solution += num;
                }
            }
			// Return the solution number as a string
			return solution.ToString();
		}
	}
}
