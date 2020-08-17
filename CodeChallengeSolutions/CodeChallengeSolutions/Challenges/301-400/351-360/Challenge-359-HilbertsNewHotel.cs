using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class HilbertsNewHotel 
	{
		/// <summary>
		/// Title: Hilbert's New Hotel
		/// Description: 
		///		
		///		<p>
		///		An infinite number of people (numbered 1, 2, 3, etc.) are lined up to get a room at Hilbert's newest infinite hotel. The hotel contains an infinite number of floors (numbered 1, 2, 3, etc.), and each floor contains an infinite number of rooms (numbered 1, 2, 3, etc.). 
		///		</p>
		///		
		///		<p>
		///		Initially the hotel is empty. Hilbert declares a rule on how the <var>n</var><sup>th</sup> person is assigned a room: person <var>n</var> gets the first vacant room in the lowest numbered floor satisfying either of the following:
		///		</p><ul><li>the floor is empty</li>
		///		<li>the floor is not empty, and if the latest person taking a room in that floor is person <var>m</var>, then <var>m</var> + <var>n</var> is a perfect square</li>
		///		</ul><p>
		///		Person 1 gets room 1 in floor 1 since floor 1 is empty.
		///		<br>Person 2 does not get room 2 in floor 1 since 1 + 2 = 3 is not a perfect square.
		///		<br>Person 2 instead gets room 1 in floor 2 since floor 2 is empty.
		///		<br>Person 3 gets room 2 in floor 1 since 1 + 3 = 4 is a perfect square.
		///		</p>
		///		
		///		<p>
		///		Eventually, every person in the line gets a room in the hotel.
		///		</p>
		///		
		///		<p>
		///		Define P(<var>f</var>, <var>r</var>) to be <var>n</var> if person <var>n</var> occupies room <var>r</var> in floor <var>f</var>, and 0 if no person occupies the room. Here are a few examples:
		///		<br>P(1, 1) = 1
		///		<br>P(1, 2) = 3
		///		<br>P(2, 1) = 2
		///		<br>P(10, 20) = 440
		///		<br>P(25, 75) = 4863
		///		<br>P(99, 100) = 19454
		///		</p>
		///		
		///		<p>
		///		Find the sum of all P(<var>f</var>, <var>r</var>) for all positive <var>f</var> and <var>r</var> such that <var>f</var> × <var>r</var> = 71328803586048 and give the last 8 digits as your answer.
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
