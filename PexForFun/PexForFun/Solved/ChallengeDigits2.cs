namespace PexForFun.Challenges
{
	// http://www.pexforfun.com/Default.aspx?language=CSharp&sample=ChallengeDigits2
	static class ChallengeDigits2
	{
		public static int Puzzle(int x)
		{
			if (x < 0) return 0;

			int sum = 0;
			int tempX = x;
			do
			{
				int digit = tempX % 10;
				sum += digit;
				tempX = tempX/10;
			} while (tempX > 0);

			return sum;
		}
	}
}
