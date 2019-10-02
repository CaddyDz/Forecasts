using System;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
	public class WeatherForecast
	{
#nullable enable
		[Key]
		public int id { get; set; }
		[Required]
		public string date { get; set; }
		public int tempertaure_c { get; set; }
		public int temperature_f => 32 + (int)(tempertaure_c / 0.5556);
		public string? summary { get; set; }
		[Timestamp]
		public DateTime created_at { get; set; }
		[Timestamp]
		public DateTime updated_at { get; set; }
#nullable disable
	}
}
