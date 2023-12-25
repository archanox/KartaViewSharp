using KartaViewSharp.V2.ResponseData.Resources.Sequence;

namespace KartaViewSharp.V2.Interfaces;

public interface IPhotoPart
{
    Task<SequenceResponse> RetrievePhotoParts();

    Task<SequenceResponse> CreateANewPhotoPart(string authToken);

    Task<SequenceResponse> UpdateTheDetailsOfAPhotoPart(int photoPartId, string authToken);

    Task<SequenceResponse> GetTheDetailsOfAPhotoPart(int photoPartId);

    Task<SequenceResponse> DeleteAPhotoPart(int photoPartId);
}