namespace Features.CSharp12.PrimaryConstructorsFeature;

// Unlike record type primary constructors, you need to create a property for the members included
// in your primary constructor to make them available to your class outside
// otherwise, they are just available inside the class during initialization
public class Product(string name, string description = "NOT_SET")
{
	public Product(Guid id, string name, string description = "NOT_SET") : this(name, description)
	{
		Id = id;
	}

	public Guid Id { get; set; }
	public string Name { get; private set; } = name;
	public string? Description { get; private set; } = description;

	public void UpdateName(string name)
	{
		Name = name;
	}
	public void UpdateDescription(string description)
	{
		Description = description;
	}
}