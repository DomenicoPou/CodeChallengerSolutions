using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Twoheadsarebetterthanone 
	{
		/// <summary>
		/// Title: Two heads are better than one
		/// Description: 
		///		
		///		<p>
		///		An unbiased coin is tossed repeatedly until two consecutive heads are obtained. Suppose these occur on the $(M-1)$th and $M$th toss.<br>
		///		Let $P(n)$ be the probability that $M$ is divisible by $n$. For example, the outcomes HH, HTHH, and THTTHH all count towards $P(2)$, but THH and HTTHH do not.</p>
		///		<p>
		///		You are given that $P(2) =\frac 3 5$ and $P(3)=\frac 9  {31}$. Indeed, it can be shown that $P(n)$ is always a rational number.</p>
		///		<p>
		///		For a prime $p$ and a fully reduced fraction $\frac a b$, define $Q(\frac a b,p)$ to be the smallest positive $q$ for which $a \equiv b q \pmod{p}$.<br>
		///		For example $Q(P(2), 109) = Q(\frac 3 5, 109) = 66$, because $5 \cdot 66 = 330 \equiv 3 \pmod{109}$ and 66 is the smallest positive such number.<br>
		///		Similarly $Q(P(3),109) = 46$.</p>
		///		<p>
		///		Find $Q(P(10^{18}),1\,000\,000\,009)$.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
