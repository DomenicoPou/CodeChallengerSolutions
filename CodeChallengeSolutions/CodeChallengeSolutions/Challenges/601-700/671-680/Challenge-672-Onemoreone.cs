using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Onemoreone 
	{
		/// <summary>
		/// Title: Onemoreone
		/// Description: 
		///		
		///		<p>Consider the following process that can be applied recursively to any positive integer $n$:</p>
		///		<ul>
		///		<li>if $n = 1$ do nothing and the process stops,</li>
		///		<li>if $n$ is divisible by 7 divide it by 7,</li>
		///		<li>otherwise add 1.</li>
		///		</ul>
		///		<p>Define $g(n)$ to be the number of 1's that must be added before the process ends. For example:</p>
		///		<center>$125\xrightarrow{\scriptsize{+1}} 126\xrightarrow{\scriptsize{\div 7}} 18\xrightarrow{\scriptsize{+1}} 19\xrightarrow{\scriptsize{+1}} 20\xrightarrow{\scriptsize{+1}} 21\xrightarrow{\scriptsize{\div 7}} 3\xrightarrow{\scriptsize{+1}} 4\xrightarrow{\scriptsize{+1}} 5\xrightarrow{\scriptsize{+1}} 6\xrightarrow{\scriptsize{+1}} 7\xrightarrow{\scriptsize{\div 7}} 1$.</center>
		///		<p>Eight 1's are added so $g(125) = 8$. Similarly $g(1000) = 9$ and $g(10000) = 21$.</p>
		///		<p>Define $S(N) = \sum_{n=1}^{N} g(n)$ and $H(K) = S\left(\frac{7^K-1}{11}\right)$. You are given $H(10) = 690409338$.</p>
		///		<p>Find $H(10^9)$ modulo $1\,117\,117\,717$.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
