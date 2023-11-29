namespace CSharpTesting.CSharp09;

public record RecordTerseExample(
	int Id, 
	string Name, 
	decimal Price, 
	string? Description = "NOT_SET"
);