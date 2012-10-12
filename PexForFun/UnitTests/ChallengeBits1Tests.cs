using System.Collections.Generic;
using Xunit.Extensions;

namespace PexForFun.Challenges.Tests
{
	public partial class ChallengeTests
	{
		[Theory(Skip="Solved")]
		[PropertyData("ChallengeBits1TestData")]
		public void ChallengeBits1Theory(byte x, int expected)
		{
			Assert.Equal<int>(expected, ChallengeBits1.Puzzle(x));
		}

		public static IEnumerable<object[]> ChallengeBits1TestData
		{
			get
			{
				return new[]
					{
						new object[] { (byte)0x00, 0 },
						new object[] { (byte)0x02, 1 },
						new object[] { (byte)0xFF, 8 },
					};
			}
		}
	}
}
