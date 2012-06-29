namespace PexForFun.Challenges
{
	/// <summary>
	/// http://www.pexforfun.com/default.aspx?language=CSharp&sample=ChallengeBits1
	/// </summary>
	public static class ChallengeBits1
	{
		public static int Puzzle(byte number)
		{
			int cnt = 0;
			byte tempNumber = number;
			for (int i=0; i<8; i++)
			{
				if((tempNumber & 1) == 1) cnt++;
				tempNumber >>= 1;
			}
			return cnt;
		}
	}
}
