using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class BestApproximationsbyQuadraticIntegers 
	{
		/// <summary>
		/// Title: Best Approximations by Quadratic Integers
		/// Description: 
		///		
		///		<p>Given a non-square integer $d$, any real $x$ can be approximated arbitrarily close by <b>quadratic integers</b> $a+b\sqrt{d}$, where $a,b$ are integers. For example, the following inequalities approximate $\pi$ with precision $10^{-13}$:<br>
		///		$$4375636191520\sqrt{2}-6188084046055 &lt; \pi &lt; 721133315582\sqrt{2}-1019836515172 $$<br> 
		///		We call $BQA_d(x,n)$ the quadratic integer closest to $x$ with the absolute values of $a,b$ not exceeding $n$.<br> We also define the integral part of a quadratic integer as $I_d(a+b\sqrt{d}) = a$.</p>
		///		
		///		<p>You are given that:</p>
		///		<ul><li>$BQA_2(\pi,10) = 6 - 2\sqrt{2}$</li>
		///		<li>$BQA_5(\pi,100)=26\sqrt{5}-55$</li>
		///		<li>$BQA_7(\pi,10^6)=560323 - 211781\sqrt{7}$</li>
		///		<li>$I_2(BQA_2(\pi,10^{13}))=-6188084046055$</li></ul>
		///		
		///		<p>Find the sum of $|I_d(BQA_d(\pi,10^{13}))|$ for all  non-square positive integers less than 100.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
