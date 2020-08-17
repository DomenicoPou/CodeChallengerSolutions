using System;
using System.Collections.Generic;

namespace Challenges
{
	public static class Aninfinitegame 
	{
		/// <summary>
		/// Title: An infinite game
		/// Description: 
		///		
		///		<p>Peter is playing a solitaire game on an infinite checkerboard, each square of which can hold an unlimited number of tokens.</p>
		///		
		///		<p>Each move of the game consists of the following steps:</p>
		///		<ol>
		///		<li>Choose one token $T$ to move. This may be any token on the board, as long as not all of its four adjacent squares are empty.</li>
		///		<li>Select and discard one token $D$ from a square adjacent to that of $T$.</li>
		///		<li>Move $T$ to any one of its four adjacent squares (even if that square is already occupied).</li>
		///		</ol>
		///		
		///		<div class="center">
		///		<img src="project/images/p664_moves.gif" alt="Allowed moves">
		///		</div>
		///		
		///		<p>The board is marked with a line called the <i>dividing line</i>. Initially, every square to the left of the dividing line contains a token, and every square to the right of the dividing line is empty:</p>
		///		
		///		<div class="center">
		///		<img src="project/images/p664_starting_0.png" alt="Initial setup">
		///		</div>
		///		
		///		<p>Peter's goal is to get a token as far as possible to the right in a finite number of moves. However, he quickly finds out that, even with his infinite supply of tokens, he cannot move a token more than four squares beyond the dividing line.</p>
		///		
		///		<p>Peter then considers starting configurations with larger supplies of tokens: each square in the $d$th column to the left of the dividing line starts with $d^n$ tokens instead of 1. This is illustrated below for $n=1$:</p>
		///		
		///		<div class="center">
		///		<img src="project/images/p664_starting_1.png" alt="Initial setup n=1">
		///		</div>
		///		
		///		<p>Let $F(n)$ be the maximum number of squares Peter can move a token beyond the dividing line. For example, $F(0)=4$.
		///		You are also given that $F(1)=6$, $F(2)=9$, $F(3)=13$, $F(11)=58$ and $F(123)=1173$.</p>
		///		<p>Find $F(1234567)$.</p>
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
