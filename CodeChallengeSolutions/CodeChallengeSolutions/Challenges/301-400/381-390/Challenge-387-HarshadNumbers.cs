using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class HarshadNumbers 
	{
		/// <summary>
		/// Title: HarshadNumbers
		/// Description: 
		///		
		///		<p>A <b>Harshad or Niven number</b> is a number that is divisible by the sum of its digits.
		///		<br>201 is a Harshad number because it is divisible by 3 (the sum of its digits.)
		///		<br>When we truncate the last digit from 201, we get 20, which is a Harshad number.
		///		<br>When we truncate the last digit from 20, we get 2, which is also a Harshad number.
		///		<br>Let's call a Harshad number that, while recursively truncating the last digit, always results in a Harshad number a <i>right truncatable Harshad number.</i></p>  
		///		
		///		<p>Also:
		///		<br>201/3=67 which is prime.
		///		<br>Let's call a Harshad number that, when divided by the sum of its digits, results in a prime a <i>strong Harshad number</i>.</p>
		///		
		///		<p>Now take the number 2011 which is prime.
		///		<br>When we truncate the last digit from it we get 201, a strong Harshad number that is also right truncatable.
		///		<br>Let's call such primes <i>strong, right truncatable Harshad primes</i>.</p>
		///		
		///		<p>You are given that the sum of the strong, right truncatable Harshad primes less than 10000 is 90619.</p>
		///		
		///		<p>Find the sum of the strong, right truncatable Harshad primes less than 10<sup>14</sup>.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
