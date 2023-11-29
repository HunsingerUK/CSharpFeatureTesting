using Features.CSharp12.AliasAnyTypeFeature;

namespace UnitTests.CSharp12;

using MyGrid = Grid;
using TwoDPoint = (int X, int Y);
using ThreeDPoint = (int X, int Y, int Z);
using XPosition = int;

public class AliasAnyTypeUnitTests
{
	[Fact]
	public void Alias_AnyType_From_Original_Alias()
	{
		MyGrid grid = new MyGrid();
		(int X, int Y) point = new TwoDPoint(0,0);
		grid.AddPoint(point);

		Assert.Equal(typeof(TwoDPoint), grid.Points.First().GetType());
	}

	[Fact]
	public void Alias_AnyType_Even_A_Class()
	{
		MyGrid grid = new MyGrid();
		(int X, int Y) point = new TwoDPoint(0, 0);
		grid.AddPoint(point);

		Assert.Equal(typeof(MyGrid), grid.GetType());
	}

	[Fact]
	public void Alias_AnyType_ThreeDPoint_Alias()
	{
		(int X, int Y, int Z) point = new ThreeDPoint(100, 100, 100);

		Assert.Equal(typeof(ThreeDPoint), point.GetType());
	}

	[Fact]
	public void Alias_AnyType_Deconstructed_XPosition()
	{
		(int X, int Y) point = new TwoDPoint(100, 200);
		(int x, int _) = point; // _ discards the second deconstructed value from the tuple

		Assert.Equal(typeof(XPosition), x.GetType());
		Assert.Equal(100, x);
	}

	[Fact]
	public void Alias_AnyType_Deconstructed_YPosition_Recognized_as_XPosition()
	{
		(int X, int Y) point = new TwoDPoint(100, 200);
		(int _, int y) = point; // _ discards the first deconstructed value from the tuple

		// notice the problem here that even though the variable is the y position of the point
		//	it gets the type of XPosition - same for it not being recognized as an int!
		Assert.Equal(typeof(XPosition), y.GetType());
		Assert.Equal(200, y);
	}
}
