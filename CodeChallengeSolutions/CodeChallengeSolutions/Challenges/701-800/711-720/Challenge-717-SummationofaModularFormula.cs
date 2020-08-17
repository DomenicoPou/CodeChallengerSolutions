using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class SummationofaModularFormula 
	{
		/// <summary>
		/// Title: SummationofaModularFormula
		/// Description: 
		///		
		///		<p>For an odd prime $p$, define $f(p) = \left\lfloor\frac{2^{(2^p)}}{p}\right\rfloor\bmod{2^p}$<br>
		///		For example, when $p=3$, $\lfloor 2^8/3\rfloor = 85 \equiv 5 \pmod 8$ and so $f(3) = 5$.</p> 
		///		
		///		<p>Further define $g(p) = f(p)\bmod p$. You are given $g(31) = 17$.</p>
		///		
		///		<p>Now define $G(N)$ to be the summation of $g(p)$ for all odd primes less than $N$.<br>
		///		You are given $G(100) = 474$ and $G(10^4) = 2819236$.</p>
		///		
		///		<p>Find $G(10^7)$</p>
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
