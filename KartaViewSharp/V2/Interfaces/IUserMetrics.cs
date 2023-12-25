using KartaViewSharp.V2.ResponseData.Resources.Sequence;

namespace KartaViewSharp.V2.Interfaces;

public interface IUserMetrics
{
    Task<SequenceResponse> GetTheMetricsDetailsOfAUser(int userId);
}