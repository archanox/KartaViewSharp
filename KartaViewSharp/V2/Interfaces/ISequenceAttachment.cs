namespace KartaViewSharp.V2.Interfaces;

internal interface ISequenceAttachment
{
    Task<object> RetrieveSequenceAttachments();

    Task<object> CreateANewSequenceAttachment(string authToken);

    Task<object> GetTheDetailsOfASequenceAttachment(int sequenceAttachmentId);

    Task<object> UpdateTheDetailsOfASequenceAttachment(int sequenceAttachmentId, string authToken);

    Task<object> DeleteASequenceAttachment(int sequenceAttachementId);
}