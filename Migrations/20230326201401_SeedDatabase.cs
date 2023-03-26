using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieManager.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Action", "2022", "Uncharted" },
                    { 2, "Action", "2021", "Shang-Chi and the Legend of the Ten Rings" },
                    { 3, "Action", "2022", "Spider-Man: No Way Home" },
                    { 4, "Action", "2023", "John Wick" },
                    { 5, "Action", "2019", "Captain Marvel" },
                    { 6, "Action", "2019", "Alita: Battle Angel" },
                    { 7, "Action", "2020", "Demon Slayer the Movie: Mugen Train" },
                    { 8, "Action", "2018", "Dragon Ball Super: Broly" },
                    { 9, "Action", "2022", "Dragon Ball Super: Super Hero" },
                    { 10, "Action", "2021", "Jujutsu Kaisen 0" },
                    { 11, "Action", "1988", "Akira" },
                    { 12, "Adventure", "2014", "Interstellar" },
                    { 13, "Adventure", "2012", "Life of Pi" },
                    { 14, "Adventure", "2022", "The Batman" },
                    { 15, "Adventure", "2015", "The Martian" },
                    { 16, "Adventure", "1982", "E.T. the Extra-Terrestrial" },
                    { 17, "Adventure", "2016", "The Jungle Book" },
                    { 18, "Adventure", "2006", "Paprika" },
                    { 19, "Adventure", "2001", "Spirited Away" },
                    { 20, "Adventure", "2002", "The Cat Returns" },
                    { 21, "Adventure", "1997", "Princess Mononoke" },
                    { 22, "Comedy", "2017", "Baywatch" },
                    { 23, "Comedy", "1998", "Rush Hour" },
                    { 24, "Comedy", "2001", "Rush Hour 2" },
                    { 25, "Comedy", "2007", "Rush Hour 3" },
                    { 26, "Comedy", "1995", "Bad Boys" },
                    { 27, "Comedy", "2003", "Bad Boys 2" },
                    { 28, "Comedy", "2013", "Gintama Movie: Kanketsu-hen" },
                    { 29, "Comedy", "2016", "Konosuba: God's Blessing On This Wonderful World!" },
                    { 30, "Comedy", "2016", "Haven't You Heard? I'm SAKAMOTO" },
                    { 31, "Comedy", "2013", "K On! Movie" },
                    { 32, "Mystery", "2020", "Hit" },
                    { 33, "Mystery", "2022", "Vikram" },
                    { 34, "Mystery", "2022", "Freddy" },
                    { 35, "Mystery", "2011", "Source Code" },
                    { 36, "Mystery", "2012", "Talaash: The Answer Lies Within" },
                    { 37, "Mystery", "2000", "American Psycho" },
                    { 38, "Mystery", "1997", "Perfect Blue" },
                    { 39, "Mystery", "2016", "Erased" },
                    { 40, "Mystery", "2020", "When Marnie Was There " },
                    { 41, "Mystery", "2006", "The Girl Who Leapt Through Time" },
                    { 42, "Romantic", "2009", "Magadheera" },
                    { 43, "Romantic", "2022", "Gurthunda Seethakalam" },
                    { 44, "Romantic", "2008", "Ghajini" },
                    { 45, "Romantic", "2017", "Arjun Reddy" },
                    { 46, "Romantic", "2009", "Sita Ramam" },
                    { 47, "Romantic", "2018", "Geetha Govindam" },
                    { 48, "Romantic", "2014", "Tamako Love Story" },
                    { 49, "Romantic", "2018", "I Want to Eat Your Pancreas" },
                    { 50, "Romantic", "2017", "Your Name" },
                    { 51, "Romantic", "2007", "5 Centimeters per Second" },
                    { 52, "Drama", "2018", "Rangasthalam" },
                    { 53, "Drama", "2019", "Uri: The Surgical Strike" },
                    { 54, "Drama", "2019", "Kesari" },
                    { 55, "Drama", "2018", "Parmanu: The Story of Pokhran" },
                    { 56, "Drama", "2018", "Raazi" },
                    { 57, "Drama", "2016", "Dangal" },
                    { 58, "Drama", "2011", "Singham" },
                    { 59, "Drama", "2018", "Bhavesh Joshi Superhero" },
                    { 60, "Drama", "2015", "Badlapur" },
                    { 61, "Drama", "2022", "RRR" },
                    { 62, "Horror", "2007", "I Am Legend" },
                    { 63, "Horror", "2022", "Prey" },
                    { 64, "Horror", "2008", "Cloverfield" },
                    { 65, "Horror", "2013", "World War Z" },
                    { 66, "Horror", "1973", "The Exorcist" },
                    { 67, "Horror", "2014", "As Above, So Below" },
                    { 68, "Horror", "2021", "Paranormal Activity" },
                    { 69, "Horror", "1999", "The Blair Witch Project" },
                    { 70, "Horror", "2010", "Insidious" },
                    { 71, "Horror", "2004", "The Grudge" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71);
        }
    }
}
