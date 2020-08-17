using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class DivisibilityMultipliers 
	{
		/// <summary>
		/// Title: DivisibilityMultipliers
		/// Description: 
		///		
		///		<p>For each integer <var>p</var> &gt; 1 coprime to 10 there is a positive <em>divisibility multiplier</em> <var>m</var> &lt; <var>p</var> which preserves divisibility by <var>p</var> for the following function on any positive integer, <var>n</var>:</p>
		///		
		///		<p><var>f</var>(<var>n</var>) = (all but the last digit of <var>n</var>) + (the last digit of <var>n</var>) * <var>m</var></p>
		///		
		///		<p>That is, if <var>m</var> is the divisibility multiplier for <var>p</var>, then <var>f</var>(<var>n</var>) is divisible by <var>p</var> if and only if <var>n</var> is divisible by <var>p</var>.</p>
		///		
		///		<p>(When <var>n</var> is much larger than <var>p</var>, <var>f</var>(<var>n</var>) will be less than <var>n</var> and repeated application of <var>f</var> provides a multiplicative divisibility test for <var>p</var>.)</p>
		///		
		///		<p>For example, the divisibility multiplier for 113 is 34.</p>
		///		
		///		<p><var>f</var>(76275) = 7627 + 5 * 34 = 7797 : 76275 and 7797 are both divisible by 113<br><var>f</var>(12345) = 1234 + 5 * 34 = 1404 : 12345 and 1404 are both not divisible by 113</p>
		///		
		///		<p>The sum of the divisibility multipliers for the primes that are coprime to 10 and less than 1000 is 39517. What is the sum of the divisibility multipliers for the primes that are coprime to 10 and less than 10<sup>7</sup>?</p>
		///		
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
