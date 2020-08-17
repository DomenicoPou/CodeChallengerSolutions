using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class SextupletNorms 
	{
		/// <summary>
		/// Title: Sextuplet Norms
		/// Description: 
		///		
		///		<p>Let $f(n)$ be the number of $6$-tuples $(x_1,x_2,x_3,x_4,x_5,x_6)$ such that:</p>
		///		<ul>
		///		<li>All $x_i$ are integers with $0 \leq x_i &lt; n$</li>
		///		<li>$\gcd(x_1^2+x_2^2+x_3^2+x_4^2+x_5^2+x_6^2,\ n^2)=1$</li>
		///		</ul>
		///		
		///		<p>Let $\displaystyle G(n)=\displaystyle\sum_{k=1}^n \frac{f(k)}{k^2\varphi(k)}$<br>
		///		where $\varphi(n)$ is Euler's totient function.</p>
		///		
		///		<p>For example, $G(10)=3053$ and $G(10^5) \equiv 157612967 \pmod{1\,000\,000\,007}$.</p>
		///		
		///		<p>Find $G(10^{12})\bmod 1\,000\,000\,007$.</p>
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
