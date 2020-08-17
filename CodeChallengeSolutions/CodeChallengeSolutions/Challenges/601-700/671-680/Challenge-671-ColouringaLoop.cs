using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class ColouringaLoop 
	{
		/// <summary>
		/// Title: Colouring a Loop
		/// Description: 
		///		
		///		<p>A certain type of flexible tile comes in three different sizes - 1×1, 1×2, and 1×3 - and in $k$ different colours. There is an unlimited number of tiles available in each combination of size and colour.</p>
		///		
		///		<p>These are used to tile a closed loop of width $2$ and length (circumference) $n$, where $n$ is a positive integer, subject to the following conditions:</p>
		///		<ul>
		///		<li>The loop must be fully covered by non-overlapping tiles.</li>
		///		<li>It is <i>not</i> permitted for four tiles to have their corners meeting at a single point.</li>
		///		<li>Adjacent tiles must be of different colours.</li>
		///		</ul>
		///		
		///		<p>For example, the following is an acceptable tiling of a $2\times 23$ loop with $k=4$ (blue, green, red and yellow):</p>
		///		
		///		<div class="center">
		///		<img src="project/images/p671_loop_acceptable.png" alt="Acceptable colouring">
		///		</div>
		///		
		///		<p>but the following is not an acceptable tiling, because it violates the "no four corners meeting at a point" rule:</p>
		///		
		///		<div class="center">
		///		<img src="project/images/p671_loop_unacceptable.png" alt="Unacceptable colouring">
		///		</div>
		///		
		///		<p>Let $F_k(n)$ be the number of ways the $2\times n$ loop can be tiled subject to these rules when $k$ colours are available. (Not all $k$ colours have to be used.) Where reflecting horizontally or vertically would give a different tiling, these tilings are to be counted separately.</p>
		///		
		///		<p>For example, $F_4(3) = 104$, $F_5(7) = 3327300$, and $F_6(101)\equiv 75309980 \pmod{1\,000\,004\,321}$.</p>
		///		<p>Find $F_{10}(10\,004\,003\,002\,001) \bmod 1\,000\,004\,321$.</p>
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
