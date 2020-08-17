using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Weightedlatticepaths 
	{
		/// <summary>
		/// Title: Weightedlatticepaths
		/// Description: 
		///		
		///		Let $P_{a,b}$ denote a path in a $a\times b$ lattice grid with following properties:
		///		<ul>
		///		<li>The path begins at $(0,0)$ and ends at $(a,b)$.</li>
		///		<li>The path consists only of unit moves upwards or to the right; that is the coordinates are increasing with every move.</li>
		///		</ul>
		///		
		///		Denote $A(P_{a,b})$ to be the area under the path. For the example of a $P_{4,3}$ path given below, the area equals 6.
		///		
		///		<div class="center">
		///		<img src="project/images/p638_lattice_area.png" alt="crossed lines">
		///		</div>
		///		<p>
		///		Define $G(P_{a,b},k)=k^{A(P_{a,b})}$. Let $C(a,b,k)$ equal the sum of $G(P_{a,b},k)$ over all valid paths in a $a\times b$ lattice grid. 
		///		</p>
		///		<p>
		///		You are given that
		///		</p>
		///		<ul>
		///		<li>$C(2,2,1)=6$</li>
		///		<li>$C(2,2,2)=35$</li>
		///		<li>$C(10,10,1)=184\,756$</li>
		///		<li>$C(15,10,3) \equiv 880\,419\,838 \mod 1\,000\,000\,007$</li>
		///		<li>$C(10\,000,10\,000,4) \equiv 395\,913\,804 \mod 1\,000\,000\,007$</li>
		///		</ul>
		///		
		///		Calculate $\displaystyle\sum_{k=1}^7 C(10^k+k, 10^k+k,k)$ . Give your answer modulo $1\,000\,000\,007$
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
