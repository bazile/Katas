using System.Collections.Generic;
using Xunit.Extensions;

namespace PexForFun.Challenges.Tests
{
	public partial class ChallengeTests
	{
		[Theory]
		[PropertyData("ChallengeCollatzTestData")]
		public void ChallengeCollatzTheory(int x, int expected)
		{
			Assert.Equal<int>(expected, ChallengeCollatzPuzzle.Puzzle(x));
		}

		public static IEnumerable<object[]> ChallengeCollatzTestData
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
