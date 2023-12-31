using KartaViewSharp.V1.Response.Resources.UserDetails;

namespace KartaViewSharp.V1.Interfaces;

public interface IUser
{
    /// <summary>
    /// The user details represent statuses and activity information of the user, like overall rank, the covered total distance, total number of photos etc.
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    Task<UserDetailsResponse> GetUserDetails(string username);
}