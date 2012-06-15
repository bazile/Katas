namespace PexForFun.Challenges
{
	/// <summary>
	/// http://www.pexforfun.com/default.aspx?language=CSharp&sample=ChallengeArrayIsSorted
	/// </summary>
	public static class ArrayIsSorted
    {
		public static bool Puzzle(int[] a)
		{
			if (a == null || a.Length < 3) return true;

			int prevSign = (a[0] - a[1]) < 0 ? -1 : 1;
			for (int i = 2; i < a.Length; i++)
			{
				int sign = (a[i - 1] - a[i]) < 0 ? -1 : 1;
				if (prevSign != sign) return false;

				if (sign == -1 && a[i] < a[i - 1]) return false;
				if (sign == 1 && a[i] > a[i - 1]) return false;

				prevSign = sign;
			}

			return false;
		}
	}
}
