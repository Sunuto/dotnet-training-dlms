using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibrarySystem.Migrations
{
    /// <inheritdoc />
    public partial class publication_id_changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Website",
                table: "Publications",
                newName: "PublicationWebsite");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Publications",
                newName: "PublicationName");

            migrationBuilder.RenameColumn(
                name: "ContactPhone",
                table: "Publications",
                newName: "PublicationEmail");

            migrationBuilder.RenameColumn(
                name: "ContactPersonName",
                table: "Publications",
                newName: "PublicationAddress");

            migrationBuilder.RenameColumn(
                name: "ContactEmail",
                table: "Publications",
                newName: "PContactPhone");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Publications",
                newName: "PContactPersonName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Publications",
                newName: "PublicationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublicationWebsite",
                table: "Publications",
                newName: "Website");

            migrationBuilder.RenameColumn(
                name: "PublicationName",
                table: "Publications",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PublicationEmail",
                table: "Publications",
                newName: "ContactPhone");

            migrationBuilder.RenameColumn(
                name: "PublicationAddress",
                table: "Publications",
                newName: "ContactPersonName");

            migrationBuilder.RenameColumn(
                name: "PContactPhone",
                table: "Publications",
                newName: "ContactEmail");

            migrationBuilder.RenameColumn(
                name: "PContactPersonName",
                table: "Publications",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "PublicationId",
                table: "Publications",
                newName: "Id");
        }
    }
}
