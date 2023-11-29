using CSharpTesting.CSharp09;

namespace UnitTests.CSharp09;

public class RecordUnitTests
{
	[Fact]
	public void RecordType_Equality_Records_Are_Equal()
	{
		RecordExample product1 = new RecordExample()
		{
			Name = "Tomato",
			Price = 2.99m
		};
		RecordExample product2 = new RecordExample()
		{
			Name = "Tomato",
			Price = 2.99m
		};

		Assert.Equal(product1, product2);
	}

	[Fact]
	public void RecordType_ToString_Format()
	{
		RecordExample product1 = new RecordExample()
		{
			Name = "Tomato",
			Price = 2.99m
		};

		string product1String = product1.ToString();
		string stringEquivalent = "RecordExample { Id = 0, Name = Tomato, Price = 2.99, Description =  }";

		Assert.Equal(product1String, stringEquivalent);
	}

	[Fact]
	public void ClassType_ToString_Format()
	{
		ClassExample product1 = new ClassExample()
		{
			Name = "Tomato",
			Price = 2.99m
		};

		string? product1String = product1.ToString();
		string stringEquivalent = "CSharpTesting.CSharp09.ClassExample"; // [Project.Namespace.Class]

		Assert.Equal(product1String, stringEquivalent);
	}
}
