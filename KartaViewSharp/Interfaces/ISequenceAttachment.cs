using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface ISequenceAttachment
{
	Task<Response> RetrieveSequenceAttachments();

	Task<Response> CreateANewSequenceAttachment();

	Task<Response> GetTheDetailsOfASequenceAttachment();

	Task<Response> UpdateTheDetailsOfASequenceAttachment();

	Task<Response> DeleteASequenceAttachment();
}