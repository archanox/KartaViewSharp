namespace KartaViewSharp.V1;

public class OpenStreetMapAuth
{
	public string? OAuthToken { get; init; }

	public string? OAuthTokenSecret { get; init; }

	public Uri AuthUrl { get; set; }
}