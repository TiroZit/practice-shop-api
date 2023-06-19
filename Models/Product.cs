using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace practice_shop_api.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public int Price { get; set; }
		public string? Images { get; set; }
		public string? Size { get; set; }
		public string? Color { get; set; }
		[ForeignKey("SizeId")]
		public Size? Sizes { get; set; }
		[ForeignKey("ColorId")]
		public Color? Colors { get; set; }
		public int? SexId { get; set; }
		[ForeignKey("SexId")]
		public Sex? Sex { get; set; }
		public int? SubCategoryId { get; set; }
		[ForeignKey("SubCategoryId")]
		public SubCategory? SubCategory { get; set; }
	}
}
