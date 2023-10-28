using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoviePosterUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieTrailerUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductionYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImdbRating = table.Column<double>(type: "float", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("073d0718-7198-495e-8bfc-282b3f312b87"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1395), null, false, null, "Bilim Kurgu" },
                    { new Guid("0f38e399-7019-4624-b05a-1a84a18e1d81"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1424), null, false, null, "Reality" },
                    { new Guid("0fe82780-5694-4810-8109-b2d81997b828"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1403), null, false, null, "Fantastik" },
                    { new Guid("12367738-4c57-4874-a1b6-eebccfe9aba8"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1412), null, false, null, "Korku" },
                    { new Guid("12f37527-8d1b-4a9b-8ec9-77cbd37bb086"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1416), null, false, null, "Müzik" },
                    { new Guid("1370f594-9ef7-4cc5-95b7-2380b4c9b2d9"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1410), null, false, null, "Komedi" },
                    { new Guid("1b01fc9e-ef99-43aa-8557-d70897d141dd"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1414), null, false, null, "Macera" },
                    { new Guid("2ba27383-5595-46bb-a4c7-0bf1393004a8"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1388), null, false, null, "Aksiyon" },
                    { new Guid("2fbe1558-2569-4a46-8c9a-2ee757fb1573"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1406), null, false, null, "Gerilim" },
                    { new Guid("4ab0190f-a4d4-49e8-8ac3-718481aa2a89"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1436), null, false, null, "Suç" },
                    { new Guid("517fdb38-4526-4136-b04e-f44da166eb0d"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1391), null, false, null, "Animasyon" },
                    { new Guid("541626c9-d0d2-491b-a8a8-adde6198b7cd"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1432), null, false, null, "Kısa Film" },
                    { new Guid("62d09be1-7149-4323-91b8-920f0e73b994"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1397), null, false, null, "Biyografi" },
                    { new Guid("6d0f565d-d05a-45d2-9475-f8d1f6ad1cd5"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1421), null, false, null, "Polisiye" },
                    { new Guid("6f91d7ca-cc5a-47cd-9b19-58806496f045"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1408), null, false, null, "Gizem" },
                    { new Guid("91f14291-3c71-44da-8a4e-ca44f7a82c76"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1439), null, false, null, "StandUp" },
                    { new Guid("96f76275-6eae-4f1d-a779-e2081708dbaf"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1401), null, false, null, "Dram" },
                    { new Guid("9ee74f9e-e752-4876-92a6-7612faa21125"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1393), null, false, null, "Belgesel" },
                    { new Guid("c7571c9a-a959-47d8-b3ea-ded35bb1ca91"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1428), null, false, null, "Savaş" },
                    { new Guid("d1eec22c-a829-41be-be4b-5a2c15dbc4ab"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1434), null, false, null, "Spor" },
                    { new Guid("d2dbfcc0-a9f5-4008-8613-9f4f5086307d"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1426), null, false, null, "Romantik" },
                    { new Guid("d5b3a8c5-f8dc-4495-b90f-d41ea9985878"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1430), null, false, null, "Bilim Kurgu" },
                    { new Guid("ed6396fd-4fe3-4b75-b585-d10b933a4c51"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1441), null, false, null, "Tarih" },
                    { new Guid("f88e8486-c147-44bc-8c98-a5bd9ae98d86"), new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1443), null, false, null, "Western" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cast", "CategoryId", "Country", "CreatedDate", "DeletedDate", "Description", "Director", "ImdbRating", "IsDeleted", "ModifiedDate", "MovieDuration", "MoviePosterUrl", "MovieTrailerUrl", "MovieUrl", "Name", "ProductionYear" },
                values: new object[,]
                {
                    { new Guid("18fa548f-94e5-4a8c-bd07-65c7ba61cd2e"), "Matthew McConaughey, Anne Hathaway", new Guid("d5b3a8c5-f8dc-4495-b90f-d41ea9985878"), "ABD", new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1271), null, "Yakın bir gelecekte, dünya yaşanmaz hale gelmiştir. Cooper adlı astronot, yeni bir yaşanabilir gezegen arayışına çıkar ve zaman ile uzay arasındaki sırları keşfeder.", "Christopher Nolan", 8.5999999999999996, false, null, "2 saat 49 dakika", "https://m.media-amazon.com/images/M/MV5BZjdkOTU3MDktN2IxOS00OGEyLWFmMjktY2FiMmZkNWIyODZiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg", "https://youtu.be/zSWdZVtXT7E", null, "Interstellar", "2014" },
                    { new Guid("320b4694-9dd1-432f-9cac-c0bf193ef68f"), "Edward Norton, Brad Pitt", new Guid("96f76275-6eae-4f1d-a779-e2081708dbaf"), "ABD", new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1249), null, "Sıradan bir ofis çalışanı, karizmatik bir yabancıyla tanışarak hayatını değiştiren bir yeraltı dövüş kulübünü kurar.", "David Fincher", 8.8000000000000007, false, null, "2 saat 19 dakika", "https://m.media-amazon.com/images/M/MV5BODQ0OWJiMzktYjNlYi00MzcwLThlZWMtMzRkYTY4ZDgxNzgxXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg", "https://youtu.be/BdJKm16Co6M", null, "Fight Club", "1999" },
                    { new Guid("46747148-7742-49d3-bc47-7b64dcfdefad"), "Leonardo DiCaprio, Joseph Gordon-Levitt", new Guid("d5b3a8c5-f8dc-4495-b90f-d41ea9985878"), "ABD", new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1252), null, "Dom Cobb, insanların rüyalarına girme yeteneği olan bir hırsızdır. Tehlikeli bir iş teklifi alır ve zihin çalma sanatını kullanarak karmaşık bir soygun planlar.", "Christopher Nolan", 8.8000000000000007, false, null, "2 saat 28 dakika", "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg", "https://youtu.be/YoHD9XEInc0", null, "Inception", "2010" },
                    { new Guid("7644d8bb-e3d9-423e-be5e-fd4c1138d7d0"), "Cary Elwes, Leigh Whannell", new Guid("12367738-4c57-4874-a1b6-eebccfe9aba8"), "ABD", new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1278), null, "Bir dizi karmaşık ve ölümcül oyunlarla dolu bir labirentte uyanan iki yabancı, korkunç bir sırrı çözmeye çalışır.", "James Wan", 7.5999999999999996, false, null, "1 saat 43 dakika", "https://m.media-amazon.com/images/M/MV5BM2M1MzI1MWYtYmM2ZC00OWY3LTk0ZGMtNmRkNzU1NzEzMWE5XkEyXkFqcGdeQXVyODUwOTkwODk@._V1_FMjpg_UX1000_.jpg", "https://youtu.be/S-1QgOMQ-ls", null, "Saw", "2004" },
                    { new Guid("c2ac8ca6-0f24-4553-b4b0-11176cada194"), "Leonardo DiCaprio, Jonah Hill", new Guid("4ab0190f-a4d4-49e8-8ac3-718481aa2a89"), "ABD", new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1273), null, "Jordan Belfort, finans dünyasının en ünlü dolandırıcısıdır. Zenginlik ve lüksün doruklarına tırmanırken yasadışı yollarla servet kazanır.", "Martin Scorsese", 8.1999999999999993, false, null, "3 saat", "https://m.media-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_FMjpg_UX1000_.jpg", "https://youtu.be/iszwuX1AK6A", null, "The Wolf of Wall Street", "2013" },
                    { new Guid("f6ec2a92-e085-4fbc-abb4-a62038867165"), "Tim Robbins, Morgan Freeman", new Guid("96f76275-6eae-4f1d-a779-e2081708dbaf"), "ABD", new DateTime(2023, 9, 13, 23, 55, 20, 221, DateTimeKind.Local).AddTicks(1219), null, "Andy Dufresne, haksız yere hüküm giydiği Shawshank hapishanesinde yaşamını sürdürmeye çalışırken, dostluğun ve umudun gücünü keşfeder.", "Frank Darabont", 9.3000000000000007, false, null, "2 saat 22 dakika", "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg", "https://youtu.be/PLl99DlL6b4", null, "The Shawshank Redemption", "1994" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
