using System;
using App.Models;
using System.Linq;
using App.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace App.Database.Seeders
{
	public static class WeatherForecastsTableSeeder
	{
		public static void run(IServiceProvider serviceProvider)
		{
			using (var context = new WeatherForecastContext(serviceProvider.GetRequiredService<DbContextOptions<WeatherForecastContext>>()))
			{
				// Look for any forecasts
			}
		}
	}
}
