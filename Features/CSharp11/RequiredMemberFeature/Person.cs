namespace Features.CSharp11.RequiredMemberFeature;

public class Person
{
	public required Guid Id { get; set; }
	public required string FirstName { get; set; }
	public required string LastName { get; set;}
}
