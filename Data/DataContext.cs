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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region Category
			modelBuilder.Entity<Category>().HasData(
				new Category 
				{ 
					Id = 1,
					Name = "Верхняя одежда",
					//Value = "outerwear",
					SexId = 1,
				},
				new Category 
				{ 
					Id = 2,
					Name = "Джинсы и брюки",
					//Value = "jeans-and-pants",
					SexId = 1,
				},
				new Category 
				{ 
					Id = 3,
					Name = "Толстовки и свитеры",
					//Value = "sweatshirts-and-Sweaters",
					SexId = 1,
				},
				new Category 
				{ 
					Id = 4,
					Name = "Футболки и поло",
					//Value = "t-shirts-and-polos",
					SexId = 1,
				},
				new Category 
				{ 
					Id = 5,
					Name = "Верхняя одежда",
					//Value = "outerwear",
					SexId = 2,
				},
				new Category 
				{ 
					Id = 6,
					Name = "Платья и юбки",
					//Value = "dresses-and-Skirts",
					SexId = 2,
				},
				new Category 
				{ 
					Id = 7,
					Name = "Футболки и лонгсливы",
					//Value = "t-shirts-and-longsleeves",
					SexId = 2,
				}
			);
			#endregion

			#region SubCategory
			modelBuilder.Entity<SubCategory>().HasData(
				new SubCategory
				{
					Id = 1,
					Name = "Куртки",
					Value = "jackets",
					CategoryId = 1,
				},
				new SubCategory
				{
					Id = 2,
					Name = "Жилеты",
					Value = "vests",
					CategoryId = 1,
				},
				new SubCategory
				{
					Id = 3,
					Name = "Шорты",
					Value = "shorts",
					CategoryId = 2,
				},
				new SubCategory
				{
					Id = 4,
					Name = "Джинсы",
					Value = "jeans",
					CategoryId = 2,
				},
				new SubCategory
				{
					Id = 5,
					Name = "Свитшоты",
					Value = "sweatshirts",
					CategoryId = 3,
				},
				new SubCategory
				{
					Id = 6,
					Name = "Толстовки и худи",
					Value = "sweatshirts-and-hoodies",
					CategoryId = 3,
				},
				new SubCategory
				{
					Id = 7,
					Name = "Футболки",
					Value = "t-shirts",
					CategoryId = 4,
				},
				new SubCategory
				{
					Id = 8,
					Name = "Поло",
					Value = "polo",
					CategoryId = 4,
				},
				new SubCategory
				{
					Id = 9,
					Name = "Джинсовые куртки",
					Value = "denim-jackets",
					CategoryId = 5,
				},
				new SubCategory
				{
					Id = 10,
					Name = "Платья",
					Value = "dresses",
					CategoryId = 6,
				},
				new SubCategory
				{
					Id = 11,
					Name = "Юбки",
					Value = "skirts",
					CategoryId = 6,
				},
				new SubCategory
				{
					Id = 12,
					Name = "Футболки и топы",
					Value = "t-shirts",
					CategoryId = 7,
				},
				new SubCategory
				{
					Id = 13,
					Name = "Лонгсливы",
					Value = "longshirts",
					CategoryId = 7,
				}
			);
			#endregion

			#region Sex
			modelBuilder.Entity<Sex>().HasData(
				new Sex { Id = 1, Name = "Мужчинам" },
				new Sex { Id = 2, Name = "Женщинам" }
			);
			#endregion

			#region Products

			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 4921,
					Name = "Футболка 2",
					Description = "Данная модель изготовлена в рамках экологического проекта BE PART с наименьшим потреблением воды и энергии. Мы хотим сохранить природные ресурсы и помочь экологической среде нашей любимой планеты. Становись частью более устойчивого мира моды вместе с нами. ",
					Images = "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/3ec/3ec424de3f7e0e613f78fd67851a25a7/1037039_18395_1.jpg",
					Price = 1999,
					SexId = 2,
					SubCategoryId = 12,
					Color = "92B9BD",
					Size = "M"
				},
				new Product
				{
					Id = 1234,
					Name = "Футболка 1",
					Description = "Данная модель изготовлена в рамках экологического проекта BE PART с наименьшим потреблением воды и энергии. Мы хотим сохранить природные ресурсы и помочь экологической среде нашей любимой планеты. Становись частью более устойчивого мира моды вместе с нами. ",
					Images = "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/ee6/ee64195a4492cc765bfaa6119da51217/1037039_11052_1.jpg",
					Price = 2999,
					SexId = 2,
					SubCategoryId = 12,
					Color = "A8D4AD",
					Size = "S"
				},
				new Product
				{
					Id = 454,
					Name = "Футболка 3",
					Description = "Данная модель изготовлена в рамках экологического проекта BE PART с наименьшим потреблением воды и энергии. Мы хотим сохранить природные ресурсы и помочь экологической среде нашей любимой планеты. Становись частью более устойчивого мира моды вместе с нами. ",
					Images = "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/bc2/bc28e7519526032072f60b3bfaa610d0/1037039_10336_1.jpg",
					Price = 4999,
					SexId = 2,
					SubCategoryId = 12,
					Color = "F4EDED",
					Size = "L"
				},
				new Product
				{
					Id = 456456,
					Name = "Куртка 1",
					Description = "Джинсовая куртка женская - это универсальный предмет гардероба, не теряющий актуальность из сезона в сезон. Куртка джинсовая приталенного кроя защитит от ветра в прохладную погоду, а также будет уместна и теплым летним днем. Застежки на болтах смотрятся в классических традициях изделий из денима. Джинсовка выглядит оригинально благодаря контрастным манжетам с полосками. Два небольших накладных кармана имеют больше декоративную функцию, однако их можно использовать и для того, чтобы положить ключи или карту. Джинсовая куртка составит стильную пару джинсам в тон, любимой юбке, а также любым брюкам. Модель изготовлена из органического хлопка высокого качества.",
					Images = "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/3f5/3f5304c250c2ec3923109e74089a40e5/1016402_10142_1.jpg",
					Price = 7599,
					SexId = 2,
					SubCategoryId = 9,
					Color = "92B9BD",
					Size = "M"
				},
				new Product
				{
					Id = 49212134,
					Name = "Куртка 2",
					Description = "Джинсовая куртка женская - это универсальный предмет гардероба, не теряющий актуальность из сезона в сезон. Куртка джинсовая приталенного кроя защитит от ветра в прохладную погоду, а также будет уместна и теплым летним днем. Застежки на болтах смотрятся в классических традициях изделий из денима. Джинсовка выглядит оригинально благодаря контрастным манжетам с полосками. Два небольших накладных кармана имеют больше декоративную функцию, однако их можно использовать и для того, чтобы положить ключи или карту. Джинсовая куртка составит стильную пару джинсам в тон, любимой юбке, а также любым брюкам. Модель изготовлена из органического хлопка высокого качества.",
					Images = "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/e30/e3074e5662bc0dc63afc583aacb349ba/1016402_10120_1.jpeg",
					Price = 5599,
					SexId = 2,
					SubCategoryId = 9,
					Color = "000",
					Size = "L"
				},
				new Product
				{
					Id = 492113,
					Name = "ПЛАТЬЕ 2",
					Description = "",
					Images = "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/fcc/fcca1fb28ae94b78704110e800170581/1030959_10668_3.jpg",
					Price = 3599,
					SexId = 2,
					SubCategoryId = 10,
					Color = "000",
					Size = "L"
				},
				new Product
				{
					Id = 49232451,
					Name = "ПЛАТЬЕ 1",
					Description = "",
					Images = "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/6c1/6c15ce85bdeb1e5492d8fc12d768be11/1030959_11486_3.jpg",
					Price = 2999,
					SexId = 2,
					SubCategoryId = 10,
					Color = "F4EDED",
					Size = "M"
				},
				new Product
				{
					Id = 492169,
					Name = "Свободные джинсы прямого кроя 90's straight",
					Description = "",
					Images = "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/065/0651fc2c53e910aadef89048ac54fc32/1037113_10113_1.jpg",
					Price = 5599,
					SexId = 1,
					SubCategoryId = 4,
					Color = "92B9BD",
					Size = "M"
				},
				new Product
				{
					Id = 49215,
					Name = "Классические прямые джинсы облегающeго кроя Troy Slim",
					Description = "Без хороших базовых или однотонный джинсов не обойтись никак. Это основа буквально для каждого повседневного аутфита. Troy Slim – это классическая база джинсовой коллекции Tom Tailor, повторяющаяся из года в год. ",
					Images = "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/b31/b31c11d04461b702bdf524d6d7db96cc/1.jpg",
					Price = 6599,
					SexId = 1,
					SubCategoryId = 4,
					Color = "000",
					Size = "M"
				}
			);

			#endregion

			#region Sizes

			modelBuilder.Entity<Size>().HasData(
				new Size { Id = 1, Name = "XXS" },
				new Size { Id = 2, Name = "XS" },
				new Size { Id = 3, Name = "S" },
				new Size { Id = 4, Name = "M" },
				new Size { Id = 5, Name = "L" },
				new Size { Id = 6, Name = "XL" },
				new Size { Id = 7, Name = "XXL" },
				new Size { Id = 8, Name = "XXXL" }
			);

			#endregion

			#region Colors

			modelBuilder.Entity<Color>().HasData(
				new Color { Id = 1, Name = "Коричневый", Value = "967D69" },
				new Color { Id = 2, Name = "Голубой", Value = "92B9BD" },
				new Color { Id = 3, Name = "Зеленый", Value = "A8D4AD" },
				new Color { Id = 4, Name = "Желтый", Value = "F9DB6D" },
				new Color { Id = 5, Name = "Белый", Value = "F4EDED" },
				new Color { Id = 6, Name = "Серый", Value = "7C7C7C" },
				new Color { Id = 7, Name = "Черный", Value = "000" }
			);

			#endregion
		}
	}
}
