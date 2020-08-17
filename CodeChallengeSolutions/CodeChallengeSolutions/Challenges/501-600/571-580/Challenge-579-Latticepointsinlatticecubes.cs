using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Latticepointsinlatticecubes 
	{
		/// <summary>
		/// Title: Lattice points in lattice cubes
		/// Description: 
		///		
		///		<p>A <b>lattice cube</b> is a cube in which all vertices have integer coordinates. Let C(<var>n</var>) be the number of different lattice cubes in which the coordinates of all vertices range between (and including) 0 and <var>n</var>. Two cubes are hereby considered different if any of their vertices have different coordinates.<br>
		///		For example, C(1)=1, C(2)=9, C(4)=100, C(5)=229, C(10)=4469 and C(50)=8154671.
		///		</p>
		///		<p>Different cubes may contain different numbers of lattice points.</p>
		///		<p>
		///		For example, the cube with the vertices<br>
		///		(0, 0, 0), (3, 0, 0), (0, 3, 0), (0, 0, 3), (0, 3, 3), (3, 0, 3), (3, 3, 0), (3, 3, 3) contains 64 lattice points (56 lattice points on the surface including the 8 vertices and 8 points within the cube). </p>
		///		<p>In contrast, the cube with the vertices<br>
		///		(0, 2, 2), (1, 4, 4), (2, 0, 3), (2, 3, 0), (3, 2, 5), (3, 5, 2), (4, 1, 1), (5, 3, 3) contains only 40 lattice points (20 points on the surface and 20 points within the cube), although both cubes have the same side length 3.
		///		</p>
		///		<p>
		///		Let S(<var>n</var>) be the sum of the lattice points contained in the different lattice cubes in which the coordinates of all vertices range between (and including) 0 and <var>n</var>.</p>
		///		
		///		<p>For example, S(1)=8, S(2)=91, S(4)=1878, S(5)=5832, S(10)=387003 and S(50)=29948928129.</p>
		///		
		///		<p>Find S(5000) mod 10<sup>9</sup>.</p>
		///		
		/// </summary>
		/// <returns>Your result in string format.</returns>
		public static string Solution()
		{
			return "";
		}
	}
}
