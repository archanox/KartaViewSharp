using KartaViewSharp.V2.Response.Resources.Sequence;

namespace KartaViewSharp.V2.Interfaces;

public interface IUserMetrics
{
    Task<SequenceResponse> GetTheMetricsDetailsOfAUser(int userId);
}