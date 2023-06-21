using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace practice_shop_api.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Value { get; set; }
		[JsonIgnore]
		[ForeignKey("SexId")]
		public int? SexId { get; set; }
		[JsonIgnore]
		public Sex? Sex { get; set; }
		public List<SubCategory> SubCategories { get; set; } = new();
	}
}
