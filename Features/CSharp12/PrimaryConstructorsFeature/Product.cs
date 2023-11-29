namespace Features.CSharp12.PrimaryConstructorsFeature;

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