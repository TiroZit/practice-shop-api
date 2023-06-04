namespace practice_shop_api.Models
{
	public class Sex
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Category> Categories{ get; set; }
		public List<SubCategory> SubCategories { get; set; }
		public List<Product> Products { get; set; }
	}
}
