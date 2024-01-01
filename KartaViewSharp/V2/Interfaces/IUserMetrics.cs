namespace KartaViewSharp.V2.Interfaces;

internal interface IUserMetrics
{
    Task<object> GetTheMetricsDetailsOfAUser(int userId);
}