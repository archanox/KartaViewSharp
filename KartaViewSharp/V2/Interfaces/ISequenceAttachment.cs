using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface ISequenceAttachment
{
    Task<SequenceResponse> RetrieveSequenceAttachments();

    Task<SequenceResponse> CreateANewSequenceAttachment();

    Task<SequenceResponse> GetTheDetailsOfASequenceAttachment();

    Task<SequenceResponse> UpdateTheDetailsOfASequenceAttachment();

    Task<SequenceResponse> DeleteASequenceAttachment();
}