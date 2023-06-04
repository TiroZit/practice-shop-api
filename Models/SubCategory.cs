namespace practice_shop_api.Models
{
	public class SubCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int SexId { get; set; }
		public Sex Sex { get; set; }
		public List<Product> Products { get; set; }
	}
}
