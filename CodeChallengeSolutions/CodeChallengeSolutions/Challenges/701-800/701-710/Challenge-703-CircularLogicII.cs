using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class CircularLogicII 
	{
		/// <summary>
		/// Title: Circular Logic II
		/// Description: 
		///		
		///		<p>Given an integer $n$, $n \geq 3$, let $B=\{\mathrm{false},\mathrm{true}\}$ and let $B^n$ be the set of sequences of $n$ values from $B$. The function $f$ from $B^n$ to $B^n$ is defined by $f(b_1 \dots b_n) = c_1 \dots c_n$ where:</p>
		///		<ul>
		///		<li>$c_i = b_{i+1}$ for $1 \leq i &lt; n$.</li>
		///		<li>$c_n = b_1 \;\mathrm{AND}\; (b_2 \;\mathrm{XOR}\; b_3)$, where $\mathrm{AND}$ and $\mathrm{XOR}$ are the logical $\mathrm{AND}$ and exclusive $\mathrm{OR}$ operations.</li>
		///		</ul>
		///		
		///		<p>Let $S(n)$ be the number of functions $T$ from $B^n$ to $B$ such that for all $x$ in $B^n$, $T(x) ~\mathrm{AND}~ T(f(x)) = \mathrm{false}$.
		///		You are given that $S(3) = 35$ and $S(4) = 2118$.</p>
		///		
		///		<p>Find $S(20)$. Give your answer modulo $1\,001\,001\,011$.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
