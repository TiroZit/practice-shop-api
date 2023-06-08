using System.Text.Json.Serialization;

namespace practice_shop_api.Models
{
	public class Size
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		[JsonIgnore]
		public List<Product> Products { get; set; } = new();
	}
}
