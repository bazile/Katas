namespace PexForFun.Challenges
{
	/// <summary>
	/// http://www.pexforfun.com/default.aspx?language=CSharp&sample=ChallengeArrayIsSorted
	/// </summary>
	public static class ArrayIsSorted
    {
		public static bool Puzzle(int[] a)
		{
			if (a == null || a.Length < 2) return true;

			for (int i = 1; i < a.Length; i++)
			{
				if(a[i - 1] > a[i]) return false;
			}

			return true;
		}
    }
}
