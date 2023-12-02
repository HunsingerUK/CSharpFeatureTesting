using Features.CSharp11.GenericMathSupportFeature;

namespace UnitTests.CSharp11;

public class GenericMathSupportUnitTests
{
	[Fact]
	public void CSharp11_AllowsGenericMathSupport_With_Int()
	{
		int[] values = [1,2,3,4,5];

		int result = MathFunctions.Add(values);

		Assert.Equal(15, result);
	}

	[Fact]
	public void CSharp11_AllowsGenericMathSupport_With_Double()
	{
		double[] values = [1, 2, 3, 4, 5, .25];

		double result = MathFunctions.Add(values);

		Assert.Equal(15.25, result);
	}

	[Fact]
	public void CSharp11_AllowsGenericMathSupport_With_Decimal()
	{
		decimal[] values = [1, 2, 3, 4, 5, .25m];

		decimal result = MathFunctions.Add(values);

		Assert.Equal(15.25m, result);
	}
}
