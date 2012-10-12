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
						new object[] {  1,  1 },
						new object[] {  2,  2 },
						new object[] {  3,  8 },
						new object[] {  7, 17 },
						new object[] { 11, 15 },
						new object[] { 19, 21 },
					};
			}
		}
	}
}
