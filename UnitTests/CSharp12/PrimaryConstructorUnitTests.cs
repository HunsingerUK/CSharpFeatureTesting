using Features.CSharp12.PrimaryConstructorsFeature;

namespace CSharpUnitTests.CSharp12;

public class PrimaryConstructorUnitTests
{
	[Fact]
	public void PrimaryConstructor_Creates_Product()
	{
		var product1 = new Product("InitialName");

		Assert.Equal("InitialName", product1.Name);
		Assert.Equal("NOT_SET", product1.Description);
	}

	[Fact]
	public void PrimaryConstructor_With_Another_Constructor_Creates_Product()
	{
		var guid = Guid.NewGuid();
		var product1 = new Product(guid, "InitialName");

		Assert.Equal("InitialName", product1.Name);
		Assert.Equal("NOT_SET", product1.Description);
		Assert.Equal(guid, product1.Id);
	}
}
