using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Requests_RequestId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportDetails_CommonTypes_TravelFromId",
                table: "TransportDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportDetails_CommonTypes_TravelToId",
                table: "TransportDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportDetails_Documents_DocumentId",
                table: "TransportDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportDetails_Requests_RequestId",
                table: "TransportDetails");

            migrationBuilder.DropColumn(
                name: "DomesticTravel",
                table: "TransportDetails");

            migrationBuilder.DropColumn(
                name: "InternationalTrvel",
                table: "TransportDetails");

            migrationBuilder.AlterColumn<int>(
                name: "TravelToId",
                table: "TransportDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TravelFromId",
                table: "TransportDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "TransportDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentId",
                table: "TransportDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Requests_RequestId",
                table: "Comments",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "RequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportDetails_CommonTypes_TravelFromId",
                table: "TransportDetails",
                column: "TravelFromId",
                principalTable: "CommonTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportDetails_CommonTypes_TravelToId",
                table: "TransportDetails",
                column: "TravelToId",
                principalTable: "CommonTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportDetails_Documents_DocumentId",
                table: "TransportDetails",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportDetails_Requests_RequestId",
                table: "TransportDetails",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "RequestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Requests_RequestId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportDetails_CommonTypes_TravelFromId",
                table: "TransportDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportDetails_CommonTypes_TravelToId",
                table: "TransportDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportDetails_Documents_DocumentId",
                table: "TransportDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportDetails_Requests_RequestId",
                table: "TransportDetails");

            migrationBuilder.AlterColumn<int>(
                name: "TravelToId",
                table: "TransportDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TravelFromId",
                table: "TransportDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "TransportDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DocumentId",
                table: "TransportDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DomesticTravel",
                table: "TransportDetails",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "InternationalTrvel",
                table: "TransportDetails",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Requests_RequestId",
                table: "Comments",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "RequestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportDetails_CommonTypes_TravelFromId",
                table: "TransportDetails",
                column: "TravelFromId",
                principalTable: "CommonTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportDetails_CommonTypes_TravelToId",
                table: "TransportDetails",
                column: "TravelToId",
                principalTable: "CommonTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportDetails_Documents_DocumentId",
                table: "TransportDetails",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportDetails_Requests_RequestId",
                table: "TransportDetails",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "RequestId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
