using Microsoft.EntityFrameworkCore;
using practice_shop_api.Models;

namespace practice_shop_api.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Category> Categories { get; set; }
		public DbSet<SubCategory> SubCategories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Sex> Sexs { get; set; }
		public DbSet<Size> Sizes { get; set; }
		public DbSet<Color> Colors { get; set; }
	}
}
