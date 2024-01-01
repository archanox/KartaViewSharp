using KartaViewSharp.V1.Response.Resources.Authentication;

namespace KartaViewSharp.V1.Interfaces;

/// <summary>
/// For each secured method you have to use the access_token parameter.
/// In order to get the access_token, you have to get the request_token and secret token returned after OAuth authentification on OSM.
/// </summary>
internal interface IAuthentication
{
    /// <summary>
    /// OpenStreetCam authentication uses request_token and secret_token obtained after OAuth authentication on OSM.
    /// </summary>
    /// <param name="requestToken"></param>
    /// <param name="secretToken"></param>
    /// <returns></returns>
    Task<AuthenticationResponse> OpenStreetCamAuthentication(string requestToken, string secretToken);
}