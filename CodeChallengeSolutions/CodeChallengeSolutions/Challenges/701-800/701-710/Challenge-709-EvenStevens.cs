using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class EvenStevens 
	{
		/// <summary>
		/// Title: Even Stevens
		/// Description: 
		///		
		///		<p>Every day for the past $n$ days Even Stevens brings home his groceries in a plastic bag. He stores these plastic bags in a cupboard. He either puts the plastic bag into the cupboard with the rest, or else he takes an <b>even</b> number of the existing bags (which may either be empty or previously filled with other bags themselves) and places these into the current bag.</p>
		///		
		///		<p>After 4 days there are 5 possible packings and if the bags are numbered 1 (oldest), 2, 3, 4, they are:</p>
		///		<ul>
		///		<li>Four empty bags,</li>
		///		<li>1 and 2 inside 3, 4 empty,</li>
		///		<li>1 and 3 inside 4, 2 empty,</li>
		///		<li>1 and 2 inside 4, 3 empty,</li>
		///		<li>2 and 3 inside 4, 1 empty.</li>
		///		</ul>
		///		<p>Note that 1, 2, 3 inside 4 is invalid because every bag must contain an even number of bags.</p>
		///		
		///		<p>Define $f(n)$ to be the number of possible packings of $n$ bags. Hence $f(4)=5$. You are also given $f(8)=1\,385$.</p>
		///		
		///		<p>Find $f(24\,680)$ giving your answer modulo $1\,020\,202\,009$.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
