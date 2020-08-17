using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Spillingthebeans 
	{
		/// <summary>
		/// Title: Spillingthebeans
		/// Description: 
		///		
		///		<p>In Plato's heaven, there exist an infinite number of bowls in a straight line.<br>
		///		Each bowl either contains some or none of a finite number of beans.<br>
		///		A child plays a game, which allows only one kind of move: removing two beans from any bowl, and putting one in each of the two adjacent bowls.<br> The game ends when each bowl contains either one or no beans.</p>
		///		
		///		<p>For example, consider two adjacent bowls containing 2 and 3 beans respectively, all other bowls being empty. The following eight moves will finish the game:</p>
		///		
		///		<div align="center"><img src="project/images/p334_beans.gif" class="dark_img" alt="p334_beans.gif"></div>
		///		
		///		<p>You are given the following sequences:<br></p>
		///		
		///		<p>
		///		$\def\htmltext#1{\style{font-family:inherit;}{\text{#1}}}$
		///		$
		///		\begin{align}
		///		\qquad t_0 &amp;= 123456,\cr
		///		\qquad t_i &amp;= \cases{
		///		\;\;\frac{t_{i-1}}{2},&amp;$\htmltext{if }t_{i-1}\htmltext{ is even}$\cr
		///		\left\lfloor\frac{t_{i-1}}{2}\right\rfloor\oplus 926252,&amp;$\htmltext{if }t_{i-1}\htmltext{ is odd}$\cr}\cr
		///		&amp;\qquad\htmltext{where }\lfloor x\rfloor\htmltext{ is the floor function }\cr
		///		&amp;\qquad\!\htmltext{and }\oplus\htmltext{is the bitwise XOR operator.}\cr
		///		\qquad b_i &amp;= (t_i\bmod2^{11}) + 1.\cr
		///		\end{align}
		///		$
		///		</p>
		///		
		///		<p>The first two terms of the last sequence are $b_1 = 289$ and $b_2 = 145$.<br>
		///		If we start with $b_1$ and $b_2$ beans in two adjacent bowls, $3419100$ moves would be required to finish the game.</p>
		///		
		///		<p>Consider now $1500$ adjacent bowls containing $b_1, b_2, \ldots, b_{1500}$ beans respectively, all other bowls being empty. Find how many moves it takes before the game ends.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
