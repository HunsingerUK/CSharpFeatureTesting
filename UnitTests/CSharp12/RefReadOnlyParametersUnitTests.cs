using Features.CSharp12.RefReadOnlyParametersFeature;

namespace UnitTests.CSharp12;

public class RefReadOnlyParametersUnitTests
{
	[Fact]
	public void Normal_Ref_Arg_Is_Mutable_SEE_Person_Class_For_Readonly_Ref()
	{
		Person person = new Person("John", "Doe", 60);
		int newAge = 50;
		person.CanChangeAge(ref newAge);

		Assert.Equal(150, newAge);
	}
}
