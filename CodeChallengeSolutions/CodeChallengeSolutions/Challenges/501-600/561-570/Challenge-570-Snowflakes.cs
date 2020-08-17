using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Snowflakes 
	{
		/// <summary>
		/// Title: Snowflakes
		/// Description: 
		///		
		///		<p>A snowflake of order n is formed by overlaying an equilateral triangle (rotated by 180 degrees) onto each equilateral triangle of the same size in a snowflake of order n-1. A snowflake of order 1 is a single equilateral triangle.</p>
		///		
		///		
		///		
		///		<div> <img src="project/images/p570-snowflakes.png" alt="p570-snowflakes.png"> </div>
		///		
		///		
		///		<p>Some areas of the snowflake are overlaid repeatedly. In the above picture, blue represents the areas that are one layer thick, red two layers thick, yellow three layers thick, and so on. </p>
		///		
		///		<p>For an order n snowflake, let A(n) be the number of triangles that are one layer thick, and let B(n) be the number of triangles that are three layers thick. Define G(n) = gcd(A(n), B(n)).</p>
		///		
		///		<p>E.g. A(3) = 30, B(3) = 6, G(3)=6<br>
		///		A(11) = 3027630, B(11) = 19862070, G(11) = 30</p>
		///		
		///		<p>Further, G(500) = 186 and  $\sum_{n=3}^{500}G(n)=5124$</p>
		///		
		///		<p>Find $\displaystyle \sum_{n=3}^{10^7}G(n)$.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
