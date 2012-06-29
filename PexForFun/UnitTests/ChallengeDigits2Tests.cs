using System.Collections.Generic;
using Xunit.Extensions;

namespace PexForFun.Challenges.UnitTests
{
	public partial class ChallengeTests
	{
		[Theory]
		[PropertyData("ChallengeDigits2TestData")]
		public void ChallengeDigits2Theory(int x, int expected)
		{
			Assert.Equal(expected, ChallengeDigits2.Puzzle(x));
		}

		public static IEnumerable<object[]> ChallengeDigits2TestData
		{
			get
			{
				return new[]
					{
						new object[] { 0, 0},
						new object[] { int.MinValue, 0},
						new object[] { 1, 1},
						new object[] { 11, 2},
						new object[] { 7, 7},
						new object[] { 259, 16},
						new object[] { int.MaxValue, 46},
					};
			}
		}
	}
}
