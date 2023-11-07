using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inheritance.Migrations
{
    /// <inheritdoc />
    public partial class USE_TPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarbonatedWater_Waters_Id",
                table: "CarbonatedWater");

            migrationBuilder.DropForeignKey(
                name: "FK_Fruits_Products_Id",
                table: "Fruits");

            migrationBuilder.DropForeignKey(
                name: "FK_StillWater_Waters_Id",
                table: "StillWater");

            migrationBuilder.DropForeignKey(
                name: "FK_Waters_Products_Id",
                table: "Waters");

            migrationBuilder.CreateSequence(
                name: "ProductSequence");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Waters",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [ProductSequence]",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Waters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Waters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ValidityTime",
                table: "Waters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "StillWater",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [ProductSequence]",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "StillWater",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "StillWater",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "StillWater",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ValidityTime",
                table: "StillWater",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [ProductSequence]",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Fruits",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [ProductSequence]",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Fruits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Fruits",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ValidityTime",
                table: "Fruits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CarbonatedWater",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [ProductSequence]",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "CarbonatedWater",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CarbonatedWater",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CarbonatedWater",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ValidityTime",
                table: "CarbonatedWater",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Waters");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Waters");

            migrationBuilder.DropColumn(
                name: "ValidityTime",
                table: "Waters");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "StillWater");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "StillWater");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "StillWater");

            migrationBuilder.DropColumn(
                name: "ValidityTime",
                table: "StillWater");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Fruits");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Fruits");

            migrationBuilder.DropColumn(
                name: "ValidityTime",
                table: "Fruits");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "CarbonatedWater");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CarbonatedWater");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CarbonatedWater");

            migrationBuilder.DropColumn(
                name: "ValidityTime",
                table: "CarbonatedWater");

            migrationBuilder.DropSequence(
                name: "ProductSequence");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Waters",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [ProductSequence]");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "StillWater",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [ProductSequence]");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [ProductSequence]")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Fruits",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [ProductSequence]");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CarbonatedWater",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [ProductSequence]");

            migrationBuilder.AddForeignKey(
                name: "FK_CarbonatedWater_Waters_Id",
                table: "CarbonatedWater",
                column: "Id",
                principalTable: "Waters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fruits_Products_Id",
                table: "Fruits",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StillWater_Waters_Id",
                table: "StillWater",
                column: "Id",
                principalTable: "Waters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Waters_Products_Id",
                table: "Waters",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
