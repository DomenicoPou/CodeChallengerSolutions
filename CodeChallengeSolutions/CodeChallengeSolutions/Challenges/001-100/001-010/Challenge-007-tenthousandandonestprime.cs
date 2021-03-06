using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class tenthousandandonestprime 
	{
		/// <summary>
		/// Title: 10001st prime
		/// Description: 
		///		
		///		<p>By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.</p>
		///		<p>What is the 10 001st prime number?</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			int currentPrime = 2;
			int primeSequenceNumber = 10001;

			for (int index = 1; index < primeSequenceNumber; index++)
            {
				currentPrime = GetNextPrime(currentPrime);
            }

			string result = currentPrime.ToString();
			return result;
		}

		private static int GetNextPrime(int currentNumber)
		{
			if (currentNumber < 0) throw new Exception("Please enter in a positive integer");
			if (currentNumber == 0) return 1;

			int iterator = currentNumber + 1;
			bool isPrime = false;
			while (!isPrime)
			{
				isPrime = true;
				for (int index = 2; index < iterator; index++)
				{
					if (iterator % index == 0)
					{
						if (iterator % 2 == 0)
						{
							iterator++;
						} else
                        {
							iterator += 2;
                        }
						isPrime = false;
						break;
					}
				}
			}
			return iterator;
		}
	}
}
