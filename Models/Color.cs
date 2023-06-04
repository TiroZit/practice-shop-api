namespace practice_shop_api.Models
{
	public class Color
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Value { get; set; }
		public List<Product> Products { get; set; }
	}
}
