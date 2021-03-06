using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Largestprimefactor 
	{
		/// <summary>
		/// Title: Largest prime factor
		/// Description: 
		///		
		///		<p>The prime factors of 13195 are 5, 7, 13 and 29.</p>
		///		<p>What is the largest prime factor of the number 600851475143 ?</p>
		///
		/// Dom's Input: Prime factors are the sequence of prime numbers multiplied to get the number.
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			/**
			 * The method being used to obtain the largest prime factor is breaking down the
			 * number in question {finish elaboration}
			 * 
			 * Using the example above, the program will go through the following steps
			 *  1: finds the next divisable prime number (which is 5).
			 *  2: 13195 / 5 = 2639  (5 can no longer divide the set number).
			 *  3: Next divisable is 7.
			 *  4: 2639 / 7 = 377
			 *  5: Next divisable is 13.
			 *  6: 377 / 13 = 29
			 *  7: The next divisable is 29 which is equal to the set number.
			 *  8: Return 29.
			 *  
			 */

			// The number we are finding the largest prime factor
			long setNumber = 600851475143;
			
			// Set the prime number variable to the smallest known prime number : 2
			long primeNumber = 2;

			// While set number is not equal to the given prime number
			while (setNumber != primeNumber)
            {
				// If the setnumber is divisable by the current prime number
				if (setNumber % primeNumber == 0)
                {
					// Devide the number by the prime number
					setNumber = setNumber / primeNumber;
                } else
                {
					// The set number still needs to be divided to get the prime factor
					// However the set number is not currently divisable by the current prime number
					primeNumber = GetNextPrimeNumber(primeNumber);
                }
            }
			// We have found the largest prime factor
			return primeNumber.ToString();
		}

		/// <summary>
		/// Finds the next prime number from the given prime number
		/// </summary>
		/// <param name="current">The current prime number</param>
		/// <returns>The next prime number</returns>
        private static long GetNextPrimeNumber(long current)
        {
			// Get the next number after the current
			long iter = current + 1;
			
			// When approaching infinity. We can assume there are also infinity amount of prime numbers.
			while (true)
            {
				bool isPrime = true;
				for (int primeCheck = 2; primeCheck < iter; primeCheck++)
				{
					if (iter % primeCheck == 0)
					{
						isPrime = false;
						break;
					}
				}
				if (isPrime)
				{
					return iter;
				}
				iter++;
            }
        }
    }
}
