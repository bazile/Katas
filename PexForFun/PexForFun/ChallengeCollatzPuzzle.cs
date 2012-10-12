namespace PexForFun.Challenges
{
	static class ChallengeCollatzPuzzle
	{
		public static int Puzzle(int x)
		{
			// Can you figure out solve this Collatz conjecture based problem?
			// http://www.numbertheory.org/php/collatz.html
			// http://en.wikipedia.org/wiki/Collatz_conjecture

			//int num = x;
			//for (int i=0; i<x; i++)
			//{
			//	if (num % 2 == 0)
			//	{
			//		num /= 2;
			//	}
			//	else
			//	{
			//		num = num*3 + 1;
			//	}
			//}
			//return num;

			if (x % 2 == 0)
			{
				//x = x;
			}
			else
			{
				x = x*2 - 1;
			}
			return x;
		}
	}
}
