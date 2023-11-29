namespace UnitTests.CSharp12;

public class DefaultLamdaParametersUnitTests
{
	[Fact]
	public void DefaultLamdaParams_Now_Available_Using_Defaults()
	{
		var lambda = (int one = 1, int two = 2) => one + two;

		Assert.Equal(3, lambda());
	}

	[Fact]
	public void DefaultLamdaParams_Now_Available_Passing_1_Params()
	{
		var lambda = (int one = 1, int two = 2) => one + two;

		Assert.Equal(11, lambda(9));
	}

	[Fact]
	public void DefaultLamdaParams_Now_Available_Passing_2_Params()
	{
		var lambda = (int one = 1, int two = 2) => one + two;

		Assert.Equal(10, lambda(5, 5));
	}

	[Fact]
	public void DefaultLamdaParams_Now_Available_Using_Default()
	{
		var lambda = (string description = "NOT_SET") => $"Description: {description}";

		Assert.Equal("Description: NOT_SET", lambda());
	}

	[Fact]
	public void DefaultLamdaParams_Now_Available_Passing_Param()
	{
		var lambda = (string description = "NOT_SET") => $"Description: {description}";

		Assert.Equal("Description: This is a random description.", lambda("This is a random description."));
	}
}
