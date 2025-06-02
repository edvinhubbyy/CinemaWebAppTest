using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CinemaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class MoviesSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ImageUrl", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("08916a91-81e7-425a-bf7a-0b984e700e38"), "The story of Forrest Gump, a man with a low IQ, whose kind heart shapes the lives of those around him.", "Robert Zemeckis", 142, "Drama", "https://www.movieposters.com/cdn/shop/products/forrest-gump---24x36_480x.progressive.jpg?v=1645558337", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump" },
                    { new Guid("09456213-94a2-4a09-9216-86757c792a74"), "A young FBI cadet must confide in an incarcerated cannibal to catch another serial killer.", "Jonathan Demme", 118, "Thriller", "https://www.movieposters.com/cdn/shop/products/The_Silence_of_the_Lambs_Movie_Poster_480x.progressive.jpg?v=1707410734", new DateTime(1991, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Silence of the Lambs" },
                    { new Guid("09f0ddfa-98ff-4ce2-97ec-eabd1e89f6ca"), "A betrayed Roman general seeks revenge against the corrupt emperor who murdered his family and sent him into     slavery.", "Ridley Scott", 155, "Action", "https://www.movieposters.com/cdn/shop/files/Gladiator.mpw.102813_480x.progressive.jpg?v=1707500493", new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiator" },
                    { new Guid("13d3e604-9d3f-4a65-96ac-b435e376a470"), "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.", "Francis Ford Coppola", 175, "Crime", "https://www.movieposters.com/cdn/shop/products/b5282f72126e4919911509e034a61f66_6ce2486d-   e0da-4b7a-9148-722cdde610b8_480x.progressive.jpg?v=1573616025", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { new Guid("13f493c3-790f-4552-8d34-1e7b2a8d2aaf"), "The lives of two mob hitmen, a boxer, and others intertwine in a series of unexpected incidents.", "Quentin Tarantino", 154, "Crime", "https://www.movieposters.com/cdn/shop/products/pulpfiction.2436_480x.progressive.jpg?v=1620048742", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" },
                    { new Guid("1533e58e-6da4-47eb-9013-2bf82ec42351"), "A group of intergalactic criminals must work together to stop a fanatical warrior from taking control of the     universe.", "James Gunn", 121, "Action", "https://www.movieposters.com/cdn/shop/products/guardiansofthegalaxy.24x36_480x.progressive.jpg?v=1707410763", new DateTime(2014, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guardians of the Galaxy" },
                    { new Guid("159c21f2-0e63-46f2-967a-bdc1e3720b4c"), "Earth's mightiest heroes must come together to stop a mischievous Loki and his alien army.", "Joss Whedon", 143, "Action", "https://www.movieposters.com/cdn/shop/files/avengers.24x36_480x.progressive.jpg?v=1707410714", new DateTime(2012, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Avengers" },
                    { new Guid("15c98ef8-3c66-42ef-8eca-76b73d0434fb"), "An insomniac office worker and a soap maker form an underground fight club.", "David Fincher", 139, "Drama", "https://www.movieposters.com/cdn/shop/products/fightclub.24x36_480x.progressive.jpg?v=1707410744", new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club" },
                    { new Guid("1616d7d0-e9e9-4d01-a323-af6a76b6bb26"), "Two magicians engage in a bitter rivalry with deadly consequences.", "Christopher Nolan", 130, "Mystery", "https://www.movieposters.com/cdn/shop/products/the-prestige-24x36_480x.progressive.jpg?v=1707410754", new DateTime(2006, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Prestige" },
                    { new Guid("1eb2e86c-ba5c-42c4-8b52-c37675463918"), "An insomniac office worker and a soap maker form an underground fight club.", "David Fincher", 139, "Drama", "https://www.movieposters.com/cdn/shop/products/fightclub.24x36_480x.progressive.jpg?v=1707410744", new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club" },
                    { new Guid("1ebd874f-ec2d-42f7-859a-73224c5395e4"), "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, and others to save the galaxy from the Empire's   world-destroying weapon.", "George Lucas", 121, "Sci-Fi", "https://www.movieposters.com/cdn/shop/products/starwars-episode-iv_480x.progressive.jpg?v=1707410770", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode IV - A New Hope" },
                    { new Guid("21b11216-4b90-465f-a278-5f5a65c61e88"), "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the ill-fated R.M.S. Titanic.", "James Cameron", 195, "Romance", "https://www.movieposters.com/cdn/shop/files/titanic.24x36_480x.progressive.jpg?v=1707410721", new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titanic" },
                    { new Guid("34cdc33d-1055-43e3-a1a7-6f9547f28927"), "With the help of a bounty hunter, a freed slave sets out to rescue his wife from a brutal plantation owner.", "Quentin Tarantino", 165, "Western", "https://www.movieposters.com/cdn/shop/products/djangounchained.24x36_480x.progressive.jpg?v=1707410784", new DateTime(2012, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Django Unchained" },
                    { new Guid("35e6a5fd-089b-4e63-9515-9d61774902dc"), "A paraplegic Marine dispatched to the moon Pandora becomes torn between following orders and protecting his home.", "James Cameron", 162, "Sci-Fi", "https://www.movieposters.com/cdn/shop/files/avatar.adv.24x36_480x.progressive.jpg?v=1707410703", new DateTime(2009, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar" },
                    { new Guid("37ab596c-7547-477c-b68a-5948363f14bf"), "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.", "Francis Ford Coppola", 175, "Crime", "https://www.movieposters.com/cdn/shop/products/b5282f72126e4919911509e034a61f66_6ce2486d-   e0da-4b7a-9148-722cdde610b8_480x.progressive.jpg?v=1573616025", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { new Guid("3d8a1587-ff50-4076-8179-98e71ac0796a"), "During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run  amok.", "Steven Spielberg", 127, "Adventure", "https://www.movieposters.com/cdn/shop/files/jurassic-park-1_480x.progressive.jpg?v=1708686293", new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jurassic Park" },
                    { new Guid("415c94e9-fb91-429e-9aef-7356ea45d337"), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", "Christopher Nolan", 169, "Adventure", "https://www.movieposters.com/cdn/shop/files/interstellar-139399_480x.progressive.jpg?v=1708527823", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" },
                    { new Guid("42f05318-ed1a-415c-baac-d78bd71fa774"), "A paraplegic Marine dispatched to the moon Pandora becomes torn between following orders and protecting his home.", "James Cameron", 162, "Sci-Fi", "https://www.movieposters.com/cdn/shop/files/avatar.adv.24x36_480x.progressive.jpg?v=1707410703", new DateTime(2009, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar" },
                    { new Guid("4597842b-aeae-4133-89e2-c083917cf8d9"), "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper.", "Steven Spielberg", 169, "War", "https://www.movieposters.com/cdn/shop/products/saving-private-ryan-24x36_480x.progressive.jpg?v=1707410738", new DateTime(1998, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saving Private Ryan" },
                    { new Guid("48dfe47e-6f93-4b6e-969f-43d39d81d44c"), "A lion prince flees his kingdom after the death of his father, only to learn the true meaning of responsibility and  bravery.", "Roger Allers, Rob Minkoff", 88, "Animation", "https://www.movieposters.com/cdn/shop/files/the-lion-king_273b54a5_480x.progressive.jpg?v=1725905168", new DateTime(1994, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lion King" },
                    { new Guid("4cd95d91-6d2b-4a74-b2e2-aec46b028f3f"), "A businessman saves the lives of hundreds of Jews during the Holocaust by employing them in his factories.", "Steven Spielberg", 195, "Drama", "https://www.movieposters.com/cdn/shop/products/9a1f9ea4a27071481cc1263e3ea11f7b_7bdb2deb-dd50-41b5- beab-8fc1cb3c895d_480x.progressive.jpg?v=1573651233", new DateTime(1993, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List" },
                    { new Guid("59562e20-dd38-4dd0-833c-4fe11cf29451"), "Two magicians engage in a bitter rivalry with deadly consequences.", "Christopher Nolan", 130, "Mystery", "https://www.movieposters.com/cdn/shop/products/the-prestige-24x36_480x.progressive.jpg?v=1707410754", new DateTime(2006, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Prestige" },
                    { new Guid("62485b6c-11d3-4b9c-bbef-d51582a07039"), "A lion prince flees his kingdom after the death of his father, only to learn the true meaning of responsibility and  bravery.", "Roger Allers, Rob Minkoff", 88, "Animation", "https://www.movieposters.com/cdn/shop/files/the-lion-king_273b54a5_480x.progressive.jpg?v=1725905168", new DateTime(1994, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lion King" },
                    { new Guid("68af2aab-4a35-42d6-8a23-bd86834d723e"), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", "Christopher Nolan", 169, "Adventure", "https://www.movieposters.com/cdn/shop/files/interstellar-139399_480x.progressive.jpg?v=1708527823", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" },
                    { new Guid("7a9f8ec8-63ef-4777-a7e3-236c8443d836"), "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, and others to save the galaxy from the Empire's   world-destroying weapon.", "George Lucas", 121, "Sci-Fi", "https://www.movieposters.com/cdn/shop/products/starwars-episode-iv_480x.progressive.jpg?v=1707410770", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode IV - A New Hope" },
                    { new Guid("8799f03d-c7a2-49f1-bcb3-a4213dd65b07"), "A group of intergalactic criminals must work together to stop a fanatical warrior from taking control of the     universe.", "James Gunn", 121, "Action", "https://www.movieposters.com/cdn/shop/products/guardiansofthegalaxy.24x36_480x.progressive.jpg?v=1707410763", new DateTime(2014, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guardians of the Galaxy" },
                    { new Guid("89d4998c-461f-4ce2-ae91-fcddc7f4f1e8"), "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of decency.", "Frank Darabont", 142, "Drama", "https://www.movieposters.com/cdn/shop/files/shawshank_eb84716b-efa9-44dc-a19d-c17924a3f7df_480x.progressive.jpg?    v=1709821984", new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption" },
                    { new Guid("97409530-7a89-4c7c-bd5e-e85592caa0fd"), "A computer hacker learns the shocking truth about the reality he lives in and joins a rebellion.", "The Wachowskis", 136, "Sci-Fi", "https://www.movieposters.com/cdn/shop/files/Matrix.mpw.102176_bb2f6cc5-4a16-4512-881b-  f855ead3c8ec_480x.progressive.jpg?v=1708703624", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { new Guid("9d2d04a3-cef8-4d46-9fde-b253efc65253"), "During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run  amok.", "Steven Spielberg", 127, "Adventure", "https://www.movieposters.com/cdn/shop/files/jurassic-park-1_480x.progressive.jpg?v=1708686293", new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jurassic Park" },
                    { new Guid("a9c0dfda-a835-41fc-ade9-8d5da156e03e"), "Batman faces the Joker, a criminal mastermind bent on causing chaos in Gotham City.", "Christopher Nolan", 152, "Action", "https://www.movieposters.com/cdn/shop/files/darkknight.building.24x36_20e90057- f673-4cc3-9ce7-7b0d3eeb7d83_480x.progressive.jpg?v=1707491191", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { new Guid("b598840f-334b-478d-9afe-23674d2fd5df"), "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the ill-fated R.M.S. Titanic.", "James Cameron", 195, "Romance", "https://www.movieposters.com/cdn/shop/files/titanic.24x36_480x.progressive.jpg?v=1707410721", new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titanic" },
                    { new Guid("b9f610d4-88ab-4371-9f33-bbd1d768146b"), "Batman faces the Joker, a criminal mastermind bent on causing chaos in Gotham City.", "Christopher Nolan", 152, "Action", "https://www.movieposters.com/cdn/shop/files/darkknight.building.24x36_20e90057- f673-4cc3-9ce7-7b0d3eeb7d83_480x.progressive.jpg?v=1707491191", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { new Guid("bb478a09-eeb7-41ee-9441-82c1fd0b6b80"), "The lives of two mob hitmen, a boxer, and others intertwine in a series of unexpected incidents.", "Quentin Tarantino", 154, "Crime", "https://www.movieposters.com/cdn/shop/products/pulpfiction.2436_480x.progressive.jpg?v=1620048742", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" },
                    { new Guid("bc61e67d-3d38-4d8e-8413-66ad1c9ac320"), "A betrayed Roman general seeks revenge against the corrupt emperor who murdered his family and sent him into     slavery.", "Ridley Scott", 155, "Action", "https://www.movieposters.com/cdn/shop/files/Gladiator.mpw.102813_480x.progressive.jpg?v=1707500493", new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiator" },
                    { new Guid("bfd11aad-df32-42cf-a5bc-fefa8761cfa8"), "A skilled thief is given a chance at redemption if he can successfully perform an inception on a target's mind.", "Christopher Nolan", 148, "Sci-Fi", "https://cdn.shopify.com/s/files/1/0057/3728/3618/files/inception.mpw.123395_9e0000d1-bc7f-400a- b488-15fa9e60a10c_500x749.jpg?v=1708527589", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { new Guid("c252982a-da71-44c1-84b7-44e1a8375c84"), "A young FBI cadet must confide in an incarcerated cannibal to catch another serial killer.", "Jonathan Demme", 118, "Thriller", "https://www.movieposters.com/cdn/shop/products/The_Silence_of_the_Lambs_Movie_Poster_480x.progressive.jpg?v=1707410734", new DateTime(1991, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Silence of the Lambs" },
                    { new Guid("c7a04b89-a363-438f-b516-45d8260687c8"), "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper.", "Steven Spielberg", 169, "War", "https://www.movieposters.com/cdn/shop/products/saving-private-ryan-24x36_480x.progressive.jpg?v=1707410738", new DateTime(1998, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saving Private Ryan" },
                    { new Guid("c9a04471-ddd6-44cf-a061-76eeb2aa007c"), "A skilled thief is given a chance at redemption if he can successfully perform an inception on a target's mind.", "Christopher Nolan", 148, "Sci-Fi", "https://cdn.shopify.com/s/files/1/0057/3728/3618/files/inception.mpw.123395_9e0000d1-bc7f-400a- b488-15fa9e60a10c_500x749.jpg?v=1708527589", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { new Guid("c9d8efbe-a9b4-4dca-88d5-49efb4e9cc5c"), "With the help of a bounty hunter, a freed slave sets out to rescue his wife from a brutal plantation owner.", "Quentin Tarantino", 165, "Western", "https://www.movieposters.com/cdn/shop/products/djangounchained.24x36_480x.progressive.jpg?v=1707410784", new DateTime(2012, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Django Unchained" },
                    { new Guid("cc438584-3c7e-48d4-9dcc-eb13c37220f2"), "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang.", "Martin Scorsese", 151, "Crime", "https://www.movieposters.com/cdn/shop/products/thedeparted.24x36_480x.progressive.jpg?v=1707410777", new DateTime(2006, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Departed" },
                    { new Guid("cd2e4303-c313-4af1-bda1-829f152b2fa1"), "T'Challa returns home to Wakanda to take his throne but faces challenges from a rival claimant.", "Ryan Coogler", 134, "Action", "https://www.movieposters.com/cdn/shop/products/blackpanther.24x36_480x.progressive.jpg?v=1707410790", new DateTime(2018, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Panther" },
                    { new Guid("db679cf5-844b-4489-b846-8c772ed59d96"), "T'Challa returns home to Wakanda to take his throne but faces challenges from a rival claimant.", "Ryan Coogler", 134, "Action", "https://www.movieposters.com/cdn/shop/products/blackpanther.24x36_480x.progressive.jpg?v=1707410790", new DateTime(2018, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Panther" },
                    { new Guid("dfa76ab8-bc25-488f-810c-5567eae15b63"), "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang.", "Martin Scorsese", 151, "Crime", "https://www.movieposters.com/cdn/shop/products/thedeparted.24x36_480x.progressive.jpg?v=1707410777", new DateTime(2006, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Departed" },
                    { new Guid("e6316357-ffa9-4584-bb59-179b7f98b92a"), "The story of Forrest Gump, a man with a low IQ, whose kind heart shapes the lives of those around him.", "Robert Zemeckis", 142, "Drama", "https://www.movieposters.com/cdn/shop/products/forrest-gump---24x36_480x.progressive.jpg?v=1645558337", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump" },
                    { new Guid("e663e4d5-b828-4c21-b73c-034de46428d8"), "A businessman saves the lives of hundreds of Jews during the Holocaust by employing them in his factories.", "Steven Spielberg", 195, "Drama", "https://www.movieposters.com/cdn/shop/products/9a1f9ea4a27071481cc1263e3ea11f7b_7bdb2deb-dd50-41b5- beab-8fc1cb3c895d_480x.progressive.jpg?v=1573651233", new DateTime(1993, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List" },
                    { new Guid("ea4abe16-1b17-4d0a-899f-c4ad56705a5e"), "A computer hacker learns the shocking truth about the reality he lives in and joins a rebellion.", "The Wachowskis", 136, "Sci-Fi", "https://www.movieposters.com/cdn/shop/files/Matrix.mpw.102176_bb2f6cc5-4a16-4512-881b-  f855ead3c8ec_480x.progressive.jpg?v=1708703624", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { new Guid("ec009376-e3c0-4ddc-9a3c-8ab516d87a71"), "Earth's mightiest heroes must come together to stop a mischievous Loki and his alien army.", "Joss Whedon", 143, "Action", "https://www.movieposters.com/cdn/shop/files/avengers.24x36_480x.progressive.jpg?v=1707410714", new DateTime(2012, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Avengers" },
                    { new Guid("fcbce5b4-d65e-45d0-9fb9-072f514e8972"), "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of decency.", "Frank Darabont", 142, "Drama", "https://www.movieposters.com/cdn/shop/files/shawshank_eb84716b-efa9-44dc-a19d-c17924a3f7df_480x.progressive.jpg?    v=1709821984", new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
