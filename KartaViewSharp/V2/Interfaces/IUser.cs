namespace KartaViewSharp.V2.Interfaces;

internal interface IUser
{
    Task<object> RetrieveUsers();

    Task<object> GetTheDetailsOfAUser(string userId);

    Task<object> DeleteAUser(string userId);

    Task<object> GetTheMetricsDetailsOfAUser(string userId);
}