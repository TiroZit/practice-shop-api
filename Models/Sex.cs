using System.Text.Json.Serialization;

namespace practice_shop_api.Models
{
	public class Sex
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public List<Category> Categories{ get; set; } = new();
	}
}
