using System.Diagnostics.CodeAnalysis;

namespace Features.CSharp11.RequiredMemberFeature;

public class Player
{
	public required string FirstName { get; init; }
	public required string LastName { get; init; }
	public required string Position { get; init; }
	public string? Number { get; set; }

	public Player()	{}

	[SetsRequiredMembers] // without this, you will get errors. this tells the compiler ite doesnt need to force the required
	// members to be in initialization syntax since we are setting them in this constructor
	// NOTE: this can bite you since you're telling the compiler to not worry about it, that you've got it
	public Player(string firstName, string lastName)
	{
		FirstName = firstName;
		LastName = lastName;
	}
}
