using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace practice_shop_api.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sexs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SexId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Sexs_SexId",
                        column: x => x.SexId,
                        principalTable: "Sexs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SexId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubCategories_Sexs_SexId",
                        column: x => x.SexId,
                        principalTable: "Sexs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    SexId = table.Column<int>(type: "int", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Sexs_SexId",
                        column: x => x.SexId,
                        principalTable: "Sexs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Коричневый", "967D69" },
                    { 2, "Голубой", "92B9BD" },
                    { 3, "Зеленый", "A8D4AD" },
                    { 4, "Желтый", "F9DB6D" },
                    { 5, "Белый", "F4EDED" },
                    { 6, "Серый", "7C7C7C" },
                    { 7, "Черный", "000" }
                });

            migrationBuilder.InsertData(
                table: "Sexs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Мужчинам" },
                    { 2, "Женщинам" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "XXS" },
                    { 2, "XS" },
                    { 3, "S" },
                    { 4, "M" },
                    { 5, "L" },
                    { 6, "XL" },
                    { 7, "XXL" },
                    { 8, "XXXL" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "SexId" },
                values: new object[,]
                {
                    { 1, "Верхняя одежда", 1 },
                    { 2, "Джинсы и брюки", 1 },
                    { 3, "Толстовки и свитеры", 1 },
                    { 4, "Футболки и поло", 1 },
                    { 5, "Верхняя одежда", 2 },
                    { 6, "Платья и юбки", 2 },
                    { 7, "Футболки и лонгсливы", 2 }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name", "SexId" },
                values: new object[,]
                {
                    { 1, 1, "Куртки", null },
                    { 2, 1, "Жилеты", null },
                    { 3, 2, "Шорты", null },
                    { 4, 2, "Джинсы", null },
                    { 5, 3, "Свитшоты", null },
                    { 6, 3, "Толстовки и худи", null },
                    { 7, 4, "Футболки", null },
                    { 8, 4, "Поло", null },
                    { 9, 5, "Джинсовые куртки", null },
                    { 10, 6, "Платья", null },
                    { 11, 6, "Юбки", null },
                    { 12, 7, "Футболки и топы", null },
                    { 13, 7, "Лонгсливы", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "ColorId", "Description", "Images", "Name", "Price", "SexId", "Size", "SizeId", "SubCategoryId" },
                values: new object[,]
                {
                    { 454, "F4EDED", null, "Данная модель изготовлена в рамках экологического проекта BE PART с наименьшим потреблением воды и энергии. Мы хотим сохранить природные ресурсы и помочь экологической среде нашей любимой планеты. Становись частью более устойчивого мира моды вместе с нами. ", "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/bc2/bc28e7519526032072f60b3bfaa610d0/1037039_10336_1.jpg", "Футболка 3", 4999, 2, "L", null, 12 },
                    { 1234, "A8D4AD", null, "Данная модель изготовлена в рамках экологического проекта BE PART с наименьшим потреблением воды и энергии. Мы хотим сохранить природные ресурсы и помочь экологической среде нашей любимой планеты. Становись частью более устойчивого мира моды вместе с нами. ", "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/ee6/ee64195a4492cc765bfaa6119da51217/1037039_11052_1.jpg", "Футболка 1", 2999, 2, "S", null, 12 },
                    { 4921, "92B9BD", null, "Данная модель изготовлена в рамках экологического проекта BE PART с наименьшим потреблением воды и энергии. Мы хотим сохранить природные ресурсы и помочь экологической среде нашей любимой планеты. Становись частью более устойчивого мира моды вместе с нами. ", "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/3ec/3ec424de3f7e0e613f78fd67851a25a7/1037039_18395_1.jpg", "Футболка 2", 1999, 2, "M", null, 12 },
                    { 49215, "000", null, "Без хороших базовых или однотонный джинсов не обойтись никак. Это основа буквально для каждого повседневного аутфита. Troy Slim – это классическая база джинсовой коллекции Tom Tailor, повторяющаяся из года в год. ", "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/b31/b31c11d04461b702bdf524d6d7db96cc/1.jpg", "Классические прямые джинсы облегающeго кроя Troy Slim", 6599, 1, "M", null, 4 },
                    { 456456, "92B9BD", null, "Джинсовая куртка женская - это универсальный предмет гардероба, не теряющий актуальность из сезона в сезон. Куртка джинсовая приталенного кроя защитит от ветра в прохладную погоду, а также будет уместна и теплым летним днем. Застежки на болтах смотрятся в классических традициях изделий из денима. Джинсовка выглядит оригинально благодаря контрастным манжетам с полосками. Два небольших накладных кармана имеют больше декоративную функцию, однако их можно использовать и для того, чтобы положить ключи или карту. Джинсовая куртка составит стильную пару джинсам в тон, любимой юбке, а также любым брюкам. Модель изготовлена из органического хлопка высокого качества.", "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/3f5/3f5304c250c2ec3923109e74089a40e5/1016402_10142_1.jpg", "Куртка 1", 7599, 2, "M", null, 9 },
                    { 492113, "000", null, "", "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/fcc/fcca1fb28ae94b78704110e800170581/1030959_10668_3.jpg", "ПЛАТЬЕ 2", 3599, 2, "L", null, 10 },
                    { 492169, "92B9BD", null, "", "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/065/0651fc2c53e910aadef89048ac54fc32/1037113_10113_1.jpg", "Свободные джинсы прямого кроя 90's straight", 5599, 1, "M", null, 4 },
                    { 49212134, "000", null, "Джинсовая куртка женская - это универсальный предмет гардероба, не теряющий актуальность из сезона в сезон. Куртка джинсовая приталенного кроя защитит от ветра в прохладную погоду, а также будет уместна и теплым летним днем. Застежки на болтах смотрятся в классических традициях изделий из денима. Джинсовка выглядит оригинально благодаря контрастным манжетам с полосками. Два небольших накладных кармана имеют больше декоративную функцию, однако их можно использовать и для того, чтобы положить ключи или карту. Джинсовая куртка составит стильную пару джинсам в тон, любимой юбке, а также любым брюкам. Модель изготовлена из органического хлопка высокого качества.", "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/e30/e3074e5662bc0dc63afc583aacb349ba/1016402_10120_1.jpeg", "Куртка 2", 5599, 2, "L", null, 9 },
                    { 49232451, "F4EDED", null, "", "https://upload-96d5e9c2a2fefe65127343db553761dc.storage.yandexcloud.net/iblock/6c1/6c15ce85bdeb1e5492d8fc12d768be11/1030959_11486_3.jpg", "ПЛАТЬЕ 1", 2999, 2, "M", null, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SexId",
                table: "Categories",
                column: "SexId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SexId",
                table: "Products",
                column: "SexId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_SexId",
                table: "SubCategories",
                column: "SexId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sexs");
        }
    }
}
