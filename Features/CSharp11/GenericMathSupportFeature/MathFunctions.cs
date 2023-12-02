using System.Numerics;

namespace Features.CSharp11.GenericMathSupportFeature;

public static class MathFunctions
{
	public static T Add<T>(T[] values) where T : INumber<T>
	{
		T result = T.Zero;
		foreach (T val in values)
		{
			result += val;
		}
		return result;
	}
}
