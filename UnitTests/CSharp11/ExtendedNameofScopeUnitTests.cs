using Features.CSharp11.ExtendedNameofScope;
using System.Diagnostics;

namespace UnitTests.CSharp11;

public class ExtendedNameofScopeUnitTests
{
	[Fact]
	public void ExtendedNameofScope_Will_Make_the_Param_Avaible_Inside_Name_Attribute_on_DoTheThing()
	{
		Person person = new Person("Joe", Positions.forward);
		person.DoTheThing((string name) => Debug.WriteLine(name), "The damndest Thing");
	}
}
