namespace CSharpTesting.CSharp09;

public record RecordTerseExample(
	int Id, 
	string Name, 
	decimal Price, 
	string? Description = "NOT_SET"
);

// BOILERPLATE UNDERNEATH
//public record Person
//{
//	public Person(string firstName, string lastName)
//	{
//		FirstName = firstName;
//		LastName = lastName;
//	}

//	public string FirstName { get; init; }
//	public string LastName { get; init; }
//}