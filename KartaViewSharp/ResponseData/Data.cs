using System.Text.Json.Serialization;

namespace KartaViewSharp.ResponseData;

public class Data
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("username")]
	public string Username { get; set; }

	[JsonPropertyName("fullName")]
	public string FullName { get; set; }

	[JsonPropertyName("status")]
	public string Status { get; set; }

	[JsonPropertyName("category")]
	public string Category { get; set; }

	[JsonPropertyName("driverType")]
	public string DriverType { get; set; }

	[JsonPropertyName("gamification")]
	public string Gamification { get; set; }

	[JsonPropertyName("countryCode")]
	public string CountryCode { get; set; }

	[JsonPropertyName("metrics")]
	public Metrics Metrics { get; set; }
}