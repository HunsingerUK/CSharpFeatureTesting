using Features.CSharp11.RawStringLiteralsFeature;

namespace UnitTests.CSharp11;

public class RawStringLiteralsUnitTests
{
	[Fact]
	public void RawStringLiterals_Allow_Double_Quotes_More_Readably()
	{
		Person person = new Person("John", "Doe");
		string expectedText = @"This is my ""overridden ToString"" method.";

		Assert.Equal(expectedText, person.ToString());
	}

	[Fact]
	public void RawStringLiterals_Allow_Double_Quotes_More_Readably_With_StringInterpolation()
	{
		Person person = new Person("John", "Doe");
		string expectedText = "{\r\n\t\"FirstName\": \"John\",\r\n\t\"LastName\": \"Doe\"\r\n}";

		Assert.Equal(expectedText, person.ToJson());
	}

	[Fact]
	public void RawStringLiterals_Allow_Double_Quotes_More_Readably_With_StringInterpolation_NoCurlyBraces()
	{
		string firstName = "John";
		string lastName = "Doe";
		string interpolatedText = $"""
			"FirstName": "{firstName}",
			"LastName": "{lastName}"
		""";
		string expectedText = "\t\"FirstName\": \"John\",\r\n\t\"LastName\": \"Doe\"";

		Assert.Equal(expectedText, interpolatedText);
	}

	[Fact]
	public void RawStringLiterals_Allow_Double_Quotes_More_Readably_With_StringInterpolation_With_CurlyBraces_in_the_Text()
	{
		string firstName = "John";
		string lastName = "Doe";
		string interpolatedText = $$"""
		{
			"FirstName": "{{firstName}}",
			"LastName": "{{lastName}}"
		}
		""";
		string expectedText = "{\r\n\t\"FirstName\": \"John\",\r\n\t\"LastName\": \"Doe\"\r\n}";

		Assert.Equal(expectedText, interpolatedText);
	}
}
