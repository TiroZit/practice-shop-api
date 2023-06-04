namespace practice_shop_api.Models
{
	public class Product
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; } = 0;
        public string[] Images { get; set; }
        public List<Size> Sizes { get; set; }
        public List<Color> Colors { get; set; }
        public int SexId { get; set; }
        public Sex Sex { get; set; }
		public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
