namespace Features.CSharp11.RawStringLiteralsFeature;

public class Person
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public override string ToString()
	{
		return """This is my "overridden ToString" method.""";
	}

	public Person(string firstName, string lastName)
	{
		FirstName = firstName;
		LastName = lastName;
	}

	public string ToJson()
	{
		return $$"""
		{
			"FirstName": "{{FirstName}}",
			"LastName": "{{LastName}}"
		}
		""";
	}
}
