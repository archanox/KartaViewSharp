using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface ISequenceRawData
{
	Task<Response> RetrieveSequenceRawdatas();

	Task<Response> CreateANewSequenceRawdata();

	Task<Response> UpdateTheDetailsOfASequenceRawdata();

	Task<Response> GetTheDetailsOfASequenceRawdata();

	Task<Response> DeleteASequenceRawdata();
}