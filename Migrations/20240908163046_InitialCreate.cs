using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TunaPiano.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    ArtistId = table.Column<int>(type: "integer", nullable: false),
                    Album = table.Column<string>(type: "text", nullable: false),
                    Length = table.Column<decimal>(type: "numeric", nullable: false),
                    GenreId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Songs_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Age", "Bio", "Name" },
                values: new object[,]
                {
                    { 1, 44, "Conor Mullen Oberst (born February 15, 1980) is an American singer-songwriter best known for his work in Bright Eyes. He has also played in several other bands, including Desaparecidos, the Faint (previously named Norman Bailer), Commander Venus, Park Ave., Conor Oberst and the Mystic Valley Band, Monsters of Folk, and Better Oblivion Community Center. Oberst was named the Best Songwriter of 2008 by Rolling Stone magazine.", "Conor Oberst" },
                    { 2, 78, "Dolly Rebecca Parton (born January 19, 1946) is an American singer-songwriter, actress, and philanthropist, known primarily for her decades-long career in country music. After achieving success as a songwriter for others, Parton made her album debut in 1967 with Hello, I'm Dolly, which led to success during the remainder of the 1960s (both as a solo artist and with a series of duet albums with Porter Wagoner), before her sales and chart peak arrived during the 1970s and continued into the 1980s. Some of Parton's albums in the 1990s did not sell as well, but she achieved commercial success again in the new millennium and has released albums on various independent labels since 2000, including her own label, Dolly Records.", "Dolly Parton" },
                    { 3, 69, "David Robert Jones (8 January 1947 – 10 January 2016), known professionally as David Bowie, was an English singer, songwriter, musician, and actor. He is regarded as one of the most influential musicians of the 20th century. Bowie was acclaimed by critics and musicians, particularly for his innovative work during the 1970s. His career was marked by reinvention and visual presentation, and his music and stagecraft had a significant impact on popular music.", "David Bowie" },
                    { 4, 43, "Sharon Katharine Van Etten (born February 26, 1981) is an American singer-songwriter and actress. She has released the albums Because I Was in Love (2009), Epic (2010), Tramp (2012), Are We There (2014), Remind Me Tomorrow (2019) and We've Been Going About This All Wrong (2022).", "Sharon Van Etten" },
                    { 5, 46, "Fiona Apple McAfee-Maggart (born September 13, 1977) is an American singer-songwriter. She released five albums from 1996 to 2020, all of which reached the top 20 on the U.S. Billboard 200 chart.[1] Apple has received numerous awards and nominations, including three Grammy Awards, two MTV Video Music Awards, and a Billboard Music Award.", "Fiona Apple" },
                    { 6, 46, "Fiona Apple McAfee-Maggart (born September 13, 1977) is an American singer-songwriter. She released five albums from 1996 to 2020, all of which reached the top 20 on the U.S. Billboard 200 chart.[1] Apple has received numerous awards and nominations, including three Grammy Awards, two MTV Video Music Awards, and a Billboard Music Award.", "Fiona Apple" },
                    { 7, 40, "Donald McKinley Glover Jr. (born September 25, 1983), also known by his stage name Childish Gambino, is an American actor, rapper, singer, writer, comedian, director and producer. While he studied at New York University and after working in Derrick Comedy, a comedy group, Glover was hired by Tina Fey to write for the NBC sitcom 30 Rock at age 23. He gained fame for portraying college student Troy Barnes on the NBC sitcom Community from 2009 to 2014. From 2016 to 2022, he starred in the FX series Atlanta, which he created and occasionally directed. For his work on Atlanta, he won various accolades including two Primetime Emmy Awards, as well as two Golden Globe Awards.", "Childish Gambino" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Indie Rock" },
                    { 2, "Pop Rock" },
                    { 3, "Country" },
                    { 4, "Rap" },
                    { 5, "Inde Folk" },
                    { 6, "Experimental Rock" },
                    { 7, "Riot Girl" },
                    { 8, "Metal" },
                    { 9, "HipHop" },
                    { 10, "Electronic" },
                    { 11, "Ambient" },
                    { 12, "Classical" },
                    { 13, "Cinematic" },
                    { 14, "Punk" },
                    { 15, "Musicals" },
                    { 16, "Math Rock" },
                    { 17, "Bluegrass" },
                    { 18, "Folk Rock" },
                    { 19, "Psychedelic Rock" },
                    { 20, "Art Pop" },
                    { 21, "Rap" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "ArtistId", "GenreId", "Length", "Title" },
                values: new object[,]
                {
                    { 1, "Jolene", 2, 3, 2.42m, "Jolene" },
                    { 2, "Cassadega", 1, 18, 4.16m, "Four Winds" },
                    { 3, "The Idler Wheel...", 5, 20, 4.02m, "Hot Knife" },
                    { 4, "Blackstar", 5, 6, 6.22m, "Lazarus" },
                    { 5, "The Rise and Fall of Ziggy Stardust...", 5, 6, 4.42m, "Five Years" },
                    { 6, "Salutations", 1, 18, 3.35m, "Afterthought" },
                    { 7, "9 to 5 and Odd Jobs", 2, 3, 2.43m, "9 to 5" },
                    { 8, "Awaken, My Love!", 1, 19, 4.41m, "Zombies" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_ArtistId",
                table: "Songs",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
