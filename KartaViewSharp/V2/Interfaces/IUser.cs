namespace KartaViewSharp.V2.Interfaces;

internal interface IUser
{
    Task<object> RetrieveUsers();

    Task<object> GetTheDetailsOfAUser(int userId);

    Task<object> DeleteAUser(int userId);

    Task<object> GetTheMetricsDetailsOfAUser(int userId);
}