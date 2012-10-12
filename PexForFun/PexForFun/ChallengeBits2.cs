namespace PexForFun.Challenges
{
	// http://www.pexforfun.com/Default.aspx?language=CSharp&sample=ChallengeBits2
	static class ChallengeBits2
	{
		public static byte Puzzle(byte x)
		{
			byte b1 = (byte) ((x << 1) & 0x0F);
			return ((byte)(b1 ^ x));
		}
	}
}
