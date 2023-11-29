namespace CSharpTesting.CSharp09
{
	public record RecordExample
	{
		public RecordExample() { }

		public RecordExample(int id, string name, decimal price, string? description = "NOT_SET")
		{
			Id = id;
			Name = name;
			Price = price;
			Description = description;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string? Description { get; set; }
	}
}
