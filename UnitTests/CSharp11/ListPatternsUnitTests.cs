using System.Diagnostics;

namespace UnitTests.CSharp11;

public class ListPatternsUnitTests
{
	[Fact]
	public void ListPatterns_Returns_True_If_Matched()
	{
		List<string> list = new List<string>() { "red", "green", "blue"};

		Assert.True(list is ["red", "green", "blue"]);
		Assert.False(list is ["red", "green"]);
		Assert.False(list is ["Red", "Green", "Blue"]);
	}

	[Fact]
	public void ListPatterns_Matches_Exact_Collection_of_Values()
	{
		int[] numbers = { 0, 1, 2, 3, 4 };
		int[] altNumbers = { 1, 2, 3, 4, 5 };

		Assert.True(numbers is [0,1,2,3,4]);
		Assert.False(numbers is [1,2,3,4]);
		Assert.False(numbers is [2, 3, 4, 5]);
		Assert.True(numbers is [0 or 1, 1 or 2, 2 or 3, 3 or 4, 4 or 5]);
		Assert.True(altNumbers is [0 or 1, 1 or 2, 2 or 3, 3 or 4, 4 or 5]);

		Assert.True(numbers is [< 2, < 2, <= 2, > 2, > 2]);
	}

	[Fact]
	public void ListPatterns_Specific_Values_Can_Be_Selected_Out()
	{
		List<string> list = new List<string>() { "red", "green", "blue" };

		// you can slice out items 
		// NOTE: here it matches on the number of items in the collection rather than the values
		if (list is [var first, _, _])
		{
			Debug.WriteLine(first);
			Assert.Equal("red", first);
		}
		if (list is [_, var second, _])
		{
			Debug.WriteLine(second);
			Assert.Equal("green", second);
		}
		if (list is [_, _, var third])
		{
			Debug.WriteLine(third);
			Assert.Equal("blue", third);
		}
		if (list is [_, _, _, var fourth]) // too many items to match on
		{
			Debug.WriteLine(fourth); // should not print
			Assert.Equal("line should never execute", fourth);
		}
		if (list is [_, var fifth]) // too few items to match on
		{
			Debug.WriteLine(fifth); // should not print
			Assert.Equal("line should never execute", fifth);
		}

		Assert.True(list is ["red", "green", "blue"]);
	}

	[Fact]
	public void ListPatterns_Specific_Values_Can_Be_Selected_Out_Individually_or_in_Bulk()
	{
		List<string> list = new List<string>() { "red", "green", "blue" };

		if (list is [var first, .. var rest])
		{
			Assert.Equal("red", first);
			Assert.Equal(["green", "blue"], rest);
		}

		Assert.True(list is ["red", "green", "blue"]);
	}


	// MORE LIST PATTERN MATCHING
	[Fact]
	public void List_Pattern_Matching_in_Array()
	{
		string[] colors = new string[] {"red", "green", "blue"};
		string value = colors switch
		{
			[] => "Value was empty",
			["hex"] => "HEX",
			["cyan", "magenta", "yellow", "black"] => "CMYK",
			["red"] => "R",
			["green"] => "G",
			["blue"] => "B",
			["red", "green"] => "RG",
			["green", "blue"] => "GB",
			["red", "blue"] => "RB",
			["red", "green", "blue"] => "RGB"
		};

		Assert.Equal("RGB", value);
	}

	[Fact]
	public void _()
	{
		string[] emptyArray = Array.Empty<string>();
		string value = emptyArray switch
		{
			[] => "Value was empty", // list has no values
			[var fullName] => $"My full name is: {fullName}", // list only has one value
			[var firstName, var lastName] => $"My full name is {firstName} {lastName}", // list only has two values
			[var firstName, var lastName, var suffix] => $"My full name is {firstName} {lastName} {suffix}." // list only has three values
		};

		Assert.Equal("Value was empty", value);
	}

	[Fact]
	public void __()
	{
		string[] name = new string[] { "Indigo Montoya" };
		string value = name switch
		{
			[] => "Value was empty", // list has no values
			[var fullName] => $"My full name is: {fullName}", // list only has one value
			[var firstName, var lastName] => $"My full name is {firstName} {lastName}", // list only has two values
			[var firstName, var lastName, var suffix] => $"My full name is {firstName} {lastName} {suffix}." // list only has three values
		};

		Assert.Equal("My full name is: Indigo Montoya", value);
	}

	[Fact]
	public void ___()
	{
		string[] nameSplitOut = new string[] { "Indigo", "Montoya" };
		string value = nameSplitOut switch
		{
			[] => "Value was empty", // list has no values
			[var fullName] => $"My full name is: {fullName}", // list only has one value
			[var firstName, var lastName] => $"My full name is {firstName} {lastName}", // list only has two values
			[var firstName, var lastName, var suffix] => $"My full name is {firstName} {lastName} {suffix}." // list only has three values
		};

		Assert.Equal("My full name is Indigo Montoya", value);
	}

	[Fact]
	public void ____()
	{
		string[] nameSplitOutMore = new string[] { "Indigo", "Montoya", "Jr" };
		string value = nameSplitOutMore switch
		{
			[] => "Value was empty", // list has no values
			[var fullName] => $"My full name is: {fullName}", // list only has one value
			[var firstName, var lastName] => $"My full name is {firstName} {lastName}", // list only has two values
			[var firstName, var lastName, var suffix] => $"My full name is {firstName} {lastName} {suffix}." // list only has three values
		};

		Assert.Equal("My full name is Indigo Montoya Jr.", value);
	}
}
