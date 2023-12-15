using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface ISequenceMetrics
{
	Task<Response> GetTheBreakdownDetailsOfASequence(int sequenceId);
}