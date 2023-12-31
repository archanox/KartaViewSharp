using KartaViewSharp.V2.Response.Resources.Sequence;

namespace KartaViewSharp.V2.Interfaces;

public interface ISequenceMetrics
{
    Task<SequenceResponse> GetTheBreakdownDetailsOfASequence(int sequenceId);
}