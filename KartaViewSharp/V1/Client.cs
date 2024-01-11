using System.Web;
using KartaViewSharp.Common;
using KartaViewSharp.V1.Interfaces;
using KartaViewSharp.V1.Request;
using KartaViewSharp.V1.Response.Resources.Authentication;
using KartaViewSharp.V1.Response.Resources.MyList;
using KartaViewSharp.V1.Response.Resources.UserDetails;
using NetTopologySuite.Geometries;
using RestSharp;
using RestSharp.Authenticators;

namespace KartaViewSharp.V1;

public class Client : IAuthentication, ISequence, IPhoto, IVideo, IMap, IUser
{
	private const string _baseUri = "https://api.openstreetcam.org/";

	private const string OSM_REQUEST_TOKEN_URL = "https://www.openstreetmap.org/oauth/request_token";
	private const string OSM_BASE_AUTHORIZATION_URL = "https://www.openstreetmap.org/oauth/authorize";
	private const string OSM_ACCESS_TOKEN_URL = "https://www.openstreetmap.org/oauth/access_token";
	private const string OSM_CLIENT_KEY = "rBWV8Eaottv44tXfdLofdNvVemHOL62Lsutpb9tw";
	private const string OSM_CLIENT_SECRET = "rpmeZIp49sEjjcz91X9dsY0vD1PpEduixuPy8T6S";

	private const string OSC_LOGIN_URL = "https://api.openstreetcam.org/auth/openstreetmap/client_auth";

	public async Task<(string? oauthToken, string? oauthTokenSecret)> OpenStreetMapAccessToken(string oauthToken, string oauthTokenSecret)
	{
		var options = new RestClientOptions(OSM_ACCESS_TOKEN_URL)
		{
			Authenticator = OAuth1Authenticator.ForAccessToken(OSM_CLIENT_KEY, OSM_CLIENT_SECRET, oauthToken, oauthTokenSecret)
		};

		var client = new RestClient(options);
		var request = new RestRequest();
		var execute = await client.GetAsync(request);
		var response = HttpUtility.ParseQueryString(execute.Content);
		return (response.Get("oauth_token"), response.Get("oauth_token_secret"));
	}

	public async Task<OpenStreetMapAuth> OpenStreetMapRequestToken()
	{
		var options = new RestClientOptions(OSM_REQUEST_TOKEN_URL)
		{
			Authenticator = OAuth1Authenticator.ForRequestToken(OSM_CLIENT_KEY, OSM_CLIENT_SECRET)
		};
		var client = new RestClient(options);
		var request = new RestRequest();
		var execute = await client.GetAsync(request);

		var response = HttpUtility.ParseQueryString(execute.Content);

		var auth = new OpenStreetMapAuth
		{
			OAuthToken = response.Get("oauth_token"),
			OAuthTokenSecret = response.Get("oauth_token_secret")
		};
		auth.AuthUrl = new Uri(OSM_BASE_AUTHORIZATION_URL + "?oauth_token=" + auth.OAuthToken);
		return auth;
	}

	public async Task<AuthenticationResponse> OpenStreetCamAuthentication(string requestToken, string secretToken)
	{
		var client = RestClientUtil.CreateRestClient<AuthenticationResponseContext>(OSC_LOGIN_URL);
		var request = new RestRequest();
		request.AddParameter("request_token", requestToken);
		request.AddParameter("secret_token", secretToken);
		var execute = await client.ExecutePostAsync<AuthenticationResponse>(request);
		return execute.Data;
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetSequenceDetails(int sequenceId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> CreateSequence(string accessToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetSequencesPhotoList(string sequenceId, string accessToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RemoveSequence(string sequenceId, string accessToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> NotifyTheServerThatTheUploadingHasBeenFinished(string sequenceId, string accessToken)
	{
		throw new NotImplementedException();
	}

	public async Task<MyListResponse> ListOfSequences(string accessToken, QueryFilters queryFilters)
	{
		var client = RestClientUtil.CreateRestClient<MyListResponseContext>(_baseUri);
		var request = new RestRequest("/my-list");
		request.AddParameter("access_token", accessToken);
		var response = await client.ExecutePostAsync<MyListResponse>(request);
		return response.Data;
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public Task<object> UploadPhoto(int sequenceId, int sequenceIndex, Coordinate coordinate, byte[] photo, string accessToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RemovePhoto(int photoId, string accessToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> UploadVideoToSpecificSequence(int sequenceId, int sequenceIndex, byte[] video, string accessToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> NearbySequences(Coordinate location)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetNearbyPhotos(Coordinate location, double radius)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> MatchedTracks(Coordinate bbTopLeft, Coordinate bbBottomRight)
	{
		throw new NotImplementedException();
	}

	public async Task<UserDetailsResponse> GetUserDetails(string username)
	{
		var client = RestClientUtil.CreateRestClient<UserDetailsResponseContext>(_baseUri);
		var request = new RestRequest("/1.0/user/details/");
		request.AddParameter("username", username);
		var response = await client.ExecutePostAsync<UserDetailsResponse>(request);
		return response.Data;
	}
}