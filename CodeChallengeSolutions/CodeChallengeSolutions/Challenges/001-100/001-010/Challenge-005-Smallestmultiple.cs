using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
	public static class Smallestmultiple 
	{
		/// <summary>
		/// Title: Smallest multiple
		/// Description: 
		///		
		///		<p>2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.</p>
		///		<p>What is the smallest positive number that is <dfn title="divisible with no remainder">evenly divisible</dfn> by all of the numbers from 1 to 20?</p>
		///		
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			string smallestDivisable = GetSmallestDivisable(20);
			return smallestDivisable;
		}

		
		/// <summary>
		/// Gets the smallest divisable number from 1 - x
		/// This is the most efficient way, if we are introducing prime factors:
		/// {Explain why}
		/// </summary>
		/// <param name="maxNumber">The maximum within the 0 - x list</param>
		/// <returns>The smallest number that is divisable by every number between 1 - x</returns>
        private static string GetSmallestDivisable(int maxNumber)
        {
			// This object will contain all the minimum prime factors
			List<int> resultPrimeFactors = new List<int>();
			
			// Skipping 1 iterate through the 1 - x list
			for (int index = 2; index <= maxNumber; index++)
			{
				// Obtain the prime factors for the given number
				List<int> primeFactors = ObtainPrimeFactors(index);

				// Create a temporary copy of the result prime factors
				List<int> differences = new List<int>(resultPrimeFactors);

				// Make sure the combination of prime factors from the index number
				// Is located within the prime factor result list
				foreach (int primeFactor in primeFactors)
                {
					if (differences.Contains(primeFactor))
                    {
						differences.Remove(primeFactor);
                    } else
                    {
						resultPrimeFactors.Add(primeFactor);
                    }
                }
			}

			// Return the multiplied number of all the minimum prime factors
			return resultPrimeFactors.Aggregate((a, x) => a * x).ToString();
		}

		
		/// <summary>
		/// Obtain the prime factors of a given number
		/// </summary>
		/// <param name="currentNumber">The number in question</param>
		/// <returns>currentNumber's prime factors</returns>
        private static List<int> ObtainPrimeFactors(int currentNumber)
        {
			List<int> results = new List<int>();
			int currentPrime = 2;
			while (currentNumber != currentPrime)
            {
				if (currentNumber % currentPrime != 0)
                {
					currentPrime = GetNextPrime(currentPrime);
                } else
                {
					results.Add(currentPrime);
					currentNumber = currentNumber / currentPrime;
                }
			}
			results.Add(currentPrime);
			return results;
        }

		/// <summary>
		/// The 2nd iteration of how I get the next Prime number after a given number
		/// </summary>
		/// <param name="currentNumber">The current number in the sequence</param>
		/// <returns>The next prime number after the currentNumber</returns>
        private static int GetNextPrime(int currentNumber)
        {
			int iterator = currentNumber + 1;
			bool isPrime = false;
            while (!isPrime)
            {
				isPrime = true;
				for (int index = 2; index < iterator; index++)
                {
					if (iterator % index == 0)
                    {
						iterator++;
						isPrime = false;
						break;
                    }
                }
            }
			return iterator;
        }

		
		/// <summary>
		/// This is the 'Dumb' way of finding the smallest divisable number
		/// </summary>
		/// <param name="maxNumber">The limit within the 0 - x list</param>
		/// <returns>Returns the smallest divisable number from 0 - x</returns>
        private static string GetSmallestDivisableDumb(int maxNumber)
        {
			// Lets start at the max number
			int current = maxNumber;

			// While we havent found number in question.
			// We have to assume that a number exists in every posibility due to infinity
			while (true)
			{
				// Check if this number is divisable by all numbers between 1 - x
				bool isDivisableByAllNumbers = true;
				for (int index = 1; index <= maxNumber; index++)
                {
					if (current % index != 0)
                    {
						isDivisableByAllNumbers = false;
						break;
                    }
                }

				// If it is, return it. If not increment it
				if (isDivisableByAllNumbers)
				{
					return current.ToString();
				}
				current++;
            }
			return null;
        }
    }
}
