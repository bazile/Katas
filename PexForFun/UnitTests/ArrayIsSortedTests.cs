using System;
using System.Collections.Generic;
using PexForFun.Challenges;
using Xunit;

namespace UnitTests
{
    public class ArrayIsSortedTests
    {
		private void MyAssert(Func<int[], bool> testFunc, List<Data<bool, int[]>> testData)
		{
			if (null == testData) return;

			foreach (var data in testData)
			{
				Assert.Equal(data.Expected, testFunc(data.Argument));
			}
		}

		[Fact]
		public void ShouldPass()
		{
			//Assert.True(ArrayIsSorted.Puzzle(new[] { 0 }) );
			//Assert.True

			//var testData = new List<Data<bool, int[]>>{{new int[0], true}};
			//MyAssert(ArrayIsSorted.Puzzle, null);

			Assert.True(ArrayIsSorted.Puzzle(new int[0]));
			Assert.True(ArrayIsSorted.Puzzle(new int[] {0,0}));
			//Assert.True(ArrayIsSorted.Puzzle(new int[] {0,0,0}));
		}
    }

	public class Data<TExpected, TArgument>
	{
		public readonly TExpected Expected;
		public readonly TArgument Argument;

		public Data(TExpected expected, TArgument argument)
		{
			Expected = expected;
			Argument = argument;
		}
	}
}
