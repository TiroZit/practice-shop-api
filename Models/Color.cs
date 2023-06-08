using System.Text.Json.Serialization;

namespace practice_shop_api.Models
{
	public class Color
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Value { get; set; }
		[JsonIgnore]
		public List<Product> Products { get; set; } = new();
	}
}
