using Features.CSharp12.PrimaryConstructorsFeature;

namespace UnitTests.CSharp12;

public class PrimaryConstructorUnitTests
{
	[Fact]
	public void PrimaryConstructor_Creates_Product()
	{
		Product product1 = new Product("InitialName");

		Assert.Equal("InitialName", product1.Name);
		Assert.Equal("NOT_SET", product1.Description);
	}

	[Fact]
	public void PrimaryConstructor_With_Another_Constructor_Creates_Product()
	{
		Guid guid = Guid.NewGuid();
		Product product1 = new Product(guid, "InitialName");

		Assert.Equal("InitialName", product1.Name);
		Assert.Equal("NOT_SET", product1.Description);
		Assert.Equal(guid, product1.Id);
	}
}
