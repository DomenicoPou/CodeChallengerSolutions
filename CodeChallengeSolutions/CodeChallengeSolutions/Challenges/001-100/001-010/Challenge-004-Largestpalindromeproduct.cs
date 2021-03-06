using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Largestpalindromeproduct 
	{
		/// <summary>
		/// Title: Largest palindrome product
		/// Description: 
		///		
		///		
		///		<p>A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.</p>
		///		<p>Find the largest palindrome made from the product of two 3-digit numbers.</p>
		///		
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			// Applying functions due to how the questions is asked. Allow the digits to be configurable.
			string obtainPalindrome = GetPalindrome(3);
			return obtainPalindrome;
		}

        private static string GetPalindrome(int digit)
        {
			int maxNumber = (int)(Math.Pow(10, digit) - 1);
			List<int> previousIntegers = new List<int>() { maxNumber };
			for (int currentNumber = maxNumber; currentNumber >= 1; currentNumber--)
            {
				for (int index = 0; index < previousIntegers.Count; index++)
                {
					int value = currentNumber * previousIntegers[index];
					if (IsPalindrome(value.ToString()))
                    {
						return value.ToString();
                    }
				}
				if (!previousIntegers.Contains(currentNumber))
                {
					previousIntegers.Add(currentNumber);
                }
            }
			return null;
        }

        private static bool IsPalindrome(string originalString)
        {
			char[] charArray = originalString.ToCharArray();
			Array.Reverse(charArray);
			string reversedString = new string (charArray);
			return originalString == reversedString;
        }
    }
}
