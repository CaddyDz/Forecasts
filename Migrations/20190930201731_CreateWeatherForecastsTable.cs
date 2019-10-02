using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
	public partial class CreateWeatherForecastsTable : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
					name: "weather_forecasts",
					columns: table => new
					{
						id = table.Column<int>(nullable: false)
									.Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
						date = table.Column<string>(nullable: true),
						tempertaure_c = table.Column<int>(nullable: false),
						summary = table.Column<string>(nullable: true),
						created_at = table.Column<DateTime>(nullable: false)
									.Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
						updated_at = table.Column<DateTime>(nullable: false)
									.Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_WeatherForecasts", x => x.id);
					});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
					name: "weather_forecasts");
		}
	}
}
