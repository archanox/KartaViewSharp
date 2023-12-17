using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface ISequenceBreakdown
{
    Task<SequenceResponse> GetTheBreakdownDetailsOfASequence();

    Task<SequenceResponse> RetrieveSequenceBreakdowns();
}