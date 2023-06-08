using System.Text.Json.Serialization;

namespace practice_shop_api.Models
{
	public class Sex
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		[JsonIgnore]
		public List<Category> Categories{ get; set; } = new();
		[JsonIgnore]
		public List<SubCategory> SubCategories { get; set; } = new();
		[JsonIgnore]
		public List<Product> Products { get; set; } = new();
	}
}
