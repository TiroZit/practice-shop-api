using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace practice_shop_api.Models
{
	public class SubCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		[ForeignKey("SexId")]
		public int SexId { get; set; }
		public Sex Sex { get; set; }
		[JsonIgnore]
		public List<Product> Products { get; set; }
	}
}
