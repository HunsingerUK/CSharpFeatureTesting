using Features.Extensions;

namespace Features.CSharp11.ExtendedNameofScope;

public class Person
{
	public string Name { get; init; }

	public string Position { get; init; }

	public Person(string name, Positions position)
	{
		Name = name;
		Position = position.GetDisplay();
	}

	[Name(nameof(actionName))] // the scope of the param is now extended so its reachable inside the attribute
	public void DoTheThing(Action<string> action, string actionName)
	{
		action(actionName);
	}
}

public enum Positions
{
	defender,
	midfielder,
	forward,
	goalkeeper
}

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public class NameAttribute : Attribute
{
	private string _name;

	public NameAttribute(string name)
	{
		_name = name;
	}
}
