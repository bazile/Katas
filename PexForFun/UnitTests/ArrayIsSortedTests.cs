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
			//{1, 0} 	 false
			//{1, 0, 0} 	 false 	  	  
			//{-2136931200, int.MinValue, 515} 	 false 	  	  
			//{1, 0, 0, 0} 	 false 	  	  
			//{1082647043, -1869110526, 0} 	 false 	  	  
			//{256, 219, 705} 	 false 	  	  
			//{1785481276, -437677763, 1694831873, 1694839802} 	 false 	  	  
			//{1960969921, -186612128, 1381466382, -1456103424} 	 false 
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
