using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Database
{
	public class WeatherForecastContext : DbContext
	{
		public DbSet<WeatherForecast> WeatherForecasts { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
				=> options.UseMySql(@"server=localhost;database=app;uid=root;password=cicada;");
	}
}
