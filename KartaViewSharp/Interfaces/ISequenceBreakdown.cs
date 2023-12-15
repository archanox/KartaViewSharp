using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface ISequenceBreakdown
{
	Task<Response> GetTheBreakdownDetailsOfASequence();

	Task<Response> RetrieveSequenceBreakdowns();
}