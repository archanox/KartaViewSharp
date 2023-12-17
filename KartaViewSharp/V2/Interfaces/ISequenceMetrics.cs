using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface ISequenceMetrics
{
    Task<SequenceResponse> GetTheBreakdownDetailsOfASequence(int sequenceId);
}