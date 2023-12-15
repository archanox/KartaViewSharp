using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface IUserMetrics
{
	Task<Response> GetTheMetricsDetailsOfAUser(int userId);
}