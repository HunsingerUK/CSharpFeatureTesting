namespace Features.CSharp12.AliasAnyTypeFeature;

using Point = (int X, int Y);

public class Grid
{
	public List<Point> Points { get; set; } = [];

	public void AddPoint (Point point)
	{
		Points.Add (point);
	}

	public void RemovePoint (Point point)
	{
		Points.Remove (point);
	}
}
