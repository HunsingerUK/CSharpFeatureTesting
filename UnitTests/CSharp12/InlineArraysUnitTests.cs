using Features.CSharp12.InlineArraysFeature;

namespace UnitTests.CSharp12;

public class InlineArraysUnitTests
{
	[Fact]
	public void InlineArray_Example_one()
	{
		InlineIntArrayBuffer buffer = new InlineIntArrayBuffer();
		for (int i = 0; i < 10; i++)
		{
			buffer[i] = i+1;
		}

		Assert.Equal([1,2,3,4,5,6,7,8,9,10], buffer);
		Assert.Equal(typeof(InlineIntArrayBuffer), buffer.GetType());
	}

	[Fact]
	public void InlineArray_Example_two()
	{
		string[] colors = ["red", "green", "blue"];
		InlineStringArrayBuffer buffer = new InlineStringArrayBuffer();
		for (int i = 0; i < 10; i++)
		{
			buffer[i] = colors[i % 3];
		}

		Assert.Equal(["red", "green", "blue", "red", "green", "blue", "red", "green", "blue", "red"], buffer);
		Assert.Equal(typeof(InlineStringArrayBuffer), buffer.GetType());
	}
}
