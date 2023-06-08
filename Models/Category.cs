using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace practice_shop_api.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public int? SexId { get; set; }
		[ForeignKey("SexId")]
		public Sex? Sex { get; set; }
		[JsonIgnore]
		public List<SubCategory> SubCategories { get; set; } = new();
	}
}
