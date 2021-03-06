using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Digitalrootsumsoffactorisations 
	{
		/// <summary>
		/// Title: Digital root sums of factorisations
		/// Description: 
		///		
		///		<p>A composite number can be factored many different ways.  
		///		For instance, not including multiplication by one, 24 can be factored in 7 distinct ways:</p>
		///		<div class="margin_left">
		///		24 = 2x2x2x3<br>
		///		24 = 2x3x4<br>
		///		24 = 2x2x6<br>
		///		24 = 4x6<br>
		///		24 = 3x8<br>
		///		24 = 2x12<br>
		///		24 = 24
		///		</div>
		///		<p>Recall that the digital root of a number, in base 10, is found by adding together the digits of that number, 
		///		and repeating that process until a number is arrived at that is less than 10.  
		///		Thus the digital root of 467 is 8.</p>
		///		<p>We shall call a Digital Root Sum (DRS) the sum of the digital roots of the individual factors of our number.<br>
		///		 The chart below demonstrates all of the DRS values for 24.</p>
		///		<table align="center" border="1" cellpadding="2" cellspacing="0"><tr><th>Factorisation</th><th>Digital Root Sum</th></tr><tr><td><div class="margin_left">2x2x2x3</div></td>
		///		<td><div class="center">9</div></td></tr><tr><td><div class="margin_left">2x3x4</div></td>
		///		<td><div class="center">9</div></td></tr><tr><td><div class="margin_left">2x2x6</div></td>
		///		<td><div class="center">10</div></td></tr><tr><td><div class="margin_left">4x6</div></td>
		///		<td><div class="center">10</div></td></tr><tr><td><div class="margin_left">3x8</div></td>
		///		<td><div class="center">11</div></td></tr><tr><td><div class="margin_left">2x12</div></td>
		///		<td><div class="center">5</div></td></tr><tr><td><div class="margin_left">24</div></td>
		///		<td><div class="center">6</div></td></tr></table><p>The maximum Digital Root Sum  of 24 is 11.<br>
		///		The function mdrs(<var>n</var>) gives the maximum Digital Root Sum of <var>n</var>. So  mdrs(24)=11.<br>
		///		Find <span style="font-size:larger;"><span style="font-size:larger;">∑</span></span> mdrs(<var>n</var>) for 1 &lt; <var>n</var> &lt; 1,000,000.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
