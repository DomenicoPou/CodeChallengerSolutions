using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class ColouringaStrip 
	{
		/// <summary>
		/// Title: ColouringaStrip
		/// Description: 
		///		
		///		<p>A certain type of tile comes in three different sizes - 1×1, 1×2, and 1×3 - and in four different colours: blue, green, red and yellow. There is an unlimited number of tiles available in each combination of size and colour.</p>
		///		
		///		<p>These are used to tile a $2\times n$ rectangle, where $n$ is a positive integer, subject to the following conditions:</p>
		///		<ul>
		///		<li>The rectangle must be fully covered by non-overlapping tiles.</li>
		///		<li>It is <i>not</i> permitted for four tiles to have their corners meeting at a single point.</li>
		///		<li>Adjacent tiles must be of different colours.</li>
		///		</ul>
		///		
		///		<p>For example, the following is an acceptable tiling of a $2\times 12$ rectangle:</p>
		///		
		///		<div class="center">
		///		<img src="project/images/p670_strip_acceptable.png" alt="Acceptable colouring">
		///		</div>
		///		
		///		<p>but the following is not an acceptable tiling, because it violates the "no four corners meeting at a point" rule:</p>
		///		
		///		<div class="center">
		///		<img src="project/images/p670_strip_unacceptable.png" alt="Unacceptable colouring">
		///		</div>
		///		
		///		<p>Let $F(n)$ be the number of ways the $2\times n$ rectangle can be tiled subject to these rules. Where reflecting horizontally or vertically would give a different tiling, these tilings are to be counted separately.</p>
		///		
		///		<p>For example, $F(2) = 120$, $F(5) = 45876$, and $F(100)\equiv 53275818 \pmod{1\,000\,004\,321}$.</p>
		///		<p>Find $F(10^{16}) \bmod 1\,000\,004\,321$.</p>
		///		
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
