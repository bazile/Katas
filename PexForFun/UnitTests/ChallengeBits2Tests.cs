using System.Collections.Generic;
using Xunit.Extensions;

namespace PexForFun.Challenges.Tests
{
	public partial class ChallengeTests
	{
		[Theory]
		[PropertyData("ChallengeBits2TestData")]
		public void ChallengeBits2Theory(byte x, byte expected)
		{
			Assert.Equal<byte>(expected, ChallengeBits2.Puzzle(x));
		}

		public static IEnumerable<object[]> ChallengeBits2TestData
		{
			get
			{
				return new[]
					{
						new object[] { (byte)0x00, (byte)0x00},
						new object[] { (byte)0x08, (byte)0x08}, // 0000 1000 -> 0000 1000
						new object[] { (byte)0x0E, (byte)0x02}, // 0000 1110 -> 0000 0010
						new object[] { (byte)0x50, (byte)0x10}, // 0101 0000 -> 0001 0000
					};
			}
		}
	}
}
