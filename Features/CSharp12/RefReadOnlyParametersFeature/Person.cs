namespace Features.CSharp12.RefReadOnlyParametersFeature;

public class Person
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }

	public Person(string firstName, string lastName, int age)
	{
		FirstName = firstName;
		LastName = lastName;
		Age = age;
	}

	public void CanChangeAge (ref int age)
	{
		age += 100;
	}
	//public void CannotChangeAge(ref readonly int age)
	//{
	//	age += 100; // red squiggles under age saying:
	//	// cannot assign to variable 'age' or use it as the right hand side
	//	//	of a ref assigmnment because it is a readonly variable
	//}
}
