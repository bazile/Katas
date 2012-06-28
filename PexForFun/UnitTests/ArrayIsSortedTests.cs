using System.Collections.Generic;
using PexForFun.Challenges;
using Xunit;
using Xunit.Extensions;

namespace UnitTests
{
    public class ArrayIsSortedTests
    {
		[Theory]
		[PropertyData("ArrayIsSortedTestData")]
		public void ArrayIsSortedTheory(bool expected, int[] arr)
		{
			Assert.Equal(expected, ArrayIsSorted.Puzzle(arr));
		}

		public static IEnumerable<object[]> ArrayIsSortedTestData
    	{
			get
			{
				// ReSharper disable RedundantExplicitArrayCreation
				return new[]
					{
						new object[] { true , new int[] {} },
						new object[] { true , new int[] {0} },
						new object[] { true , new int[] {0, 0} },
						new object[] { true , new int[] {0, 0, 0} },
						new object[] { false, new int[] {1, 0} },
						new object[] { false, new int[] {1, 0, 0} },
						new object[] { false, new int[] {1, 0, 0, 0} },
						new object[] { false, new int[] {256, 219, 705} },
						new object[] { false, new int[] {-2136931200, int.MinValue, 515} },
						new object[] { false, new int[] {1082647043, -1869110526, 0} },
						new object[] { false, new int[] {1785481276, -437677763, 1694831873, 1694839802} },
						new object[] { false, new int[] {1960969921, -186612128, 1381466382, -1456103424} },
					};
				// ReSharper restore RedundantExplicitArrayCreation
			}
    	}
	}
}
