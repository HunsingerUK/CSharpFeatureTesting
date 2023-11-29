using CSharpTesting.CSharp09;

namespace CSharpUnitTests.CSharp09;

public class TerseRecordUnitTests
{
	[Fact]
	public void RecordType_Equality_Records_Are_Equal()
	{
		var product1 = new RecordTerseExample(1, "Tomato", 2.99m);
		var product2 = new RecordTerseExample(1, "Tomato", 2.99m);

		Assert.Equal(product1, product2);
	}

	[Fact]
	public void RecordType_Equality_Records_Are_Not_Equal()
	{
		var product1 = new RecordTerseExample(1, "Tomato", 2.99m);
		var product2 = product1 with { Price = 1.99m };

		Assert.NotEqual(product1, product2);
		Assert.NotEqual(product1.Price, product2.Price);

		Assert.Equal(product1.Id, product2.Id);
		Assert.Equal(product1.Name, product2.Name); 
		Assert.Equal(product1.Description, product2.Description);
	}
}
