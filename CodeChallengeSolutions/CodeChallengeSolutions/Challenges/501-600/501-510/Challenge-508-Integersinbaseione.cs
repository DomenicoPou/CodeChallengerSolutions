using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Integersinbaseione 
	{
		/// <summary>
		/// Title: Integersinbaseione
		/// Description: 
		///		
		///		<p>Consider the Gaussian integer i-1. A <b>base i-1 representation</b> of a Gaussian integer <var>a</var>+<var>b</var>i is a finite sequence of digits <var>d</var><sub><var>n</var>-1</sub><var>d</var><sub><var>n</var>-2</sub>...<var>d</var><sub>1</sub><var>d</var><sub>0</sub> such that:</p>
		///		
		///		<ul><li><var>a</var>+<var>b</var>i = <var>d</var><sub><var>n</var>-1</sub>(i-1)<sup><var>n</var>-1</sup> + <var>d</var><sub><var>n</var>-2</sub>(i-1)<sup><var>n</var>-2</sup> + ... + <var>d</var><sub>1</sub>(i-1) + <var>d</var><sub>0</sub></li>
		///		<li>Each <var>d</var><sub><var>k</var></sub> is in {0,1}</li>
		///		<li>There are no leading zeroes, i.e. <var>d</var><sub>n-1</sub> ≠ 0, unless <var>a</var>+<var>b</var>i is itself 0</li>
		///		</ul><p>Here are base i-1 representations of a few Gaussian integers:<br><br>
		///		11+24i → 111010110001101<br>
		///		24-11i → 110010110011<br>
		///		8+0i → 111000000<br>
		///		-5+0i → 11001101<br>
		///		0+0i → 0</p>
		///		
		///		Remarkably, every Gaussian integer has a unique base i-1 representation!<br><br>
		///		
		///		Define <var>f</var>(<var>a</var>+<var>b</var>i) as the number of 1s in the unique base i-1 representation of <var>a</var>+<var>b</var>i. For example, <var>f</var>(11+24i) = 9 and <var>f</var>(24-11i) = 7.<br><br>
		///		
		///		Define <var>B</var>(<var>L</var>) as the sum of <var>f</var>(<var>a</var>+<var>b</var>i) for all integers <var>a</var>, <var>b</var> such that |<var>a</var>| ≤ <var>L</var> and |<var>b</var>| ≤ <var>L</var>. For example, <var>B</var>(500) = 10795060.<br><br>
		///		
		///		Find <var>B</var>(10<sup>15</sup>) mod 1 000 000 007.
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
