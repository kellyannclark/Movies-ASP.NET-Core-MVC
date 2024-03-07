using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMovieImageNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Movies SET ImageName = '17_Miracles.jpg' WHERE Title = '17 Miracles'");
            migrationBuilder.Sql("UPDATE Movies SET ImageName = 'The_Other_Side_of_Heaven.jpg' WHERE Title = 'The Other Side of Heaven'");
            migrationBuilder.Sql("UPDATE Movies SET ImageName = 'The_Saratov_Approach.jpg' WHERE Title = 'The Saratov Approach'");
            migrationBuilder.Sql("UPDATE Movies SET ImageName = 'Meet_the_Mormons.jpg' WHERE Title = 'Meet the Mormons'");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Optional: Clear the ImageName column for these movies
            migrationBuilder.Sql("UPDATE Movies SET ImageName = NULL WHERE Title IN ('17 Miracles', 'The Other Side of Heaven', 'The Saratov Approach', 'Meet the Mormons')");
        }

    }
}
