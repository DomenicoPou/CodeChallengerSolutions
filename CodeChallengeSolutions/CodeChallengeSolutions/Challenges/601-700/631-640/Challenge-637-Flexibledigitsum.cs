using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Flexibledigitsum 
	{
		/// <summary>
		/// Title: Flexible digit sum
		/// Description: 
		///		
		///		<p>
		///		Given any positive integer $n$, we can construct a new integer by inserting plus signs between some of the digits of the base $B$ representation of $n$, and then carrying out the additions.
		///		</p>
		///		<p>
		///		For example, from $n=123_{10}$  ($n$ in base 10) we can construct the four base 10 integers $123_{10}$,  $1+23=24_{10}$, $12+3=15_{10}$ and $1+2+3=6_{10}$
		///		</p>
		///		<p>
		///		Let $f(n,B)$  be the smallest number of steps needed to arrive at a single-digit number in base $B$. For example, $f(7,10)=0$ and $f(123,10)=1$.
		///		</p>
		///		<p>
		///		Let $g(n,B_1,B_2)$ be the sum of the positive integers $i$ not exceeding $n$ such that $f(i,B_1)=f(i,B_2)$.
		///		</p>
		///		<p>
		///		You are given $g(100,10,3)=3302$. 
		///		</p>
		///		<p>
		///		Find $g(10^7,10,3)$
		///		</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
