using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class InvestigatingUlamsequences 
	{
		/// <summary>
		/// Title: InvestigatingUlamsequences
		/// Description: 
		///		
		///		<p>For two positive integers a and b, the Ulam sequence U(a,b) is defined by U(a,b)<sub>1</sub> = a, U(a,b)<sub>2</sub> = b and for k &gt; 2,
		///		U(a,b)<sub>k</sub> is the smallest integer greater than U(a,b)<sub>(k-1)</sub> which can be written in exactly one way as the sum of two distinct previous members of U(a,b).</p>
		///		<p>For example, the sequence U(1,2) begins with<br>
		///		1, 2, 3 = 1 + 2, 4 = 1 + 3, 6 = 2 + 4, 8 = 2 + 6, 11 = 3 + 8;<br>
		///		5 does not belong to it because 5 = 1 + 4 = 2 + 3 has two representations as the sum of two previous members, likewise 7 = 1 + 6 = 3 + 4.</p>
		///		<p>Find <span style="font-size:larger;"><span style="font-size:larger;">∑</span></span> U(2,2<var>n</var>+1)<sub><var>k</var></sub> for 2 ≤ <var>n</var> ≤10, where <var>k</var> = 10<sup>11</sup>.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
