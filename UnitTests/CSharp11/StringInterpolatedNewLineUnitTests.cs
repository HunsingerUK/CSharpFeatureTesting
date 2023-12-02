namespace UnitTests.CSharp11;

public class StringInterpolatedNewLineUnitTests
{
	[Fact]
	public void StringInterpolation_Now_Allows_New_Lines_in_Variables()
	{
		string text = "WORLD";

		string modifiedText = $"The {text
									.ToLower()}";

		Assert.Equal("The world", modifiedText);
	}
}
