using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Orderedradicals 
	{
		/// <summary>
		/// Title: Orderedradicals
		/// Description: 
		///		
		///		<p>The radical of <i>n</i>, rad(<i>n</i>), is the product of the distinct prime factors of <i>n</i>. For example, 504 = 2<sup>3</sup> × 3<sup>2</sup> × 7, so rad(504) = 2 × 3 × 7 = 42.</p>
		///		<p>If we calculate rad(<i>n</i>) for <i>1</i> ≤ <i>n</i> ≤ 10, then sort them on rad(<i>n</i>), and sorting on <i>n</i> if the radical values are equal, we get:</p>
		///		<table cellpadding="2" cellspacing="0" border="0" align="center"><tr><td colspan="2"><div class="center"><b>Unsorted</b></div></td>
		///		<td> </td>
		///		<td colspan="3"><div class="center"><b>Sorted</b></div></td>
		///		</tr><tr><td><div class="center"><img src="images/spacer.gif" width="50" height="1" alt=""><br><b><i>n</i></b></div></td>
		///		<td><div class="center"><img src="images/spacer.gif" width="50" height="1" alt=""><br><b>rad(<i>n</i>)</b></div></td>
		///		<td><img src="images/spacer.gif" width="50" height="1" alt=""><br></td>
		///		<td><div class="center"><img src="images/spacer.gif" width="50" height="1" alt=""><br><b><i>n</i></b></div></td>
		///		<td><div class="center"><img src="images/spacer.gif" width="50" height="1" alt=""><br><b>rad(<i>n</i>)</b></div></td>
		///		<td><div class="center"><img src="images/spacer.gif" width="50" height="1" alt=""><br><b>k</b></div></td>
		///		</tr><tr><td><div class="center">1</div></td><td><div class="center">1</div></td>
		///		<td> </td>
		///		<td><div class="center">1</div></td><td><div class="center">1</div></td><td><div class="center">1</div></td>
		///		</tr><tr><td><div class="center">2</div></td><td><div class="center">2</div></td>
		///		<td> </td>
		///		<td><div class="center">2</div></td><td><div class="center">2</div></td><td><div class="center">2</div></td>
		///		</tr><tr><td><div class="center">3</div></td><td><div class="center">3</div></td>
		///		<td> </td>
		///		<td><div class="center">4</div></td><td><div class="center">2</div></td><td><div class="center">3</div></td>
		///		</tr><tr><td><div class="center">4</div></td><td><div class="center">2</div></td>
		///		<td> </td>
		///		<td><div class="center">8</div></td><td><div class="center">2</div></td><td><div class="center">4</div></td>
		///		</tr><tr><td><div class="center">5</div></td><td><div class="center">5</div></td>
		///		<td> </td>
		///		<td><div class="center">3</div></td><td><div class="center">3</div></td><td><div class="center">5</div></td>
		///		</tr><tr><td><div class="center">6</div></td><td><div class="center">6</div></td>
		///		<td> </td>
		///		<td><div class="center">9</div></td><td><div class="center">3</div></td><td><div class="center">6</div></td>
		///		</tr><tr><td><div class="center">7</div></td><td><div class="center">7</div></td>
		///		<td> </td>
		///		<td><div class="center">5</div></td><td><div class="center">5</div></td><td><div class="center">7</div></td>
		///		</tr><tr><td><div class="center">8</div></td><td><div class="center">2</div></td>
		///		<td> </td>
		///		<td><div class="center">6</div></td><td><div class="center">6</div></td><td><div class="center">8</div></td>
		///		</tr><tr><td><div class="center">9</div></td><td><div class="center">3</div></td>
		///		<td> </td>
		///		<td><div class="center">7</div></td><td><div class="center">7</div></td><td><div class="center">9</div></td>
		///		</tr><tr><td><div class="center">10</div></td><td><div class="center">10</div></td>
		///		<td> </td>
		///		<td><div class="center">10</div></td><td><div class="center">10</div></td><td><div class="center">10</div></td>
		///		</tr></table><p>Let E(<i>k</i>) be the <i>k</i>th element in the sorted <i>n</i> column; for example, E(4) = 8 and E(6) = 9.</p>
		///		<p>If rad(<i>n</i>) is sorted for 1 ≤ <i>n</i> ≤ 100000, find E(10000).</p>
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
