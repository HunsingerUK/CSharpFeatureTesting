using Features.CSharp11.RequiredMemberFeature;

namespace UnitTests.CSharp11;

public class RequiredMembersUnitTests
{
	[Fact]
	public void RequiredMembers_Are_Required()
	{
		Guid id = Guid.NewGuid();
		//Person person = new Person(); // red squiggles when I try this
		Person person = new Person() { Id = id, FirstName = "Zinedine", LastName = "Zidane" };

		Assert.IsType<Person>(person);
		Assert.Equal(id, person.Id);
		Assert.Equal("Zinedine", person.FirstName);
		Assert.Equal("Zidane", person.LastName);
	}

	[Fact]
	public void RequiredMembers_Can_Be_Set_Inside_Constructor_With_SetsRequiredMembers_Attribute()
	{
		//Player player = new Player("Eric", "Cantona"); // red squiggles due to not setting required Position on initialization
		Player player1 = new Player()
		{
			FirstName = "Eric",
			LastName = "Cantona",
			Position = "Forward"
		};
		Player player2 = new Player("Kobbie", "Mainoo") { Position = "Midfielder" };
	}
}
