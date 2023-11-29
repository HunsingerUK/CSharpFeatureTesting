using CSharpTesting.CSharp09;

namespace CSharpUnitTests.CSharp9;

public class RecordUnitTests
{
	[Fact]
	public void RecordType_Equality_Records_Are_Equal()
	{
		var product1 = new RecordExample()
		{
			Name = "Tomato",
			Price = 2.99m
		};
		var product2 = new RecordExample()
		{
			Name = "Tomato",
			Price = 2.99m
		};

		Assert.Equal(product1, product2);
	}

	[Fact]
	public void RecordType_ToString_Format()
	{
		var product1 = new RecordExample()
		{
			Name = "Tomato",
			Price = 2.99m
		};

		var product1String = product1.ToString();
		var stringEquivalent = "RecordExample { Id = 0, Name = Tomato, Price = 2.99, Description =  }";

		Assert.Equal(product1String, stringEquivalent);
	}

	[Fact]
	public void ClassType_ToString_Format()
	{
		var product1 = new ClassExample()
		{
			Name = "Tomato",
			Price = 2.99m
		};

		var product1String = product1.ToString();
		var stringEquivalent = "CSharpTesting.CSharp9.ClassExample"; // [Project.Namespace.Class]

		Assert.Equal(product1String, stringEquivalent);
	}
}
