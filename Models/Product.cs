using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace practice_shop_api.Models
{
	public class Product
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public int Price { get; set; }
		public string? Images { get; set; }
		[JsonIgnore]
		public List<Size> Sizes { get; set; } = new();
		[JsonIgnore]
		public List<Color> Colors { get; set; } = new();
		public int? SexId { get; set; }
		[ForeignKey("SexId")]
		public Sex? Sex { get; set; }
		public int? SubCategoryId { get; set; }
		[ForeignKey("SubCategoryId")]
		public SubCategory? SubCategory { get; set; }
	}
}
