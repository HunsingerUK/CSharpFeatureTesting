namespace UnitTests.CSharp12;

public class CollectionExpressionsUnitTests
{
	[Fact]
	public void Initializing_Array_Old_vs_New()
	{
		int[] intArrayOld = new int[] { 1, 2, 3, 4, 5 }; // before C#12
		int[] intArrayNew = [1, 2, 3, 4, 5]; // cannot use var with this type of initialization

		Assert.Equal(intArrayOld, intArrayNew);
	}

	[Fact]
	public void Initializing_Span_Old_vs_New()
	{
		Span<int> intSpanOld = stackalloc[] { 1, 2, 3, 4, 5 };
		Span<int> intSpanNew = [1, 2, 3, 4, 5];

		Assert.Equal(intSpanOld, intSpanNew);
	}

	[Fact]
	public void Initializing_TwoDArray_Old_vs_New()
	{
		int[][] intTwoDArrayOld = new int[][] { [1, 2, 3], [4, 5, 6], [7, 8, 9] };
		int[][] intTwoDArrayNew = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

		Assert.Equal(intTwoDArrayOld, intTwoDArrayNew);
	}

	[Fact]
	public void Initializing_FlattenedArrayFromArraysUsingSpread_Old_vs_New_()
	{
		int[] intArray1 = [1, 2, 3, 4, 5];
		int[] intArray2 = [6, 7, 8, 9, 10];
		int[] intArray3 = [11, 12, 13, 14, 15];

		int[] intArrayFromVariablesNew = [.. intArray1, .. intArray2, .. intArray3];

		Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, intArrayFromVariablesNew);
	}
}