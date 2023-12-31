using KartaViewSharp.V2.Response.Resources.Sequence;

namespace KartaViewSharp.V2.Interfaces;

public interface ISequenceAttachment
{
    Task<SequenceResponse> RetrieveSequenceAttachments();

    Task<SequenceResponse> CreateANewSequenceAttachment(string authToken);

    Task<SequenceResponse> GetTheDetailsOfASequenceAttachment(int sequenceAttachmentId);

    Task<SequenceResponse> UpdateTheDetailsOfASequenceAttachment(int sequenceAttachmentId, string authToken);

    Task<SequenceResponse> DeleteASequenceAttachment(int sequenceAttachementId);
}